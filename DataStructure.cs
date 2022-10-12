using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureWiki2
{
    internal class DataStructure : IComparable<DataStructure>
    {
        private string Name;
        private string Category;
        private string Structure;
        private string Definition;

        public int CompareTo(DataStructure other)
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
