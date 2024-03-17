﻿using System;
using System.Collections.Generic;
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

namespace MLM2PRO_BT_APP
{
    /// <summary>
    /// Interaction logic for WebApiWindow.xaml
    /// </summary>
    public partial class WebApiWindow : Window
    {
        public WebApiWindow()
        {
            InitializeComponent();
        }

        private void WebAPISaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (WebAPITextBox.Text != "")
            {
                Logger.Log("Save API Token called");
                // Save the token to the settings
                SettingsManager.Instance.Settings.WebApiSettings.WebApiSecret = WebAPITextBox.Text;
                SettingsManager.Instance.SaveSettings();
                Logger.Log("API Token saved");
                (App.Current as App)?.ConnectAndSetupBluetooth();
                Close();
            }
        }
    }
}