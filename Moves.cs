using RubiksCubeSolver.StartCrossMoves;
using RubiksCubeSolver.StartEdgeMove;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver
{
	public static class Moves
	{
		public static readonly IStartCrossMove[] StartCrossMoves = new IStartCrossMove[] { new StartCrossMove1(), new StartCrossMove2(), new StartCrossMove3(), new StartCrossMove4(), new StartCrossMove5(), new StartCrossMove6(), new StartCrossMove7(), new StartCrossMove8(), new StartCrossMove9(), new StartCrossMove10(), new StartCrossMove11(), new StartCrossMove12(), new StartCrossMove13(), new StartCrossMove14(), new StartCrossMove15(), new StartCrossMove16(), new StartCrossMove17(), new StartCrossMove18(), new StartCrossMove19(), new StartCrossMove20(), new StartCrossMove21(), new StartCrossMove22(), new StartCrossMove23(), };

		public static readonly IStartEdgeMove[] StartEdgeMoves = new IStartEdgeMove[] { new StartEdgeMove1(), new StartEdgeMove2(), new StartEdgeMove3() };
		public static readonly IStartEdgeMove StartEdgeMoveDownMove = new StartEdgeMove4();
	}
}
