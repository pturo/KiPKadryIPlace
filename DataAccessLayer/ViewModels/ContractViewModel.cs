using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiPKadryIPlace.DataAccessLayer.ViewModels
{
    public class ContractViewModel
    {
        public int Id { get; set; }

        private string lastName;

        public string LastName
        {
            get { return lastName.ToUpper(); }
            set { lastName = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName.ToUpper(); }
            set { firstName = value; }
        }

        private string code;
        public string Code
        {
            get { return code.PadLeft(4, '0'); }
            set { code = value; }
        }

        private string typeContract;
        public string TypeContract
        {
            get { return typeContract.ToUpper(); }
            set { typeContract = value; }
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

        private string conclusionDate;

        public string ConclusionDate
        {
            get { return conclusionDate; }
            set { conclusionDate = value; }
        }

        private string terminationWay;

        public string TerminationWay
        {
            get { return terminationWay.ToUpper(); }
            set { terminationWay = value; }
        }
    }
}
