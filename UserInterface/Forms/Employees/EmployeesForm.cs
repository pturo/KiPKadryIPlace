using KiPKadryIPlace.DataAccessLayer.ViewModels;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using KiPKadryIPlace.DataAccessLayer;
using KiPKadryIPlace.UserInterface.Forms.Employees.Base;
using System.Collections.Generic;

namespace KiPKadryIPlace.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : BaseForm
    {
        #region Fields

        private static EmployeesForm _instance = null;
        private int employeeId;
        private BindingList<EmployeeViewModel> sqlEmp = new BindingList<EmployeeViewModel>();
        private DBUtilities dbUtilConn;

        #endregion
        #region Properties

        public static EmployeesForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeesForm();
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

        public EmployeesForm()
        {
            InitializeComponent();
            GetEmployeesFromDB();
        }

        #endregion
        #region Private Methods

        private void GetEmployeesFromDB()
        {
            dbUtilConn = new DBUtilities();
            DataTable dt = dbUtilConn.GetData("select dbo.Employees.ID, LastName, FirstName, Code, s.Value from dbo.Employees inner join dbo.Statuses s on StatusId = s.ID order by dbo.Employees.ID;");
            
            if(dt?.Rows?.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    sqlEmp.Add(new EmployeeViewModel()
                    {
                        Id = Convert.ToInt32(row["ID"]),
                        LastName = row["LastName"].ToString(),
                        FirstName = row["FirstName"].ToString(),
                        Code = row["Code"].ToString(),
                        Position = string.Empty,
                        Status = row["Value"].ToString()
                    });

                    var source = new BindingSource(sqlEmp, null);
                    dgvEmployees.DataSource = source;
                }
            }
        }

        private void DeleteEmployeeFromDB(int employeeId)
        {
            try
            {
                string query = "delete from dbo.Employees where dbo.Employees.ID = @ID;";
                var param = new Dictionary<string, string>();
                param.Add("ID", Convert.ToString(employeeId));
                int result = dbUtilConn.ExecuteQuery(query, param);
                if(result > 0)
                {
                    MessageBox.Show("Pomyślnie usunięto pracownika z bazy!");
                    RefreshData();
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                MessageBox.Show("Wystąpił problem podczas usuwania pracownika z bazy!");
            }
        }

        private void RefreshData()
        {
            dgvEmployees.Rows.Clear();
            GetEmployeesFromDB();
        }

        #endregion
        #region Events

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmployeeAddForm frm = new EmployeeAddForm();
            frm.ShowDialog();
            RefreshData();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["colId"].Value);

            EmployeeEditForm frm = new EmployeeEditForm(employeeId);
            frm.ShowDialog();
            RefreshData();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            DismissEmployeeForm frm = new DismissEmployeeForm();
            frm.ShowDialog();
            RefreshData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["colId"].Value);

            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć pracownika?", "Usuwanie pracownika",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                DeleteEmployeeFromDB(employeeId);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        #endregion
    }
}
