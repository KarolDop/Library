using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmAddNew : Form
    {
        public frmAddNew()
        {
            InitializeComponent();
        }

        private void btnCancelNew_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbTranslator_CheckedChanged(object sender, EventArgs e)
        {
            if(chbTranslator.Checked == true)
            {
                cobTranslatorFirstName.Enabled = true;
                cobTranslatorLastName.Enabled = true;
            }
            else
            {
                cobTranslatorFirstName.Enabled = false;
                cobTranslatorLastName.Enabled = false;
            }
        }
    }
}
