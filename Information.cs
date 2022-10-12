using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureWiki2

// 6.1 Create a separate class file to hold the four data items of the Data Structure (use the Data
// Structure Matrix as a guide). Use private properties for the fields which must be of type
// “string”. The class file must have separate setters and getters, add an appropriate IComparable
// for the Name attribute. Save the class as “Information.cs”.

{
    internal class Information : IComparable<Information>
    {
        private string Name;
        private string Category;
        private string Structure;
        private string Definition;

        public int CompareTo(Information other)
        {
            // The data structure comparison depends on the comparison of the String name values.
            return Name.CompareTo(other.Name);
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetCategory()
        {
            return Category;
        }

        public void SetCategory(string category)
        {
            Category = category;
        }

        public string GetStructure()
        {
            return Structure;
        }

        public void SetStructure(string structure)
        {
            Structure = structure;
        }

        public string GetDefinition()
        {
            return Definition;
        }

        public void SetDefinition(string definition)
        {
            Definition = definition;
        }
    }
}
