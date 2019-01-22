namespace PBingenering.Model
{
    public class User
    {
        public int Id;
        public string Surname;
        public string Name;
        public string NameName;
        public string Login;
        public string Password;
        public Role role; // вот это поле по умолчанию null т.к. ссылочный тип, а ты пытаешься из него обратиться к чему-то
        
        public object[] SerializeToDataGridRow()
        {
            return new object[] { Surname, Name, NameName, Login, role != null ? role.Name : "НЕ ОПРЕДЕЛЕНА", 0 };
        }
    }
}