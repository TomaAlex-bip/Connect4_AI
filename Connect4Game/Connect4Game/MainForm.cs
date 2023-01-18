using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using static System.Net.WebRequestMethods;

namespace Connect4Game
{
    public partial class MainForm : Form
    {
        private Table _table;
        private Bitmap _tableImg;

        private PlayerType _currentPlayer;

        private SolidBrush _transparentRed;
        private SolidBrush _transparentGreen;
        private int _cellDiameter = 76;
        private int _dx = 22;
        private int _dy = 470;

        private int _miniMaxDepth = 4;
        private Func<Table, int> _evaluationFunction = Minimax.EvaluationFunction;

		Stopwatch sw = new Stopwatch();
        List<TimeSpan> timings = new List<TimeSpan>();

		public MainForm()
        {
            InitializeComponent();

            _transparentRed = new SolidBrush(Color.FromArgb(200, 255, 50, 0));
            _transparentGreen = new SolidBrush(Color.FromArgb(200, 50, 255, 50));

            _tableImg = (Bitmap)pictureBoxTable.Image;

            pictureBoxTable.Refresh();

            _table = new Table();

            EnableAddTokenButtons(false);
        }

        private void pictureBoxTable_Paint(object sender, PaintEventArgs e)
        {
            Bitmap table = new Bitmap(_tableImg);
            e.Graphics.DrawImage(table, 0, 0);

            if (_table == null)
            {
                return;
            }

            for (int x = 0; x < _table.Columns; x++)
            {
                for (int y = 0; y < _table.Rows; y++)
                {
                    SolidBrush brush;
                    if (_table.Cells[x,y].PlayerType == PlayerType.Human)
                    {
                        brush = _transparentGreen;
                    }
                    else if (_table.Cells[x, y].PlayerType == PlayerType.Computer)
                    {
                        brush = _transparentRed;
                    }
                    else
                    {
                        continue;
                    }

                    e.Graphics.FillEllipse(brush, _dx + x * 90, _dy - y * 90, _cellDiameter, _cellDiameter);
                }
            }
        }

        private void buttonTableColumn0_Click(object sender, EventArgs e)
        {
            PlayerMove(0);
        }

        private void buttonTableColumn1_Click(object sender, EventArgs e)
        {
            PlayerMove(1);
        }

        private void buttonTableColumn2_Click(object sender, EventArgs e)
        {
            PlayerMove(2);
        }

        private void buttonTableColumn3_Click(object sender, EventArgs e)
        {
            PlayerMove(3);
        }

        private void buttonTableColumn4_Click(object sender, EventArgs e)
        {
            PlayerMove(4);
        }

        private void buttonTableColumn5_Click(object sender, EventArgs e)
        {
            PlayerMove(5);
        }

        private void buttonTableColumn6_Click(object sender, EventArgs e)
        {
            PlayerMove(6);
        }

        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _miniMaxDepth = toolStripComboBoxSearchDepth.SelectedIndex + 1;
            if(_miniMaxDepth <= 0 )
            {
                _miniMaxDepth = 1;
            }

            var evalFuncIndex = toolStripComboBoxEvalFunction.SelectedIndex;
            if(evalFuncIndex == 1)
            {
                _evaluationFunction = Minimax.EvaluationFunction;
            }
            else
            {
                _evaluationFunction = Minimax.EvaluationFunction2;
            }

            _table = new Table();
            _currentPlayer = PlayerType.Computer;
            ComputerMove();
        }

        private void simulateGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _miniMaxDepth = toolStripComboBoxSearchDepth.SelectedIndex + 1;
            if (_miniMaxDepth <= 0)
            {
                _miniMaxDepth = 1;
            }

            _table = new Table();
            _currentPlayer = PlayerType.Computer;
            SimulatorMove();

            //Writing timings to a file
			TextWriter tw = System.IO.File.AppendText("MinimaxTimings.txt");

			tw.WriteLine("___NEW RUN___");
			foreach (var s in timings)
				tw.WriteLine(s.TotalSeconds.ToString());

