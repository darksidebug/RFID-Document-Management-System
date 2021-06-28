using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace RFID_Document_Management_System
{
    public partial class Form1 : Form
    {

        Animator animator = new Animator();
        DropShadow dropShadow = new DropShadow();
        DragForm dragForm = new DragForm();

        public Form1()
        {
            InitializeComponent();
            animator.AnimateWindow(this);
            dragForm.Drag(this);
            dropShadow.RenderShadows(this);
        }

        private void applyDropShadow(object sender, PaintEventArgs e)
        {
            GunaLinePanel panel = (GunaLinePanel)sender;
            Color[] shadow = new Color[3];
            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(195, 195, 195);
            shadow[2] = Color.FromArgb(211, 211, 211);
            Pen pen = new Pen(shadow[0]);
            using (pen)
            {
                foreach (GunaLinePanel p in panel.Controls.OfType<GunaLinePanel>())
                {
                    Point pt = p.Location;
                    pt.Y += p.Height;
                    for (var sp = 0; sp < 3; sp++)
                    {
                        pen.Color = shadow[sp];
                        e.Graphics.DrawLine(pen, pt.X, pt.Y, pt.X + p.Width - 1, pt.Y);
                        pt.Y++;
                    }
                }
            }
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            animator.AnimateDropDownPanel(gunaLinePanel1, gunaButton10, false);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            animator.AnimateDropDownPanel(gunaLinePanel2, gunaButton2, true);
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            animator.AnimateDropDownPanel(gunaLinePanel1, gunaButton10, false);
        }

        private void gunaButton9_Click_1(object sender, EventArgs e)
        {
            new Documents_Entry().Show();
            animator.AnimateDropDownPanel(gunaLinePanel2, gunaButton2, true);
        }

        private void gunaButton11_Click_1(object sender, EventArgs e)
        {
            new ReturnDocuments().Show();
            animator.AnimateDropDownPanel(gunaLinePanel2, gunaButton2, true);
        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {
            applyDropShadow(sender, e);
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            new UserAccounts().Show();
            animator.AnimateDropDownPanel(gunaLinePanel1, gunaButton10, false);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            (System.Windows.Forms.Application.OpenForms["LoginForm"] as LoginForm).WindowState = FormWindowState.Normal;
        }
    }
}
