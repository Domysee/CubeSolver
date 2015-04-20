using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver
{
	public class Side
	{
		private const int sideLength = 3;

		/// <summary>
		/// row is the first index, column the second
		/// </summary>
		private Color[,] fields;
		public Color[,] Fields
		{
			get { return fields; }
			set { fields = value; }
		}

		public Side(Color initializationColor)
		{
			fields = new Color[sideLength, sideLength];
			for (int i = 0; i < sideLength; i++)
			{
				for (int j = 0; j < sideLength; j++)
				{
					fields[i, j] = initializationColor;
				}
			}
		}

		public Color[] GetRow(int row)
		{
			Debug.Assert(row >= 0 && row < sideLength);

			var rowColors = new Color[sideLength];
			for (int i = 0; i < sideLength; i++)
			{
				rowColors[i] = fields[row, i];
			}
			return rowColors;
		}

		public Color[] GetColumn(int column)
		{
			Debug.Assert(column >= 0 && column < sideLength);

			var columnColors = new Color[sideLength];
			for (int i = 0; i < sideLength; i++)
			{
				columnColors[i] = fields[i, column];
			}
			return columnColors;
		}

		public void SetRow(int row, Color[] rowColors)
		{
			Debug.Assert(rowColors.Length == sideLength);
			Debug.Assert(row >= 0 && row < sideLength);

			for (int i = 0; i < sideLength; i++)
			{
				fields[row, i] = rowColors[i];
			}
		}

		public void SetColumn(int column, Color[] columnColors)
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
			var newFields = new Color[sideLength, sideLength];

		}

		public void RotateCCW()
		{

		}
	}
}
