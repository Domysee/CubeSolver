using System;
using System.Collections.Generic;
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
	}
}
