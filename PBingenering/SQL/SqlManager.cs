using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PBingenering.Model;

namespace PBingenering.SQL
{
    public static class SqlManager
    {
        static string conncetionString;
        static SqlConnection sqlConnection;
        static SqlManager()
        {
            conncetionString = ConfigurationManager.ConnectionStrings["PBingenering.Properties.Settings.Setting"].ConnectionString;
            sqlConnection = new SqlConnection(conncetionString);
            sqlConnection.Open();

        }
        public static void CloseConnection()
        {
           
            sqlConnection?.Close();
        }

        //вход проверка логина и пароля
        public static User CheckLogin(string Login, string Password)
        {

            if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password))
                return null;

           
            using (var command = sqlConnection.CreateCommand())
            {
                command.CommandText = "Select Personal.ID as LoginID,login, Roles.ROL as Role, Roles.ID as RoleId from Personal inner join roles on personal.rol = roles.id where login= @login and password = @pass and Personal.IDELETESTATE = 0";
                command.Parameters.AddWithValue("@login", Login);
                command.Parameters.AddWithValue("@pass", Password);

                using (var reader = command.ExecuteReader())
                {
                 
                    if (!reader.Read()) // в скуле нет строк для такого запроса
                        return null;

                    return new User
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("LoginID")),
                        Login = reader.GetString(reader.GetOrdinal("login")),
                        role = new Role {
                            id = reader.GetInt32(reader.GetOrdinal("RoleId")),
                            Name = reader.GetString(reader.GetOrdinal("Role")),
                        }
                    };
                }
            }
        }
        
        //Запускаем Вьюшку по пользователям для админа
        public static DataTable GetUserView()
        {
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;

            string queary = "SELECT * FROm VPersonal";
            using (var dataAdapter = new SqlDataAdapter(queary, sqlConnection))
            {
                dataAdapter.Fill(table);
            }

            return table;
           
        }

        //Вьюшка для просмотра сотрудник своих проектов
        public static DataTable GetProjectSpendedView(string user)
        {
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;

            string queary = $@"SELECT * From VSubProject Where LOGIN ='" + user + "'";
            using (var dataAdapter = new SqlDataAdapter(queary, sqlConnection))
            {
                dataAdapter.Fill(table);
            }

            return table;
        }

        //Вьющка для админа
        public static DataTable GetProjectSpendedView()
        {
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;

            string queary = $@"SELECT * From VSubProject";
            using (var dataAdapter = new SqlDataAdapter(queary, sqlConnection))
            {
                dataAdapter.Fill(table);
            }

            return table;
        }

        //Запускаем вьющку по проектам, НО только видишь свои проекты
        public static DataTable GetProjectView(string user)
        {
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;

            string queary = $@"SELECT * From VProject Where LOGIN ={user}";
            using (var dataAdapter = new SqlDataAdapter(queary, sqlConnection))
            {
                dataAdapter.Fill(table);
            }

            return table;
        }


        //Запускаем вьюшку для админа, видны все записи
        public static DataTable GetProjectView()
        {
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;

            string queary = $@"SELECT * From VProject";
            using (var dataAdapter = new SqlDataAdapter(queary, sqlConnection))
            {
                dataAdapter.Fill(table);
            }

            return table;
        }

        //Запускаем вьюшку для руководства,(видим штрафников)
        public static DataTable GetleadershipView()
        {
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            DateTime yesterday = DateTime.Now.AddDays(((int)DateTime.Now.DayOfWeek == 1) ? -3 : -1).Date;
            string day = yesterday.ToString("d"); //выводим только дату

            string queary = $@"Select * From VPersonal where rol <> 1 and rol <> 2 NOT EXISTS (SELECT * From VLeaderShip where coast (datatime as date) ={day})";  //Создать вьюшку для вывода инфы о создании проекта (id,ФИО,дата) where Deleted = 0;
            using (var dataAdapter = new SqlDataAdapter(queary, sqlConnection))
            {
                dataAdapter.Fill(table);
            }

            return table;
        }


        //Создаем запись в Проект (работы)
        public static ProjectDoc InsertProjectDoc(ProjectDoc projectDoc)
        {
            if (projectDoc == null)
                throw new ArgumentException($"{nameof(projectDoc)} не может быть NULL.");

            if (projectDoc.User.Id == 0)
                throw new ArgumentException("Id Пользователя не может быть 0.");
            if (string.IsNullOrEmpty(projectDoc.User.Login))
                throw new ArgumentException("Логин пользователя не может быть пустой.");
            if (string.IsNullOrEmpty(projectDoc.User.role?.Name))
                throw new ArgumentException("Роль не может быть пустой.");


            Guid newGuid = Guid.NewGuid();
            int result = 0;
            using (SqlCommand cmd = sqlConnection.CreateCommand())
            {

                cmd.CommandText = @"INSERT INTO 
            [dbo].[Project]
           ([ProjectName]
           ,[ProjectSurNave]
           ,[LoginIdCreater]
           ,[PlanHourse]
           ,[PlanMinets]
           ,[SpendedHourse]
           ,[SpendedMinets]
           ,[PlanMoney]
           ,[SpendedMoney]
           ,[GUID])

             VALUES
            (@NameProject,
            @SurNameProject,
            @LoginIdCreater,
            @PlanHourse,
            @PlanMinets,
            @SpendedHourse,
            @SpendedMinets,
            @PlanMoney,
            @SpendedMoney,
            @GUID)";

                cmd.Parameters.AddWithValue("@NameProject", projectDoc.NameProject);
                cmd.Parameters.AddWithValue("@SurNameProject", projectDoc.SurNameProject);
                cmd.Parameters.AddWithValue("@LoginIdCreater", projectDoc.User.Id);
                cmd.Parameters.AddWithValue("@PlanHourse", projectDoc.PlanHourse);
                cmd.Parameters.AddWithValue("@PlanMinets", projectDoc.PlanMinets);
                cmd.Parameters.AddWithValue("@SpendedHourse", projectDoc.SpendedHourse);
                cmd.Parameters.AddWithValue("@SpendedMinets", projectDoc.SpendedMinets);
                cmd.Parameters.AddWithValue("@PlanMoney", projectDoc.PlanMoney);
                cmd.Parameters.AddWithValue("@SpendedMoney", projectDoc.SpendedMoney);
                cmd.Parameters.AddWithValue("@GUID", newGuid);

                result = cmd.ExecuteNonQuery();
            }

            if (result == 0)
            {
                //тут ошибка
            }

            projectDoc.guid = newGuid;

            return projectDoc;
        }


        //Создаем нового пользователя
        public static User CreateUser (User user)
        {
            //if (user == null)
            //    throw new ArgumentException($"{nameof(user)} не может быть NULL.");

            //if (user.Id == 0)
            //    throw new ArgumentException("Id Пользователя не может быть 0.");
            //if (string.IsNullOrEmpty(user.Login))
            //    throw new ArgumentException("Логин пользователя не может быть пустой.");
            //if (string.IsNullOrEmpty(user.role?.Name))
            //    throw new ArgumentException("Роль не может быть пустой.");
            //if (string.IsNullOrEmpty(user.Name))
            //    throw new ArgumentException("Имя должно быть задано.");
            //if (string.IsNullOrEmpty(user.Surname))
            //    throw new ArgumentException("Фамилия должна быть задана.");

            int result = 0;

            using (SqlCommand cmd = sqlConnection.CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO
                [dbo].[Personal]
	            ([SURNAME],
	            [NAME],
	            [NAMENAME],
	            [LOGIN],
	            [PASSWORD],
	            [ROL],
	            [IDeleteState])

                VALUES
                (@SURNAME,
	            @NAME,
	            @NAMENAME,
	            @LOGIN,
	            @PASSWORD,
	            @ROL,
	            @IDeleteState)";

                //FROM [dbo].[Personal]
                //INNER JOIN
                //[dbo].[Roles]
                //ON Personal.ROL = Roles.ID"

                cmd.Parameters.AddWithValue("@SURNAME", user.Surname);
                cmd.Parameters.AddWithValue("@NAME", user.Name);
                cmd.Parameters.AddWithValue("@NAMENAME", user.NameName);
                cmd.Parameters.AddWithValue("@LOGIN", user.Login);
                cmd.Parameters.AddWithValue("@PASSWORD", user.Password);
                cmd.Parameters.AddWithValue("@ROL", user.role.id);
                cmd.Parameters.AddWithValue("@IDeleteState", 0);


                result = cmd.ExecuteNonQuery();
               
            }
            return user;
        }

        //Список ролей
        public static Dictionary<int, string> GetRolView()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
           

            string queary = "SELECT ID,ROL FROM Roles";
           
            using (var command = sqlConnection.CreateCommand())
            {
                command.CommandText = queary;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int _id = reader.GetInt32(reader.GetOrdinal("ID"));
                        string _rol = reader.GetString(reader.GetOrdinal("ROL"));

                        if (!result.ContainsKey(_id))
                            result.Add(_id, _rol);
                    }
                }
            }
            return result;
        }

        //Список сотрудников(не входят админы и руководство)
        public static DataTable GetWorkPersonalsView()
        {
            
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;

            string queary = $@"SELECT * From WorkPersonal";
            using ( SqlDataAdapter adapter = new SqlDataAdapter(queary, sqlConnection))
            {
                adapter.Fill(table);
            }

            return table;
        }
    

        public static int BlocUser(int index)
        {
            int result = 0;

            using (SqlCommand cmd = sqlConnection.CreateCommand())
            {
                cmd.CommandText = @"UPDATE Personal SET IDELETESTATE = 1
                 WHERE ID='" + index + "'";

                result = cmd.ExecuteNonQuery();
            }

            return index;
        }


        //Блокируем/восстанавливаем пользователя удачная версия
        public static int RestoreUser(int index, int deleteState)
        {
            int result = 0;

            using (SqlCommand cmd = sqlConnection.CreateCommand())
            {
                cmd.CommandText = $@"UPDATE Personal SET IDELETESTATE = {deleteState} 
                                    WHERE ID={index}";

                result = cmd.ExecuteNonQuery();
            }

            return index;
        }

        //Удалить из базы пользователя
        public static bool DeleteUser(int index)
        {
            int result = 0;

            using (SqlCommand cmd = sqlConnection.CreateCommand())
            {
                cmd.CommandText = $"DELETE FROM Personal WHERE ID = {index}";

                result = cmd.ExecuteNonQuery();
            }
            if (result == 1)
                return true;
            else
                return false;
        }


        //Сменить пароль
        public static void ResPass(int index,string str)
        {
            //int result = 0;

            using (SqlCommand cmd = sqlConnection.CreateCommand())
            {
                cmd.CommandText = $@"UPDATE Personal SET Password = {str}
                 WHERE ID = {index}";

                //result = 
                cmd.ExecuteNonQuery();
            }

        }

        //Блокируем/восстанавливаем документ 
        public static void RestoreProj(int index, int deleteState)
        {
            int result = 0;

            using (SqlCommand cmd = sqlConnection.CreateCommand())
            {
                cmd.CommandText = $@"UPDATE Project SET Deleted = {deleteState}
                 WHERE ID={index}";

                result = cmd.ExecuteNonQuery();
            }

            //return index;
        }

        //создаем основную таблицу
        public static void CreateMainProject(User currentUser, string ProjectName, out string ErrorMsg, params int[] UserIDs)
        {
            ErrorMsg = string.Empty;

            if (UserIDs.Length == 0)
                return;
            if (string.IsNullOrEmpty(ProjectName))
                return;
            if (currentUser == null)
                return;

            int result = 0;
            Guid guid = Guid.NewGuid();

            try
            {
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO
                    [dbo].[Project]
	                ([ProjectName],
	                [LoginIdCreater],
	                [Deleted],
	                [GUID],
                    [IDStage])


                    VALUES
                    (@ProjectName,
	                @LoginIdCreater,
	                @Deleted,
	                @GUID
                    @IDStage)";


                    cmd.Parameters.AddWithValue("@ProjectName", ProjectName);
                    cmd.Parameters.AddWithValue("@LoginIdCreater", currentUser.Id);
                    cmd.Parameters.AddWithValue("@Deleted", 0);
                    cmd.Parameters.AddWithValue("@GUID", guid);
                    cmd.Parameters.AddWithValue("@IDStage", 1);


                    result = cmd.ExecuteNonQuery();

                }
                string _err = string.Empty;

                if (result == 1)
                {
                    CreateSubProject(GetProjectId(guid), out _err, UserIDs);
                }
                else
                    ErrorMsg += "Не удалось сделать запись в таблицу [Project]" + Environment.NewLine;

                if (!string.IsNullOrEmpty(_err))
                {
                    ErrorMsg += _err;
                }
            }
            catch (Exception ex)
            {
                ErrorMsg += ex.Message + Environment.NewLine;
            }

        }

        private static int GetProjectId(Guid guid)
        {
            int projId = -1;
            using (SqlCommand cmd = sqlConnection.CreateCommand())
            {
                cmd.CommandText = $"SELECT id FROM PROJECT WHERE GUID = @GUID";
                cmd.Parameters.AddWithValue("@GUID", guid);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        projId = reader.GetInt32(reader.GetOrdinal("id"));
                }
            }

            return projId;
        }

        //создаем таблицы для сотрудников (раздел проектов)
        public static void CreateSubProject(int ProjectID, out string ErrorMsg, params int[] UsersIDs)
        {
            int result = 0;

            ErrorMsg = string.Empty;

            for (int i = 0; i < UsersIDs.Length; i++)
            {
                try
                {
                    using (SqlCommand cmd = sqlConnection.CreateCommand())
                    {
                        cmd.CommandText = @"INSERT INTO [dbo].[SubProject]
                                           ([SubName]
                                           ,[ProjectId]
                                           ,[UserId]
                                           ,[Deleted]
                                           ,[GUID]
                                           ,[SpendedTime]
                                           ,[IDStage])
                                     VALUES
                                            (@SubName
                                           ,@ProjectId
                                           ,@UserId
                                           ,@Deleted
                                           ,@GUID
                                           ,@SpendedTime
                                           ,@IDStage)";
                      
                        cmd.Parameters.AddWithValue("@SubName", DBNull.Value);
                        cmd.Parameters.AddWithValue("@ProjectId", ProjectID);
                        cmd.Parameters.AddWithValue("@UserId", UsersIDs[i]);
                        cmd.Parameters.AddWithValue("@Deleted", 0);
                        cmd.Parameters.AddWithValue("@GUID", Guid.NewGuid());
                        cmd.Parameters.AddWithValue("@SpendedTime", 0);
                        cmd.Parameters.AddWithValue("@IDStage", 1);

                        result = cmd.ExecuteNonQuery();

                        if(result != 1)
                            ErrorMsg += $"Не удалось сделать запись в таблицу [SubProject]. ProjectID = [{ProjectID}],UserId =[{UsersIDs[i]}] " + Environment.NewLine;

                    }

                }
                catch (Exception ex)
                {
                    ErrorMsg += ex.Message + Environment.NewLine;
                }
            }
        }
        
        //Добавить имя раздела и планируемых часов
        public static void AddSubNameProject(Guid GUID, string SubName, int SpendedTime) // жо
        {
           // int result = 0;

            using (SqlCommand cmd = sqlConnection.CreateCommand())
            {
                cmd.CommandText = $@"UPDATE [dbo].[SubProject] SET SubName= @SubName, SpendedTime = @SpendedTime Where GUID = @GUID";
                cmd.Parameters.AddWithValue("@SubName", SubName);
                cmd.Parameters.AddWithValue("@SpendedTime", SpendedTime);
                cmd.Parameters.AddWithValue("@GUID", GUID);

                cmd.ExecuteNonQuery();
            }
        }


        //добавляем разделы в проект(доп функция)
        public static void AddSubProject(User CurrentUser, string SubSectionName,int ProjectID, out string ErrorMsg, int SpendedTime)
        {
            int result = 0;

            ErrorMsg = string.Empty;

            try
            {
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO [dbo].[SubProject]
                                           ([SubName]
                                           ,[ProjectId]
                                           ,[UserId]
                                           ,[Deleted]
                                           ,[GUID]
                                           ,[SpendedTime]
                                           ,[IDStage])
                                     VALUES
                                            (@SubName
                                           ,@ProjectId
                                           ,@UserId
                                           ,@Deleted
                                           ,@GUID
                                           ,@SpendedTime
                                           ,@IDStage)";

                    cmd.Parameters.AddWithValue("@SubName", SubSectionName);
                    cmd.Parameters.AddWithValue("@ProjectId", ProjectID);
                    cmd.Parameters.AddWithValue("@UserId", CurrentUser.Id);
                    cmd.Parameters.AddWithValue("@Deleted", 0);
                    cmd.Parameters.AddWithValue("@GUID", Guid.NewGuid());
                    cmd.Parameters.AddWithValue("@SpendedTime", SpendedTime);
                    cmd.Parameters.AddWithValue("@IDStage", 1);
                    result = cmd.ExecuteNonQuery();

                    if (result != 1)
                        ErrorMsg += $"Не удалось сделать запись в таблицу [SubProject]. ProjectID = [{ProjectID}],UserId =[{CurrentUser.Id}] " + Environment.NewLine;

                }

            }
            catch (Exception ex)
            {
                ErrorMsg += ex.Message + Environment.NewLine;
            }
        }
    }
}


    

