using System;
using System.Drawing;
using System.Windows.Forms;

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
            _table = new Table();
            _currentPlayer = PlayerType.Computer;
            ComputerMove();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ComputerMove()
        {
            Table nextTable = Minimax.FindNextTable(_table, out int affectedRow, out int affectedColumn);

            AnimateTransition(_table, nextTable, affectedColumn, affectedRow);
            _table = nextTable;
            pictureBoxTable.Refresh();

            CheckWinningConditions();

            _currentPlayer = PlayerType.Human;
            EnableAddTokenButtons();
        }

        private void CheckWinningConditions()
        {
            return;
        }

        private void PlayerMove(int x)
        {
            if (_currentPlayer != PlayerType.Human)
                return;

            Table oldTable = new Table(_table);

            int y = _table.FirstFreePosition(x);
            if (y == -1)
                return;

            _table.Cells[x, y].PlayerType = PlayerType.Human;

            AnimateTransition(oldTable, _table, x, y);
            pictureBoxTable.Refresh();

            _currentPlayer = PlayerType.Computer;
            EnableAddTokenButtons(false);
            ComputerMove();
        }

        private void AnimateTransition(Table oldTable, Table newTable, int column, int row)
        {
            Bitmap table = new Bitmap(_tableImg);
            Bitmap final = new Bitmap(_tableImg.Width, _tableImg.Height);
            Graphics g = Graphics.FromImage(final);

            int animationSteps = 50;

            for (int a = 1; a < animationSteps; a++)
            {
                g.DrawImage(table, 0, 0);

                RedrawTable(g, oldTable);

                double avy = (a * row + (animationSteps - a) * newTable.Rows) / (double)animationSteps;

                SolidBrush brush = _transparentRed;
                if (newTable.Cells[column, row].PlayerType == PlayerType.Human)
                    brush = _transparentGreen;

                g.FillEllipse(brush, (_dx + column * 90), (int)(_dy - avy * 90), _cellDiameter, _cellDiameter);

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

        
    }
}
