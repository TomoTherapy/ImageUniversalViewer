﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ImageUniversalViewer
{
    /// <summary>
    /// Interaction logic for Splash.xaml
    /// </summary>
    public partial class SplashWindow : Window, INotifyPropertyChanged
    {
        private string m_Status;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Status
        {
            get { return m_Status; }
            set
            {
                if (m_Status != value)
                {
                    m_Status = value;

                }
            }
        }

        public SplashWindow()
        {
            InitializeComponent();
        }
    }
}
