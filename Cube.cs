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

		}

		public void RotateBackCCW()
		{

		}

		public void RotateLeftCW()
		{

		}

		public void RotateLeftCCW()
		{

		}

		public void RotateRightCW()
		{

		}

		public void RotateRightCCW()
		{

		}

		public void RotateTopCW()
		{

		}

		public void RotateTopCCW()
		{

		}

		public void RotateBottomCW()
		{

		}

		public void RotateBottomCCW()
		{

		}
	}
}
