using System;
using Microsoft.Maui.Controls;

namespace Maui
{
    public abstract class Conversion
    {
        protected string name;
        protected string definition;

        public Conversion(string name, string definition)
        {
            this.name = name;
            this.definition = definition;
        }
        public abstract string Change(string input);
        public string GetName() => name;
        public string GetDefintion() => definition;
    }
}