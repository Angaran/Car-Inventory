
namespace CustomerViewer
{
    partial class formCustomerEntry
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxMake = new System.Windows.Forms.ComboBox();
            this.newStatus = new System.Windows.Forms.CheckBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.listViewEntries = new System.Windows.Forms.ListView();
            this.columnNew = new System.Windows.Forms.ColumnHeader();
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnMake = new System.Windows.Forms.ColumnHeader();
            this.columnModel = new System.Windows.Forms.ColumnHeader();
            this.columnYear = new System.Windows.Forms.ColumnHeader();
            this.columnPrice = new System.Windows.Forms.ColumnHeader();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxMake
            // 
            this.comboBoxMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMake.FormattingEnabled = true;
            this.comboBoxMake.Items.AddRange(new object[] {
            "Toyota",
            "Mercedes-Benz",
            "BMW",
            "Honda",
            "Chevrolet",
            "Ford",
            "Jeep",
            "Porsche",
            "Subaru",
            "Nissan",
            "Cadillac",
            "Volkswagen",
            "Lexus",
            "Audi",
            "Ferrari",
            "Volvo",
            "Jaguar",
            "GMC",
            "Buick",
            "Acura",
            "Bentley",
            "Dodge",
            "Hyundai",
            "Lincoln",
            "Mazda",
            "Land Rover",
            "Tesla",
            "Ram Trucks",
            "Kia",
            "Chrysler",
            "Pontiac",
            "Infiniti",
            "Mitsubishi",
            "Maserati",
            "Aston Martin",
            "Bugatti",
            "Fiat",
            "Mini",
            "Alfa Romeo",
            "Genesis",
            "Suzuki"});
            this.comboBoxMake.Location = new System.Drawing.Point(141, 13);
            this.comboBoxMake.Name = "comboBoxMake";
            this.comboBoxMake.Size = new System.Drawing.Size(150, 28);
            this.comboBoxMake.TabIndex = 1;
            this.toolTip.SetToolTip(this.comboBoxMake, "Select the customer\'s title");
            // 
            // newStatus
            // 
            this.newStatus.AutoSize = true;
            this.newStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newStatus.Location = new System.Drawing.Point(97, 169);
            this.newStatus.Name = "newStatus";
            this.newStatus.Size = new System.Drawing.Size(64, 24);
            this.newStatus.TabIndex = 6;
            this.newStatus.Text = "New:";
            this.toolTip.SetToolTip(this.newStatus, "Select if the customer is a VIP");
            this.newStatus.UseVisualStyleBackColor = true;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(141, 133);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(150, 27);
            this.textBoxPrice.TabIndex = 5;
            this.toolTip.SetToolTip(this.textBoxPrice, "Enter the customer\'s last name");
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(142, 53);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(150, 27);
            this.textBoxModel.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxModel, "Enter the customer\'s first name");
            // 
            // labelLastName
            // 
            this.labelLastName.Location = new System.Drawing.Point(16, 137);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(120, 20);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Price";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Location = new System.Drawing.Point(16, 57);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(120, 20);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Model";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(14, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(120, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Make";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelError
            // 
            this.labelError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelError.Location = new System.Drawing.Point(10, 449);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(358, 85);
            this.labelError.TabIndex = 8;
            this.toolTip.SetToolTip(this.labelError, "Displays all error messages");
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(282, 537);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(86, 39);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Click to exit the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(142, 537);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(86, 39);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset all entry fields");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(10, 537);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(86, 39);
            this.buttonEnter.TabIndex = 9;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click to enter the current customer");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // listViewEntries
            // 
            this.listViewEntries.CheckBoxes = true;
            this.listViewEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNew,
            this.columnID,
            this.columnMake,
            this.columnModel,
            this.columnYear,
            this.columnPrice});
            this.listViewEntries.FullRowSelect = true;
            this.listViewEntries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewEntries.HideSelection = false;
            this.listViewEntries.Location = new System.Drawing.Point(9, 199);
            this.listViewEntries.MultiSelect = false;
            this.listViewEntries.Name = "listViewEntries";
            this.listViewEntries.Size = new System.Drawing.Size(358, 247);
            this.listViewEntries.TabIndex = 7;
            this.toolTip.SetToolTip(this.listViewEntries, "Display a list of all customers");
            this.listViewEntries.UseCompatibleStateImageBehavior = false;
            this.listViewEntries.View = System.Windows.Forms.View.Details;
            this.listViewEntries.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PreventCheck);
            this.listViewEntries.SelectedIndexChanged += new System.EventHandler(this.CarSelected);
            // 
            // columnNew
            // 
            this.columnNew.Text = "New";
            this.columnNew.Width = 45;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 45;
            // 
            // columnMake
            // 
            this.columnMake.Text = "Make";
            this.columnMake.Width = 50;
            // 
            // columnModel
            // 
            this.columnModel.Text = "Model";
            this.columnModel.Width = 75;
            // 
            // columnYear
            // 
            this.columnYear.Text = "Year";
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 75;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.comboBoxYear.Location = new System.Drawing.Point(141, 93);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(150, 28);
            this.comboBoxYear.TabIndex = 13;
            this.toolTip.SetToolTip(this.comboBoxYear, "Select the customer\'s title");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Year:";
            // 
            // formCustomerEntry
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(382, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.listViewEntries);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.comboBoxMake);
            this.Controls.Add(this.newStatus);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCustomerEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Inventory";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMake;
        private System.Windows.Forms.CheckBox newStatus;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.ListView listViewEntries;
        private System.Windows.Forms.ColumnHeader columnMake;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderLastName;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnNew;
        private System.Windows.Forms.ColumnHeader columnModel;
        private System.Windows.Forms.ColumnHeader columnYear;
        private System.Windows.Forms.ColumnHeader columnPrice;
    }
}