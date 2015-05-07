using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RubiksCubeSolver
{
	public class Cube
	{
		#region Sides
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

		public Side[] CubeSides
		{
			get { return new Side[] { front, back, left, right, top, bottom }; }
		}
		#endregion

		#region Events
		public event EventHandler BeforeLeftCWRotation;
		public event EventHandler BeforeLeftCCWRotation;
		public event EventHandler BeforeRightCWRotation;
		public event EventHandler BeforeRightCCWRotation;
		public event EventHandler BeforeFrontCWRotation;
		public event EventHandler BeforeFrontCCWRotation;
		public event EventHandler BeforeBackCWRotation;
		public event EventHandler BeforeBackCCWRotation;
		public event EventHandler BeforeTopCWRotation;
		public event EventHandler BeforeTopCCWRotation;
		public event EventHandler BeforeBottomCWRotation;
		public event EventHandler BeforeBottomCCWRotation;

		private void raiseBeforeLeftCWRotation()
		{
			if (BeforeLeftCWRotation != null) BeforeLeftCWRotation(this, new EventArgs());
		}
		private void raiseBeforeLeftCCWRotation()
		{
			if (BeforeLeftCCWRotation != null) BeforeLeftCCWRotation(this, new EventArgs());
		}
		private void raiseBeforeRightCWRotation()
		{
			if (BeforeRightCWRotation != null) BeforeRightCWRotation(this, new EventArgs());
		}
		private void raiseBeforeRightCCWRotation()
		{
			if (BeforeRightCCWRotation != null) BeforeRightCCWRotation(this, new EventArgs());
		}
		private void raiseBeforeFrontCWRotation()
		{
			if (BeforeFrontCWRotation != null) BeforeFrontCWRotation(this, new EventArgs());
		}
		private void raiseBeforeFrontCCWRotation()
		{
			if (BeforeFrontCCWRotation != null) BeforeFrontCCWRotation(this, new EventArgs());
		}
		private void raiseBeforeBackCWRotation()
		{
			if (BeforeBackCWRotation != null) BeforeBackCWRotation(this, new EventArgs());
		}
		private void raiseBeforeBackCCWRotation()
		{
			if (BeforeBackCCWRotation != null) BeforeBackCCWRotation(this, new EventArgs());
		}
		private void raiseBeforeTopCWRotation()
		{
			if (BeforeTopCWRotation != null) BeforeTopCWRotation(this, new EventArgs());
		}
		private void raiseBeforeTopCCWRotation()
		{
			if (BeforeTopCCWRotation != null) BeforeTopCCWRotation(this, new EventArgs());
		}
		private void raiseBeforeBottomCWRotation()
		{
			if (BeforeBottomCWRotation != null) BeforeBottomCWRotation(this, new EventArgs());
		}
		private void raiseBeforeBottomCCWRotation()
		{
			if (BeforeBottomCCWRotation != null) BeforeBottomCCWRotation(this, new EventArgs());
		}
		#endregion

		public Cube()
		{
			front = new Side(Brushes.Blue, Sides.Front);
			back = new Side(Brushes.Green, Sides.Back);
			left = new Side(Brushes.Red, Sides.Left);
			right = new Side(Brushes.Orange, Sides.Right);
			top = new Side(Brushes.White, Sides.Top);
			bottom = new Side(Brushes.Yellow, Sides.Bottom);

			front.Left = GetSideFromEnum(Helper.GetRelativeSide(Sides.Front, RelativeSidePosition.Left));
			front.Right = GetSideFromEnum(Helper.GetRelativeSide(Sides.Front, RelativeSidePosition.Right));
			front.Top = GetSideFromEnum(Helper.GetRelativeSide(Sides.Front, RelativeSidePosition.Top));
			front.Bottom = GetSideFromEnum(Helper.GetRelativeSide(Sides.Front, RelativeSidePosition.Bottom));
			front.Opposite = GetSideFromEnum(Helper.GetRelativeSide(Sides.Front, RelativeSidePosition.Opposite));

			back.Left = GetSideFromEnum(Helper.GetRelativeSide(Sides.Back, RelativeSidePosition.Left));
			back.Right = GetSideFromEnum(Helper.GetRelativeSide(Sides.Back, RelativeSidePosition.Right));
			back.Top = GetSideFromEnum(Helper.GetRelativeSide(Sides.Back, RelativeSidePosition.Top));
			back.Bottom = GetSideFromEnum(Helper.GetRelativeSide(Sides.Back, RelativeSidePosition.Bottom));
			back.Opposite = GetSideFromEnum(Helper.GetRelativeSide(Sides.Back, RelativeSidePosition.Opposite));

			left.Left = GetSideFromEnum(Helper.GetRelativeSide(Sides.Left, RelativeSidePosition.Left));
			left.Right = GetSideFromEnum(Helper.GetRelativeSide(Sides.Left, RelativeSidePosition.Right));
			left.Top = GetSideFromEnum(Helper.GetRelativeSide(Sides.Left, RelativeSidePosition.Top));
			left.Bottom = GetSideFromEnum(Helper.GetRelativeSide(Sides.Left, RelativeSidePosition.Bottom));
			left.Opposite = GetSideFromEnum(Helper.GetRelativeSide(Sides.Left, RelativeSidePosition.Opposite));

			right.Left = GetSideFromEnum(Helper.GetRelativeSide(Sides.Right, RelativeSidePosition.Left));
			right.Right = GetSideFromEnum(Helper.GetRelativeSide(Sides.Right, RelativeSidePosition.Right));
			right.Top = GetSideFromEnum(Helper.GetRelativeSide(Sides.Right, RelativeSidePosition.Top));
			right.Bottom = GetSideFromEnum(Helper.GetRelativeSide(Sides.Right, RelativeSidePosition.Bottom));
			right.Opposite = GetSideFromEnum(Helper.GetRelativeSide(Sides.Right, RelativeSidePosition.Opposite));

			top.Left = GetSideFromEnum(Helper.GetRelativeSide(Sides.Top, RelativeSidePosition.Left));
			top.Right = GetSideFromEnum(Helper.GetRelativeSide(Sides.Top, RelativeSidePosition.Right));
			top.Top = GetSideFromEnum(Helper.GetRelativeSide(Sides.Top, RelativeSidePosition.Top));
			top.Bottom = GetSideFromEnum(Helper.GetRelativeSide(Sides.Top, RelativeSidePosition.Bottom));
			top.Opposite = GetSideFromEnum(Helper.GetRelativeSide(Sides.Top, RelativeSidePosition.Opposite));

			bottom.Left = GetSideFromEnum(Helper.GetRelativeSide(Sides.Bottom, RelativeSidePosition.Left));
			bottom.Right = GetSideFromEnum(Helper.GetRelativeSide(Sides.Bottom, RelativeSidePosition.Right));
			bottom.Top = GetSideFromEnum(Helper.GetRelativeSide(Sides.Bottom, RelativeSidePosition.Top));
			bottom.Bottom = GetSideFromEnum(Helper.GetRelativeSide(Sides.Bottom, RelativeSidePosition.Bottom));
			bottom.Opposite = GetSideFromEnum(Helper.GetRelativeSide(Sides.Bottom, RelativeSidePosition.Opposite));
		}

		#region Rotations
		/// <summary>
		/// for the turns, the sides are rotated to the front
		/// the y-axis points upwards, the x-axis to the right and the z-axis backwards
		/// for the left side, the cube is turned 90 degrees counterclockwise around the y-axis
		/// for the right side, the cube is turned 90 degrees clockwise around the y-axis
		/// for the top side, the cube is turned 90 degrees counterclockwise around the x-axis
		/// for the bottom side, the cube is turned 90 degrees clockwise around the x-axis
		/// for the back side, the cube is turned 180 degrees around the y-axis
		/// 
		/// the notations in the method are marked according to this page: 
		/// https://rubiks.com/uploads/general_content/Rubiks_cube_3x3_solution-en.pdf
		/// 
		/// the rotations need to run in separate threads, because otherwise they would run in the UI thread
		/// but because the events have to await until the storyboard finished, the rotation method's execution continues 
		/// so basically there is no way to wait until the rotation is finished in the UI for the rest of the methods to continue
		/// therefore they have to run in a second thread, so that the event also runs in a second thread
		/// the event handler can then synchronously wait for a task executed with the dispatcher to finish
		/// </summary>


		/// <summary>
		/// F
		/// </summary>
		public void RotateFrontCW()
		{
			raiseBeforeFrontCWRotation();
			var tempRow = top.GetRow(2);
			top.SetRow(2, left.GetColumn(2).Reverse().ToArray());
			left.SetColumn(2, bottom.GetRow(0));
			bottom.SetRow(0, right.GetColumn(0).Reverse().ToArray());
			right.SetColumn(0, tempRow);
			front.RotateCW();
		}

		/// <summary>
		/// Fi
		/// </summary>
		public void RotateFrontCCW()
		{
			raiseBeforeFrontCCWRotation();
			var tempRow = top.GetRow(2);
			top.SetRow(2, right.GetColumn(0));
			right.SetColumn(0, bottom.GetRow(0).Reverse().ToArray());
			bottom.SetRow(0, left.GetColumn(2));
			left.SetColumn(2, tempRow.Reverse().ToArray());
			front.RotateCCW();
		}

		/// <summary>
		/// B
		/// </summary>
		public async Task RotateBackCWAsync()
		{
			await Task.Run(() =>
			{
				raiseBeforeBackCWRotation();
				var tempRow = top.GetRow(0);
				top.SetRow(0, right.GetColumn(2));
				right.SetColumn(2, bottom.GetRow(2).Reverse().ToArray());
				bottom.SetRow(2, left.GetColumn(0));
				left.SetColumn(0, tempRow.Reverse().ToArray());
				back.RotateCW();
			});
		}

		/// <summary>
		/// Bi
		/// </summary>
		public void RotateBackCCW()
		{
			raiseBeforeBackCCWRotation();
			var tempRow = top.GetRow(0);
			top.SetRow(0, left.GetColumn(0).Reverse().ToArray());
			left.SetColumn(0, bottom.GetRow(2));
			bottom.SetRow(2, right.GetColumn(2).Reverse().ToArray());
			right.SetColumn(2, tempRow);
			back.RotateCCW();
		}

		/// <summary>
		/// L
		/// </summary>
		public void RotateLeftCW()
		{
			raiseBeforeLeftCWRotation();
			var tempColumn = top.GetColumn(0);
			top.SetColumn(0, back.GetColumn(2).Reverse().ToArray());
			back.SetColumn(2, bottom.GetColumn(0).Reverse().ToArray());
			bottom.SetColumn(0, front.GetColumn(0));
			front.SetColumn(0, tempColumn);
			left.RotateCW();
		}

		/// <summary>
		/// Li
		/// </summary>
		public void RotateLeftCCW()
		{
			raiseBeforeLeftCCWRotation();
			var tempColumn = top.GetColumn(0);
			top.SetColumn(0, front.GetColumn(0));
			front.SetColumn(0, bottom.GetColumn(0));
			bottom.SetColumn(0, back.GetColumn(2).Reverse().ToArray());
			back.SetColumn(2, tempColumn.Reverse().ToArray());
			left.RotateCCW();
		}

		/// <summary>
		/// R
		/// </summary>
		public void RotateRightCW()
		{
			raiseBeforeRightCWRotation();
			var tempColumn = top.GetColumn(2);
			top.SetColumn(2, front.GetColumn(2));
			front.SetColumn(2, bottom.GetColumn(2));
			bottom.SetColumn(2, back.GetColumn(0).Reverse().ToArray());
			back.SetColumn(0, tempColumn.Reverse().ToArray());
			right.RotateCW();
		}

		/// <summary>
		/// Ri
		/// </summary>
		public void RotateRightCCW()
		{
			raiseBeforeRightCCWRotation();
			var tempColumn = top.GetColumn(2);
			top.SetColumn(2, back.GetColumn(0).Reverse().ToArray());
			back.SetColumn(0, bottom.GetColumn(2).Reverse().ToArray());
			bottom.SetColumn(2, front.GetColumn(2));
			front.SetColumn(2, tempColumn);
			right.RotateCCW();
		}

		/// <summary>
		/// U
		/// </summary>
		public void RotateTopCW()
		{
			raiseBeforeTopCWRotation();
			var tempRow = front.GetRow(0);
			front.SetRow(0, right.GetRow(0));
			right.SetRow(0, back.GetRow(0));
			back.SetRow(0, left.GetRow(0));
			left.SetRow(0, tempRow);
			top.RotateCW();
		}

		/// <summary>
		/// Ui
		/// </summary>
		public void RotateTopCCW()
		{
			raiseBeforeTopCCWRotation();
			var tempRow = front.GetRow(0);
			front.SetRow(0, left.GetRow(0));
			left.SetRow(0, back.GetRow(0));
			back.SetRow(0, right.GetRow(0));
			right.SetRow(0, tempRow);
			top.RotateCCW();
		}

		/// <summary>
		/// D
		/// </summary>
		public void RotateBottomCW()
		{
			raiseBeforeBottomCWRotation();
			var tempRow = front.GetRow(2);
			front.SetRow(2, left.GetRow(2));
			left.SetRow(2, back.GetRow(2));
			back.SetRow(2, right.GetRow(2));
			right.SetRow(2, tempRow);
			bottom.RotateCW();
		}

		/// <summary>
		/// Di
		/// </summary>
		public void RotateBottomCCW()
		{
			raiseBeforeBottomCCWRotation();
			var tempRow = front.GetRow(2);
			front.SetRow(2, right.GetRow(2));
			right.SetRow(2, back.GetRow(2));
			back.SetRow(2, left.GetRow(2));
			left.SetRow(2, tempRow);
			bottom.RotateCCW();
		}

		public void RotateSideCW(Sides side)
		{
			if (side == Sides.Back)
				RotateBackCWAsync();
			if (side == Sides.Front)
				RotateFrontCW();
			if (side == Sides.Left)
				RotateLeftCW();
			if (side == Sides.Right)
				RotateRightCW();
			if (side == Sides.Top)
				RotateTopCW();
			if (side == Sides.Bottom)
				RotateBottomCW();
		}

		public void RotateSideCCW(Sides side)
		{
			if (side == Sides.Back)
				RotateBackCCW();
			if (side == Sides.Front)
				RotateFrontCCW();
			if (side == Sides.Left)
				RotateLeftCCW();
			if (side == Sides.Right)
				RotateRightCCW();
			if (side == Sides.Top)
				RotateTopCCW();
			if (side == Sides.Bottom)
				RotateBottomCCW();
		}
		#endregion

		/// <summary>
		/// finds the position of that edge
		/// </summary>
		/// <param name="startSide"></param>
		/// <param name="primaryColor">determines to which of the 2 adjacent sides the resulting position is relative to</param>
		/// <param name="secondaryColor"></param>
		/// <param name="relativeSidePosition">contains the relative side to the startSide</param>
		/// <param name="relativeEdgePosition">contains the edge relative to the relative side</param>
		public void GetRelativeEdgePosition(Sides startSide, Brush primaryColor, Brush secondaryColor,
			out RelativeSidePosition relativeSidePosition, out RelativeEdgePosition relativeEdgePosition)
		{
			//default to satisfy the compiler, should never occur
			relativeSidePosition = RelativeSidePosition.NotExisting;
			relativeEdgePosition = RelativeEdgePosition.NotExisting;

			foreach (var side in CubeSides)
			{
				var relativePosition = side.GetRelativeEdgePosition(primaryColor, secondaryColor);
				if (relativePosition != RelativeEdgePosition.NotExisting)
				{
					relativeEdgePosition = relativePosition;
					relativeSidePosition = Helper.GetSideRelation(startSide, side.CubeSide);
					//normally, to create a real relative position of the edge, here would be a need for special handling of sides and relative sides combinations
					//but this would introduce a lot of special handling in other places too, which is unnecessary
					//therefore, the relativeEdgePosition is relative to the side
					//e.g. in a solved cube: when back (green) is the startside, the edge (primary white, secondary blue) is the top side relative to back
					//because the edge is relative to the top side, the resulting relative edge position is bottom
					//the view of the relative edge position is as if the cube is not turned 
					break;	//after the position is found, there cannot be another one
				}
			}
		}

		public Side GetSideFromEnum(Sides side)
		{
			switch (side)
			{
				case Sides.Front:
					return front;
				case Sides.Back:
					return back;
				case Sides.Left:
					return left;
				case Sides.Right:
					return right;
				case Sides.Top:
					return top;
				case Sides.Bottom:
					return bottom;
			}
			return null;
		}

		#region Solve States
		public bool IsTopCrossSolved()
		{
			//check if the top cross is all white
			if (top.Fields[0, 1] != top.Color || top.Fields[1, 0] != top.Color || top.Fields[1, 2] != top.Color || top.Fields[2, 1] != top.Color) return false;

			//check if the cross edges are in the correct position
			if (top.Left.Fields[0, 1] != top.Left.Color) return false;
			if (top.Top.Fields[0, 1] != top.Top.Color) return false;
			if (top.Right.Fields[0, 1] != top.Right.Color) return false;
			if (top.Bottom.Fields[0, 1] != top.Bottom.Color) return false;

			return true;
		}
		#endregion
	}
}
