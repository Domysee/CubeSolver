using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver.ThirdLayerCrossMoves
{
	public class PLLEdgeMove1 : IPLLEdgeMove
	{
		/// <summary>
		/// represents the move to rotate the front 3 edges clockwise
		/// </summary>
		/// <param name="cube"></param>
		public void Apply(Cube cube, RelativeCornerPosition corner)
		{
			Sides f, l;
			Helper.GetFrontLeftFromCorner(corner, out f, out l);
			Side front = cube.GetSideFromEnum(f);
			//because the cube is rotated around the x-axis, left and right are switched
			Side right = cube.GetSideFromEnum(l);
			Side left = right.Opposite;

			cube.RotateSideCW(front.CubeSide);
			cube.RotateSideCW(front.CubeSide);
			cube.RotateBottomCW();
			cube.RotateSideCW(left.CubeSide);
			cube.RotateSideCCW(right.CubeSide);
			cube.RotateSideCW(front.CubeSide);
			cube.RotateSideCW(front.CubeSide);
			cube.RotateSideCCW(left.CubeSide);
			cube.RotateSideCW(right.CubeSide);
			cube.RotateBottomCW();
			cube.RotateSideCW(front.CubeSide);
			cube.RotateSideCW(front.CubeSide);
		}

		public double Applicable(Cube cube, RelativeCornerPosition corner)
		{
			Sides f, l;
			Helper.GetFrontLeftFromCorner(corner, out f, out l);
			Side front = cube.GetSideFromEnum(f);
			Side left = cube.GetSideFromEnum(l);
			Side right = left.Opposite;

			foreach (var side in new Side[] { front, left, right })
			{
				if (side.Fields[2, 1] == side.Color) return 0;
			}
			return 1;
		}
	}
}
