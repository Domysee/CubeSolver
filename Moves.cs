using RubiksCubeSolver.StartCrossMoves;
using RubiksCubeSolver.StartCornerMoves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RubiksCubeSolver.SecondLayerEdgeMoves;
using RubiksCubeSolver.ThirdLayerCrossMoves;

namespace RubiksCubeSolver
{
	public static class Moves
	{
		public static readonly IStartCrossMove[] StartCrossMoves = new IStartCrossMove[] { new StartCrossMove1(), new StartCrossMove2(), new StartCrossMove3(), new StartCrossMove4(), new StartCrossMove5(), new StartCrossMove6(), new StartCrossMove7(), new StartCrossMove8(), new StartCrossMove9(), new StartCrossMove10(), new StartCrossMove11(), new StartCrossMove12(), new StartCrossMove13(), new StartCrossMove14(), new StartCrossMove15(), new StartCrossMove16(), new StartCrossMove17(), new StartCrossMove18(), new StartCrossMove19(), new StartCrossMove20(), new StartCrossMove21(), new StartCrossMove22(), new StartCrossMove23(), };

		public static readonly IStartCornerMove[] StartEdgeMoves = new IStartCornerMove[] { new StartCornerMove1(), new StartCornerMove2(), new StartCornerMove3() };
		public static readonly IStartCornerMove StartEdgeMoveDownMove = new StartCornerMove4();
		public static readonly ISecondLayerEdgeMove[] SecondLayerEdgeMoves = new ISecondLayerEdgeMove[] { new SecondLayerEdgeMove1(), new SecondLayerEdgeMove2() };
		public static readonly ISecondLayerEdgeMove SecondLayerOutMove = new SecondLayerEdgeMove3();
		public static readonly IOLLCrossMove[] OLLCrossMoves = new IOLLCrossMove[] { new OLLCrossMove1(), new OLLCrossMove2() };
		public static readonly IOLLCornerMove[] OLLCornerMoves = new IOLLCornerMove[] { new OLLCornerMove1() };
		public static readonly IPLLCornerMove[] PLLCornerMoves = new IPLLCornerMove[] { new PLLCornerMove1() };
		public static readonly IPLLEdgeMove[] PLLEdgeMoves = new IPLLEdgeMove[] { new PLLEdgeMove1() };
	}
}
