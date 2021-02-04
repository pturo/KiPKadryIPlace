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

namespace KiPKadryIPlace.UserInterface.Forms.Payroll
{
    public partial class PayrollForm : BaseForm
    {
        #region Fields

        private static PayrollForm _instance = null;
        private int payrollId;
        private DBUtilities dBUtilitiesCon;
        private BindingList<PayrollViewModel> sqlPay = new BindingList<PayrollViewModel>();

        #endregion
        #region Properties

        public static PayrollForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PayrollForm();
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

        public PayrollForm()
        {
            InitializeComponent();
            GetPayrollsFromDB();
        }

        #endregion
        #region Private Methods

        private void GetPayrollsFromDB()
        {
            dBUtilitiesCon = new DBUtilities();
            DataTable dt = dBUtilitiesCon.GetData("select dbo.Payrolls.ID, concat(e.FirstName, ' ', e.LastName) as FullName, RateHour, HourDay, DaysWorked, DatePay, Month, Description from dbo.Payrolls inner join dbo.Employees e on EmployeeId = e.ID order by dbo.Payrolls.ID; ");

            if (dt?.Rows?.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    sqlPay.Add(new PayrollViewModel()
                    {
                        Id = Convert.ToInt32(row["ID"]),
                        FullName = row["FullName"].ToString(),
                        RateHour = row["RateHour"].ToString(),
                        HourDay = row["HourDay"].ToString(),
                        DaysWorked = row["DaysWorked"].ToString(),
                        DatePay = row["DatePay"].ToString(),
                        Month = row["Month"].ToString(),
                        Description = row["Description"].ToString(),
                    });

                    var source = new BindingSource(sqlPay, null);
                    dgvPayrolls.DataSource = source;
                }
            }
        }

        private void DeletePayrollFromDB(int payrollId)
        {
            try
            {
                string query = "delete from dbo.Payrolls where dbo.Payrolls.ID = @ID;";
                var param = new Dictionary<string, string>();
                param.Add("ID", Convert.ToString(payrollId));
                int result = dBUtilitiesCon.ExecuteQuery(query, param);
                if (result > 0)
                {
                    MessageBox.Show("Pomyślnie usunięto listę płac z bazy!");
                    RefreshData();
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                MessageBox.Show("Wystąpił problem podczas usuwania listy płac z bazy!");
            }
        }

        private void ComputeSalary(int payrollId)
        {
            try
            {
                string query = "select dbo.Payrolls.ID, RateHour, HourDay, DaysWorked " +
                "from dbo.Payrolls where dbo.Payrolls.ID = @ID;";

                var param = new Dictionary<string, string>();
                param.Add("@ID", payrollId.ToString());

                int rHour;
                int hDay;
                int dWorked;
                int total;

                DataTable dt = dBUtilitiesCon.GetData(query, param);

                if(dt?.Rows?.Count > 0)
                {
                    foreach(DataRow row in dt.Rows)
                    {
                        rHour = Convert.ToInt32(row["RateHour"]);
                        hDay = Convert.ToInt32(row["HourDay"]);
                        dWorked = Convert.ToInt32(row["DaysWorked"]);


                        total = rHour * hDay * dWorked;
                        txtToPay.Text = Convert.ToString(Convert.ToDecimal(total).ToString("#,##"));
                    }
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                MessageBox.Show("Wystąpił błąd podczas liczenia!");
            }
        }

        private void RefreshData()
        {
            dgvPayrolls.Rows.Clear();
            GetPayrollsFromDB();
        }

        #endregion
        #region Events

        private void PayrollForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddPayrollForm frm = new AddPayrollForm();
            frm.ShowDialog();
            RefreshData();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            payrollId = Convert.ToInt32(dgvPayrolls.CurrentRow.Cells["colId"].Value);

            EditPayrollForm frm = new EditPayrollForm(payrollId);
            frm.ShowDialog();
            RefreshData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            payrollId = Convert.ToInt32(dgvPayrolls.CurrentRow.Cells["colId"].Value);

            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć listę płac?", "Usuwanie listy płac",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                DeletePayrollFromDB(payrollId);
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            payrollId = Convert.ToInt32(dgvPayrolls.CurrentRow.Cells["colId"].Value);

            ComputeSalary(payrollId);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        #endregion
    }
}
