using System;
using System.Collections.Generic;
using System.Linq;

namespace Connect4Game
{
    internal class Minimax
    {
        //Fuctie de evalare in stil minimax( min - castila player, max -castiga AI-ul)
		public static int EvaluationFunction(Table table)
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

		public static int EvaluationFunction2(Table table)
		{
			int playerAdvantage = 0;
			int aiAdvantage = 0;

			playerAdvantage = table.GetAdvantage( PlayerType.Human);
			aiAdvantage = table.GetAdvantage( PlayerType.Computer);

			return aiAdvantage - playerAdvantage;
		}


		private static List<Table> GeneratePosibleTables(Table table, bool isMaximizing)
		{
			List<Table> possibleTables = new List<Table>();

			PlayerType player = isMaximizing ? PlayerType.Computer : PlayerType.Human;

			for (int i = 0; i < table.Columns; i++)
			{
				var nextTable = table.MakeMove(i, player);
				if (nextTable != null) 
				{ 
					possibleTables.Add(nextTable);
				}
			}

			return possibleTables;
		}

		private static Table GetRandomTable(List<Table> tables)
		{
			var rand = new Random();

			if (tables.Count > 0)
			{
				return tables[rand.Next(0, tables.Count)];
			}

			return null;
		}
		static int wa = 0;

		//Algoritmul minimax
		public static int MinimaxAlg(Table table, int depth, bool isMaximizing, int alpha, int beta, out Table bestTable, Func<Table, int> evalutionFunction)
        {
			wa++;
			if (depth == 0)
			{
				bestTable = null;
				return evalutionFunction(table);
			}

			if (isMaximizing)
			{
				int bestVal = int.MinValue;

				List<Table> possibleTables = GeneratePosibleTables(table, isMaximizing);
				List<Table> bestTables = new List<Table>();

				foreach (Table currentTable in possibleTables)
				{
					int value = MinimaxAlg(currentTable, depth - 1, false, alpha, beta, out var t, evalutionFunction);

                    // verifica daca gasim o mutare mai buna sau la fel de buna
                    if (value > bestVal)
					{
						bestTables.Clear();
						bestVal = value;
						bestTables.Add(currentTable);
					}
					else if (value == bestVal)
					{
						bestTables.Add(currentTable);
					}

					alpha = Math.Max(alpha, bestVal);
					if (beta < alpha) // doar daca gasim o varianta mai proasta nu o luam in considerare
					{
						break;
					}
				}

				// alege random una din cele mai bune mutari
                bestTable = GetRandomTable(bestTables);

				if( bestTable == null)
				{
					return evalutionFunction(table);
				}

                return bestVal;
			}
			else
			{
				int bestVal = int.MaxValue;

				List<Table> possibleTables = GeneratePosibleTables(table, isMaximizing);
                List<Table> bestTables = new List<Table>();

                foreach (Table currentTable in possibleTables)
				{
					int value = MinimaxAlg(currentTable, depth - 1, true, alpha, beta, out var t, evalutionFunction);

                    // verifica daca gasim o mutare mai buna sau la fel de buna
                    if (value < bestVal)
                    {
                        bestTables.Clear();
                        bestVal = value;
                        bestTables.Add(currentTable);
                    }
                    else if (value == bestVal)
                    {
                        bestTables.Add(currentTable);
                    }

					beta = Math.Min(beta, bestVal);
					if (beta <= alpha)
					{
						break;
					}
				}

                bestTable = GetRandomTable(bestTables);
				if (bestTable == null)
				{
					return evalutionFunction(table);
				}
				return bestVal;
			}
		}
	}
}
