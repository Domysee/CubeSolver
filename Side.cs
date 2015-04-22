using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RubiksCubeSolver
{
	public class Side
	{
		private const int sideLength = 3;

		/// <summary>
		/// row is the first index, column the second
		/// </summary>
		private Brush[,] fields;
		public Brush[,] Fields
		{
			get { return fields; }
			set { fields = value; }
		}

		private Sides side;
		public Sides CubeSide
		{
			get { return side; }
		}

		private Side left;

		public Side Left
		{
			get { return left; }
			set { left = value; }
		}
		private Side right;

		public Side Right
		{
			get { return right; }
			set { right = value; }
		}
		private Side top;

		public Side Top
		{
			get { return top; }
			set { top = value; }
		}
		private Side bottom;

		public Side Bottom
		{
			get { return bottom; }
			set { bottom = value; }
		}
		private Side opposite;

		public Side Opposite
		{
			get { return opposite; }
			set { opposite = value; }
		}

		public Side(Brush initializationColor, Sides side)
		{
			fields = new Brush[sideLength, sideLength];
			for (int i = 0; i < sideLength; i++)
			{
				for (int j = 0; j < sideLength; j++)
				{
					fields[i, j] = initializationColor;
				}
			}

			this.side = side;
		}

		public Brush[] GetRow(int row)
		{
			Debug.Assert(row >= 0 && row < sideLength);

			var rowColors = new Brush[sideLength];
			for (int i = 0; i < sideLength; i++)
			{
				rowColors[i] = fields[row, i];
			}
			return rowColors;
		}

		public Brush[] GetColumn(int column)
		{
			Debug.Assert(column >= 0 && column < sideLength);

			var columnColors = new Brush[sideLength];
			for (int i = 0; i < sideLength; i++)
			{
				columnColors[i] = fields[i, column];
			}
			return columnColors;
		}

		public void SetRow(int row, Brush[] rowColors)
		{
			Debug.Assert(rowColors.Length == sideLength);
			Debug.Assert(row >= 0 && row < sideLength);

			for (int i = 0; i < sideLength; i++)
			{
				fields[row, i] = rowColors[i];
			}
		}

		public void SetColumn(int column, Brush[] columnColors)
		{
			Debug.Assert(columnColors.Length == sideLength);
			Debug.Assert(column >= 0 && column < sideLength);

			for (int i = 0; i < sideLength; i++)
			{
				fields[i, column] = columnColors[i];
			}
		}

		public void RotateCW()
		{
			var newFields = new Brush[sideLength, sideLength];
			newFields[0, 0] = fields[2, 0];
			newFields[0, 1] = fields[1, 0];
			newFields[0, 2] = fields[0, 0];
			newFields[1, 0] = fields[2, 1];
			newFields[1, 1] = fields[1, 1];
			newFields[1, 2] = fields[0, 1];
			newFields[2, 0] = fields[2, 2];
			newFields[2, 1] = fields[1, 2];
			newFields[2, 2] = fields[0, 2];
			fields = newFields;
		}

		public void RotateCCW()
		{
			var newFields = new Brush[sideLength, sideLength];
			newFields[0, 0] = fields[0, 2];
			newFields[0, 1] = fields[1, 2];
			newFields[0, 2] = fields[2, 2];
			newFields[1, 0] = fields[0, 1];
			newFields[1, 1] = fields[1, 1];
			newFields[1, 2] = fields[2, 1];
			newFields[2, 0] = fields[0, 0];
			newFields[2, 1] = fields[1, 0];
			newFields[2, 2] = fields[2, 0];
			fields = newFields;
		}

		public RelativeEdgePosition FindEdge(Brush primaryColor, Brush secondaryColor)
		{
			if (fields[1, 0] == primaryColor && GetSecondaryEdgeColor(RelativeEdgePosition.Left) == secondaryColor)
			{
				return RelativeEdgePosition.Left;
			}
			if (fields[0, 1] == primaryColor && GetSecondaryEdgeColor(RelativeEdgePosition.Top) == secondaryColor)
			{
				return RelativeEdgePosition.Top;
			}
			if (fields[1, 2] == primaryColor && GetSecondaryEdgeColor(RelativeEdgePosition.Right) == secondaryColor)
			{
				return RelativeEdgePosition.Right;
			}
			if (fields[2, 1] == primaryColor && GetSecondaryEdgeColor(RelativeEdgePosition.Bottom) == secondaryColor)
			{
				return RelativeEdgePosition.Bottom;
			}

			return RelativeEdgePosition.NotExisting;
		}

		public Brush GetSecondaryEdgeColor(RelativeEdgePosition edgePosition)
		{
			//these 2 (top, bottom) sides are special cases, because they change the column/row alignment with other sides
			if (CubeSide == Sides.Top)
			{
				switch (edgePosition)
				{
					case RelativeEdgePosition.Left:
						return left.GetRow(0)[1];
					case RelativeEdgePosition.Right:
						return right.GetRow(0)[1];
					case RelativeEdgePosition.Top:
						return top.GetRow(0)[1];
					case RelativeEdgePosition.Bottom:
						return bottom.GetRow(0)[1];
				}
			}
			if (CubeSide == Sides.Bottom)
			{
				switch (edgePosition)
				{
					case RelativeEdgePosition.Left:
						return left.GetRow(2)[1];
					case RelativeEdgePosition.Right:
						return right.GetRow(2)[1];
					case RelativeEdgePosition.Top:
						return top.GetRow(2)[1];
					case RelativeEdgePosition.Bottom:
						return bottom.GetRow(2)[1];
				}
			}
			else
			{
				if (edgePosition == RelativeEdgePosition.Left)
				{
					return left.GetColumn(2)[1];
				}
				if (edgePosition == RelativeEdgePosition.Right)
				{
					return right.GetColumn(0)[1];
				}
				if (edgePosition == RelativeEdgePosition.Top)
				{
					//only has to handle the remaining 4 cases (top and bottom are handled before)
					switch (CubeSide)
					{
						case Sides.Front:
							return top.GetRow(2)[1];
						case Sides.Left:
							return top.GetColumn(0)[1];
						case Sides.Back:
							return top.GetRow(0)[1];
						case Sides.Right:
							return top.GetColumn(2)[1];
					}
				}
				if (edgePosition == RelativeEdgePosition.Bottom)
				{
					//only has to handle the remaining 4 cases (top and bottom are handled before)
					switch (CubeSide)
					{
						case Sides.Front:
							return bottom.GetRow(0)[1];
						case Sides.Left:
							return bottom.GetColumn(0)[1];
						case Sides.Back:
							return bottom.GetRow(2)[1];
						case Sides.Right:
							return bottom.GetColumn(2)[1];
					}
				}
			}
			return null;	//default case to satisfy the compiler, should never occur
		}
	}
}
