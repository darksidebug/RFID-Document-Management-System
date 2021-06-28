using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI.WinForms;

namespace RFID_Document_Management_System
{
    class ImageApplier
    {
        public void Image(GunaButton button, Boolean isMinimumHeight, bool isWhiteIcon)
        {
            if (isMinimumHeight)
            {
                button.Image = isWhiteIcon ? global::RFID_Document_Management_System.Properties.Resources.Sort_Up_50px_2 : global::RFID_Document_Management_System.Properties.Resources.Sort_Up_50px;
            }
            else
            {
                button.Image = isWhiteIcon ? global::RFID_Document_Management_System.Properties.Resources.Sort_Down_50px_1 : global::RFID_Document_Management_System.Properties.Resources.Sort_Down_60px;
            }
        }
    }
}
