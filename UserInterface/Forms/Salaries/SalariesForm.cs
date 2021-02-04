using KiPKadryIPlace.DataAccessLayer;
using KiPKadryIPlace.DataAccessLayer.ViewModels;
using KiPKadryIPlace.UserInterface.Forms.Employees.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiPKadryIPlace.UserInterface.Forms.Salaries
{
    public partial class SalariesForm : BaseForm
    {
        #region Fields

        private static SalariesForm _instance = null;
        private BindingList<SalaryViewModel> sqlSal = new BindingList<SalaryViewModel>();
        private DBUtilities dbUtilConn;

        #endregion
        #region Properties

        public static SalariesForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SalariesForm();
                }
                return _instance;
            }
        }

        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }

        #endregion
        #region Constructor

        public SalariesForm()
        {
            InitializeComponent();
            GetSalaryFromDB();
        }

        #endregion
        #region Private Methods

        private void GetSalaryFromDB()
        {
            dbUtilConn = new DBUtilities();

            DataTable salaryData = dbUtilConn.GetData("select dbo.Contracts.ID, Salary, c.Value, t.Value, DateFrom, DateTo from dbo.Contracts " +
                "inner join dbo.Currencies c on dbo.Contracts.CurrencyId = c.ID " +
                "inner join dbo.TypeRates t on dbo.Contracts.TypeRateId = t.ID order by dbo.Contracts.ID;");

            if(salaryData?.Rows?.Count > 0)
            {
                foreach(DataRow row in salaryData.Rows)
                {
                    sqlSal.Add(new SalaryViewModel()
                    {
                        Id = Convert.ToInt32(row["ID"]),
                        Salary = row["Salary"].ToString(),
                        Currency = row["Value"].ToString(),
                        TypeRate = row["Value"].ToString(),
                        DateFrom = row["DateFrom"].ToString(),
                        DateTo = row["DateTo"].ToString()
                    });

                    var source = new BindingSource(sqlSal, null);
                    dgvSalaries.DataSource = source;
                }
            }
        }

        #endregion
        #region Events

        private void SalariesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        #endregion
    }
}
