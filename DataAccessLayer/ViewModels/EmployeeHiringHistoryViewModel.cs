using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiPKadryIPlace.DataAccessLayer.ViewModels
{
    public class EmployeeHiringHistoryViewModel
    {
        public int Id { get; set; }

        private string dateFrom;

        public string DateFrom
        {
            get { return dateFrom; }
            set { dateFrom = value; }
        }

        private string dateTo;

        public string DateTo
        {
            get { return dateTo; }
            set { dateTo = value; }
        }

        private string position;

        public string Position
        {
            get { return position.ToUpper(); }
            set { position = value; }
        }

        private string departament;

        public string Departament
        {
            get { return departament.ToUpper(); }
            set { departament = value; }
        }

        private string typeContract;

        public string TypeContract
        {
            get { return typeContract.ToUpper(); }
            set { typeContract = value; }
        }
    }
}
