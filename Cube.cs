using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			front = new Side(Color.Blue);
			back = new Side(Color.Green);
			left = new Side(Color.Red);
			right = new Side(Color.Orange);
			top = new Side(Color.White);
			bottom = new Side(Color.Yellow);
		}

		public void RotateFrontCW()
		{
			var tempRow = top.GetRow(3);
			top.SetRow(3, left.GetColumn(1));
			left.SetColumn(1, bottom.GetRow(1));
			bottom.SetRow(1, right.GetColumn(3));
			right.SetColumn(3, tempRow);
			front.RotateCW();
		}

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
		/// acts as the cube was turned 180 degree around the y axis (pointing upwards)
		/// then the back is the front, clockwise rotation is treated the same as it were the front
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

		public void RotateBackCCW()
		{
			var tempRow = top.GetRow(1);
			top.SetRow(1, left.GetColumn(1));
			left.SetColumn(1, bottom.GetRow(3));
			bottom.SetRow(3, right.GetColumn(3));
			right.SetColumn(3, tempRow);
			back.RotateCCW();
		}

		public void RotateLeftCW()
		{
			var tempColumn = top.GetColumn(1);
			top.SetColumn(1, back.GetColumn(1));
			back.SetColumn(1, bottom.GetColumn(1));
			bottom.SetColumn(1, front.GetColumn(1));
			front.SetColumn(1, tempColumn);
			left.RotateCW();
		}

		public void RotateLeftCCW()
		{
			var tempColumn = top.GetColumn(1);
			top.SetColumn(1, front.GetColumn(1));
			front.SetColumn(1, bottom.GetColumn(1));
			bottom.SetColumn(1, back.GetColumn(1));
			back.SetColumn(1, tempColumn);
			left.RotateCCW();
		}

		public void RotateRightCW()
		{
			var tempColumn = top.GetColumn(3);
			top.SetColumn(3, front.GetColumn(3));
			front.SetColumn(3, bottom.GetColumn(3));
			bottom.SetColumn(3, back.GetColumn(3));
			back.SetColumn(3, tempColumn);
			right.RotateCW();
		}

		public void RotateRightCCW()
		{
			var tempColumn = top.GetColumn(3);
			top.SetColumn(3, back.GetColumn(3));
			back.SetColumn(3, bottom.GetColumn(3));
			bottom.SetColumn(3, front.GetColumn(3));
			front.SetColumn(3, tempColumn);
			right.RotateCCW();
		}

		public void RotateTopCW()
		{
			var tempRow = front.GetRow(1);
			front.SetRow(1, right.GetRow(1));
			right.SetRow(1, back.GetRow(3));
			back.SetRow(3, left.GetRow(1));
			left.SetRow(1, tempRow);
			top.RotateCW();
		}

		public void RotateTopCCW()
		{
			var tempRow = front.GetRow(1);
			front.SetRow(1, left.GetRow(1));
			left.SetRow(1, back.GetRow(3));
			back.SetRow(3, right.GetRow(1));
			right.SetRow(1, tempRow);
			top.RotateCW();
		}

		public void RotateBottomCW()
		{

		}

		public void RotateBottomCCW()
		{

		}
	}
}
