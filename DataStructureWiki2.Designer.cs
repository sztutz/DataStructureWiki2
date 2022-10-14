namespace DataStructureWiki2
{
    partial class DataStructureWiki2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelDefinition = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxDefinition = new System.Windows.Forms.TextBox();
            this.ListViewWiki = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.LabelStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.GroupBoxStructure = new System.Windows.Forms.GroupBox();
            this.RadioButtonNonLinear = new System.Windows.Forms.RadioButton();
            this.RadioButtonLinear = new System.Windows.Forms.RadioButton();
            this.LabelStucture = new System.Windows.Forms.Label();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.LabelDataStructures = new System.Windows.Forms.Label();
            this.StatusStrip.SuspendLayout();
            this.GroupBoxStructure.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.ButtonAdd.Location = new System.Drawing.Point(15, 300);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(60, 23);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "add";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.Color.PaleGreen;
            this.ButtonEdit.Location = new System.Drawing.Point(81, 300);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(60, 23);
            this.ButtonEdit.TabIndex = 1;
            this.ButtonEdit.Text = "edit";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.PaleGreen;
            this.ButtonDelete.Location = new System.Drawing.Point(147, 300);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(60, 23);
            this.ButtonDelete.TabIndex = 2;
            this.ButtonDelete.Text = "delete";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(12, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(38, 13);
            this.LabelName.TabIndex = 3;
            this.LabelName.Text = "Name:";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(12, 48);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(52, 13);
            this.LabelCategory.TabIndex = 4;
            this.LabelCategory.Text = "Category:";
            // 
            // LabelDefinition
            // 
            this.LabelDefinition.AutoSize = true;
            this.LabelDefinition.Location = new System.Drawing.Point(12, 157);
            this.LabelDefinition.Name = "LabelDefinition";
            this.LabelDefinition.Size = new System.Drawing.Size(54, 13);
            this.LabelDefinition.TabIndex = 6;
            this.LabelDefinition.Text = "Definition:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(15, 25);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(192, 20);
            this.TextBoxName.TabIndex = 7;
            this.TextBoxName.DoubleClick += new System.EventHandler(this.TextBoxName_DoubleClick);
            // 
            // TextBoxDefinition
            // 
            this.TextBoxDefinition.Location = new System.Drawing.Point(15, 173);
            this.TextBoxDefinition.Multiline = true;
            this.TextBoxDefinition.Name = "TextBoxDefinition";
            this.TextBoxDefinition.Size = new System.Drawing.Size(192, 121);
            this.TextBoxDefinition.TabIndex = 10;
            // 
            // ListViewWiki
            // 
            this.ListViewWiki.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderCategory});
            this.ListViewWiki.FullRowSelect = true;
            this.ListViewWiki.HideSelection = false;
            this.ListViewWiki.Location = new System.Drawing.Point(216, 25);
            this.ListViewWiki.MultiSelect = false;
            this.ListViewWiki.Name = "ListViewWiki";
            this.ListViewWiki.Scrollable = false;
            this.ListViewWiki.Size = new System.Drawing.Size(240, 308);
            this.ListViewWiki.TabIndex = 11;
            this.ListViewWiki.UseCompatibleStateImageBehavior = false;
            this.ListViewWiki.View = System.Windows.Forms.View.Details;
            this.ListViewWiki.SelectedIndexChanged += new System.EventHandler(this.ListViewWiki_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 120;
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.Text = "Category";
            this.columnHeaderCategory.Width = 120;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.PaleGreen;
            this.ButtonSearch.Location = new System.Drawing.Point(147, 368);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(60, 23);
            this.ButtonSearch.TabIndex = 12;
            this.ButtonSearch.Text = "search";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(15, 342);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(192, 20);
            this.TextBoxSearch.TabIndex = 13;
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.PaleGreen;
            this.ButtonSave.Location = new System.Drawing.Point(394, 339);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(60, 23);
            this.ButtonSave.TabIndex = 14;
            this.ButtonSave.Text = "save";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.BackColor = System.Drawing.Color.PaleGreen;
            this.ButtonLoad.Location = new System.Drawing.Point(394, 368);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(60, 23);
            this.ButtonLoad.TabIndex = 15;
            this.ButtonLoad.Text = "load";
            this.ButtonLoad.UseVisualStyleBackColor = false;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.PaleGreen;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelStatusStrip});
            this.StatusStrip.Location = new System.Drawing.Point(0, 405);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(466, 22);
            this.StatusStrip.TabIndex = 16;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // LabelStatusStrip
            // 
            this.LabelStatusStrip.Name = "LabelStatusStrip";
            this.LabelStatusStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Location = new System.Drawing.Point(15, 64);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(192, 21);
            this.ComboBoxCategory.TabIndex = 17;
            // 
            // GroupBoxStructure
            // 
            this.GroupBoxStructure.BackColor = System.Drawing.Color.LimeGreen;
            this.GroupBoxStructure.Controls.Add(this.RadioButtonNonLinear);
            this.GroupBoxStructure.Controls.Add(this.RadioButtonLinear);
            this.GroupBoxStructure.Location = new System.Drawing.Point(15, 104);
            this.GroupBoxStructure.Name = "GroupBoxStructure";
            this.GroupBoxStructure.Size = new System.Drawing.Size(192, 50);
            this.GroupBoxStructure.TabIndex = 18;
            this.GroupBoxStructure.TabStop = false;
            // 
            // RadioButtonNonLinear
            // 
            this.RadioButtonNonLinear.AutoSize = true;
            this.RadioButtonNonLinear.Location = new System.Drawing.Point(92, 19);
            this.RadioButtonNonLinear.Name = "RadioButtonNonLinear";
            this.RadioButtonNonLinear.Size = new System.Drawing.Size(77, 17);
            this.RadioButtonNonLinear.TabIndex = 1;
            this.RadioButtonNonLinear.TabStop = true;
            this.RadioButtonNonLinear.Text = "Non-Linear";
            this.RadioButtonNonLinear.UseVisualStyleBackColor = true;
            // 
            // RadioButtonLinear
            // 
            this.RadioButtonLinear.AutoSize = true;
            this.RadioButtonLinear.Location = new System.Drawing.Point(17, 19);
            this.RadioButtonLinear.Name = "RadioButtonLinear";
            this.RadioButtonLinear.Size = new System.Drawing.Size(54, 17);
            this.RadioButtonLinear.TabIndex = 0;
            this.RadioButtonLinear.TabStop = true;
            this.RadioButtonLinear.Text = "Linear";
            this.RadioButtonLinear.UseVisualStyleBackColor = true;
            // 
            // LabelStucture
            // 
            this.LabelStucture.AutoSize = true;
            this.LabelStucture.Location = new System.Drawing.Point(12, 88);
            this.LabelStucture.Name = "LabelStucture";
            this.LabelStucture.Size = new System.Drawing.Size(53, 13);
            this.LabelStucture.TabIndex = 19;
            this.LabelStucture.Text = "Structure:";
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(12, 326);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(44, 13);
            this.LabelSearch.TabIndex = 20;
            this.LabelSearch.Text = "Search:";
            // 
            // LabelDataStructures
            // 
            this.LabelDataStructures.AutoSize = true;
            this.LabelDataStructures.Location = new System.Drawing.Point(213, 9);
            this.LabelDataStructures.Name = "LabelDataStructures";
            this.LabelDataStructures.Size = new System.Drawing.Size(84, 13);
            this.LabelDataStructures.TabIndex = 21;
            this.LabelDataStructures.Text = "Data Structures:";
            // 
            // DataStructureWiki2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(466, 427);
            this.Controls.Add(this.LabelDataStructures);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.LabelStucture);
            this.Controls.Add(this.GroupBoxStructure);
            this.Controls.Add(this.ComboBoxCategory);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ListViewWiki);
            this.Controls.Add(this.TextBoxDefinition);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelDefinition);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonAdd);
            this.Name = "DataStructureWiki2";
            this.Text = "Data Structure Wiki 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataStructureWiki2_FormClosing);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.GroupBoxStructure.ResumeLayout(false);
            this.GroupBoxStructure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelDefinition;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxDefinition;
        private System.Windows.Forms.ListView ListViewWiki;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.GroupBox GroupBoxStructure;
        private System.Windows.Forms.RadioButton RadioButtonNonLinear;
        private System.Windows.Forms.RadioButton RadioButtonLinear;
        private System.Windows.Forms.Label LabelStucture;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.Label LabelDataStructures;
        private System.Windows.Forms.ToolStripStatusLabel LabelStatusStrip;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderCategory;
    }
}

