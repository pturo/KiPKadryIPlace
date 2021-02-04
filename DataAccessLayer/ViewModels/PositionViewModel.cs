using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiPKadryIPlace.DataAccessLayer.ViewModels
{
    public class PositionViewModel
    {
        public int Id { get; set; }

        private string name;

        public string Name
        {
            get { return name.ToUpper(); }
            set { name = value; }
        }

        private string minSalary;

        public string MinSalary
        {
            get { return minSalary; }
            set { minSalary = value; }
        }

        private string maxSalary;

        public string MaxSalary
        {
            get { return maxSalary; }
            set { maxSalary = value; }
        }
    }
}
