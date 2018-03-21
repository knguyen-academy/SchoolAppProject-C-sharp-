﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolAppProject
{
    public partial class Education_UserControl : UserControl
    {
        private static Education_UserControl _instance;
        public static Education_UserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Education_UserControl();
                return _instance;
            }
        }
        public Education_UserControl()
        {
            InitializeComponent();
        }
    }
}


