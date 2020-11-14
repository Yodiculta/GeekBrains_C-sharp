using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace calculator
{
    
    class Program
    {
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new Form2(); 
            Application.Run(mainForm);

            switch (mainForm.InternalDialogResult)
            {
                case DialogResult.Cancel:
                    MessageBox.Show("Bye!");
                    break;
                case DialogResult.OK:

                    var mainForm2 = new Form1();
                    DialogResult secondresult = mainForm2.ShowDialog();
                    break;
            }


        }
    }
}
