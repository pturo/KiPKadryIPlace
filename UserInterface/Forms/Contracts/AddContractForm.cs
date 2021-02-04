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

namespace KiPKadryIPlace.UserInterface.Forms.Contracts
{
    public partial class AddContractForm : BaseAddEditForm
    {
        #region Fields

        private DBUtilities dbUtilitiesCon;

        #endregion
        #region Constructor

        public AddContractForm()
        {
            InitializeComponent();
            dbUtilitiesCon = new DBUtilities();
            LoadFirstName();
            LoadLastName();
            LoadTypeContract();
            LoadPosition();
            LoadDepartament();
            LoadCurrency();
            LoadTypeRate();
        }

        #endregion
        #region Private Methods

        private void LoadFirstName() 
        {
            try
            {
                cbFirstName.Items.Clear();
                DataTable firstName = dbUtilitiesCon.GetData("select FirstName from dbo.Employees");

                if (firstName?.Rows?.Count > 0)
                {
                    foreach (DataRow row in firstName.Rows)
                    {
                        cbFirstName.Items.Add(row["FirstName"].ToString());
                    }
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }

        private void LoadLastName() 
        {
            try
            {
                cbLastName.Items.Clear();
                DataTable lastName = dbUtilitiesCon.GetData("select LastName from dbo.Employees");

                if (lastName?.Rows?.Count > 0)
                {
                    foreach (DataRow row in lastName.Rows)
                    {
                        cbLastName.Items.Add(row["LastName"].ToString());
                    }
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }

        private void LoadTypeContract() 
        {
            try
            {
                cbTypeContract.Items.Clear();
                DataTable typeContract = dbUtilitiesCon.GetData("select Value from dbo.TypeContracts");

                if (typeContract?.Rows?.Count > 0)
                {
                    foreach (DataRow row in typeContract.Rows)
                    {
                        cbTypeContract.Items.Add(row["Value"].ToString());
                    }
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }

        private void LoadPosition() 
        {
            try
            {
                cbPosition.Items.Clear();
                DataTable position = dbUtilitiesCon.GetData("select Name from dbo.Positions");

                if (position?.Rows?.Count > 0)
                {
                    foreach (DataRow row in position.Rows)
                    {
                        cbPosition.Items.Add(row["Name"].ToString());
                    }
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }

        private void LoadDepartament() 
        {
            try
            {
                cbDepartament.Items.Clear();
                DataTable departament = dbUtilitiesCon.GetData("select Name from dbo.Departaments");

                if (departament?.Rows?.Count > 0)
                {
                    foreach (DataRow row in departament.Rows)
                    {
                        cbDepartament.Items.Add(row["Name"].ToString());
                    }
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }

        private void LoadCurrency() 
        {
            try
            {
                cbCurrency.Items.Clear();
                DataTable currency = dbUtilitiesCon.GetData("select Value from dbo.Currencies");

                if (currency?.Rows?.Count > 0)
                {
                    foreach (DataRow row in currency.Rows)
                    {
                        cbCurrency.Items.Add(row["Value"].ToString());
                    }
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }

        private void LoadTypeRate() 
        {
            try
            {
                cbTypeRate.Items.Clear();
                DataTable typeRate = dbUtilitiesCon.GetData("select Value from dbo.TypeRates");

                if (typeRate?.Rows?.Count > 0)
                {
                    foreach (DataRow row in typeRate.Rows)
                    {
                        cbTypeRate.Items.Add(row["Value"].ToString());
                    }
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }

        private int GetFirstAndLastName(string firstName, string lastName) 
        {
            try
            {
                var param = new Dictionary<string, string>();
                param.Add("@FirstName", firstName);
                param.Add("@LastName", lastName);

                string fullNameId = dbUtilitiesCon.DataLookUp("ID", "dbo.Employees", "FirstName = @FirstName and LastName = @LastName", param);

                return Convert.ToInt32(fullNameId);
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return 0;
            }
        }

        private int GetTypeContract(string typeContract)
        {
            try
            {
                var param = new Dictionary<string, string>();
                param.Add("@TypeContract", typeContract);

                string typeContractId = dbUtilitiesCon.DataLookUp("ID", "dbo.TypeContracts", "Value = @TypeContract", param);

                return Convert.ToInt32(typeContractId);
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return 0;
            }
        }

        private int GetPosition(string position) 
        {
            try
            {
                var param = new Dictionary<string, string>();
                param.Add("@Position", position);

                string positionId = dbUtilitiesCon.DataLookUp("ID", "dbo.Positions", "Name = @Position", param);

                return Convert.ToInt32(positionId);
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return 0;
            }
        }

        private int GetDepartament(string departament) 
        {
            try
            {
                var param = new Dictionary<string, string>();
                param.Add("@Departament", departament);

                string departamentId = dbUtilitiesCon.DataLookUp("ID", "dbo.Departaments", "Name = @Departament", param);

                return Convert.ToInt32(departamentId);
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return 0;
            }
        }

        private int GetCurrency(string currency)
        {
            try
            {
                var param = new Dictionary<string, string>();
                param.Add("@Currency", currency);

                string currencyId = dbUtilitiesCon.DataLookUp("ID", "dbo.Currencies", "Value = @Currency", param);

                return Convert.ToInt32(currencyId);
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return 0;
            }
        }

        private int GetTypeRate(string typeRate)
        {
            try
            {
                var param = new Dictionary<string, string>();
                param.Add("@TypeRate", typeRate);

                string typeRateId = dbUtilitiesCon.DataLookUp("ID", "dbo.TypeRates", "Value = @TypeRate", param);

                return Convert.ToInt32(typeRateId);
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

            string lastNameErrorMessage = eLastName.GetError(cbLastName);
            if (!string.IsNullOrEmpty(lastNameErrorMessage))
            {
                sbErrorMessage.Append(lastNameErrorMessage);
            }

            string firstNameErrorMessage = eFirstName.GetError(cbFirstName);
            if (!string.IsNullOrEmpty(firstNameErrorMessage))
            {
                sbErrorMessage.Append(firstNameErrorMessage);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(sbErrorMessage.ToString(), "Dodawanie umowy", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                string query = "insert into dbo.Contracts (TypeContractId, ConclusionDate, DateFrom, DateTo, PositionId, DepartamentId, Salary, TypeRateId, CurrencyId, EmployeeId) " +
                    "values (@TypeContractId, @ConclusionDate, @DateFrom, @DateTo, @PositionId, @DepartamentId, @Salary, @TypeRateId, @CurrencyId, @EmployeeId);";

                var param = new Dictionary<string, string>();
                param.Add("@TypeContractId", GetTypeContract(cbTypeContract.Text).ToString());
                param.Add("@ConclusionDate", Convert.ToDateTime(dtpConclusionDate.Value).ToString("yyyy-MM-dd"));
                param.Add("@DateFrom", Convert.ToDateTime(dtpDateFrom.Value).ToString("yyyy-MM-dd"));
                param.Add("@DateTo", Convert.ToDateTime(dtpDateTo.Value).ToString("yyyy-MM-dd"));
                param.Add("@PositionId", GetPosition(cbPosition.Text).ToString());
                param.Add("@DepartamentId", GetDepartament(cbDepartament.Text).ToString());
                param.Add("@Salary", nudSalary.Value.ToString());
                param.Add("@TypeRateId", GetTypeRate(cbTypeRate.Text).ToString());
                param.Add("@CurrencyId", GetCurrency(cbCurrency.Text).ToString());
                param.Add("@EmployeeId", GetFirstAndLastName(cbFirstName.Text, cbLastName.Text).ToString());

                int result = dbUtilitiesCon.ExecuteQuery(query, param);
                if(result > 0)
                {
                    MessageBox.Show("Pomyślnie dodano umowę do bazy!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas dodawania umowy do bazy!");
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
