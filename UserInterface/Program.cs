using KiPKadryIPlace.DataAccessLayer;
using KiPKadryIPlace.UserInterface.Forms;
using KiPKadryIPlace.UserInterface.Forms.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    static class Program
    {
        #region Main Entry
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginForm());
        }

        #endregion
    }
}
