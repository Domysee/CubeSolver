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
			throw new NotImplementedException();
		}
	}
}
