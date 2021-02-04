using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiPKadryIPlace.DataAccessLayer.ViewModels
{
    public class PayrollViewModel
    {
        public int Id { get; set; }

        private string fullName;
        public string FullName
        {
            get { return fullName.ToUpper(); }
            set { fullName = value; }
        }

        private string rateHour;
        public string RateHour
        {
            get { return rateHour.ToUpper(); }
            set { rateHour = value; }
        }

        private string hourDay;
        public string HourDay
        {
            get { return hourDay.ToUpper(); }
            set { hourDay = value; }
        }

        private string daysWorked;
        public string DaysWorked
        {
            get { return daysWorked.ToUpper(); }
            set { daysWorked = value; }
        }

        private string datePay;
        public string DatePay
        {
            get { return datePay; }
            set { datePay = value; }
        }

        private string month;
        public string Month
        {
            get { return month.ToUpper(); }
            set { month = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
