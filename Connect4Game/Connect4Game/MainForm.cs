using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4Game
{
    public partial class MainForm : Form
    {
        private Table _table;
        private Bitmap _tableImg;

        private SolidBrush _transparentRed;
        private SolidBrush _transparentGreen;
        private int _cellDiameter = 76;
        private int _dx = 22;
        private int _dy = 470;

        public MainForm()
        {
            InitializeComponent();

            _transparentRed = new SolidBrush(Color.FromArgb(192, 255, 0, 0));
            _transparentGreen = new SolidBrush(Color.FromArgb(192, 255, 128, 0));

            _tableImg = (Bitmap)pictureBoxTable.Image;

            pictureBoxTable.Refresh();

            _table = new Table();

            _table.InitializeDummyData();
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
            AddToken(0);
        }

        private void buttonTableColumn1_Click(object sender, EventArgs e)
        {
            AddToken(1);
        }

        private void buttonTableColumn2_Click(object sender, EventArgs e)
        {
            AddToken(2);
        }

        private void buttonTableColumn3_Click(object sender, EventArgs e)
        {
            AddToken(3);
        }

        private void buttonTableColumn4_Click(object sender, EventArgs e)
        {
            AddToken(4);
        }

        private void buttonTableColumn5_Click(object sender, EventArgs e)
        {
            AddToken(5);
        }

        private void buttonTableColumn6_Click(object sender, EventArgs e)
        {
            AddToken(6);
        }

        private void AddToken(int x)
        {
            Table oldTable = new Table(_table);

            for (int i = _table.Rows - 1; i >= 0; i--)
            {
                var currentCell = _table.Cells[x, i];
                if (currentCell.PlayerType != PlayerType.Empty)
                {
                    if (i >= _table.Rows - 1)
                    {
                        return;
                    }

                    _table.Cells[x, i + 1].PlayerType = PlayerType.Human;

                    AnimateTransition(oldTable, _table, x, i + 1);

                    return;
                }
            }

            pictureBoxTable.Refresh();
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

                DrawTable(g, oldTable);

                double avy = (a * row + (animationSteps - a) * newTable.Rows) / (double)animationSteps;

                SolidBrush brush = _transparentRed;
                if (newTable.Cells[column, row].PlayerType == PlayerType.Human)
                    brush = _transparentGreen;

                g.FillEllipse(brush, (_dx + column * 90), (int)(_dy - avy * 90), _cellDiameter, _cellDiameter);

                if(a == animationSteps - 1)
                {
                    g.DrawImage(table, 0, 0);
                    DrawTable(g, newTable);
                }

                Graphics pbg = pictureBoxTable.CreateGraphics();
                pbg.DrawImage(final, 0, 0);
            }
        }

        private void DrawTable(Graphics g, Table table)
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
