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
		public Cube cube;

		#region Properties
		public Brush Front00
		{
			get { return cube.Front.Fields[0, 0]; }
		}

		public Brush Front01
		{
			get { return cube.Front.Fields[0, 1]; }
		}

		public Brush Front02
		{
			get { return cube.Front.Fields[0, 2]; }
		}

		public Brush Front10
		{
			get { return cube.Front.Fields[1, 0]; }
		}

		public Brush Front11
		{
			get { return cube.Front.Fields[1, 1]; }
		}

		public Brush Front12
		{
			get { return cube.Front.Fields[1, 2]; }
		}

		public Brush Front20
		{
			get { return cube.Front.Fields[2, 0]; }
		}

		public Brush Front21
		{
			get { return cube.Front.Fields[2, 1]; }
		}

		public Brush Front22
		{
			get { return cube.Front.Fields[2, 2]; }
		}

		public Brush Back00
		{
			get { return cube.Back.Fields[0, 0]; }
		}

		public Brush Back01
		{
			get { return cube.Back.Fields[0, 1]; }
		}

		public Brush Back02
		{
			get { return cube.Back.Fields[0, 2]; }
		}

		public Brush Back10
		{
			get { return cube.Back.Fields[1, 0]; }
		}

		public Brush Back11
		{
			get { return cube.Back.Fields[1, 1]; }
		}

		public Brush Back12
		{
			get { return cube.Back.Fields[1, 2]; }
		}

		public Brush Back20
		{
			get { return cube.Back.Fields[2, 0]; }
		}

		public Brush Back21
		{
			get { return cube.Back.Fields[2, 1]; }
		}

		public Brush Back22
		{
			get { return cube.Back.Fields[2, 2]; }
		}

		public Brush Left00
		{
			get { return cube.Left.Fields[0, 0]; }
		}

		public Brush Left01
		{
			get { return cube.Left.Fields[0, 1]; }
		}

		public Brush Left02
		{
			get { return cube.Left.Fields[0, 2]; }
		}

		public Brush Left10
		{
			get { return cube.Left.Fields[1, 0]; }
		}

		public Brush Left11
		{
			get { return cube.Left.Fields[1, 1]; }
		}

		public Brush Left12
		{
			get { return cube.Left.Fields[1, 2]; }
		}

		public Brush Left20
		{
			get { return cube.Left.Fields[2, 0]; }
		}

		public Brush Left21
		{
			get { return cube.Left.Fields[2, 1]; }
		}

		public Brush Left22
		{
			get { return cube.Left.Fields[2, 2]; }
		}

		public Brush Right00
		{
			get { return cube.Right.Fields[0, 0]; }
		}

		public Brush Right01
		{
			get { return cube.Right.Fields[0, 1]; }
		}

		public Brush Right02
		{
			get { return cube.Right.Fields[0, 2]; }
		}

		public Brush Right10
		{
			get { return cube.Right.Fields[1, 0]; }
		}

		public Brush Right11
		{
			get { return cube.Right.Fields[1, 1]; }
		}

		public Brush Right12
		{
			get { return cube.Right.Fields[1, 2]; }
		}

		public Brush Right20
		{
			get { return cube.Right.Fields[2, 0]; }
		}

		public Brush Right21
		{
			get { return cube.Right.Fields[2, 1]; }
		}

		public Brush Right22
		{
			get { return cube.Right.Fields[2, 2]; }
		}

		public Brush Top00
		{
			get { return cube.Top.Fields[0, 0]; }
		}

		public Brush Top01
		{
			get { return cube.Top.Fields[0, 1]; }
		}

		public Brush Top02
		{
			get { return cube.Top.Fields[0, 2]; }
		}

		public Brush Top10
		{
			get { return cube.Top.Fields[1, 0]; }
		}

		public Brush Top11
		{
			get { return cube.Top.Fields[1, 1]; }
		}

		public Brush Top12
		{
			get { return cube.Top.Fields[1, 2]; }
		}

		public Brush Top20
		{
			get { return cube.Top.Fields[2, 0]; }
		}

		public Brush Top21
		{
			get { return cube.Top.Fields[2, 1]; }
		}

		public Brush Top22
		{
			get { return cube.Top.Fields[2, 2]; }
		}

		public Brush Bottom00
		{
			get { return cube.Bottom.Fields[0, 0]; }
		}

		public Brush Bottom01
		{
			get { return cube.Bottom.Fields[0, 1]; }
		}

		public Brush Bottom02
		{
			get { return cube.Bottom.Fields[0, 2]; }
		}

		public Brush Bottom10
		{
			get { return cube.Bottom.Fields[1, 0]; }
		}

		public Brush Bottom11
		{
			get { return cube.Bottom.Fields[1, 1]; }
		}

		public Brush Bottom12
		{
			get { return cube.Bottom.Fields[1, 2]; }
		}

		public Brush Bottom20
		{
			get { return cube.Bottom.Fields[2, 0]; }
		}

		public Brush Bottom21
		{
			get { return cube.Bottom.Fields[2, 1]; }
		}

		public Brush Bottom22
		{
			get { return cube.Bottom.Fields[2, 2]; }
		}
		#endregion

		public MainWindowViewModel()
		{
			cube = new Cube();
		}
	}
}
