using KiPKadryIPlace.DataAccessLayer;
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
    public partial class AddDepartamentForm : BaseAddEditForm
    {
        #region Fields

        private DBUtilities dbUtilitiesCon;

        #endregion
        #region Constructor

        public AddDepartamentForm()
        {
            InitializeComponent();
            dbUtilitiesCon = new DBUtilities();
            LoadEmployee();
            LoadParentDepartament();
        }

        #endregion
        #region Private Methods

        private void LoadEmployee()
        {
            try
            {
                cbManager.Items.Clear();
                DataTable employees = dbUtilitiesCon.GetData("select concat(FirstName, ' ', LastName) as FullName from dbo.Employees");

                if (employees?.Rows?.Count > 0)
                {
                    foreach (DataRow row in employees.Rows)
                    {
                        cbManager.Items.Add(row["FullName"].ToString());
                    }
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }

        private void LoadParentDepartament()
        {
            try
            {
                cbParentDepartament.Items.Clear();
                DataTable departaments = dbUtilitiesCon.GetData("select Value from dbo.ParentDepartaments");

                if (departaments?.Rows?.Count > 0)
                {
                    foreach (DataRow row in departaments.Rows)
                    {
                        cbParentDepartament.Items.Add(row["Value"].ToString());
                    }
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }

        private int GetEmployeeId(string employee)
        {
            try
            {
                var param = new Dictionary<string, string>();
                param.Add("@Employee", employee);

                string employeeId = dbUtilitiesCon.DataLookUp("ID", "dbo.Employees", "concat(FirstName, ' ', LastName) = @Employee", param);

                return Convert.ToInt32(employeeId);
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return 0;
            }
        }

        private int GetDepartamentId(string parentDepartament)
        {
            try
            {
                var param = new Dictionary<string, string>();
                param.Add("@ParentDepartament", parentDepartament);

                string departamentId = dbUtilitiesCon.DataLookUp("ID", "dbo.ParentDepartaments", "Value = @ParentDepartament", param);

                return Convert.ToInt32(departamentId);
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return 0;
            }
        }

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string nameErrorMessage = eName.GetError(txtName);
            if (!string.IsNullOrEmpty(nameErrorMessage))
            {
                sbErrorMessage.Append(nameErrorMessage);
            }

            string managerErrorMessage = eManager.GetError(cbManager);
            if (!string.IsNullOrEmpty(managerErrorMessage))
            {
                sbErrorMessage.Append(managerErrorMessage);
            }

            string parentDepartamentErrorMessage = eParentDepartament.GetError(cbParentDepartament);
            if (!string.IsNullOrEmpty(parentDepartamentErrorMessage))
            {
                sbErrorMessage.Append(parentDepartamentErrorMessage);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(sbErrorMessage.ToString(), "Dodawanie działu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        #endregion
        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                // SQL

                string query = "insert into dbo.Departaments (Name, EmployeeId, Location, DepartamentId) " +
                    "values (@Name, @EmployeeId, @Location, @DepartamentId);";

                var param = new Dictionary<string, string>();
                param.Add("@Name", txtName.Text);
                param.Add("@EmployeeId", GetEmployeeId(cbManager.Text).ToString());
                param.Add("@Location", txtLocation.Text);
                param.Add("@DepartamentId", GetDepartamentId(cbParentDepartament.Text).ToString());

                int result = dbUtilitiesCon.ExecuteQuery(query, param);
                if(result > 0)
                {
                    MessageBox.Show("Pomyślnie dodano dział do bazy!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas dodawania działu do bazy!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
