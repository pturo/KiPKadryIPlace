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

namespace KiPKadryIPlace.UserInterface.Forms.Payroll
{
    public partial class EditPayrollForm : BaseAddEditForm
    {
        #region Fields

        private DBUtilities dbUtilitiesCon;

        #endregion
        #region Constructor

        public EditPayrollForm(int payrollId)
        {
            InitializeComponent();
            dbUtilitiesCon = new DBUtilities();
            LoadEmployee();
            GetPayrollFromDB(payrollId);
        }

        #endregion
        #region Private Methods

        private void GetPayrollFromDB(int payrollId)
        {
            string query = "select dbo.Payrolls.ID, concat(e.FirstName, ' ', e.LastName) as FullName, RateHour, HourDay, DaysWorked, DatePay, Month, Description " +
                "from dbo.Payrolls inner join dbo.Employees e on EmployeeId = e.ID where dbo.Payrolls.ID = @ID;";

            DataTable payrollData = dbUtilitiesCon.GetData(query, new Dictionary<string, string> { { "@ID", Convert.ToString(payrollId) } });

            if(payrollData?.Rows?.Count > 0)
            {
                foreach(DataRow row in payrollData.Rows)
                {
                    txtID.Text = row["ID"].ToString();
                    cbFullName.Text = row["FullName"].ToString();
                    txtRateHour.Text = row["RateHour"].ToString();
                    txtHourDay.Text = row["HourDay"].ToString();
                    txtDaysWorked.Text = row["DaysWorked"].ToString();
                    dtpDatePay.Value = Convert.ToDateTime(row["DatePay"]);
                    cbMonth.Text = row["Month"].ToString();
                    txtDescription.Text = row["Description"].ToString();
                }
            }
        }

        private void LoadEmployee()
        {
            try
            {
                cbFullName.Items.Clear();
                DataTable employees = dbUtilitiesCon.GetData("select concat(FirstName, ' ', LastName) as FullName from dbo.Employees");

                if (employees?.Rows?.Count > 0)
                {
                    foreach (DataRow row in employees.Rows)
                    {
                        cbFullName.Items.Add(row["FullName"].ToString());
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

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string fullNameErrorMessage = eFullName.GetError(cbFullName);
            if (!string.IsNullOrEmpty(fullNameErrorMessage))
            {
                sbErrorMessage.Append(fullNameErrorMessage);
            }

            string rateHourErrorMessage = eRateHour.GetError(txtRateHour);
            if (!string.IsNullOrEmpty(rateHourErrorMessage))
            {
                sbErrorMessage.Append(rateHourErrorMessage);
            }

            string hourDayDepartamentErrorMessage = eHourDay.GetError(txtHourDay);
            if (!string.IsNullOrEmpty(hourDayDepartamentErrorMessage))
            {
                sbErrorMessage.Append(hourDayDepartamentErrorMessage);
            }

            string daysWorkedErrorMessage = eDaysWorked.GetError(txtDaysWorked);
            if (!string.IsNullOrEmpty(daysWorkedErrorMessage))
            {
                sbErrorMessage.Append(daysWorkedErrorMessage);
            }

            string datePayDepartamentErrorMessage = eDatePay.GetError(dtpDatePay);
            if (!string.IsNullOrEmpty(datePayDepartamentErrorMessage))
            {
                sbErrorMessage.Append(datePayDepartamentErrorMessage);
            }

            string monthErrorMessage = eMonth.GetError(cbMonth);
            if (!string.IsNullOrEmpty(monthErrorMessage))
            {
                sbErrorMessage.Append(monthErrorMessage);
            }

            string descriptionDepartamentErrorMessage = eDescription.GetError(txtDescription);
            if (!string.IsNullOrEmpty(descriptionDepartamentErrorMessage))
            {
                sbErrorMessage.Append(descriptionDepartamentErrorMessage);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(sbErrorMessage.ToString(), "Dodawanie listy płac", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                var param = new Dictionary<string, string>();
                param.Add("@ID", txtID.Text);
                param.Add("@EmployeeId", GetEmployeeId(cbFullName.Text).ToString());
                param.Add("@RateHour", txtRateHour.Text);
                param.Add("@HourDay", txtHourDay.Text);
                param.Add("@DaysWorked", txtDaysWorked.Text);
                param.Add("@DatePay", Convert.ToDateTime(dtpDatePay.Value).ToString("yyyy-MM-dd"));
                param.Add("@Month", cbMonth.Text);
                param.Add("@Description", txtDescription.Text);

                string query = "update dbo.Payrolls set EmployeeId = @EmployeeId, RateHour = @RateHour, HourDay = @HourDay, " +
                    "DaysWorked = @DaysWorked, DatePay = @DatePay, Month = @Month, Description = @Description where dbo.Payrolls.ID = @ID;";

                int result = dbUtilitiesCon.ExecuteQuery(query, param);
                if(result > 0)
                {
                    MessageBox.Show("Pomyślnie zmodyfikowano listę płac!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Wystąpił bład podczas zapisywania zmodyfikowaych danych do bazy!");
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
