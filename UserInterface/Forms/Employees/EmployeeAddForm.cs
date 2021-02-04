using KiPKadryIPlace.DataAccessLayer;
using KiPKadryIPlace.UserInterface.Extensions;
using KiPKadryIPlace.UserInterface.Forms.Employees.Base;
using KiPKadryIPlace.UserInterface.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace KiPKadryIPlace.UserInterface.Forms.Employees
{
    public partial class EmployeeAddForm : BaseAddEditForm
    {
        #region Fields

        private DBUtilities dbUtilitiesCon;

        #endregion
        #region Constructor

        public EmployeeAddForm()
        {
            InitializeComponent();
            dbUtilitiesCon = new DBUtilities();
            LoadGender();
            ValidateControls();
        }

        #endregion
        #region Private Methods

        private void LoadGender()
        {
            try
            {
                cbGender.Items.Clear();
                DataTable genders = dbUtilitiesCon.GetData("select Value from dbo.Genders");

                if (genders?.Rows?.Count > 0)
                {
                    foreach (DataRow row in genders.Rows)
                    {
                        cbGender.Items.Add(row["Value"].ToString());
                    }
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }

        private int GetGenderId(string gender)
        {
            try
            {
                var param = new Dictionary<string, string>();
                param.Add("@Gender", gender);

                string genderId = dbUtilitiesCon.DataLookUp("ID", "dbo.Genders", "Value = @Gender", param);

                return Convert.ToInt32(genderId);
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return 0;
            }
        }

        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                epLastName.SetError(txtLastName, "Pole 'Nazwisko' jest wymagane!");
            }
            else
            {
                epLastName.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                epFirstName.SetError(txtFirstName, "Pole 'Imię' jest wymagane!");
            }
            else
            {
                epFirstName.Clear();
            }
        }

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string lastNameErrorMessage = epLastName.GetError(txtLastName);
            if (!string.IsNullOrEmpty(lastNameErrorMessage))
            {
                sbErrorMessage.Append(lastNameErrorMessage);
            }

            string firstNameErrorMessage = epFirstName.GetError(txtFirstName);
            if (!string.IsNullOrEmpty(firstNameErrorMessage))
            {
                sbErrorMessage.Append(firstNameErrorMessage);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(sbErrorMessage.ToString(), "Dodawanie pracownika", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string peselWarinngMessage = epPesel.GetError(txtPesel);
            if (!string.IsNullOrEmpty(peselWarinngMessage))
            {
                DialogResult answer = MessageBox.Show(peselWarinngMessage + Environment.NewLine + "Czy mimo to chcesz dodać pracownika?", "Dodawanie pracownika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dtp.DateTimePickerValueChanged();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPesel_Validated(object sender, EventArgs e)
        {
            string pesel = txtPesel.Text;

            if (!string.IsNullOrWhiteSpace(pesel) && !ValidatorsHelper.IsValidPESEL(pesel))
            {
                epPesel.SetError(txtPesel, "Cyfra kontrolna numeru pesel jest nieprawidłowa!");
            }
            else
            {
                epPesel.Clear();
            }
        }

        #endregion
        #region Override

        protected override void Save()
        {
            if (ValidateForm())
            {
                // SQL

                string query = "insert into dbo.Employees " +
                    "(LastName, FirstName, Code, GenderId, DateBirth, Pesel, PhoneNumber, EmailAddress, IdentityCardNumber, " +
                    "IssueDateIdentityCard, ExpirationDateIdentityCard, PassportNumber, IssueDatePassport, ExpirationDatePassport, StatusId) " +
                    "values (@LastName, @FirstName, @Code, @GenderId, @DateBirth, @Pesel, @PhoneNumber, @EmailAddress, @IdentityCardNumber, " +
                    "@IssueDateIdentityCard, @ExpirationDateIdentityCard, @PassportNumber, @IssueDatePassport, @ExpirationDatePassport, @StatusId)";

                var param = new Dictionary<string, string>();
                param.Add("@LastName", txtLastName.Text);
                param.Add("@FirstName", txtFirstName.Text);
                param.Add("@Code", txtCode.Text);
                param.Add("@GenderId", GetGenderId(cbGender.Text).ToString());
                param.Add("@DateBirth", Convert.ToDateTime(dtpDateBirth.Value).ToString("yyyy-MM-dd"));
                param.Add("@Pesel", txtPesel.Text);
                param.Add("@PhoneNumber", txtPhoneNumber.Text);
                param.Add("@EmailAddress", txtEmailAddress.Text);
                param.Add("@IdentityCardNumber", txtIdentityCardNumber.Text);
                param.Add("@IssueDateIdentityCard", Convert.ToDateTime(dtpIssueDateIdentityCard.Value).ToString("yyyy-MM-dd"));
                param.Add("@ExpirationDateIdentityCard", Convert.ToDateTime(dtpExpirationDateIdentityCard.Value).ToString("yyyy-MM-dd"));
                param.Add("@PassportNumber", txtPassportNumber.Text);
                param.Add("@IssueDatePassport", Convert.ToDateTime(dtpIssueDatePassport.Value).ToString("yyyy-MM-dd"));
                param.Add("@ExpirationDatePassport", Convert.ToDateTime(dtpExpirationDatePassport.Value).ToString("yyyy-MM-dd"));
                param.Add("@StatusId", Convert.ToString(1));

                int result = dbUtilitiesCon.ExecuteQuery(query, param);
                if(result > 0)
                {
                    MessageBox.Show("Pomyślnie wprowadzono pracownika do bazy!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas wprowadzania pracownika do bazy!");
                }
            }
        }

        protected override void Cancel()
        {
            Close();
        }

        #endregion
    }
}
