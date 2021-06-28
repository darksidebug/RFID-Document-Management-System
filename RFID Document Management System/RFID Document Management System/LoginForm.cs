using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_Document_Management_System
{
    public partial class LoginForm : Form
    {
        DragForm dragForm = new DragForm();
        Animator animator = new Animator();

        public LoginForm()
        {
            InitializeComponent();
            animator.AnimateWindow(this);
            dragForm.Drag(this);
            (new RFID_Document_Management_System.DropShadow()).RenderShadows(this);
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
