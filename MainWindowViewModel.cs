using RubiksCubeSolver.StartCrossMoves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
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

		#region Commands
		private RelayCommand test;

		public RelayCommand Test
		{
			get { return test; }
			set { test = value; }
		}
		private RelayCommand randomize;

		public RelayCommand Randomize
		{
			get { return randomize; }
			set { randomize = value; }
		}
		private RelayCommand actionU;

		public RelayCommand ActionU
		{
			get { return actionU; }
			set { actionU = value; }
		}
		private RelayCommand actionUi;

		public RelayCommand ActionUi
		{
			get { return actionUi; }
			set { actionUi = value; }
		}
		private RelayCommand actionD;

		public RelayCommand ActionD
		{
			get { return actionD; }
			set { actionD = value; }
		}
		private RelayCommand actionDi;

		public RelayCommand ActionDi
		{
			get { return actionDi; }
			set { actionDi = value; }
		}
		private RelayCommand actionL;

		public RelayCommand ActionL
		{
			get { return actionL; }
			set { actionL = value; }
		}
		private RelayCommand actionLi;

		public RelayCommand ActionLi
		{
			get { return actionLi; }
			set { actionLi = value; }
		}
		private RelayCommand actionR;

		public RelayCommand ActionR
		{
			get { return actionR; }
			set { actionR = value; }
		}
		private RelayCommand actionRi;

		public RelayCommand ActionRi
		{
			get { return actionRi; }
			set { actionRi = value; }
		}
		private RelayCommand actionF;

		public RelayCommand ActionF
		{
			get { return actionF; }
			set { actionF = value; }
		}
		private RelayCommand actionFi;

		public RelayCommand ActionFi
		{
			get { return actionFi; }
			set { actionFi = value; }
		}
		private RelayCommand actionB;

		public RelayCommand ActionB
		{
			get { return actionB; }
			set { actionB = value; }
		}
		private RelayCommand actionBi;

		public RelayCommand ActionBi
		{
			get { return actionBi; }
			set { actionBi = value; }
		}
		#endregion

		public MainWindowViewModel()
		{
			cube = new Cube();
			initializeCommands();
		}

		private void initializeCommands()
		{
			test = new RelayCommand((param) =>
			{
				var move = new StartCrossMove3();
				foreach (RelativeSidePosition relativeSidePosition in Enum.GetValues(typeof(RelativeSidePosition)))
				{
					if (relativeSidePosition != RelativeSidePosition.NotExisting && 
						relativeSidePosition != RelativeSidePosition.Self && 
						relativeSidePosition != RelativeSidePosition.Opposite && 
						move.Applicable(cube, relativeSidePosition) == 1)
					{
						move.Apply(cube, relativeSidePosition);
					}
				}
				raiseAllPropertiesChanged();
			});
			randomize = new RelayCommand((param) =>
			{
				new CubeRandomizer().DoRandomTurns(cube);
				raiseAllPropertiesChanged();
			});
			actionB = new RelayCommand((param) =>
			{
				cube.RotateBackCW();
				raiseAllPropertiesChanged();
			});
			actionBi = new RelayCommand((param) =>
			{
				cube.RotateBackCCW();
				raiseAllPropertiesChanged();
			});
			actionF = new RelayCommand((param) =>
			{
				cube.RotateFrontCW();
				raiseAllPropertiesChanged();
			});
			actionFi = new RelayCommand((param) =>
			{
				cube.RotateFrontCCW();
				raiseAllPropertiesChanged();
			});
			actionL = new RelayCommand((param) =>
			{
				cube.RotateLeftCW();
				raiseAllPropertiesChanged();
			});
			actionLi = new RelayCommand((param) =>
			{
				cube.RotateLeftCCW();
				raiseAllPropertiesChanged();
			});
			actionR = new RelayCommand((param) =>
			{
				cube.RotateRightCW();
				raiseAllPropertiesChanged();
			});
			actionRi = new RelayCommand((param) =>
			{
				cube.RotateRightCCW();
				raiseAllPropertiesChanged();
			});
			actionU = new RelayCommand((param) =>
			{
				cube.RotateTopCW();
				raiseAllPropertiesChanged();
			});
			actionUi = new RelayCommand((param) =>
			{
				cube.RotateTopCCW();
				raiseAllPropertiesChanged();
			});
			actionD = new RelayCommand((param) =>
			{
				cube.RotateBottomCW();
				raiseAllPropertiesChanged();
			});
			actionDi = new RelayCommand((param) =>
			{
				cube.RotateBottomCCW();
				raiseAllPropertiesChanged();
			});
		}
	}
}
