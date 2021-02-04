using KiPKadryIPlace.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiPKadryIPlace.UserInterface.Forms.Contracts
{
    public partial class ShowContractForm : Form
    {
        #region Fields

        private DBUtilities dbUtilitiesCon;

        #endregion
        #region Constructor

        public ShowContractForm(int contractId)
        {
            InitializeComponent();
            dbUtilitiesCon = new DBUtilities();
            ShowContractFromDB(contractId);
        }

        #endregion
        #region Private Methods

        private void ShowContractFromDB(int contractId)
        {
            try
            {
                string query = "select dbo.Contracts.ID, e.LastName, e.FirstName, t.Value, ConclusionDate, DateFrom, DateTo, p.Name, d.Name, Salary, c.Value, r.Value from dbo.Contracts " +
                    "inner join dbo.Employees e on dbo.Contracts.EmployeeId = e.ID " +
                    "inner join dbo.TypeContracts t on dbo.Contracts.TypeContractId = t.ID " +
                    "inner join dbo.Positions p on dbo.Contracts.PositionId = p.ID " +
                    "inner join dbo.Departaments d on dbo.Contracts.DepartamentId = d.ID " +
                    "inner join dbo.Currencies c on dbo.Contracts.CurrencyId = c.ID " +
                    "inner join dbo.TypeRates r on dbo.Contracts.TypeRateId = r.ID where dbo.Contracts.ID = @ID;";

                DataTable contractData = dbUtilitiesCon.GetData(query, new Dictionary<string, string> { { "@ID", Convert.ToString(contractId) } });

                if (contractData?.Rows?.Count > 0)
                {
                    foreach (DataRow row in contractData.Rows)
                    {
                        txtID.Text = row["ID"].ToString();
                        txtLastName.Text = row["LastName"].ToString();
                        txtFirstName.Text = row["FirstName"].ToString();
                        txtTypeContract.Text = row["Value"].ToString();
                        txtConclusionDate.Text = row["ConclusionDate"].ToString();
                        txtDateFrom.Text = row["DateFrom"].ToString();
                        txtDateTo.Text = row["DateTo"].ToString();
                        txtPosition.Text = row["Name"].ToString();
                        txtDepartament.Text = row["Name"].ToString();
                        txtSalary.Text = row["Salary"].ToString();
                        txtCurrency.Text = row["Value"].ToString();
                        txtTypeOfRate.Text = row["Value"].ToString();
                    }
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }

        #endregion
        #region Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
