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
        private int harga;


		
		public barang(string nama, string jenis, int harga)
		{
			this.Nama = nama;
			this.Jenis = jenis;
			this.Harga = harga;
		}

        public string Nama { get => nama; set => nama = value; }
        public string Jenis { get => jenis; set => jenis = value; }
        public int Harga { get => harga; set => harga = value; }
    }
}
