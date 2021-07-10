﻿using System;
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
    public partial class Login : Form
    {
        private Classes.Animator animator = new Classes.Animator();
        private Classes.DropShadow dropShadow = new Classes.DropShadow();
        private Classes.DragForm dragForm = new Classes.DragForm();
        private Classes.RenderStyling render = new Classes.RenderStyling();

        public Login()
        {
            InitializeComponent();

            this.animator.AnimateWindow(this);
            this.dragForm.Drag(this);
            this.dropShadow.RenderShadows(this);
        }
    }
}
