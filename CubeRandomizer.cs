using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver
{
	public class CubeRandomizer
	{
		public Cube CreateRandomCube()
		{
			var cube = new Cube();
			DoRandomTurns(cube);
			return cube;
		}

		public void DoRandomTurns(Cube cube)
		{
			var random = new Random();
			//randomize how many turns
			int turnCount = random.Next(100);
			//generate random turns
			var turns = new int[turnCount];
			for (int i = 0; i < turnCount; i++)
			{
				turns[i] = random.Next(12);
			}
			//apply turns
			foreach (var turnId in turns)
			{
				applyAction(cube, turnId);
			}
		}

		private void applyAction(Cube cube, int turnId)
		{
			Debug.Assert(turnId < 12 && turnId >= 0);

			switch (turnId)
			{
				case 0:
					cube.RotateBackCCWAsync().Wait();
					break;
				case 1:
					cube.RotateBackCWAsync().Wait();
					break;
				case 2:
					cube.RotateBottomCCWAsync().Wait();
					break;
				case 3:
					cube.RotateBottomCWAsync().Wait();
					break;
				case 4:
					cube.RotateFrontCCWAsync().Wait();
					break;
				case 5:
					cube.RotateFrontCWAsync().Wait();
					break;
				case 6:
					cube.RotateLeftCCWAsync().Wait();
					break;
				case 7:
					cube.RotateLeftCWAsync().Wait();
					break;
				case 8:
					cube.RotateRightCCWAsync().Wait();
					break;
				case 9:
					cube.RotateRightCWAsync().Wait();
					break;
				case 10:
					cube.RotateTopCCWAsync().Wait();
					break;
				case 11:
					cube.RotateTopCWAsync().Wait();
					break;
			}
		}
	}
}
