using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_Based_Document_Management
{
    public partial class Document_Entry : UserControl
    {
        public Document_Entry()
        {
            InitializeComponent();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            new New_Document_Type().ShowDialog();
        }
    }
}
