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

//TODO: unify the names of layers: instead of Start... name it FirstLayer, also rename Cube.SolveStates methods
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

		private void viewmodel_BeforeCubeTopCWRotation(object sender, EventArgs e)
		{
			this.Dispatcher.Invoke(async () =>
			{
				var animation = this.Resources["RotateTopCW"] as Storyboard;
				animation.Begin();
				await waitUntilAnimationCompletion();
			}).Wait();
		}

		private void viewmodel_BeforeCubeTopCCWRotation(object sender, EventArgs e)
		{
			this.Dispatcher.Invoke(async () =>
			{
				var animation = this.Resources["RotateTopCCW"] as Storyboard;
				animation.Begin();
				await waitUntilAnimationCompletion();
			}).Wait();
		}

		private void viewmodel_BeforeCubeRightCWRotation(object sender, EventArgs e)
		{
			this.Dispatcher.Invoke(async () =>
			{
				var animation = this.Resources["RotateRightCW"] as Storyboard;
				animation.Begin();
				await waitUntilAnimationCompletion();
			}).Wait();
		}

		private void viewmodel_BeforeCubeRightCCWRotation(object sender, EventArgs e)
		{
			this.Dispatcher.Invoke(async () =>
			{
				var animation = this.Resources["RotateRightCCW"] as Storyboard;
				animation.Begin();
				await waitUntilAnimationCompletion();
			}).Wait();
		}

		private void viewmodel_BeforeCubeLeftCWRotation(object sender, EventArgs e)
		{
			this.Dispatcher.Invoke(async () =>
			{
				var animation = this.Resources["RotateLeftCW"] as Storyboard;
				animation.Begin();
				await waitUntilAnimationCompletion();
			}).Wait();
		}

		private void viewmodel_BeforeCubeLeftCCWRotation(object sender, EventArgs e)
		{
			this.Dispatcher.Invoke(async () =>
			{
				var animation = this.Resources["RotateLeftCCW"] as Storyboard;
				animation.Begin();
				await waitUntilAnimationCompletion();
			}).Wait();
		}

		private void viewmodel_BeforeCubeFrontCWRotation(object sender, EventArgs e)
		{
			this.Dispatcher.Invoke(async () =>
			{
				var animation = this.Resources["RotateFrontCW"] as Storyboard;
				animation.Begin();
				await waitUntilAnimationCompletion();
			}).Wait();
		}

		private void viewmodel_BeforeCubeFrontCCWRotation(object sender, EventArgs e)
		{
			this.Dispatcher.Invoke(async () =>
			{
				var animation = this.Resources["RotateFrontCCW"] as Storyboard;
				animation.Begin();
				await waitUntilAnimationCompletion();
			}).Wait();
		}

		private void viewmodel_BeforeCubeBottomCWRotation(object sender, EventArgs e)
		{
			this.Dispatcher.Invoke(async () =>
			{
				var animation = this.Resources["RotateBottomCW"] as Storyboard;
				animation.Begin();
				await waitUntilAnimationCompletion();
			}).Wait();
		}

		private void viewmodel_BeforeCubeBottomCCWRotation(object sender, EventArgs e)
		{
			this.Dispatcher.Invoke(async () =>
			{
				var animation = this.Resources["RotateBottomCCW"] as Storyboard;
				animation.Begin();
				await waitUntilAnimationCompletion();
			}).Wait();
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

		private void viewmodel_BeforeCubeBackCCWRotation(object sender, EventArgs e)
		{
			this.Dispatcher.Invoke(async () =>
			{
				var animation = this.Resources["RotateBackCCW"] as Storyboard;
				animation.Begin();
				await waitUntilAnimationCompletion();
			}).Wait();
		}

		private bool animationCompleted = false;

		private Task waitUntilAnimationCompletion()
		{
			return Task.Run(() =>
			{
				while (!animationCompleted) Task.Delay(10);
				animationCompleted = false;
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
