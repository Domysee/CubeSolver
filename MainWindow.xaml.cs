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
			viewmodel.BeforeCubeBackCCWRotation += viewmodel_BeforeCubeBackCCWRotation;
			viewmodel.BeforeCubeBackCWRotation += viewmodel_BeforeCubeBackCWRotation;
			viewmodel.BeforeCubeBottomCCWRotation += viewmodel_BeforeCubeBottomCCWRotation;
			viewmodel.BeforeCubeBottomCWRotation += viewmodel_BeforeCubeBottomCWRotation;
			viewmodel.BeforeCubeFrontCCWRotation += viewmodel_BeforeCubeFrontCCWRotation;
			viewmodel.BeforeCubeFrontCWRotation += viewmodel_BeforeCubeFrontCWRotation;
			viewmodel.BeforeCubeLeftCCWRotation += viewmodel_BeforeCubeLeftCCWRotation;
			viewmodel.BeforeCubeLeftCWRotation += viewmodel_BeforeCubeLeftCWRotation;
			viewmodel.BeforeCubeRightCCWRotation += viewmodel_BeforeCubeRightCCWRotation;
			viewmodel.BeforeCubeRightCWRotation += viewmodel_BeforeCubeRightCWRotation;
			viewmodel.BeforeCubeTopCCWRotation += viewmodel_BeforeCubeTopCCWRotation;
			viewmodel.BeforeCubeTopCWRotation += viewmodel_BeforeCubeTopCWRotation;
			this.DataContext = viewmodel;
		}

		private async void viewmodel_BeforeCubeTopCWRotation(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private async void viewmodel_BeforeCubeTopCCWRotation(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private async void viewmodel_BeforeCubeRightCWRotation(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private async void viewmodel_BeforeCubeRightCCWRotation(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private async void viewmodel_BeforeCubeLeftCWRotation(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private async void viewmodel_BeforeCubeLeftCCWRotation(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private async void viewmodel_BeforeCubeFrontCWRotation(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private async void viewmodel_BeforeCubeFrontCCWRotation(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private async void viewmodel_BeforeCubeBottomCWRotation(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private async void viewmodel_BeforeCubeBottomCCWRotation(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void viewmodel_BeforeCubeBackCWRotation(object sender, EventArgs e)
		{
			this.Dispatcher.Invoke(async () =>
			{
				var animation = this.Resources["RotateBackCW"] as Storyboard;
				animation.Begin();
				await waitUntilAnimationCompletion();
			}).Wait();
		}

		private async void viewmodel_BeforeCubeBackCCWRotation(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private bool animationCompleted = false;

		private Task waitUntilAnimationCompletion()
		{
			return Task.Run(() =>
			{
				while (!animationCompleted) Task.Delay(10);
			});
		}

		private void Storyboard_Completed(object sender, EventArgs e)
		{
			animationCompleted = true;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
		}
	}
}
