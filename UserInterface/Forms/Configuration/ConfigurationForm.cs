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
using KiPKadryIPlace.DataAccessLayer;

namespace KiPKadryIPlace.UserInterface.Forms.Configuration
{
    public partial class ConfigurationForm : BaseAddEditForm
    {
        #region Constructor

        public ConfigurationForm()
        {
            InitializeComponent();
            LoadCredentials();
        }

        #endregion
        #region Private Methods

        private void LoadCredentials()
        {
            //txtServerName.Text = AccessGlobalConnection.SERVER;
            //txtDatabase.Text = AccessGlobalConnection.DATABASE;
            //txtUser.Text = AccessGlobalConnection.USERNAME;
            //txtPassword.Text = AccessGlobalConnection.PASSWORD;
        }

        #endregion
        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
