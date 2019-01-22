using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBingenering.Model
{
    public class ProjectDoc
    {
        public string NameProject;
        public string SurNameProject;
        public User User;
        public int PlanHourse;
        public int PlanMinets;
        public int SpendedHourse;
        public int SpendedMinets;
        public decimal PlanMoney;
        public decimal SpendedMoney;
        public Guid guid;
    }
}
