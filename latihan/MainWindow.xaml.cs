﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace latihan
{

    public partial class MainWindow : Window
    {

        List<barang> daftarBarang = new List<barang>();

        
        public MainWindow()
        {
            InitializeComponent();
            clearField();
        }

        private void clearField()
        {
            txt_nama.Clear();
            txt_harga.Clear();
            txt_jenis.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string namaBarang = txt_nama.Text;
                string jenis = txt_jenis.Text;
                int harga = int.Parse(txt_harga.Text);
                barang item = new barang(namaBarang, jenis, harga);
                daftarBarang.Add(item);

                MessageBox.Show("added " + item.Nama);
            }catch(Exception ex)
            {
                MessageBox.Show("Something gone wrong " + ex.ToString());
            }
            
        }
    }
}
