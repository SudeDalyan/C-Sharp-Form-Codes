﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasta_Sipariş_Formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = checkBox1.Text;

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            label16.Text = checkBox6.Text;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            label22.Text = checkBox8.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(comboBox1.Text+","+comboBox2.Text+","+comboBox3.Text+","+comboBox4.Text);
            listBox5.Items.Add(label11.Text+","+ label12.Text +","+label16.Text+ "," +label17.Text + "," + label18.Text + "," + label19.Text + "," + label20.Text + "," + label21.Text + "," + label22.Text);
            
           
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = checkBox4.Text;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            label17.Text = checkBox9.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label18.Text = checkBox2.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label19.Text = checkBox3.Text;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            label20.Text = checkBox7.Text;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label21.Text = checkBox5.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";
            comboBox4.Text = " ";
            label11.Text = " ";
            label12.Text = " ";
            label16.Text = " ";
            label17.Text = " ";
            label18.Text = " ";
            label19.Text = " ";
            label20.Text = " ";
            label21.Text = " ";
            label22.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
