﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace viusal_critter
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txb_display.Font = new Font(txb_display.Font.FontFamily,16);

            
        }

        private void btn_changename_Click(object sender, EventArgs e)
        {
            txb_display.Text = txb_containt.Text;
        }

        private void rbt_red_CheckedChanged(object sender, EventArgs e)
        {
            txb_display.BackColor = Color.Red;
        }

        private void rbt_green_CheckedChanged(object sender, EventArgs e)
        {
            txb_display.BackColor = Color.Green;
        }

        private void rbt_blue_CheckedChanged(object sender, EventArgs e)
        {
            txb_display.BackColor = Color.Blue;
        }

        private void cmb_fontsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            txb_display.Font = new Font(txb_display.Font.FontFamily, float.Parse(cmb_fontsize.Text));
        }
    }
}
