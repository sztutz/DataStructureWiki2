using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataStructureWiki2
{
    public partial class DataStructureWiki2 : Form
    {
        public DataStructureWiki2()
        {
            InitializeComponent();
            PopulateComboBox();
            // This is here because some times it dissappears from the Designer code for an unknown
            // reason.
            ListViewWiki.HideSelection = true;
        }

        // 6.2 Create a global List<T> of type Information called Wiki.

        List<Information> Wiki = new List<Information>();

        // 6.3 Create a button method to ADD a new item to the list. Use a TextBox for the Name
        // input, ComboBox for the Category, Radio group for the Structure and Multiline TextBox
        // for the Definition.
        #region Add
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // Check that name is not duplicated.
            if (ValidName(TextBoxName.Text))
            {
                // Adding information to the wiki if all criteria are met.
                if (EnterInformation())
                {
                    UpdateListViewWiki();
                    LabelStatusStrip.Text = TextBoxName.Text + " added";
                    ClearInformation();
                }
            }
        }
        // Validates all four inputs. If valid; enters information to ListWiki, and returns true. 
        // If invalid; returns false.

        private bool EnterInformation()
        {
            // Create an instance of information.
            Information information = new Information();
            // This boolean will be false if any of the inputs do not meet the accepted criteria.
            bool valid = true;

            // Name
            if (!string.IsNullOrWhiteSpace(TextBoxName.Text))
            {
                    information.SetName(TextBoxName.Text);
            }
            else
            {
                MessageBox.Show("Name must contain atleast one character.");
                valid = false;
            }
            information.SetName(TextBoxName.Text);

            // Category
            if (!string.IsNullOrWhiteSpace(ComboBoxCategory.Text))
            {
                information.SetCategory(ComboBoxCategory.Text);
            }
            else
            {
                MessageBox.Show("Category must contain atleast one character.");
                valid = false;
            }

            // Structure
            if (GetStructureRadioButton() == "")
            {
                MessageBox.Show("A structure must be checked.");
                valid = false;
            }
            else
            {
                information.SetStructure(GetStructureRadioButton());
            }

            // Definition
            if (!string.IsNullOrWhiteSpace(TextBoxDefinition.Text))
            {
                information.SetDefinition(TextBoxDefinition.Text);
            }
            else
            {
                MessageBox.Show("Definition must not be empty.");
                valid = false;
            }
            Wiki.Add(information);
            // Sort the List
            Wiki.Sort();
            return valid;
        }
        #endregion

        // 6.4 Create a custom method to populate the ComboBox when the Form Load method is
        // called. The six categories must be read from a simple text file.

        private void PopulateComboBox()
        {
            string path = Path.Combine(Application.StartupPath, @"..\..\Categories.txt");
            foreach (string line in File.ReadLines(path))
            {
                ComboBoxCategory.Items.Add(line);
            }
        }

        // 6.5 Create a custom ValidName method which will take a parameter string value from the
        // Textbox Name and returns a Boolean after checking for duplicates. Use the built in
        // List<T> method “Exists” to answer this requirement.
        #region ValidName
        private bool ValidName(string name) // needs to be implemented
        {
            bool valid;   
            if (Wiki.Exists(x => x.GetName().ToLower() == name.ToLower()))
            {
                MessageBox.Show("Name can not be duplicated.");
                valid = false;
            }
            else
            {
                valid = true;
            }
            return valid;
        }
        #endregion
        // 6.6 Create two methods to highlight and return the values from the Radio button
        // GroupBox. The first method must return a string value from the selected radio button
        // (Linear or Non-Linear). The second method must send an integer index which will
        // highlight an appropriate radio button.
        #region Structure Selection
        // Checks which radio button within the Structure group box is checked and returns the 
        // structure as a string
        private string GetStructureRadioButton()
        {
            string structure = "";
            foreach (RadioButton radioButton in GroupBoxStructure.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    structure = radioButton.Text;
                }
            }
            return structure;
        }

        // Checks the respective radio button within the Structure group box
        private void SetStructureRadioButton(int index)
        {
            foreach (RadioButton radioButton in GroupBoxStructure.Controls.OfType<RadioButton>())
            {
                if (radioButton.Text == Wiki[index].GetStructure())
                {
                    radioButton.Checked = true;
                }
                else
                {
                    radioButton.Checked = false;
                }
            }
        }
        #endregion

        // 6.7 Create a button method that will delete the currently selected record in the
        // ListView. Ensure the user has the option to backout of this action by using a dialog
        // box. Display an updated version of the sorted list at the end of this process.
        #region Delete
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            // Checking that there is an item selected
            if (ListViewWiki.SelectedIndices.Count == 1)
            {
                var result = MessageBox.Show("Do you want to delete this item?", "Delete", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Getting the index of the selected item
                    int index = ListViewWiki.SelectedIndices[0];
                    string name = Wiki[index].GetName();
                    ListViewWiki.Items.RemoveAt(index);
                    Wiki.RemoveAt(index);
                    LabelStatusStrip.Text = name + " deleted";
                    UpdateListViewWiki();
                    ClearInformation();
                }
            }
            else
            {
                MessageBox.Show("There is no item selected to delete");
            }
        }
        #endregion
        // 6.8 Create a button method that will save the edited record of the currently selected
        // item in the ListView. All the changes in the input controls will be written back to the
        // list. Display an updated version of the sorted list at the end of this process.
        #region edit
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (ListViewWiki.SelectedIndices.Count == 1)
            {
                int index = ListViewWiki.SelectedIndices[0];
                if ((TextBoxName.Text != Wiki[index].GetName() && ValidName(TextBoxName.Text))
                    || TextBoxName.Text == Wiki[index].GetName())
                {
                    var result = MessageBox.Show("Do you want to edit this item?", "Edit",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        if (EnterInformation())
                        {
                            Wiki.RemoveAt(index);
                            LabelStatusStrip.Text = TextBoxName.Text + " edited";
                            ClearInformation();
                            UpdateListViewWiki();
                        }
                    }
                }
            }
            else
            {
                LabelStatusStrip.Text = " There is no data structure selected to edit";
            }
        }
        #endregion
        // 6.9 Create a single custom method that will sort and then display the Name and Category
        // from the wiki information in the list.

        private void UpdateListViewWiki()
        {
            // Clear the List View
            ListViewWiki.Items.Clear();
            // Iterate through the List
            for (int x = 0; x < Wiki.Count; x++)
            {
                // Creating the Name item
                ListViewItem item = new ListViewItem(Wiki[x].GetName());
                // Creating the Category subitem
                item.SubItems.Add(Wiki[x].GetCategory());
                // Adding the item to the List View
                ListViewWiki.Items.Add(item);
            }
        }

        // 6.10 Create a button method that will use the builtin binary search to find a Data
        // Structure name. If the record is found the associated details will populate the
        // appropriate input controls and highlight the name in the ListView. At the end of the
        // search process the search input TextBox must be cleared.
        #region Search
        private void ButtonSearch_Click(object sender, EventArgs e) // needs error handling
        {
            string searchName = TextBoxSearch.Text;
            Information searchDataStructure = new Information();
            searchDataStructure.SetName(searchName);
            int index = Wiki.BinarySearch(searchDataStructure);
            if (index >= 0)
            {
                ShowInformation(index);
                ListViewWiki.Items[index].Selected = true;
                //ListViewWiki.Items[index].BackColor = Color.LawnGreen;
                LabelStatusStrip.Text = searchName + " found";
            }
            else
            {
                LabelStatusStrip.Text = searchName + " not found";
            }
            TextBoxSearch.Text = "";
            TextBoxSearch.Focus();
        }
        // Only allows alphabetic characters and hyphens to be entered into the TextBox
        // When focused on the search text box, pressing enter will click the search button
        private void TextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                ButtonSearch.PerformClick();
            }
        }
        #endregion
        // 6.11 Create a ListView event so a user can select a Data Structure Name from the list of
        // Names and the associated information will be displayed in the related text boxes combo
        // box and radio button.

        // 6.12 Create a custom method that will clear and reset the TextBoxes, ComboBox and Radio
        // button

        private void ClearInformation()
        {
            TextBoxName.Clear();
            ComboBoxCategory.ResetText();
            foreach (RadioButton radioButton in GroupBoxStructure.Controls.OfType<RadioButton>())
            {
                radioButton.Checked = false;
            }
            TextBoxDefinition.Clear();
        }

        // 6.13 Create a double click event on the Name TextBox to clear the TextBboxes, ComboBox
        // and Radio button.

        private void TextBoxName_DoubleClick(object sender, EventArgs e)
        {
            ClearInformation();
            LabelStatusStrip.Text = "Cleared";
        }

        // 6.14 Create two buttons for the manual open and save option; this must use a dialog box
        // to select a file or rename a saved file. All Wiki data is stored/retrieved using a
        // binary reader/writer file format.
        #region Save&Load
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
                            for (int x = 0; x < Wiki.Count; x++)
                            {
                                writer.Write(Wiki[x].GetName());
                                writer.Write(Wiki[x].GetCategory());
                                writer.Write(Wiki[x].GetStructure());
                                writer.Write(Wiki[x].GetDefinition());
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
                Wiki.Clear();

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
                                Wiki.Add(information);
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
            UpdateListViewWiki();
        }

        #endregion

        // 6.15 The Wiki application will save data when the form closes. 

        private void DataStructureWiki2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Wiki.Count > 0)
            {
                try
                {
                    using (Stream stream = File.Open("AutoSave.bin", FileMode.Create))
                    {
                        using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                        {
                            for (int x = 0; x < Wiki.Count; x++)
                            {
                                writer.Write(Wiki[x].GetName());
                                writer.Write(Wiki[x].GetCategory());
                                writer.Write(Wiki[x].GetStructure());
                                writer.Write(Wiki[x].GetDefinition());
                            }
                        }
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        // 6.16 All code is required to be adequately commented. Map the programming criteria and
        // features to your code/methods by adding comments above the method signatures. Ensure
        // your code is compliant with the CITEMS coding standards (refer http://www.citems.com.au/).


        // Shows the properties of the data structure at parameter int index within List Wiki
        private void ShowInformation(int index)
        {
            TextBoxName.Text = Wiki[index].GetName();
            ComboBoxCategory.Text = Wiki[index].GetCategory();
            SetStructureRadioButton(index);
            TextBoxDefinition.Text = Wiki[index].GetCategory();
        }

        // Only allows alphabetic characters and hyphens to be entered in TextBox
        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void ListViewWiki_MouseClick(object sender, MouseEventArgs e)
        {
            if (ListViewWiki.SelectedIndices.Count == 1)
            {
                int index = ListViewWiki.SelectedIndices[0];
                ShowInformation(index);
                // This takes focus away from the ListView, needed to show the desired color.
                GroupBoxStructure.Focus();
            }
        }

        // This makes the selected item and the unselected item change color.
        private void ListViewWiki_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                e.Item.BackColor = Color.LawnGreen;
            }
            else
            {
                e.Item.BackColor = Color.White;
            }
        }
    }
}
