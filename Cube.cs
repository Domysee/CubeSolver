using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RubiksCubeSolver
{
	public class Cube
	{
		private Side front;
		public Side Front
		{
			get { return front; }
			set { front = value; }
		}
		private Side back;
		public Side Back
		{
			get { return back; }
			set { back = value; }
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

		public Cube()
		{
			front = new Side(Brushes.Blue);
			back = new Side(Brushes.Green);
			left = new Side(Brushes.Red);
			right = new Side(Brushes.Orange);
			top = new Side(Brushes.White);
			bottom = new Side(Brushes.Yellow);
		}

		/// <summary>
		/// for the turns, the sides are rotated to the front
		/// the y-axis points upwards, the x-axis to the right and the z-axis backwards
		/// for the left side, the cube is turned 90 degrees counterclockwise around the y-axis
		/// for the right side, the cube is turned 90 degrees clockwise around the y-axis
		/// for the top side, the cube is turned 90 degrees counterclockwise around the x-axis
		/// for the bottom side, the cube is turned 90 degrees clockwise around the x-axis
		/// for the back side, the cube is turned 180 degrees around the x-axis
		/// 
		/// the notations in the method are marked according to this page: 
		/// https://rubiks.com/uploads/general_content/Rubiks_cube_3x3_solution-en.pdf
		/// </summary>


		/// <summary>
		/// F
		/// </summary>
		public void RotateFrontCW() 
		{
			var tempRow = top.GetRow(2);
			top.SetRow(2, left.GetColumn(2));
			left.SetColumn(2, bottom.GetRow(0));
			bottom.SetRow(0, right.GetColumn(0));
			right.SetColumn(0, tempRow);
			front.RotateCW();
		}

		/// <summary>
		/// Fi
		/// </summary>
		public void RotateFrontCCW()
		{
			var tempRow = top.GetRow(2);
			top.SetRow(2, right.GetColumn(0));
			right.SetColumn(0, bottom.GetRow(0));
			bottom.SetRow(0, left.GetColumn(2));
			left.SetColumn(2, tempRow);
			front.RotateCCW();
		}

		/// <summary>
		/// B
		/// </summary>
		public void RotateBackCW()
		{
			var tempRow = top.GetRow(0);
			top.SetRow(0, right.GetColumn(2));
			right.SetColumn(2, bottom.GetRow(2));
			bottom.SetRow(2, left.GetColumn(0));
			left.SetColumn(0, tempRow);
			back.RotateCW();
		}

		/// <summary>
		/// Bi
		/// </summary>
		public void RotateBackCCW()
		{
			var tempRow = top.GetRow(0);
			top.SetRow(0, left.GetColumn(0));
			left.SetColumn(0, bottom.GetRow(2));
			bottom.SetRow(2, right.GetColumn(2));
			right.SetColumn(2, tempRow);
			back.RotateCCW();
		}

		/// <summary>
		/// L
		/// </summary>
		public void RotateLeftCW()
		{
			var tempColumn = top.GetColumn(0);
			top.SetColumn(0, back.GetColumn(0));
			back.SetColumn(0, bottom.GetColumn(0));
			bottom.SetColumn(0, front.GetColumn(0));
			front.SetColumn(0, tempColumn);
			left.RotateCW();
		}

		/// <summary>
		/// Li
		/// </summary>
		public void RotateLeftCCW()
		{
			var tempColumn = top.GetColumn(0);
			top.SetColumn(0, front.GetColumn(0));
			front.SetColumn(0, bottom.GetColumn(0));
			bottom.SetColumn(0, back.GetColumn(0));
			back.SetColumn(0, tempColumn);
			left.RotateCCW();
		}

		/// <summary>
		/// R
		/// </summary>
		public void RotateRightCW()
		{
			var tempColumn = top.GetColumn(2);
			top.SetColumn(2, front.GetColumn(2));
			front.SetColumn(2, bottom.GetColumn(2));
			bottom.SetColumn(2, back.GetColumn(2));
			back.SetColumn(2, tempColumn);
			right.RotateCW();
		}

		/// <summary>
		/// Ri
		/// </summary>
		public void RotateRightCCW()
		{
			var tempColumn = top.GetColumn(2);
			top.SetColumn(2, back.GetColumn(2));
			back.SetColumn(2, bottom.GetColumn(2));
			bottom.SetColumn(2, front.GetColumn(2));
			front.SetColumn(2, tempColumn);
			right.RotateCCW();
		}

		/// <summary>
		/// U
		/// </summary>
		public void RotateTopCW()
		{
			var tempRow = front.GetRow(0);
			front.SetRow(0, right.GetRow(0));
			right.SetRow(0, back.GetRow(2));
			back.SetRow(2, left.GetRow(0));
			left.SetRow(0, tempRow);
			top.RotateCW();
		}

		/// <summary>
		/// Ui
		/// </summary>
		public void RotateTopCCW()
		{
			var tempRow = front.GetRow(0);
			front.SetRow(0, left.GetRow(0));
			left.SetRow(0, back.GetRow(2));
			back.SetRow(2, right.GetRow(0));
			right.SetRow(0, tempRow);
			top.RotateCW();
		}

		/// <summary>
		/// D
		/// </summary>
		public void RotateBottomCW()
		{
			var tempRow = front.GetRow(2);
			front.SetRow(2, left.GetRow(2));
			left.SetRow(2, back.GetRow(0));
			back.SetRow(0, right.GetRow(2));
			right.SetRow(2, tempRow);
			bottom.RotateCW();
		}

		/// <summary>
		/// Di
		/// </summary>
		public void RotateBottomCCW()
		{
			var tempRow = front.GetRow(2);
			front.SetRow(2, right.GetRow(2));
			right.SetRow(2, back.GetRow(0));
			back.SetRow(0, left.GetRow(2));
			left.SetRow(2, tempRow);
			bottom.RotateCCW();
		}
	}
}
