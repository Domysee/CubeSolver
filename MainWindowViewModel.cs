using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RubiksCubeSolver
{
	public class MainWindowViewModel : ViewModelBase
	{
		private Cube cube;

		public Brush Front00
		{
			get { return cube.Front.Fields[0, 0]; }
		}
	}
}
