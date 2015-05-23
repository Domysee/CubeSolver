using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.OLLCrossMoves
{
	public class OLLCrossMove2 : IOLLCrossMove
	{
		/// <summary>
		/// represents the move to build the cross from a line
		/// </summary>
		/// <param name="cube"></param>
		public void Apply(Cube cube)
		{
			cube.RotateBackCW();
			cube.RotateRightCW();
			cube.RotateBottomCW();
			cube.RotateRightCCW();
			cube.RotateBottomCCW();
			cube.RotateBackCCW();
		}

		public double Applicable(Cube cube)
		{
			if (cube.Bottom.Fields[0, 1] != cube.Bottom.Color && cube.Bottom.Fields[1, 0] == cube.Bottom.Color &&
				   cube.Bottom.Fields[1, 2] == cube.Bottom.Color && cube.Bottom.Fields[2, 1] != cube.Bottom.Color)
			{
				return 1;
			}
			else if (cube.Bottom.Fields[0, 1] != cube.Bottom.Color && cube.Bottom.Fields[1, 0] != cube.Bottom.Color &&
				 cube.Bottom.Fields[1, 2] != cube.Bottom.Color && cube.Bottom.Fields[2, 1] != cube.Bottom.Color)
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}
	}
}
