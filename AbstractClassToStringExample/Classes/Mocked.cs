using System.Collections.Generic;
using System.IO;
using AbstractClassToStringExample.Models;
using Newtonsoft.Json;

namespace AbstractClassToStringExample.Classes
{
    /// <summary>
    /// For demonstration, replace were your data is coming from
    /// </summary>
    public class Mocked
    {
        private static string _fileName = "machines.json";
        public static List<MachineCombo1> MachineList1() => 
            JsonConvert.DeserializeObject<List<MachineCombo1>>(File.ReadAllText(_fileName));

        public static List<MachineCombo2> MachineList2() =>
            JsonConvert.DeserializeObject<List<MachineCombo2>>(File.ReadAllText(_fileName));
    }
}