using System;
using System.Net.Sockets;

public class Mahasiswa
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public List<Courses> courses { get; set; }
}
