﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inf_Security
{
    public partial class errorForm : Form
    {
        public errorForm()
        {
            InitializeComponent();
        }

        private void errorButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
