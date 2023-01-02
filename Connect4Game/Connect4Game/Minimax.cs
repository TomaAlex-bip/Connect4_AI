using System;
using System.Collections.Generic;
using System.Linq;

namespace Connect4Game
{
    internal class Minimax
    {
        //Fuctie de evalare in stil minimax( min - castila player, max -castiga AI-ul)
		private static int EvaluationFunction(Table table)
		{
			int playerAdvantage = 0;
			int aiAdvantage = 0;

			for	(int i = 0; i < table.Columns; i++)
			{
				for (int j = 0; j < table.Rows; j++)
				{
					var player = table.GetMaxPoints(PlayerType.Human, i, j);
					var ai = table.GetMaxPoints(PlayerType.Computer, i, j);

					playerAdvantage = Math.Max(player, playerAdvantage);
					aiAdvantage = Math.Max(ai, aiAdvantage);
				}
			}

			return aiAdvantage - playerAdvantage;
		}

		private static List<Table> GeneratePosibleTables(Table table, bool isMaximizingPlayer)
		{
			List<Table> possibleTables = new List<Table>();
			int y;

			PlayerType player = isMaximizingPlayer ? PlayerType.Human : PlayerType.Computer;

			for (int i = 0; i < 7; i++)
			{
				var nextTable = table.MakeMove(i, out y, player);
				if (nextTable != null) { 
					possibleTables.Add(nextTable);
				}
			}

			return possibleTables;
		}

		//Algoritmul minimax
		public static int MinimaxAlg(Table table, int depth, bool isMaximizingPlayer, int alpha, int beta, out Table bestTable)
        {
			if (depth == 0)
			{
				bestTable = null;
				return EvaluationFunction(table);
			}

			if (isMaximizingPlayer)
			{
				int bestVal = int.MinValue;

				List<Table> possibleTables = GeneratePosibleTables(table, isMaximizingPlayer);

				foreach (Table currentTable in possibleTables)
				{
					int value = MinimaxAlg(currentTable, depth - 1, false, alpha, beta, out var t);

					bestVal = Math.Max(bestVal, value);

					alpha = Math.Max(alpha, bestVal);
					if (beta <= alpha)
					{
						break;
					}
				}

				bestTable = null;
				return bestVal;
			}
			else
			{
				int bestVal = int.MaxValue;

				List<Table> possibleTables = GeneratePosibleTables(table, isMaximizingPlayer);

				foreach (Table currentTable in possibleTables)
				{
					int value = MinimaxAlg(currentTable, depth - 1, true, alpha, beta, out var t);
					bestVal = Math.Min(bestVal, value);
					beta = Math.Min(beta, bestVal);
					if (beta <= alpha)
					{
						break;
					}


				}
				bestTable = possibleTables.OrderByDescending(tableLam => EvaluationFunction(tableLam)).First();
				return bestVal;
			}
		}

	}
}
