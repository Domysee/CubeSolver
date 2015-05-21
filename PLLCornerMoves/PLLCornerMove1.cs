using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.ThirdLayerCrossMoves
{
	public class PLLCornerMove1 : IPLLCornerMove
	{
		/// <summary>
		/// represents the one single move that is needed to solve the corners
		/// </summary>
		/// <param name="cube"></param>
		public void Apply(Cube cube)
		{
			cube.RotateRightCCW();
			cube.RotateBackCW();
			cube.RotateRightCCW();
			cube.RotateFrontCW();
			cube.RotateFrontCW();
			cube.RotateRightCW();
			cube.RotateBackCCW();
			cube.RotateRightCCW();
			cube.RotateFrontCW();
			cube.RotateFrontCW();
			cube.RotateRightCW();
			cube.RotateRightCW();
			cube.RotateBottomCCW();
		}

		public double Applicable(Cube cube)
		{
			foreach (var side in new Side[] { cube.Front, cube.Left, cube.Right })
			{
				//checks if there are no correctly aligned corners on all sides except back
				if (side.GetCornerField(RelativeCornerPosition.TopLeft) == side.GetCornerField(RelativeCornerPosition.TopRight))
				{
					return 0;
				}
			}
			//if the for loop didnt return 0, then either the correctly aligned corners are on the back or there are no correctly aligned corers
			//both of which make this move applicable
			return 1;
		}
	}
}
