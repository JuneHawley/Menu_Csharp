namespace Menu_Hawley
{
    partial class MenuForm
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
            this.burgersGroupBox = new System.Windows.Forms.GroupBox();
            this.drinksGroupBox = new System.Windows.Forms.GroupBox();
            this.friesGroupBox = new System.Windows.Forms.GroupBox();
            this.drinksCheckBox = new System.Windows.Forms.CheckBox();
            this.burgersCheckBox = new System.Windows.Forms.CheckBox();
            this.friesCheckBox = new System.Windows.Forms.CheckBox();
            this.computeButton = new System.Windows.Forms.Button();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regularRadioButton = new System.Windows.Forms.RadioButton();
            this.cheeseRadioButton = new System.Windows.Forms.RadioButton();
            this.baconRadioButton = new System.Windows.Forms.RadioButton();
            this.bothRadioButton = new System.Windows.Forms.RadioButton();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.largeRadioButton = new System.Windows.Forms.RadioButton();
            this.sodaRadioButton = new System.Windows.Forms.RadioButton();
            this.waterRadioButton = new System.Windows.Forms.RadioButton();
            this.burgersGroupBox.SuspendLayout();
            this.drinksGroupBox.SuspendLayout();
            this.friesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // burgersGroupBox
            // 
            this.burgersGroupBox.Controls.Add(this.bothRadioButton);
            this.burgersGroupBox.Controls.Add(this.baconRadioButton);
            this.burgersGroupBox.Controls.Add(this.cheeseRadioButton);
            this.burgersGroupBox.Controls.Add(this.regularRadioButton);
            this.burgersGroupBox.Location = new System.Drawing.Point(132, 1);
            this.burgersGroupBox.Name = "burgersGroupBox";
            this.burgersGroupBox.Size = new System.Drawing.Size(200, 122);
            this.burgersGroupBox.TabIndex = 0;
            this.burgersGroupBox.TabStop = false;
            this.burgersGroupBox.Text = "Choice for Burgers";
            this.burgersGroupBox.Visible = false;
            // 
            // drinksGroupBox
            // 
            this.drinksGroupBox.Controls.Add(this.waterRadioButton);
            this.drinksGroupBox.Controls.Add(this.sodaRadioButton);
            this.drinksGroupBox.Location = new System.Drawing.Point(132, 243);
            this.drinksGroupBox.Name = "drinksGroupBox";
            this.drinksGroupBox.Size = new System.Drawing.Size(200, 81);
            this.drinksGroupBox.TabIndex = 0;
            this.drinksGroupBox.TabStop = false;
            this.drinksGroupBox.Text = "Choice for Drinks";
            this.drinksGroupBox.Visible = false;
            // 
            // friesGroupBox
            // 
            this.friesGroupBox.Controls.Add(this.largeRadioButton);
            this.friesGroupBox.Controls.Add(this.mediumRadioButton);
            this.friesGroupBox.Controls.Add(this.smallRadioButton);
            this.friesGroupBox.Location = new System.Drawing.Point(132, 129);
            this.friesGroupBox.Name = "friesGroupBox";
            this.friesGroupBox.Size = new System.Drawing.Size(200, 108);
            this.friesGroupBox.TabIndex = 1;
            this.friesGroupBox.TabStop = false;
            this.friesGroupBox.Text = "Choice for Fries";
            this.friesGroupBox.Visible = false;
            // 
            // drinksCheckBox
            // 
            this.drinksCheckBox.AutoSize = true;
            this.drinksCheckBox.Location = new System.Drawing.Point(12, 262);
            this.drinksCheckBox.Name = "drinksCheckBox";
            this.drinksCheckBox.Size = new System.Drawing.Size(56, 17);
            this.drinksCheckBox.TabIndex = 0;
            this.drinksCheckBox.Text = "Drinks";
            this.drinksCheckBox.UseVisualStyleBackColor = true;
            this.drinksCheckBox.CheckedChanged += new System.EventHandler(this.DrinksCheckBox_CheckedChanged);
            // 
            // burgersCheckBox
            // 
            this.burgersCheckBox.AutoSize = true;
            this.burgersCheckBox.Location = new System.Drawing.Point(12, 33);
            this.burgersCheckBox.Name = "burgersCheckBox";
            this.burgersCheckBox.Size = new System.Drawing.Size(62, 17);
            this.burgersCheckBox.TabIndex = 1;
            this.burgersCheckBox.Text = "Burgers";
            this.burgersCheckBox.UseVisualStyleBackColor = true;
            this.burgersCheckBox.CheckedChanged += new System.EventHandler(this.burgersCheckBox_CheckedChanged);
            // 
            // friesCheckBox
            // 
            this.friesCheckBox.AutoSize = true;
            this.friesCheckBox.Location = new System.Drawing.Point(12, 139);
            this.friesCheckBox.Name = "friesCheckBox";
            this.friesCheckBox.Size = new System.Drawing.Size(48, 17);
            this.friesCheckBox.TabIndex = 2;
            this.friesCheckBox.Text = "Fries";
            this.friesCheckBox.UseVisualStyleBackColor = true;
            this.friesCheckBox.CheckedChanged += new System.EventHandler(this.friesCheckBox_CheckedChanged);
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(405, 224);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(78, 43);
            this.computeButton.TabIndex = 3;
            this.computeButton.Text = "Compute Cost of Meal";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResultsLabel.Location = new System.Drawing.Point(426, 283);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(100, 32);
            this.ResultsLabel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cost of Meal:";
            // 
            // regularRadioButton
            // 
            this.regularRadioButton.AutoSize = true;
            this.regularRadioButton.Location = new System.Drawing.Point(6, 19);
            this.regularRadioButton.Name = "regularRadioButton";
            this.regularRadioButton.Size = new System.Drawing.Size(92, 17);
            this.regularRadioButton.TabIndex = 1;
            this.regularRadioButton.TabStop = true;
            this.regularRadioButton.Text = "Regular (4.19)";
            this.regularRadioButton.UseVisualStyleBackColor = true;
            // 
            // cheeseRadioButton
            // 
            this.cheeseRadioButton.AutoSize = true;
            this.cheeseRadioButton.Location = new System.Drawing.Point(6, 42);
            this.cheeseRadioButton.Name = "cheeseRadioButton";
            this.cheeseRadioButton.Size = new System.Drawing.Size(106, 17);
            this.cheeseRadioButton.TabIndex = 2;
            this.cheeseRadioButton.TabStop = true;
            this.cheeseRadioButton.Text = "w/ cheese (4.79)";
            this.cheeseRadioButton.UseVisualStyleBackColor = true;
            // 
            // baconRadioButton
            // 
            this.baconRadioButton.AutoSize = true;
            this.baconRadioButton.Location = new System.Drawing.Point(6, 65);
            this.baconRadioButton.Name = "baconRadioButton";
            this.baconRadioButton.Size = new System.Drawing.Size(101, 17);
            this.baconRadioButton.TabIndex = 3;
            this.baconRadioButton.TabStop = true;
            this.baconRadioButton.Text = "w/ bacon (4.79)";
            this.baconRadioButton.UseVisualStyleBackColor = true;
            // 
            // bothRadioButton
            // 
            this.bothRadioButton.AutoSize = true;
            this.bothRadioButton.Location = new System.Drawing.Point(6, 88);
            this.bothRadioButton.Name = "bothRadioButton";
            this.bothRadioButton.Size = new System.Drawing.Size(160, 17);
            this.bothRadioButton.TabIndex = 4;
            this.bothRadioButton.TabStop = true;
            this.bothRadioButton.Text = "w/ bacon and cheese (5.39)";
            this.bothRadioButton.UseVisualStyleBackColor = true;
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Location = new System.Drawing.Point(6, 21);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(80, 17);
            this.smallRadioButton.TabIndex = 0;
            this.smallRadioButton.TabStop = true;
            this.smallRadioButton.Text = "Small (2.39)";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(6, 44);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(92, 17);
            this.mediumRadioButton.TabIndex = 1;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium (3.09)";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // largeRadioButton
            // 
            this.largeRadioButton.AutoSize = true;
            this.largeRadioButton.Location = new System.Drawing.Point(6, 67);
            this.largeRadioButton.Name = "largeRadioButton";
            this.largeRadioButton.Size = new System.Drawing.Size(82, 17);
            this.largeRadioButton.TabIndex = 2;
            this.largeRadioButton.TabStop = true;
            this.largeRadioButton.Text = "Large (4.99)";
            this.largeRadioButton.UseVisualStyleBackColor = true;
            // 
            // sodaRadioButton
            // 
            this.sodaRadioButton.AutoSize = true;
            this.sodaRadioButton.Location = new System.Drawing.Point(3, 27);
            this.sodaRadioButton.Name = "sodaRadioButton";
            this.sodaRadioButton.Size = new System.Drawing.Size(80, 17);
            this.sodaRadioButton.TabIndex = 0;
            this.sodaRadioButton.TabStop = true;
            this.sodaRadioButton.Text = "Soda (1.69)";
            this.sodaRadioButton.UseVisualStyleBackColor = true;
            // 
            // waterRadioButton
            // 
            this.waterRadioButton.AutoSize = true;
            this.waterRadioButton.Location = new System.Drawing.Point(3, 49);
            this.waterRadioButton.Name = "waterRadioButton";
            this.waterRadioButton.Size = new System.Drawing.Size(117, 17);
            this.waterRadioButton.TabIndex = 1;
            this.waterRadioButton.TabStop = true;
            this.waterRadioButton.Text = "Bottled water (1.49)";
            this.waterRadioButton.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.friesCheckBox);
            this.Controls.Add(this.friesGroupBox);
            this.Controls.Add(this.drinksGroupBox);
            this.Controls.Add(this.burgersCheckBox);
            this.Controls.Add(this.burgersGroupBox);
            this.Controls.Add(this.drinksCheckBox);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.burgersGroupBox.ResumeLayout(false);
            this.burgersGroupBox.PerformLayout();
            this.drinksGroupBox.ResumeLayout(false);
            this.drinksGroupBox.PerformLayout();
            this.friesGroupBox.ResumeLayout(false);
            this.friesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox burgersGroupBox;
        private System.Windows.Forms.RadioButton bothRadioButton;
        private System.Windows.Forms.RadioButton baconRadioButton;
        private System.Windows.Forms.RadioButton cheeseRadioButton;
        private System.Windows.Forms.RadioButton regularRadioButton;
        private System.Windows.Forms.GroupBox drinksGroupBox;
        private System.Windows.Forms.RadioButton waterRadioButton;
        private System.Windows.Forms.RadioButton sodaRadioButton;
        private System.Windows.Forms.GroupBox friesGroupBox;
        private System.Windows.Forms.RadioButton largeRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.CheckBox drinksCheckBox;
        private System.Windows.Forms.CheckBox burgersCheckBox;
        private System.Windows.Forms.CheckBox friesCheckBox;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.Label label1;
    }
}

