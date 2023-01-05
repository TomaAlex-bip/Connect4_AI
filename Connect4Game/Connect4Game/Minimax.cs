using System;
using System.Collections.Generic;
using System.Linq;

namespace Connect4Game
{
    public class Minimax
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
			int playerAdvantage = table.GetAdvantage( PlayerType.Human);
			int aiAdvantage = table.GetAdvantage( PlayerType.Computer);

			return aiAdvantage - playerAdvantage;
		}

		/// <summary>
		/// Metoda care genereaza toate tablele de joc posibile dupa o mutare.
		/// </summary>
		/// <param name="table">Tabla de joc actuala.</param>
		/// <param name="isMaximizing">Parametru pentru a determina tipul de jucator.</param>
		/// <returns>O lista cu tablele de joc generate.</returns>
		
		// preconditii P:
		// - table este o tabla de joc goala
		// - table are 7 coloane
		// - isMaximizing este true
		
		// postconditii Q:
		// - generarea a cel mult table.Columns table de joc noi
		// - tipul de jucator este in functie de parametrul isMaximizing
		private static List<Table> GeneratePosibleTables(Table table, bool isMaximizing)
		{
			List<Table> possibleTables = new List<Table>();

			// P0: table = gol
			// c: isMaximizing = true
			// A1:
			PlayerType player = isMaximizing ? 
				PlayerType.Computer : PlayerType.Human;

            // P0 && c -A1-> P1: table = gol, isMaximizing = true, player = PlayerType.Computer
            // P0 && !c -A1-> P2: table = gol, isMaximizing = false, player = PlayerType.Human

            // A2: i = 0;
            // P1 -A2-> P3: initializam i = 0
            // P2 -A2-> P3: initializam i = 0
            // Invariantul I: {i < table.Columns; i = 0...table.Columns}
            for (int i = 0; i < table.Columns; i++)
			{
				// A3: primim noua tabela generata
				var nextTable = table.MakeMove(i, player);

				// P3 -A3-> P4: generam o noua tabla de joc dupa o mutare in functie de coloana si player.

				// c: nextTable != null
				// A4: verificam daca tabla noua de joc este valida
				if (nextTable != null) 
				{
					// A5: adaugam in lista noua tabla
					possibleTables.Add(nextTable);
					// P4 -A5-> Q
				}
                // {i == table.Columns; i = 0...table.Columns} -> Q
            }

            // Q: returnam lista de table de joc generate
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

		//Algoritmul minimax
		public static int MinimaxAlg(Table table, int depth, bool isMaximizing, int alpha, int beta, out Table bestTable, Func<Table, int> evalutionFunction)
        {
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
