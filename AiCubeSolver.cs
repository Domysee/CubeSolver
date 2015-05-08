using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver
{
	public class AiCubeSolver
	{
		public void SolveTopCross(Cube cube)
		{
			const int maxDepth = 10;
			var actionStack = new Stack<int>();
			while (!cube.IsTopCrossSolved())
			{
				if (actionStack.Count < maxDepth)
				{
					actionStack.Push(0);
					applyAction(cube, 0);
				}
				else if (actionStack.Count == maxDepth)
				{
					//reverse the action done previously
					int previousAction = actionStack.Pop();
					applyOppositeAction(cube, previousAction);

					//pop all last actions from the stack
					while (previousAction == 11)
					{
						previousAction = actionStack.Pop();
						applyOppositeAction(cube, previousAction);
						if (actionStack.Count == 0)
						{
							var x = 0;
						}
					}

					//apply next action
					int action = previousAction + 1;
					actionStack.Push(action);
					applyAction(cube, action);
				}
			}

			int[] actions = actionStack.Reverse().ToArray();
			//reset the cube so that it is in original state
			while (actionStack.Count > 0) applyOppositeAction(cube, actionStack.Pop());

			foreach (var action in actions)
			{
				applyAction(cube, action, true);
			}
		}

		private void applyAction(Cube cube, int turnId, bool fireEvents = false)
		{
			Debug.Assert(turnId < 12 && turnId >= 0);

			switch (turnId)
			{
				case 0:
					cube.RotateBackCCWAsync(fireEvents).Wait();
					break;
				case 1:
					cube.RotateBackCWAsync(fireEvents).Wait();
					break;
				case 2:
					cube.RotateBottomCCWAsync(fireEvents).Wait();
					break;
				case 3:
					cube.RotateBottomCWAsync(fireEvents).Wait();
					break;
				case 4:
					cube.RotateFrontCCWAsync(fireEvents).Wait();
					break;
				case 5:
					cube.RotateFrontCWAsync(fireEvents).Wait();
					break;
				case 6:
					cube.RotateLeftCCWAsync(fireEvents).Wait();
					break;
				case 7:
					cube.RotateLeftCWAsync(fireEvents).Wait();
					break;
				case 8:
					cube.RotateRightCCWAsync(fireEvents).Wait();
					break;
				case 9:
					cube.RotateRightCWAsync(fireEvents).Wait();
					break;
				case 10:
					cube.RotateTopCCWAsync(fireEvents).Wait();
					break;
				case 11:
					cube.RotateTopCWAsync(fireEvents).Wait();
					break;
			}
		}

		private void applyOppositeAction(Cube cube, int turnId, bool fireEvents = false)
		{
			Debug.Assert(turnId < 12 && turnId >= 0);

			switch (turnId)
			{
				case 0:
					cube.RotateBackCWAsync(fireEvents).Wait();
					break;
				case 1:
					cube.RotateBackCCWAsync(fireEvents).Wait();
					break;
				case 2:
					cube.RotateBottomCWAsync(fireEvents).Wait();
					break;
				case 3:
					cube.RotateBottomCCWAsync(fireEvents).Wait();
					break;
				case 4:
					cube.RotateFrontCWAsync(fireEvents).Wait();
					break;
				case 5:
					cube.RotateFrontCCWAsync(fireEvents).Wait();
					break;
				case 6:
					cube.RotateLeftCWAsync(fireEvents).Wait();
					break;
				case 7:
					cube.RotateLeftCCWAsync(fireEvents).Wait();
					break;
				case 8:
					cube.RotateRightCWAsync(fireEvents).Wait();
					break;
				case 9:
					cube.RotateRightCCWAsync(fireEvents).Wait();
					break;
				case 10:
					cube.RotateTopCWAsync(fireEvents).Wait();
					break;
				case 11:
					cube.RotateTopCCWAsync(fireEvents).Wait();
					break;
			}
		}
	}
}
