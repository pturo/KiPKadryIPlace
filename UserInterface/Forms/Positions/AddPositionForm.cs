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

namespace KiPKadryIPlace.UserInterface.Forms.Positions
{
    public partial class AddPositionForm : BaseAddEditForm
    {
        #region Fields

        private DBUtilities dbUtilitiesCon;

        #endregion
        #region Constructor

        public AddPositionForm()
        {
            InitializeComponent();
            dbUtilitiesCon = new DBUtilities();
            //ValidateControls();
        }

        #endregion
        #region Private Methods

        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                eName.SetError(txtName, "Pole 'Nazwa' jest wymagane!");
            }
            else
            {
                eName.Clear();
            }

            if (string.IsNullOrWhiteSpace(nudMinSalary.Text))
            {
                eMinSalary.SetError(nudMinSalary, "Pole 'Minimalne wynagrodzenie' jest wymagane!");
            }
            else
            {
                eMinSalary.Clear();
            }

            if (string.IsNullOrWhiteSpace(nudMaxSalary.Text))
            {
                eMinSalary.SetError(nudMaxSalary, "Pole 'Maksymalne wynagrodzenie' jest wymagane!");
            }
            else
            {
                eMinSalary.Clear();
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

            string minSalaryErrorMessage = eMinSalary.GetError(nudMinSalary);
            if (!string.IsNullOrEmpty(minSalaryErrorMessage))
            {
                sbErrorMessage.Append(minSalaryErrorMessage);
            }

            string maxSalaryErrorMessage = eMinSalary.GetError(nudMaxSalary);
            if (!string.IsNullOrEmpty(maxSalaryErrorMessage))
            {
                sbErrorMessage.Append(maxSalaryErrorMessage);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(sbErrorMessage.ToString(), "Dodawanie stanowiska", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                string query = "insert into dbo.Positions (Name, MinSalary, MaxSalary) " +
                    "values (@Name, @MinSalary, @MaxSalary)";

                var param = new Dictionary<string, string>();
                param.Add("@Name", txtName.Text);
                param.Add("@MinSalary", nudMinSalary.Value.ToString());
                param.Add("@MaxSalary", nudMaxSalary.Value.ToString());

                int result = dbUtilitiesCon.ExecuteQuery(query, param);
                if(result > 0)
                {
                    MessageBox.Show("Pomyślnie dodano stanowisko do bazy!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas dodawania stanowiska do bazy!");
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
