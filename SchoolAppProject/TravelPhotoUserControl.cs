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
    public partial class TravelPhotoUserControl : UserControl
    {
       
        private static TravelPhotoUserControl _instance;
        public static TravelPhotoUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TravelPhotoUserControl();
                return _instance;
            }
        }
        public TravelPhotoUserControl()
        {
            InitializeComponent();
        }

        public string DestinationLabel
        {
            get { return Destination_label.Text; }
            set { Destination_label.Text = value; }
        }

        public string DateLabel
        {
            get { return Date_label.Text; }
            set { Date_label.Text = value; }
        }
        public string NumberLabel
        {
            get { return Number_label.Text; }
            set { Number_label.Text = value; }
        }

        public Image PostImage
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }

       
        private void pictureBox_Click(object sender, EventArgs e)
        {
          
            if (DestinationLabel == "JAPAN")
            {
                AlbumUserControl uc1 = new AlbumUserControl();
                uc1.AlbumLabel = "JAPAN ALBUM";
                TravelUserControl.Instance.Controls.Add(uc1);
                uc1.BringToFront();
            }

            if (DestinationLabel == "CANADA")
            {
                AlbumUserControl uc2 = new AlbumUserControl();
                uc2.AlbumLabel = "CANADA ALBUM";
                TravelUserControl.Instance.Controls.Add(uc2);
                uc2.BringToFront();
            }

            if (DestinationLabel == "VIETNAM")
            {
                AlbumUserControl uc3 = new AlbumUserControl();
                uc3.AlbumLabel = "VIETNAM ALBUM";
                TravelUserControl.Instance.Controls.Add(uc3);
                uc3.BringToFront();
            }

            if (DestinationLabel == "NEWYORK")
            {
                AlbumUserControl uc4 = new AlbumUserControl();
                uc4.AlbumLabel = "NEWYORK ALBUM";
                TravelUserControl.Instance.Controls.Add(uc4);
                uc4.BringToFront();
            }

            if (DestinationLabel == "LA")
            {
                AlbumUserControl uc5 = new AlbumUserControl();
                uc5.AlbumLabel = "LA ALBUM";
                TravelUserControl.Instance.Controls.Add(uc5);
                uc5.BringToFront();
            }

        }
    }
}
