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
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                GunaLinePanel gunaLinePanel = new GunaLinePanel();
                //gunaLinePanel.MouseHover += new System.EventHandler(this.gunaPanel_Hover);
                //gunaLinePanel.MouseLeave += new System.EventHandler(this.gunaPanel_Leave);
                gunaLinePanel.Size = new System.Drawing.Size(this.Width - 38, 50);
                gunaLinePanel.Location = new System.Drawing.Point(12, ((27 * (i * 2)) + 2));
                gunaLinePanel.LineColor = System.Drawing.Color.FromArgb(224, 224, 224);
                gunaLinePanel.LineLeft = 1;
                gunaLinePanel.LineRight = 1;
                gunaLinePanel.LineTop = 1;
                gunaLinePanel.LineBottom = 1;
                gunaLinePanel.Name = "gunaLinePanel" + (i + 1);
                gunaLinePanel.Cursor = System.Windows.Forms.Cursors.Hand;
                gunaLinePanel.AutoSize = true;
                gunaLinePanel.Click += new System.EventHandler(this.gunaPanel_Click);
                this.Controls.Add(gunaLinePanel);
            }

            int a = 1;
            foreach (GunaLinePanel panel in this.Controls.OfType<GunaLinePanel>())//GunaTileButton item in this.Controls.OfType<GunaTileButton>()
            {
                GunaLabel label = new GunaLabel();
                label.Text = "Folder" + (a++);
                label.Location = new System.Drawing.Point(5, 17);
                label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                panel.Controls.Add(label);
            }
            
        }

        private void gunaPanel_Click(object sender, EventArgs e)
        {
            GunaLinePanel gunaPanel = sender as GunaLinePanel;
            MessageBox.Show(gunaPanel.Name);
        }

        private void gunaPanel_Hover(object sender, EventArgs e)
        {
            GunaLinePanel gunaPanel = sender as GunaLinePanel;
            gunaPanel.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
        }

        private void gunaPanel_Leave(object sender, EventArgs e)
        {
            GunaLinePanel gunaPanel = sender as GunaLinePanel;
            gunaPanel.BackColor = System.Drawing.Color.White;
        }
    }
}
