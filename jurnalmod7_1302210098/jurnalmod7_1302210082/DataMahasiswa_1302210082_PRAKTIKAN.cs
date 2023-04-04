using System;
using System.Text.Json;

public class DataMahasiswa1302210082
{
    Mahasiswa mahasiswa = new Mahasiswa();
    public DataMahasiswa1302210082()
    {

    }

    string text = File.ReadAllText("D:\\modul7_kelompok1\\jurnalmod7_1302210098\\jurnalmod7_1302210082\\jurnal7_1_1302210082.json");

    public void readJson()
    {
        mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(text);
        Console.WriteLine($"Nama : {mahasiswa.firstName}{mahasiswa.lastName}");
        Console.WriteLine($"Gender : {mahasiswa.gender}");
        Console.WriteLine($"Age : {mahasiswa.age}");
        Console.WriteLine($"Address: {mahasiswa.address.streetAddress} {mahasiswa.address.city} {mahasiswa.address.state}");
        for (int i =0; i< mahasiswa.courses.Count; i++) {
            Console.WriteLine($"Course: {mahasiswa.courses[i].code} {mahasiswa.courses[i].name}");
        }
    }
}

