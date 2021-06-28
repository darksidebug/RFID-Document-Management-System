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
    public partial class UserAccounts : Form
    {
        DragForm dragForm = new DragForm();
        Animator animator = new Animator();

        public UserAccounts()
        {
            InitializeComponent();
            animator.AnimateWindow(this);
            dragForm.Drag(this);
            (new RFID_Document_Management_System.DropShadow()).RenderShadows(this);
        }
    }
}
