using MODUL5_1302210087;

Penjumlahan P = new Penjumlahan();
int hasil = P.JumlahTigaAngka<int>(13, 02, 21);
Console.WriteLine("Hasil Penjumlahan Tiga Angka Adalah " + hasil);

Console.WriteLine(" ");

SimpleDataBase<int> data = new SimpleDataBase<int>();
data.AddNewData(12);
data.AddNewData(34);
data.AddNewData(56);
data.printalldata();