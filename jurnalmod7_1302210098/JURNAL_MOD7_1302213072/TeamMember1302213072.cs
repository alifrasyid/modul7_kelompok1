using System;
using System.Text.Json;
using System.IO;
namespace JURNAL_MOD7_1302213072;
public class TeamMember1302213072
{
    ListMembers anggota = new ListMembers();
    public void readJSON()
    {
        string text2 = File.ReadAllText("D:\\modul7_kelompok1\\jurnalmod7_1302210098\\JURNAL_MOD7_1302213072\\jurnal7_2_1302213072.json");

        anggota = JsonSerializer.Deserialize<ListMembers>(text2);

        for (int i = 0; i < anggota.members.Count; i++)
        {
            Console.WriteLine($"MK {i + 1}: <{anggota.members[i].nim}> < {anggota.members[i].firstName} {anggota.members[i].lastName} {anggota.members[i].age} {anggota.members[i].gender} >");
        }
    }
}