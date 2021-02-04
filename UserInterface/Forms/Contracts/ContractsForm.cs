using KiPKadryIPlace.DataAccessLayer;
using KiPKadryIPlace.DataAccessLayer.ViewModels;
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
    public partial class ContractsForm : Form
    {
        #region Fields

        private static ContractsForm _instance = null;
        private int contractId;
        private BindingList<ContractViewModel> sqlCtr = new BindingList<ContractViewModel>();
        private DBUtilities dbUtilConn;

        #endregion
        #region Properties

        public static ContractsForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ContractsForm();
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

        private ContractsForm()
        {
            InitializeComponent();
            GetContractsFromDB();
        }

        #endregion
        #region Private Methods

        private void GetContractsFromDB()
        {
            dbUtilConn = new DBUtilities();
            DataTable dt = dbUtilConn.GetData("select dbo.Contracts.ID, e.FirstName, e.LastName, e.Code, t.Value, DateFrom, DateTo, ConclusionDate from dbo.Contracts " +
                "inner join dbo.Employees e on EmployeeId = e.ID " +
                "inner join dbo.TypeContracts t on TypeContractId = t.ID order by dbo.Contracts.ID;");

            if (dt?.Rows?.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    sqlCtr.Add(new ContractViewModel()
                    {
                        Id = Convert.ToInt32(row["ID"]),
                        LastName = row["FirstName"].ToString(),
                        FirstName = row["LastName"].ToString(),
                        Code = row["Code"].ToString(),
                        TypeContract = row["Value"].ToString(),
                        DateFrom = row["DateFrom"].ToString(),
                        DateTo = row["DateTo"].ToString(),
                        ConclusionDate = row["ConclusionDate"].ToString(),
                        TerminationWay = string.Empty,
                    });

                    var source = new BindingSource(sqlCtr, null);
                    dgvContracts.DataSource = source;
                }
            }
        }

        private void DeleteContractFromDB(int contractId)
        {
            try
            {
                string query = "delete from dbo.Contracts where dbo.Contracts.ID = @ID;";
                var param = new Dictionary<string, string>();
                param.Add("ID", Convert.ToString(contractId));
                int result = dbUtilConn.ExecuteQuery(query, param);
                if (result > 0)
                {
                    MessageBox.Show("Pomyślnie usunięto umowę z bazy!");
                    RefreshData();
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                MessageBox.Show("Wystąpił problem podczas usuwania umowy z bazy!");
            }
        }

        private void RefreshData()
        {
            dgvContracts.Rows.Clear();
            GetContractsFromDB();
        }

        #endregion
        #region Events

        private void ContractsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddContractForm frm = new AddContractForm();
            frm.ShowDialog();
            RefreshData();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            contractId = Convert.ToInt32(dgvContracts.CurrentRow.Cells["colId"].Value);

            ShowContractForm frm = new ShowContractForm(contractId);
            frm.ShowDialog();
            RefreshData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            contractId = Convert.ToInt32(dgvContracts.CurrentRow.Cells["colId"].Value);

            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć umowę?", "Usuwanie umowy",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteContractFromDB(contractId);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        #endregion
    }
}
