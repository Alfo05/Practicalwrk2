using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace Maui
{
    public class Converter
    {
        public List<Conversion> operations;

        public Converter()
        {
            operations = new List<Conversion>();
            {
                new DecimalToBinary("Binary", "Decimal to Binary");
                new DecimalToOctal("Octal", "Decimal to Octal");
                new DecimalToHexadecimal("Hexadecimal", "Decimal to Hexadecimal");
                new DecimalToTwoComplement("TwoComplement", "Decimal to Binary (TwoComplement)");
                new BinaryToDecimal("Decimal", "Binary to Decimal");
                new TwoComplementToDecimal("Decimal", "Binary (TwoComplement) to Decimal");
                new OctalToDecimal("Decimal", "Octal to Decimal");
                new HexadecimalToDecimal("Decimal", "Hexadecimal to Decimal");

            };

            
        }
        public int GetNumberOperations() => operations.Count;
        public string PerformConversion(int index, string input)
        {
            if (index < 0 || index >= operations.Count)
            {
                return "Operation Not Valid";
            }
            return operations[index].Change(input);
        }
    }
}
