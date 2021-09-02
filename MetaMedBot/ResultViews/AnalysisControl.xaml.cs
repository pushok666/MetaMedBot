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
using MetaMedBot.ModelData;

namespace MetaMedBot.ResultViews
{
    /// <summary>
    /// Interaction logic for AnalysisControl.xaml
    /// </summary>
    public partial class AnalysisControl : UserControl
    {
        public AnalysisControl()
        {
            InitializeComponent();
            this.DataContext = new Analysis();
        }
    }
}
