using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiPKadryIPlace.UserInterface.Forms.Employees.Base
{
    public partial class BaseAddEditForm : BaseForm
    {
        #region Constructor

        public BaseAddEditForm()
        {
            InitializeComponent();
        }

        #endregion
        #region Events

        private void BaseAddEditForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            {
                Save();
            }

            if(ModifierKeys == Keys.Control && e.KeyCode == Keys.C)
            {
                Cancel();
            }

            if(e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        #endregion
        #region Override

        protected virtual void Save() { }

        protected virtual void Cancel() { }

        #endregion
    }
}
