﻿using CrmBl.Model;
using System;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }
        public ProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product = new Product()
            {
                Name = textBox1.Text,
                Price = numericUpDown1.Value,
                Count = Convert.ToInt32(numericUpDown2.Value)
            };
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
