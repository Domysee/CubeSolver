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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RubiksCubeSolver
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		MainWindowViewModel viewmodel;

		public MainWindow()
		{
			InitializeComponent();

			viewmodel = new MainWindowViewModel();
			this.DataContext = viewmodel;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			(this.Resources["RotateBackCW"] as Storyboard).Begin();
		}
	}
}
