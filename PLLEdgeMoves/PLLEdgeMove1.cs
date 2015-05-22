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
			Side left = cube.GetSideFromEnum(l);
			Side right = left.Opposite;

			cube.RotateSideCW(front.Opposite.CubeSide);	//need to turn the opposite side because of the cube rotation
			cube.RotateSideCW(front.Opposite.CubeSide);
			cube.RotateBottomCW();
			cube.RotateSideCW(left.CubeSide);
			cube.RotateSideCCW(right.CubeSide);
			cube.RotateSideCW(front.Opposite.CubeSide);
			cube.RotateSideCW(front.Opposite.CubeSide);
			cube.RotateSideCCW(left.CubeSide);
			cube.RotateSideCW(right.CubeSide);
			cube.RotateBottomCW();
			cube.RotateSideCW(front.Opposite.CubeSide);
			cube.RotateSideCW(front.Opposite.CubeSide);
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
				if (side.Fields[0, 1] == side.Color) return 0;
			}
			return 1;
		}
	}
}
