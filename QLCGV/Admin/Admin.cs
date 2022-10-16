﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCGV.Admin
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           // this.Hide();
            new Phim().Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Phong().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NhanVien().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            this.Hide();
            new LichChieu().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new KhachHang().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TheLoaiPhim().Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TheLoaiPhim().Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // this.Hide();
            new Phim().Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Phong().Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LichChieu().Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NhanVien().Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new KhachHang().Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
