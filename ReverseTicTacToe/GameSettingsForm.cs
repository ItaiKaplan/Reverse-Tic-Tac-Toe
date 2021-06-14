﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReverseTicTacToe
{
    public partial class GameSettingsForm : Form
    {
        public GameSettingsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.nUDRows.ValueChanged += NUDRows_ValueChanged;
            this.nUDCols.ValueChanged += NUDCols_ValueChanged;
            this.m_ButtonStart.Click += M_ButtonStart_Click;
        }

        private void M_ButtonStart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GameSettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            this.m_TextBoxPlayer2.Enabled = !this.m_TextBoxPlayer2.Enabled;
            if(!this.m_TextBoxPlayer2.Enabled)
            {
                this.m_TextBoxPlayer2.Text = "[Computer]";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NUDRows_ValueChanged(object sender, System.EventArgs e)
        {
            this.nUDCols.Value = (sender as NumericUpDown).Value;
        }

        private void NUDCols_ValueChanged(object sender, System.EventArgs e)
        {
            this.nUDRows.Value = (sender as NumericUpDown).Value;
        }

        public int BoardSize
        {
            get
            {
                return (int)this.nUDCols.Value;
            }
        }
        public string Player1Name
        {
            get
            {
                return this.m_TextBoxPlayer1.Text;
            }
        }

        public string Player2Name
        {
            get
            {
                return this.m_TextBoxPlayer2.Text;
            }
        }

        public bool CheckBoxPlayer2Checked
        {
            get
            {
                return this.m_CheckBoxPlayer2.Checked;
            }
        }
    }
}
