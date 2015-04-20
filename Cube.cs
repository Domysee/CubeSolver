﻿using System;
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
			var tempRow = top.GetRow(3);
			top.SetRow(3, left.GetColumn(1));
			left.SetColumn(1, bottom.GetRow(1));
			bottom.SetRow(1, right.GetColumn(3));
			right.SetColumn(3, tempRow);
			front.RotateCW();
		}

		/// <summary>
		/// Fi
		/// </summary>
		public void RotateFrontCCW()
		{
			var tempRow = top.GetRow(3);
			top.SetRow(3, right.GetColumn(1));
			right.SetColumn(1, bottom.GetRow(1));
			bottom.SetRow(1, left.GetColumn(3));
			left.SetColumn(3, tempRow);
			front.RotateCCW();
		}

		/// <summary>
		/// B
		/// </summary>
		public void RotateBackCW()
		{
			var tempRow = top.GetRow(1);
			top.SetRow(1, right.GetColumn(3));
			right.SetColumn(3, bottom.GetRow(3));
			bottom.SetRow(3, left.GetColumn(1));
			left.SetColumn(1, tempRow);
			back.RotateCW();
		}

		/// <summary>
		/// Bi
		/// </summary>
		public void RotateBackCCW()
		{
			var tempRow = top.GetRow(1);
			top.SetRow(1, left.GetColumn(1));
			left.SetColumn(1, bottom.GetRow(3));
			bottom.SetRow(3, right.GetColumn(3));
			right.SetColumn(3, tempRow);
			back.RotateCCW();
		}

		/// <summary>
		/// L
		/// </summary>
		public void RotateLeftCW()
		{
			var tempColumn = top.GetColumn(1);
			top.SetColumn(1, back.GetColumn(1));
			back.SetColumn(1, bottom.GetColumn(1));
			bottom.SetColumn(1, front.GetColumn(1));
			front.SetColumn(1, tempColumn);
			left.RotateCW();
		}

		/// <summary>
		/// Li
		/// </summary>
		public void RotateLeftCCW()
		{
			var tempColumn = top.GetColumn(1);
			top.SetColumn(1, front.GetColumn(1));
			front.SetColumn(1, bottom.GetColumn(1));
			bottom.SetColumn(1, back.GetColumn(1));
			back.SetColumn(1, tempColumn);
			left.RotateCCW();
		}

		/// <summary>
		/// R
		/// </summary>
		public void RotateRightCW()
		{
			var tempColumn = top.GetColumn(3);
			top.SetColumn(3, front.GetColumn(3));
			front.SetColumn(3, bottom.GetColumn(3));
			bottom.SetColumn(3, back.GetColumn(3));
			back.SetColumn(3, tempColumn);
			right.RotateCW();
		}

		/// <summary>
		/// Ri
		/// </summary>
		public void RotateRightCCW()
		{
			var tempColumn = top.GetColumn(3);
			top.SetColumn(3, back.GetColumn(3));
			back.SetColumn(3, bottom.GetColumn(3));
			bottom.SetColumn(3, front.GetColumn(3));
			front.SetColumn(3, tempColumn);
			right.RotateCCW();
		}

		/// <summary>
		/// U
		/// </summary>
		public void RotateTopCW()
		{
			var tempRow = front.GetRow(1);
			front.SetRow(1, right.GetRow(1));
			right.SetRow(1, back.GetRow(3));
			back.SetRow(3, left.GetRow(1));
			left.SetRow(1, tempRow);
			top.RotateCW();
		}

		/// <summary>
		/// Ui
		/// </summary>
		public void RotateTopCCW()
		{
			var tempRow = front.GetRow(1);
			front.SetRow(1, left.GetRow(1));
			left.SetRow(1, back.GetRow(3));
			back.SetRow(3, right.GetRow(1));
			right.SetRow(1, tempRow);
			top.RotateCW();
		}

		/// <summary>
		/// D
		/// </summary>
		public void RotateBottomCW()
		{
			var tempRow = front.GetRow(3);
			front.SetRow(3, left.GetRow(3));
			left.SetRow(3, back.GetRow(1));
			back.SetRow(1, right.GetRow(3));
			right.SetRow(3, tempRow);
			bottom.RotateCW();
		}

		/// <summary>
		/// Di
		/// </summary>
		public void RotateBottomCCW()
		{
			var tempRow = front.GetRow(3);
			front.SetRow(3, right.GetRow(3));
			right.SetRow(3, back.GetRow(1));
			back.SetRow(1, left.GetRow(3));
			left.SetRow(3, tempRow);
			bottom.RotateCCW();
		}
	}
}
