﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFilters
{
    public partial class Form2 : Form
    {
        public int size = 0;
        public bool[,] structureElement = null;

        public Form2()
        {
            Form1 form1 = (Form1)this.Owner;
            InitializeComponent();
        }

        public Form2(Form form)
        {
            InitializeComponent();
            dataGridView1.Hide();
        }


        public int maxSize
        {
            get
            {
                return size;
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            if (size != 0)
            {
                structureElement = new bool[size, size];
                for (int m = 0; m < size; m++)
                {
                    for (int n = 0; n < size; n++)
                    {
                        if (dataGridView1[n, m].Style.BackColor == Color.Red)
                        {
                            structureElement[m, n] = true;
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("Enter the size and type of structure element", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setDefaultButton_Click(object sender, EventArgs e)
        {
            if (size != 0)
            {
                structureElement = new bool[size, size];
                for (int m = 0; m < size; m++)
                {
                    for (int n = 0; n < size; n++)
                    {
                        dataGridView1[n, m].Style.BackColor = Color.Red;                     
                        structureElement[m, n] = true;
                        dataGridView1[n, m].Value = Convert.ToString(1);
                    }
                }
                MessageBox.Show("Structure element was set", "Error", MessageBoxButtons.OK);
                //TODO: Добавить закрытие 2 формы по нажатию кнопки ОК
                //if (DialogResult == DialogResult.OK)
                //{
                //    this.Close();
                    
                //}

            }

            else
            {
                MessageBox.Show("Enter the size and type of structure element", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
                    dataGridView1[e.ColumnIndex, e.RowIndex].Value = Convert.ToString(1);
                    break;
                case MouseButtons.Right:
                    dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                    dataGridView1[e.ColumnIndex, e.RowIndex].Value = Convert.ToString(0);
                    break;
            }

            
        }

        private void SetSize(int chosedSize)
        {
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Rows.Clear();

            size = chosedSize;
            dataGridView1.Show();
            dataGridView1.RowCount = dataGridView1.ColumnCount = size;

            for (int m = 0; m < size; m++)
            {
                for (int n = 0; n < size; n++)
                {
                    dataGridView1.Rows[m].Cells[n].Value = Convert.ToString(0);
                }
            }

            Refresh();
        }

        private void size3radioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetSize(3);
        }

        private void size5radioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetSize(5);
        }

        private void size7radioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetSize(7);
        }

        private void size9radioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetSize(9);
        }

    }
}
