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
				case RelativeSidePosition.Bottom: return RelativeEdgePosition.Top;
				case RelativeSidePosition.Top: return RelativeEdgePosition.Bottom;
				case RelativeSidePosition.Left: return RelativeEdgePosition.Right;
				case RelativeSidePosition.Right: return RelativeEdgePosition.Left;
				default: return RelativeEdgePosition.NotExisting;
			}
		}
	}
}
