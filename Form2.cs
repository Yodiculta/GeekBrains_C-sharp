using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form2 : Form
    {
        private DialogResult internalDialogResult = DialogResult.None;

        public DialogResult InternalDialogResult
        {
            get { return internalDialogResult; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void pusk_but_Click(object sender, EventArgs e)
        {
            internalDialogResult = DialogResult.OK;
            Close();

        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            internalDialogResult = DialogResult.Cancel;
            Close();

        }

    }
}
