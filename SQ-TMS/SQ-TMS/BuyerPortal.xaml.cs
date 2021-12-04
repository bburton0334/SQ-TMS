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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SQ_TMS
{
    /// <summary>
    /// Interaction logic for BuyerPortal.xaml
    /// </summary>
    /// 

    public partial class BuyerPortal : Page
    {
        bool isCMPVisible = false;

        public BuyerPortal()
        {
            InitializeComponent();

        }

        private void btnContractMarketplace_Click(object sender, RoutedEventArgs e)
        {
            if (isCMPVisible == false)
            {
                frameContractMarketplace.Content = new Buyer_ContractMarketplace();
                frameContractMarketplace.Visibility = Visibility.Visible;
                isCMPVisible = true;
            }
            else
            {
                frameContractMarketplace.Visibility = Visibility.Hidden;
                isCMPVisible = false;
            }
        }
    }
}
