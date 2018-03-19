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
    public partial class TravelUserControl : UserControl
    {
        public TravelUserControl()
        {
            
            InitializeComponent();
            control();
        }


        public void control()
        {
            TravelPhotoUserControl uc1 = new TravelPhotoUserControl();
            uc1.DestinationLabel = "JAPAN";
            uc1.DateLabel = "2017-08";
            uc1.NumberLabel = "0";
            Photo_Panel.Controls.Add(uc1);

            TravelPhotoUserControl uc2 = new TravelPhotoUserControl();
            uc2.DestinationLabel = "CANANDA";
            uc2.DateLabel = "2018-02";
            uc2.NumberLabel = "0";
            Photo_Panel.Controls.Add(uc2);

            TravelPhotoUserControl uc3 = new TravelPhotoUserControl();
            uc3.DestinationLabel = "VIETNAM";
            uc3.DateLabel = "2016-06";
            uc3.NumberLabel = "0";
            Photo_Panel.Controls.Add(uc3);

            TravelPhotoUserControl uc4 = new TravelPhotoUserControl();
            uc4.DestinationLabel = "US";
            uc4.DateLabel = "2018-02";
            uc4.NumberLabel = "0";
            Photo_Panel.Controls.Add(uc4);
        }
        
    }
}