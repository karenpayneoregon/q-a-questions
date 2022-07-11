using System.Collections.Generic;
using AbstractClassToStringExample.Models;

namespace AbstractClassToStringExample.Classes
{
    /// <summary>
    /// For demonstration, replace were your data is coming from
    /// </summary>
    public class Mocked
    {
        public static List<BaseContainer> MachineList(bool type1 = true)
        {
            return type1
                ? new List<BaseContainer>()
                {
                    new MachineCombo1() { SerialNumber = "X1234", Name = "Machine 1A" },
                    new MachineCombo1() { SerialNumber = "X1255", Name = "Machine 1B" },
                    new MachineCombo1() { SerialNumber = "X1265", Name = "Machine 1C" },
                }
                : new List<BaseContainer>()
                {
                    new MachineCombo2() { SerialNumber = "X1234", Name = "Machine 1A" },
                    new MachineCombo2() { SerialNumber = "X1255", Name = "Machine 1B" },
                    new MachineCombo2() { SerialNumber = "X1265", Name = "Machine 1C" },
                };
        }
    }
}