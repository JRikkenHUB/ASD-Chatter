using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASD_chatter
{
    public partial class UsernameDialog : Form
    {
        public string UsernameText { get; set; }
        public UsernameDialog()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UsernameText = txtUsername.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
