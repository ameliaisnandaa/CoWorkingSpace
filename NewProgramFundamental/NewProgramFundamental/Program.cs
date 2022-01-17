using NewProgramFundamental;
using System;
using System.Collections.Generic;

namespace WorkingSpace
{
    public class Program
    {
        int pilih;    
        private static List<string> roomList = new List<string>();
        private static List<int> priceList = new List<int>();

        private static List<string> nameList = new List<string>();
        private static List<string> phoneList = new List<string>();
        private static List<string> idList = new List<string>();
        private static List<string> addressList = new List<string>();
        private static List<int> paymentList = new List<int>();


        static void Main(string[] args)
        {

                Program pg = new Program();
                Customer c = new Customer();
                Menu m = new Menu();

                mainMenu();

        }
        public static void mainMenu()
        {
            Program p = new Program();
            Customer c = new Customer();
            List<string> pilihan = new List<string>() { "Data Menu", "Tambah Pesanan", "Tutup Program" };
            for (int i = 0; i < pilihan.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + pilihan[i]);
            }

            Console.Write("Masukan Pilihan\t: ");
            int pilih = Convert.ToInt32(Console.ReadLine());
            switch (pilih)
            {
                case 1:
                    crud();
                    //Menu.tampil();
                    //goto run;
                    break;
                case 2:
                    tampilkanList();
                    pilihanRoom();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        public static void crud()
        {
            int ganti, hapus;
            int pilih;

            List<string> menu1 = new List<string> { "Tambah", "Edit", "Hapus",  "Keluar" };
            menu:
            for (int i = 0; i < menu1.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + menu1[i]);
            }

            Console.Write("Masukan pilhanmu\t: ");
            pilih = Convert.ToInt32((Console.ReadLine()));
            if (pilih == 1)
            {
                inputRoom();
            }
            else if (pilih == 2)
            {
                editRoom();
            }
            else if (pilih == 3)
            {
                hapusRoom();
            }
            else if (pilih == 4)
            {
                Console.Clear();
                mainMenu();
            }
            else
            {
                Console.WriteLine("Input Salah, Coba Lagi!!");
            }
        }
        public static void tampilkanList()
        {
            Console.Clear();
            Console.WriteLine("=============================================================================");
            Console.WriteLine("\tJenis Ruangan\t");
            Console.WriteLine("=============================================================================");
            for (int i = 0; i < roomList.Count; i++)
            {
                Console.WriteLine($"{i+1}. \t{roomList[i]}");
            }
            Console.WriteLine("=============================================================================");
            Console.WriteLine("\tHarga Ruangan\t");
            Console.WriteLine("=============================================================================");
            for (int j = 0; j < priceList.Count; j++)
            {

                Console.WriteLine($"{j+1}. \t{priceList[j]}");
            }
            Console.WriteLine();
        }
        public static void inputRoom()
        {
            Console.Clear();
            Console.Write("Masukkan ruangan = ");
            string nRoom = Console.ReadLine();
            Console.Write("Masukkan harga = ");
            int nPrice = Convert.ToInt32(Console.ReadLine());
            Menu m = new Menu();
            m.room = nRoom;
            m.price = nPrice;
            //isi lisst
            roomList.Add(m.room);
            priceList.Add(m.price);
            m.tampil();

            Program.inputAgain();
        }
        public static void inputAgain()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Input Lagi? [y/n]\t: ");
            string ulang = Console.ReadLine().ToLower();
            switch (ulang)
            {
                case "y":
                    //Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Clear();
                    inputRoom();
                    break;
                case "n":
                    Program.tampilkanList();
                    Program.crud();
                    break;
            }
        }
        public static void editRoom()
        {
            Console.Write("Masukan Nomor data yang akan diedit: ");
            int edit = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nMasukan nama ruangan baru\t: ");
            string editRoom = Console.ReadLine();
            Console.Write("\nMasukan harga ruangan baru\t: ");
            int editPrice = Convert.ToInt32(Console.ReadLine());
            roomList[edit-1] = editRoom;
            priceList[edit-1] = editPrice;
            tampilkanList();
            crud();
        }
        public static void hapusRoom()
        {
            Console.Write("Masukan Nomor data yang akan dihapus: ");
            int hapus = Convert.ToInt32(Console.ReadLine());
            roomList.RemoveAt(hapus-1);
            priceList.RemoveAt(hapus-1);
            tampilkanList();
            crud();
        }
        public static void pilihanRoom()
        {
            Program p = new Program();
            Console.Write("Masukan nomor Ruangan yang dipilih\t: ");
            p.pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Pilihan Room\t\t\t\t: {roomList[p.pilih-1]}");
            Console.WriteLine($"Harga Room\t\t\t\t: {priceList[p.pilih-1]}");

            Customer c = new Customer();
            inputDataCustomer();
            p.dataCustomer();
        }

        public static void inputDataCustomer()
        {
            Console.WriteLine("DATA CUSTOMER");

            Console.Write("Nama Konsumen\t\t\t\t: ");
            string nName = Console.ReadLine();
            Console.Write("No. Telp\t\t\t\t: ");
            string nPhone = Console.ReadLine();
            Console.Write("Masukan No Identitas\t\t\t: ");
            string nId = Console.ReadLine();
            Console.Write("Alamat\t\t\t\t\t: ");
            string nAddress = Console.ReadLine();
            Console.Write("Masukan Uang\t\t\t\t: ");
            int nPayment = int.Parse(Console.ReadLine());

            Menu m = new Menu();
            m.Name = nName;
            m.NumberPhone = nPhone;
            m.Address = nAddress;
            m.IDNumber = nId;
            m.Payment = nPayment;

            nameList.Add(m.Name);
            phoneList.Add(m.NumberPhone);
            addressList.Add(m.Address);
            idList.Add(m.IDNumber);
            paymentList.Add(m.Payment);

        }

        public void dataCustomer()
        {
            Customer c = new Customer();
            Console.Clear();
            Console.WriteLine("YOUR CUSTOMER DATA");
            Console.WriteLine("Nama Konsumen\t\t\t\t: {0}", nameList[0]);
            Console.WriteLine("No. Telp\t\t\t\t: {0}", phoneList[0]);
            Console.WriteLine("No. Identitas\t\t\t\t: {0}", idList[0]);
            Console.WriteLine("Alamat\t\t\t\t\t: {0}", addressList[0]);
            Console.WriteLine($"Pilihan Room\t\t\t\t: {roomList[pilih-1]}");
            Console.WriteLine($"Harga Room\t\t\t\t: {priceList[pilih-1]}");

            Console.WriteLine("TAGIHAN");
            Console.WriteLine("Harga Room\t\t\t\t: {0}", priceList[pilih-1]);
            Console.WriteLine("Uang Tunai\t\t\t\t: {0}", paymentList[0]);
            Console.WriteLine("Kembalian\t\t\t\t: {0}", (paymentList[0] - priceList[pilih-1]));

            backToMenu();
        }

        public void backToMenu()
        {
            Console.WriteLine("\nKembali ke Menu? [y/n]");
            string jwb = Console.ReadLine();
            switch (jwb)
            {
                case "y":
                    Console.Clear();
                    mainMenu();
                    break;
                case "n":
                    Environment.Exit(0);
                    break;
            }
        }
    }   


        
         



}