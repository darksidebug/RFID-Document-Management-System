using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RFID_Document_Management_System
{
    public partial class Documents_Entry : Form
    {
        Animator animator = new Animator();
        DragForm dragForm = new DragForm();

        public Documents_Entry()
        {
            InitializeComponent();
            animator.AnimateWindow(this);
            dragForm.Drag(this);
            (new RFID_Document_Management_System.DropShadow()).RenderShadows(this);
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
