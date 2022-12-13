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

        public MainForm()
        {
            InitializeComponent();

            _tableImg = (Bitmap)pictureBoxTable.Image;

            pictureBoxTable.Refresh();

            _table = new Table();

            _table.InitializeDummyData();
        }

        private void pictureBoxTable_Paint(object sender, PaintEventArgs e)
        {
            int cellDiameter = 76;
            int dx = 22;
            int dy = 470;

            Bitmap table = new Bitmap(_tableImg);
            e.Graphics.DrawImage(table, 0, 0);

            if (_table == null)
            {
                return;
            }

            SolidBrush transparentRed = new SolidBrush(Color.FromArgb(192, 255, 0, 0));
            SolidBrush transparentGreen = new SolidBrush(Color.FromArgb(192, 255, 128, 0));

            for (int x = 0; x < _table.Columns; x++)
            {
                for (int y = 0; y < _table.Rows; y++)
                {
                    SolidBrush brush;
                    if (_table.Cells[x,y].PlayerType == PlayerType.Human)
                    {
                        brush = transparentGreen;
                    }
                    else if (_table.Cells[x, y].PlayerType == PlayerType.Computer)
                    {
                        brush = transparentRed;
                    }
                    else
                    {
                        continue;
                    }

                    e.Graphics.FillEllipse(brush, dx + x * 90, dy - y * 90, cellDiameter, cellDiameter);
                }
            }
        }

        private void buttonTableColumn0_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonTableColumn1_Click(object sender, EventArgs e)
        {
            for (int i = _table.Rows-1; i >= 0 ; i--)
            {
                var currentCell = _table.Cells[1,i];
                if(currentCell.PlayerType != PlayerType.Empty)
                {
                    if (i >= _table.Rows-1)
                    {
                        return;
                    }

                    _table.Cells[1, i + 1].PlayerType = PlayerType.Human;
                    return;
                }
            }

            pictureBoxTable.Refresh();
        }

        private void buttonTableColumn2_Click(object sender, EventArgs e)
        {

        }

        private void buttonTableColumn3_Click(object sender, EventArgs e)
        {

        }

        private void buttonTableColumn4_Click(object sender, EventArgs e)
        {

        }

        private void buttonTableColumn5_Click(object sender, EventArgs e)
        {

        }

        private void buttonTableColumn6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
