using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Stuart Anderson, 30056472, 19/10/2022
// C Sharp Two, Assessment Task Two

namespace DataStructureWiki2

// 6.1 Create a separate class file to hold the four data items of the Data Structure (use the Data
// Structure Matrix as a guide). Use private properties for the fields which must be of type
// “string”. The class file must have separate setters and getters, add an appropriate IComparable
// for the Name attribute. Save the class as “Information.cs”.

{
    internal class Information : IComparable<Information>
    {
        private string _name;
        private string _category;
        private string _structure;
        private string _definition;

        public int CompareTo(Information other)
        {
            //return Compare(_name, other.Compare._name, false);
            // The data structure comparison depends on the comparison of the String name values.
            
            return _name.ToLower().CompareTo(other._name.ToLower());
        }

        //public int CompareTo(Information other, StringComparer comparer)
        //{
        //    // The data structure comparison depends on the comparison of the String name values.
        //    return _name.CompareTo(other._name, StringComparer.OrdinalIgnoreCase);
        //}

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetCategory()
        {
            return _category;
        }

        public void SetCategory(string category)
        {
            _category = category;
        }

        public string GetStructure()
        {
            return _structure;
        }

        public void SetStructure(string structure)
        {
            _structure = structure;
        }

        public string GetDefinition()
        {
            return _definition;
        }

        public void SetDefinition(string definition)
        {
            _definition = definition;
        }
    }
}
