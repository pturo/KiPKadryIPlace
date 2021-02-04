using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiPKadryIPlace.DataAccessLayer.ViewModels
{
    public class DepartamentViewModel
    {
        public int Id { get; set; }

        private string manager;

        public string Manager
        {
            get { return manager.ToUpper(); }
            set { manager = value; }
        }

        private string location;

        public string Location
        {
            get { return location.ToUpper(); }
            set { location = value; }
        }

        private string parentDepartament;

        public string ParentDepartament
        {
            get { return parentDepartament.ToUpper(); }
            set { parentDepartament = value; }
        }
    }
}