            tw.Close();

		}

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ComputerMove()
        {
            Minimax.MinimaxAlg(_table, _miniMaxDepth, true, int.MinValue, int.MaxValue, out Table t, _evaluationFunction);
            Table nextTable = t;

            AnimateTransition(_table, nextTable);
            _table = nextTable;
            pictureBoxTable.Refresh();

            CheckWinningConditions();

            _currentPlayer = PlayerType.Human;
            EnableAddTokenButtons();
        }


		private void SimulatorMove()
        {
            bool isMax = true;
            //Verde joaca cu ev2 si rosu cu ev1
            Func<Table, int> evalFunc = Minimax.EvaluationFunction2;  //Rosu

            if(_currentPlayer == PlayerType.Human)  //Verde
            {
                isMax = false;
               evalFunc = _evaluationFunction;
            }
			sw.Restart();
			sw.Start();
			Minimax.MinimaxAlg(_table, _miniMaxDepth, isMax, int.MinValue, int.MaxValue, out Table t, evalFunc);
			sw.Stop();

            timings.Add(sw.Elapsed);

			Table nextTable = t;

            AnimateTransition(_table, nextTable);
            _table = nextTable;
            pictureBoxTable.Refresh();

            if (!CheckWinningConditions())
            {
                _currentPlayer = SwitchPlayer(_currentPlayer);
                SimulatorMove();
            }
        }

        private PlayerType SwitchPlayer(PlayerType player)
        {
            if (player == PlayerType.Computer)
                return PlayerType.Human;
            return PlayerType.Computer;
        }

        private bool CheckWinningConditions()
        {
            for (int i = 0; i < _table.Columns; i++)
            {
                for (int j = 0; j < _table.Rows; j++)
                {
                    var humanPoints = _table.GetMaxPoints(PlayerType.Human, i, j);
                    var computerPoints = _table.GetMaxPoints(PlayerType.Computer, i, j);

                    if (computerPoints >= 4)
                    {
                        MessageBox.Show("A castigat inteligenta! (rosu)");
                        EnableAddTokenButtons(false);
                        return true;
                    }
                    else if (humanPoints >= 4)
                    {
                        MessageBox.Show("A castigat umanitatea! (verde)");
                        EnableAddTokenButtons(false);
                        return true;
                    }
                }
            }

            return false;
        }

        private void PlayerMove(int x)
        {
            if (_currentPlayer != PlayerType.Human)
                return;

            Table oldTable = new Table(_table);
            
            Table newTable = oldTable.MakeMove(x, PlayerType.Human);
            if(newTable != null)
            {
                _table = newTable;
            }
            else
            {
                MessageBox.Show("Invalid move!");
                return;
            }

            AnimateTransition(oldTable, _table);
            pictureBoxTable.Refresh();

            if(CheckWinningConditions())
            {
                return;
            }

            _currentPlayer = PlayerType.Computer;
            EnableAddTokenButtons(false);
            ComputerMove();
        }

        private void AnimateTransition(Table oldTable, Table newTable)
        {
            Bitmap table = new Bitmap(_tableImg);
            Bitmap final = new Bitmap(_tableImg.Width, _tableImg.Height);
            Graphics g = Graphics.FromImage(final);

            int animationSteps = 50;

            oldTable.FindDifferences(newTable, out int x, out int y);
            
            if(x == -1 || y == -1)
            {
                g.DrawImage(table, 0, 0);

                RedrawTable(g, oldTable);

                return;
            }

            for (int a = 1; a < animationSteps; a++)
            {
                g.DrawImage(table, 0, 0);
            
                RedrawTable(g, oldTable);
            
                double avy = (a * y + (animationSteps - a) * newTable.Rows) / (double)animationSteps;
            
                SolidBrush brush = _transparentRed;
                if (newTable.Cells[x, y].PlayerType == PlayerType.Human)
                    brush = _transparentGreen;
            
                g.FillEllipse(brush, (_dx + x * 90), (int)(_dy - avy * 90), _cellDiameter, _cellDiameter);
            
                if(a == animationSteps - 1)
                {
                    g.DrawImage(table, 0, 0);
                    RedrawTable(g, newTable);
                }
            
                Graphics pbg = pictureBoxTable.CreateGraphics();
                pbg.DrawImage(final, 0, 0);
            }
            
        }

        private void RedrawTable(Graphics g, Table table)
        {
            for (int x = 0; x < table.Columns; x++)
            {
                for (int y = 0; y < table.Rows; y++)
                {
                    SolidBrush brush;
                    if (table.Cells[x, y].PlayerType == PlayerType.Human)
                    {
                        brush = _transparentGreen;
                    }
                    else if (table.Cells[x, y].PlayerType == PlayerType.Computer)
                    {
                        brush = _transparentRed;
                    }
                    else
                    {
                        continue;
                    }

                    g.FillEllipse(brush, _dx + x * 90, _dy - y * 90, _cellDiameter, _cellDiameter);
                }
            }
        }

        private void EnableAddTokenButtons(bool status = true)
        {
            buttonTableColumn0.Enabled = status;
            buttonTableColumn1.Enabled = status;
            buttonTableColumn2.Enabled = status;
            buttonTableColumn3.Enabled = status;
            buttonTableColumn4.Enabled = status;
            buttonTableColumn5.Enabled = status;
            buttonTableColumn6.Enabled = status;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string copyright =
                "Connect4 utilizand algoritmul minimax\r\n" +
                "Proiect Inteligenta artificiala\r\n" +
                "(c)2022-2023 Apetrei Gabriel Bogdan si Toma Alexandru Ionut\r\n\r\n" +
                "https://github.com/TomaAlex-bip/Connect4_AI";

            MessageBox.Show(copyright, "Despre jocul Connect4");
        }
    }
}
