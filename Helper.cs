using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver
{
	public static class Helper
	{
		public static RelativeSidePosition GetOppositeRelativeSide(RelativeSidePosition relativeSide)
		{
			switch (relativeSide)
			{
				case RelativeSidePosition.Bottom: return RelativeSidePosition.Top;
				case RelativeSidePosition.Top: return RelativeSidePosition.Bottom;
				case RelativeSidePosition.Left: return RelativeSidePosition.Right;
				case RelativeSidePosition.Right: return RelativeSidePosition.Left;
				case RelativeSidePosition.Opposite: return RelativeSidePosition.Self;
				case RelativeSidePosition.Self: return RelativeSidePosition.Opposite;
				default: return RelativeSidePosition.NotExisting;
			}
		}

		public static RelativeEdgePosition GetOppositeRelativeEdge(RelativeEdgePosition relativeEdge)
		{
			switch (relativeEdge)
			{
				case RelativeEdgePosition.Bottom: return RelativeEdgePosition.Top;
				case RelativeEdgePosition.Top: return RelativeEdgePosition.Bottom;
				case RelativeEdgePosition.Left: return RelativeEdgePosition.Right;
				case RelativeEdgePosition.Right: return RelativeEdgePosition.Left;
				default: return RelativeEdgePosition.NotExisting;
			}
		}
		public static RelativeEdgePosition ConvertRelativeSidePositionToRelativeEdgePosition(RelativeSidePosition relativeSide)
		{
			switch (relativeSide)
			{
				case RelativeSidePosition.Bottom: return RelativeEdgePosition.Bottom;
				case RelativeSidePosition.Top: return RelativeEdgePosition.Top;
				case RelativeSidePosition.Left: return RelativeEdgePosition.Left;
				case RelativeSidePosition.Right: return RelativeEdgePosition.Right;
				default: return RelativeEdgePosition.NotExisting;
			}
		}

		/// <summary>
		/// treats the cube as if it were rotated so that the relativeEdgePosition is bottom
		/// and then returns the side that is given by relativeSidePosition
		/// </summary>
		/// <param name="startSide"></param>
		/// <param name="relativeSidePosition"></param>
		/// <param name="relativeEdgePosition"></param>
		/// <returns></returns>
		public static Side GetRotationNeutralRelativeSide(Side startSide,
			RelativeSidePosition relativeSidePosition, RelativeEdgePosition relativeEdgePosition)
		{
			if (relativeEdgePosition == RelativeEdgePosition.Left)
			{
				if (relativeSidePosition == RelativeSidePosition.Left) return startSide.Top;
				if (relativeSidePosition == RelativeSidePosition.Right) return startSide.Bottom;
				if (relativeSidePosition == RelativeSidePosition.Bottom) return startSide.Left;
				if (relativeSidePosition == RelativeSidePosition.Top) return startSide.Right;
				if (relativeSidePosition == RelativeSidePosition.Opposite) return startSide.Opposite;
				if (relativeSidePosition == RelativeSidePosition.Self) return startSide;
			}
			if (relativeEdgePosition == RelativeEdgePosition.Right)
			{
				if (relativeSidePosition == RelativeSidePosition.Left) return startSide.Bottom;
				if (relativeSidePosition == RelativeSidePosition.Right) return startSide.Top;
				if (relativeSidePosition == RelativeSidePosition.Bottom) return startSide.Right;
				if (relativeSidePosition == RelativeSidePosition.Top) return startSide.Left;
				if (relativeSidePosition == RelativeSidePosition.Opposite) return startSide.Opposite;
				if (relativeSidePosition == RelativeSidePosition.Self) return startSide;
			}
			if (relativeEdgePosition == RelativeEdgePosition.Top)
			{
				if (relativeSidePosition == RelativeSidePosition.Left) return startSide.Right;
				if (relativeSidePosition == RelativeSidePosition.Right) return startSide.Left;
				if (relativeSidePosition == RelativeSidePosition.Bottom) return startSide.Top;
				if (relativeSidePosition == RelativeSidePosition.Top) return startSide.Bottom;
				if (relativeSidePosition == RelativeSidePosition.Opposite) return startSide.Opposite;
				if (relativeSidePosition == RelativeSidePosition.Self) return startSide;
			}
			if (relativeEdgePosition == RelativeEdgePosition.Bottom)
			{
				if (relativeSidePosition == RelativeSidePosition.Left) return startSide.Left;
				if (relativeSidePosition == RelativeSidePosition.Right) return startSide.Right;
				if (relativeSidePosition == RelativeSidePosition.Bottom) return startSide.Bottom;
				if (relativeSidePosition == RelativeSidePosition.Top) return startSide.Top;
				if (relativeSidePosition == RelativeSidePosition.Opposite) return startSide.Opposite;
				if (relativeSidePosition == RelativeSidePosition.Self) return startSide;
			}

			return null;
		}

		public static RelativeSidePosition GetRotationNeutralRelativeSidePosition(Side startSide,
			RelativeSidePosition relativeSidePosition, RelativeEdgePosition relativeEdgePosition)
		{
			return GetSideRelation(startSide.CubeSide, GetRotationNeutralRelativeSide(startSide, relativeSidePosition, relativeEdgePosition).CubeSide);
		}

		public static RelativeSidePosition GetSideRelation(Sides startSide, Sides relationSide)
		{
			if (startSide == Sides.Front)
			{
				if (relationSide == Sides.Front)
				{
					return RelativeSidePosition.Self;
				}
				if (relationSide == Sides.Back)
				{
					return RelativeSidePosition.Opposite;
				}
				if (relationSide == Sides.Left)
				{
					return RelativeSidePosition.Left;
				}
				if (relationSide == Sides.Right)
				{
					return RelativeSidePosition.Right;
				}
				if (relationSide == Sides.Top)
				{
					return RelativeSidePosition.Top;
				}
				if (relationSide == Sides.Bottom)
				{
					return RelativeSidePosition.Bottom;
				}
			}

			if (startSide == Sides.Left)
			{
				if (relationSide == Sides.Front)
				{
					return RelativeSidePosition.Right;
				}
				if (relationSide == Sides.Back)
				{
					return RelativeSidePosition.Left;
				}
				if (relationSide == Sides.Left)
				{
					return RelativeSidePosition.Self;
				}
				if (relationSide == Sides.Right)
				{
					return RelativeSidePosition.Opposite;
				}
				if (relationSide == Sides.Top)
				{
					return RelativeSidePosition.Top;
				}
				if (relationSide == Sides.Bottom)
				{
					return RelativeSidePosition.Bottom;
				}
			}

			if (startSide == Sides.Right)
			{
				if (relationSide == Sides.Front)
				{
					return RelativeSidePosition.Left;
				}
				if (relationSide == Sides.Back)
				{
					return RelativeSidePosition.Right;
				}
				if (relationSide == Sides.Left)
				{
					return RelativeSidePosition.Opposite;
				}
				if (relationSide == Sides.Right)
				{
					return RelativeSidePosition.Self;
				}
				if (relationSide == Sides.Top)
				{
					return RelativeSidePosition.Top;
				}
				if (relationSide == Sides.Bottom)
				{
					return RelativeSidePosition.Bottom;
				}
			}

			if (startSide == Sides.Back)
			{
				if (relationSide == Sides.Front)
				{
					return RelativeSidePosition.Opposite;
				}
				if (relationSide == Sides.Back)
				{
					return RelativeSidePosition.Self;
				}
				if (relationSide == Sides.Left)
				{
					return RelativeSidePosition.Right;
				}
				if (relationSide == Sides.Right)
				{
					return RelativeSidePosition.Left;
				}
				if (relationSide == Sides.Top)
				{
					return RelativeSidePosition.Top;
				}
				if (relationSide == Sides.Bottom)
				{
					return RelativeSidePosition.Bottom;
				}
			}

			if (startSide == Sides.Top)
			{
				if (relationSide == Sides.Front)
				{
					return RelativeSidePosition.Bottom;
				}
				if (relationSide == Sides.Back)
				{
					return RelativeSidePosition.Top;
				}
				if (relationSide == Sides.Left)
				{
					return RelativeSidePosition.Left;
				}
				if (relationSide == Sides.Right)
				{
					return RelativeSidePosition.Right;
				}
				if (relationSide == Sides.Top)
				{
					return RelativeSidePosition.Self;
				}
				if (relationSide == Sides.Bottom)
				{
					return RelativeSidePosition.Opposite;
				}
			}

			if (startSide == Sides.Bottom)
			{
				if (relationSide == Sides.Front)
				{
					return RelativeSidePosition.Top;
				}
				if (relationSide == Sides.Back)
				{
					return RelativeSidePosition.Bottom;
				}
				if (relationSide == Sides.Left)
				{
					return RelativeSidePosition.Left;
				}
				if (relationSide == Sides.Right)
				{
					return RelativeSidePosition.Right;
				}
				if (relationSide == Sides.Top)
				{
					return RelativeSidePosition.Opposite;
				}
				if (relationSide == Sides.Bottom)
				{
					return RelativeSidePosition.Self;
				}
			}

			return RelativeSidePosition.NotExisting;	//default to satisfy the compiler, should never occur
		}

		public static Sides GetRelativeSide(Sides startSide, RelativeSidePosition relativeSide)
		{
			Debug.Assert(relativeSide != RelativeSidePosition.NotExisting);

			if (startSide == Sides.Front)
			{
				if (relativeSide == RelativeSidePosition.Self) return Sides.Front;
				if (relativeSide == RelativeSidePosition.Opposite) return Sides.Back;
				if (relativeSide == RelativeSidePosition.Left) return Sides.Left;
				if (relativeSide == RelativeSidePosition.Right) return Sides.Right;
				if (relativeSide == RelativeSidePosition.Top) return Sides.Top;
				if (relativeSide == RelativeSidePosition.Bottom) return Sides.Bottom;
			}
			if (startSide == Sides.Back)
			{
				if (relativeSide == RelativeSidePosition.Self) return Sides.Back;
				if (relativeSide == RelativeSidePosition.Opposite) return Sides.Front;
				if (relativeSide == RelativeSidePosition.Left) return Sides.Right;
				if (relativeSide == RelativeSidePosition.Right) return Sides.Left;
				if (relativeSide == RelativeSidePosition.Top) return Sides.Top;
				if (relativeSide == RelativeSidePosition.Bottom) return Sides.Bottom;
			}
			if (startSide == Sides.Left)
			{
				if (relativeSide == RelativeSidePosition.Self) return Sides.Left;
				if (relativeSide == RelativeSidePosition.Opposite) return Sides.Right;
				if (relativeSide == RelativeSidePosition.Left) return Sides.Back;
				if (relativeSide == RelativeSidePosition.Right) return Sides.Front;
				if (relativeSide == RelativeSidePosition.Top) return Sides.Top;
				if (relativeSide == RelativeSidePosition.Bottom) return Sides.Bottom;
			}
			if (startSide == Sides.Right)
			{
				if (relativeSide == RelativeSidePosition.Self) return Sides.Right;
				if (relativeSide == RelativeSidePosition.Opposite) return Sides.Left;
				if (relativeSide == RelativeSidePosition.Left) return Sides.Front;
				if (relativeSide == RelativeSidePosition.Right) return Sides.Back;
				if (relativeSide == RelativeSidePosition.Top) return Sides.Top;
				if (relativeSide == RelativeSidePosition.Bottom) return Sides.Bottom;
			}
			if (startSide == Sides.Top)
			{
				if (relativeSide == RelativeSidePosition.Self) return Sides.Top;
				if (relativeSide == RelativeSidePosition.Opposite) return Sides.Bottom;
				if (relativeSide == RelativeSidePosition.Left) return Sides.Left;
				if (relativeSide == RelativeSidePosition.Right) return Sides.Right;
				if (relativeSide == RelativeSidePosition.Top) return Sides.Back;
				if (relativeSide == RelativeSidePosition.Bottom) return Sides.Front;
			}
			if (startSide == Sides.Bottom)
			{
				if (relativeSide == RelativeSidePosition.Self) return Sides.Bottom;
				if (relativeSide == RelativeSidePosition.Opposite) return Sides.Top;
				if (relativeSide == RelativeSidePosition.Left) return Sides.Left;
				if (relativeSide == RelativeSidePosition.Right) return Sides.Right;
				if (relativeSide == RelativeSidePosition.Top) return Sides.Front;
				if (relativeSide == RelativeSidePosition.Bottom) return Sides.Back;
			}
			return startSide;	//default value to satisfy the compiler, should never be used
		}

		public static RelativeEdgePosition GetRelativeEdge(RelativeEdgePosition startEdge, RelativeEdgePosition relativeEdge)
		{
			if (relativeEdge == RelativeEdgePosition.Bottom) return startEdge;
			if (relativeEdge == RelativeEdgePosition.Left)
			{
				if (startEdge == RelativeEdgePosition.Bottom) return RelativeEdgePosition.Left;
				if (startEdge == RelativeEdgePosition.Left) return RelativeEdgePosition.Top;
				if (startEdge == RelativeEdgePosition.Top) return RelativeEdgePosition.Right;
				if (startEdge == RelativeEdgePosition.Right) return RelativeEdgePosition.Bottom;
			}
			if (relativeEdge == RelativeEdgePosition.Top)
			{
				if (startEdge == RelativeEdgePosition.Bottom) return RelativeEdgePosition.Top;
				if (startEdge == RelativeEdgePosition.Left) return RelativeEdgePosition.Right;
				if (startEdge == RelativeEdgePosition.Top) return RelativeEdgePosition.Bottom;
				if (startEdge == RelativeEdgePosition.Right) return RelativeEdgePosition.Left;
			}
			if (relativeEdge == RelativeEdgePosition.Right)
			{
				if (startEdge == RelativeEdgePosition.Bottom) return RelativeEdgePosition.Right;
				if (startEdge == RelativeEdgePosition.Left) return RelativeEdgePosition.Bottom;
				if (startEdge == RelativeEdgePosition.Top) return RelativeEdgePosition.Left;
				if (startEdge == RelativeEdgePosition.Right) return RelativeEdgePosition.Top;
			}

			return RelativeEdgePosition.NotExisting;
		}
	}
}
