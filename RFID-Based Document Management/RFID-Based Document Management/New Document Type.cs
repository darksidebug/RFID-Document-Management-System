using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_Based_Document_Management
{
    public partial class New_Document_Type : Form
    {
        private Classes.Animator animate = new Classes.Animator();

        public New_Document_Type()
        {
            InitializeComponent();
            this.animate.AnimateWindow(this);
            (new Classes.DropShadow()).RenderShadows(this);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
