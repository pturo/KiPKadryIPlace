using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiPKadryIPlace.DataAccessLayer.ViewModels
{
    public class SalaryViewModel
    {
        public int Id { get; set; }

        private string salary;

        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private string currency;

        public string Currency
        {
            get { return currency.ToUpper(); }
            set { currency = value; }
        }

        private string typeRate;

        public string TypeRate
        {
            get { return typeRate; }
            set { typeRate = value; }
        }

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
    }
}
