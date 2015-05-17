using RubiksCubeSolver.StartCrossMoves;
using RubiksCubeSolver.StartCornerMoves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using RubiksCubeSolver.SecondLayerEdgeMoves;
using RubiksCubeSolver.ThirdLayerCrossMoves;

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
		private RelayCommand solve;

		public RelayCommand Solve
		{
			get { return solve; }
			set { solve = value; }
		}
		#endregion

		#region Events
		public event EventHandler BeforeCubeLeftCWRotation
		{
			add { cube.BeforeLeftCWRotation += value; }
			remove { cube.BeforeLeftCWRotation -= value; }
		}
		public event EventHandler BeforeCubeLeftCCWRotation
		{
			add { cube.BeforeLeftCCWRotation += value; }
			remove { cube.BeforeLeftCCWRotation -= value; }
		}
		public event EventHandler BeforeCubeRightCWRotation
		{
			add { cube.BeforeRightCWRotation += value; }
			remove { cube.BeforeRightCWRotation -= value; }
		}
		public event EventHandler BeforeCubeRightCCWRotation
		{
			add { cube.BeforeRightCCWRotation += value; }
			remove { cube.BeforeRightCCWRotation -= value; }
		}
		public event EventHandler BeforeCubeFrontCWRotation
		{
			add { cube.BeforeFrontCWRotation += value; }
			remove { cube.BeforeFrontCWRotation -= value; }
		}
		public event EventHandler BeforeCubeFrontCCWRotation
		{
			add { cube.BeforeFrontCCWRotation += value; }
			remove { cube.BeforeFrontCCWRotation -= value; }
		}
		public event EventHandler BeforeCubeBackCWRotation
		{
			add { cube.BeforeBackCWRotation += value; }
			remove { cube.BeforeBackCWRotation -= value; }
		}
		public event EventHandler BeforeCubeBackCCWRotation
		{
			add { cube.BeforeBackCCWRotation += value; }
			remove { cube.BeforeBackCCWRotation -= value; }
		}
		public event EventHandler BeforeCubeTopCWRotation
		{
			add { cube.BeforeTopCWRotation += value; }
			remove { cube.BeforeTopCWRotation -= value; }
		}
		public event EventHandler BeforeCubeTopCCWRotation
		{
			add { cube.BeforeTopCCWRotation += value; }
			remove { cube.BeforeTopCCWRotation -= value; }
		}
		public event EventHandler BeforeCubeBottomCWRotation
		{
			add { cube.BeforeBottomCWRotation += value; }
			remove { cube.BeforeBottomCWRotation -= value; }
		}
		public event EventHandler BeforeCubeBottomCCWRotation
		{
			add { cube.BeforeBottomCCWRotation += value; }
			remove { cube.BeforeBottomCCWRotation -= value; }
		}
		#endregion

		public MainWindowViewModel()
		{
			cube = new Cube();
			cube.AfterBackCWRotation += cube_AfterRotation;
			cube.AfterBackCCWRotation += cube_AfterRotation;
			cube.AfterFrontCWRotation += cube_AfterRotation;
			cube.AfterFrontCCWRotation += cube_AfterRotation;
			cube.AfterTopCWRotation += cube_AfterRotation;
			cube.AfterTopCCWRotation += cube_AfterRotation;
			cube.AfterBottomCWRotation += cube_AfterRotation;
			cube.AfterBottomCCWRotation += cube_AfterRotation;
			cube.AfterLeftCWRotation += cube_AfterRotation;
			cube.AfterLeftCCWRotation += cube_AfterRotation;
			cube.AfterRightCWRotation += cube_AfterRotation;
			cube.AfterRightCCWRotation += cube_AfterRotation;
			initializeCommands();
		}

		void cube_AfterRotation(object sender, EventArgs e)
		{
			raiseAllPropertiesChanged();
		}

		private void initializeCommands()
		{
			test = new RelayCommand((param) =>
			{
				Task.Run(() =>
				{
					IThirdLayerCrossMove move = new ThirdLayerCrossMove1();
					move.Apply(cube);
				});
			});
			randomize = new RelayCommand((param) =>
			{
				Task.Run(() =>
				{
					new CubeRandomizer().DoRandomTurns(cube);
				});
			});
			solve = new RelayCommand((param) =>
			{
				Task.Run(() =>
				{
					var solver = new HumanCubeSolver3x3();
					solver.SolveTopCross(cube);
					solver.SolveTopEdges(cube);
					solver.SolveSecondLayer(cube);
					solver.SolveThirdLayerCross(cube);
				});
			});
			actionB = new RelayCommand((param) =>
			{
				cube.RotateBackCWAsync();
			});
			actionBi = new RelayCommand((param) =>
			{
				cube.RotateBackCCWAsync();
			});
			actionF = new RelayCommand((param) =>
			{
				cube.RotateFrontCWAsync();
			});
			actionFi = new RelayCommand((param) =>
			{
				cube.RotateFrontCCWAsync();
			});
			actionL = new RelayCommand((param) =>
			{
				cube.RotateLeftCWAsync();
			});
			actionLi = new RelayCommand((param) =>
			{
				cube.RotateLeftCCWAsync();
			});
			actionR = new RelayCommand((param) =>
			{
				cube.RotateRightCWAsync();
			});
			actionRi = new RelayCommand((param) =>
			{
				cube.RotateRightCCWAsync();
			});
			actionU = new RelayCommand((param) =>
			{
				cube.RotateTopCWAsync();
			});
			actionUi = new RelayCommand((param) =>
			{
				cube.RotateTopCCWAsync();
			});
			actionD = new RelayCommand((param) =>
			{
				cube.RotateBottomCWAsync();
			});
			actionDi = new RelayCommand((param) =>
			{
				cube.RotateBottomCCWAsync();
			});
		}
	}
}
