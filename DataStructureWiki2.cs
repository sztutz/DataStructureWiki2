using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructureWiki2
{
    public partial class DataStructureWiki2 : Form
    {
        public DataStructureWiki2()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        // 6.2 Create a global List<T> of type Information called Wiki.

        List<Information> DataStructures = new List<Information>();

        // 6.3 Create a button method to ADD a new item to the list. Use a TextBox for the Name
        // input, ComboBox for the Category, Radio group for the Structure and Multiline TextBox
        // for the Definition.
        #region Add
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddToList();            
            LabelStatusStrip.Text = TextBoxName.Text + " added";
        }
        // This method exists because it used by the ButtonAdd_Click method and the
        // ButtonEdit_Click method
        private void AddToList()
        {
            Information information = new Information();
            information.SetName(TextBoxName.Text); // needs error handling, use ValidName()
            information.SetCategory(ComboBoxCategory.Text); // needs error handling
            if (RadioButtonLinear.Checked) // needs error handling
            {
                information.SetStructure("Linear");
            }
            else if (RadioButtonNonLinear.Checked)
            {
                information.SetStructure("Non-Linear");
            }
            information.SetDefinition(TextBoxDefinition.Text); // needs error handling
            DataStructures.Add(information);
            UpdateListViewDataStructure();
        }
        #endregion

        // 6.4 Create a custom method to populate the ComboBox when the Form Load method is
        // called. The six categories must be read from a simple text file.

        private void PopulateComboBox()
        {
            foreach (string line in File.ReadLines("Categories.txt"))
            {
                ComboBoxCategory.Items.Add(line);
            }
        }

        // 6.5 Create a custom ValidName method which will take a parameter string value from the
        // Textbox Name and returns a Boolean after checking for duplicates. Use the built in
        // List<T> method “Exists” to answer this requirement.

        private bool ValidName(string name)
        {
            return DataStructures.Exists(x => x.GetName() == name);
        }

        // 6.6 Create two methods to highlight and return the values from the Radio button
        // GroupBox. The first method must return a string value from the selected radio button
        // (Linear or Non-Linear). The second method must send an integer index which will
        // highlight an appropriate radio button.

        // 6.7 Create a button method that will delete the currently selected record in the
        // ListView. Ensure the user has the option to backout of this action by using a dialog
        // box. Display an updated version of the sorted list at the end of this process.

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            // Checking that there is an item selected
            if (ListViewDataStructure.SelectedIndices.Count == 1)
            {
                var result = MessageBox.Show("Do you want to delete this item?", "Delete", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Getting the index of the selected item
                    int index = ListViewDataStructure.SelectedIndices[0];
                    string name = DataStructures[index].GetName();
                    ListViewDataStructure.Items.RemoveAt(index);
                    DataStructures.RemoveAt(index);
                    LabelStatusStrip.Text = name + " deleted";
                    UpdateListViewDataStructure();
                }
            }
            else
            {
                MessageBox.Show("There is no item selected to delete");
            }
        }

        // 6.8 Create a button method that will save the edited record of the currently selected
        // item in the ListView. All the changes in the input controls will be written back to the
        // list. Display an updated version of the sorted list at the end of this process.

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (ListViewDataStructure.SelectedIndices.Count == 1)
            {
                var result = MessageBox.Show("Do you want to edit this item?", "Edit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int index = ListViewDataStructure.SelectedIndices[0];
                    DataStructures.RemoveAt(index);
                    AddToList();
                    LabelStatusStrip.Text = TextBoxName.Text + " edited";
                }
            }
            else
            {
                LabelStatusStrip.Text = " There is no data structure selected to edit";
            }
        }

        // 6.9 Create a single custom method that will sort and then display the Name and Category
        // from the wiki information in the list.

        private void UpdateListViewDataStructure()
        {
            // Clear the List View
            ListViewDataStructure.Items.Clear();
            // Sort the List
            DataStructures.Sort();
            // Iterate through the List
            for (int x = 0; x < DataStructures.Count; x++)
            {
                // Creating the Name item
                ListViewItem item = new ListViewItem(DataStructures[x].GetName());
                // Creating the Category subitem
                item.SubItems.Add(DataStructures[x].GetCategory());
                // Adding the item to the List View
                ListViewDataStructure.Items.Add(item);
            }
        }

        // 6.10 Create a button method that will use the builtin binary search to find a Data
        // Structure name. If the record is found the associated details will populate the
        // appropriate input controls and highlight the name in the ListView. At the end of the
        // search process the search input TextBox must be cleared.

        // 6.11 Create a ListView event so a user can select a Data Structure Name from the list of
        // Names and the associated information will be displayed in the related text boxes combo
        // box and radio button.

        // 6.12 Create a custom method that will clear and reset the TextBoxes, ComboBox and Radio
        // button

        // 6.13 Create a double click event on the Name TextBox to clear the TextBboxes, ComboBox
        // and Radio button.

        // 6.14 Create two buttons for the manual open and save option; this must use a dialog box
        // to select a file or rename a saved file. All Wiki data is stored/retrieved using a
        // binary reader/writer file format.
        #region Save & Load
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "bin file|*.bin";
            saveFileDialog.Title = "Save a bin file";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.DefaultExt = "bin";
            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;
            if (saveFileDialog.FileName != "")
            {
                try
                {
                    using (Stream stream = File.Open(fileName, FileMode.Create))
                    {
                        using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                        {
                            for (int x = 0; x < DataStructures.Count; x++)
                            {
                                writer.Write(DataStructures[x].GetName());
                                writer.Write(DataStructures[x].GetCategory());
                                writer.Write(DataStructures[x].GetStructure());
                                writer.Write(DataStructures[x].GetDefinition());
                            }
                        }
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                LabelStatusStrip.Text = fileName + " saved";
            }
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "bin files|*.bin";
            openFileDialog.Title = "Open a bin file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Clear the current list of data structures
                DataStructures.Clear();

                string openFileName = Path.GetFileName(openFileDialog.FileName);
                try
                {
                    using (Stream stream = File.Open(openFileName, FileMode.Open))
                    {
                        using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                        {
                            while (stream.Position < stream.Length)
                            {
                                Information information = new Information();
                                DataStructures.Add(information);
                                information.SetName(reader.ReadString());
                                information.SetCategory(reader.ReadString());
                                information.SetStructure(reader.ReadString());
                                information.SetDefinition(reader.ReadString());
                            }
                        }
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                LabelStatusStrip.Text = openFileName + " loaded";
            }
            UpdateListViewDataStructure();
        }
        #endregion

        // 6.15 The Wiki application will save data when the form closes. 

        // 6.16 All code is required to be adequately commented. Map the programming criteria and
        // features to your code/methods by adding comments above the method signatures. Ensure
        // your code is compliant with the CITEMS coding standards (refer http://www.citems.com.au/).

    }
}
