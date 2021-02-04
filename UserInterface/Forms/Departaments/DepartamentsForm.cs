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

namespace KiPKadryIPlace.UserInterface.Forms.Departaments
{
    public partial class DepartamentsForm : BaseForm
    {
        #region Fields

        private static DepartamentsForm _instance = null;
        private int departamentId;
        private DBUtilities dBUtilitiesCon;
        private BindingList<DepartamentViewModel> sqlDep = new BindingList<DepartamentViewModel>();

        #endregion
        #region Properties

        public static DepartamentsForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DepartamentsForm();
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

        public DepartamentsForm()
        {
            InitializeComponent();
            GetDepartamentsFromDB();
        }

        #endregion
        #region Private Methods

        private void GetDepartamentsFromDB()
        {
            dBUtilitiesCon = new DBUtilities();
            DataTable dt = dBUtilitiesCon.GetData("select dbo.Departaments.ID, Name, concat(e.FirstName, ' ', e.LastName) as FullName, Location, d.Value from dbo.Departaments " +
                "inner join dbo.Employees e on employeeId = e.ID " +
                "inner join dbo.ParentDepartaments d on DepartamentId = d.ID;");

            if(dt?.Rows?.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    sqlDep.Add(new DepartamentViewModel()
                    {
                        Id = Convert.ToInt32(row["ID"]),
                        Manager = row["FullName"].ToString(),
                        Location = row["Location"].ToString(),
                        ParentDepartament = row["Value"].ToString()
                    });

                    var source = new BindingSource(sqlDep, null);
                    dgvDepartaments.DataSource = source;
                }
            }
        }

        private void DeleteDepartamentFromDB(int departamentId)
        {
            try
            {
                string query = "delete from dbo.Departaments where dbo.Departaments.ID = @ID;";
                var param = new Dictionary<string, string>();
                param.Add("ID", Convert.ToString(departamentId));
                int result = dBUtilitiesCon.ExecuteQuery(query, param);
                if (result > 0)
                {
                    MessageBox.Show("Pomyślnie usunięto dział z bazy!");
                    RefreshData();
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                MessageBox.Show("Wystąpił problem podczas usuwania działu z bazy!");
            }
        }

        private void RefreshData()
        {
            dgvDepartaments.Rows.Clear();
            GetDepartamentsFromDB();
        }

        #endregion
        #region Events

        private void DepartamentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddDepartamentForm frm = new AddDepartamentForm();
            frm.ShowDialog();
            RefreshData();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            departamentId = Convert.ToInt32(dgvDepartaments.CurrentRow.Cells["colId"].Value);

            EditDepartamentForm frm = new EditDepartamentForm(departamentId);
            frm.ShowDialog();
            RefreshData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            departamentId = Convert.ToInt32(dgvDepartaments.CurrentRow.Cells["colId"].Value);

            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć dział?", "Usuwanie działu",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                DeleteDepartamentFromDB(departamentId);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        #endregion
    }
}
