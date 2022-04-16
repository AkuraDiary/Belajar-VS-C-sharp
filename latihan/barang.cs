using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan
{
	public class barang
	{
        private string nama, jenis;
        private int harga, stock;


		
		public barang(string nama, string jenis, int harga, int stock)
		{
			this.Nama = nama;
			this.Jenis = jenis;
			this.Harga = harga;
			this.Stock = stock;
		}

        public string Nama { get => nama; set => nama = value; }
        public string Jenis { get => jenis; set => jenis = value; }
        public int Harga { get => harga; set => harga = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
