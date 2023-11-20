﻿using CommunityToolkit.Mvvm.Sample.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
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

namespace CommunityToolkit.Mvvm.Sample.Views
{
    /// <summary>
    /// AsyncCommandsView.xaml 的交互逻辑
    /// </summary>
    public partial class AsyncCommandsView : UserControl
    {
        public AsyncCommandsView()
        {
            InitializeComponent();
            DataContext = App.Current.Services.GetService<AsyncCommandsViewModel>();
        }
    }
}