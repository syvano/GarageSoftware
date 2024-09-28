namespace GarageSoftware
{
    partial class GarageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RegistrationTxtBox = new TextBox();
            label1 = new Label();
            MakeTxtBox = new TextBox();
            ModelTxtBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            AddVehicleBtn = new Button();
            EditVehicleBtn = new Button();
            VehicleDataGrid = new DataGridView();
            SearchTxt = new TextBox();
            SearchBtn = new Button();
            FrontBrakeNum = new NumericUpDown();
            RearBrakeNum = new NumericUpDown();
            AntiFreezeStengthNum = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            OdometerNum = new NumericUpDown();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)VehicleDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FrontBrakeNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RearBrakeNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AntiFreezeStengthNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OdometerNum).BeginInit();
            SuspendLayout();
            // 
            // RegistrationTxtBox
            // 
            RegistrationTxtBox.Location = new Point(2035, 220);
            RegistrationTxtBox.Margin = new Padding(5);
            RegistrationTxtBox.Name = "RegistrationTxtBox";
            RegistrationTxtBox.Size = new Size(522, 50);
            RegistrationTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1693, 225);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(190, 45);
            label1.TabIndex = 1;
            label1.Text = "Registration";
            // 
            // MakeTxtBox
            // 
            MakeTxtBox.Location = new Point(2035, 344);
            MakeTxtBox.Margin = new Padding(5);
            MakeTxtBox.Name = "MakeTxtBox";
            MakeTxtBox.Size = new Size(522, 50);
            MakeTxtBox.TabIndex = 2;
            // 
            // ModelTxtBox
            // 
            ModelTxtBox.Location = new Point(2035, 469);
            ModelTxtBox.Margin = new Padding(5);
            ModelTxtBox.Name = "ModelTxtBox";
            ModelTxtBox.Size = new Size(522, 50);
            ModelTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1693, 349);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 45);
            label2.TabIndex = 8;
            label2.Text = "Make";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1693, 474);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 45);
            label3.TabIndex = 9;
            label3.Text = "Model";
            // 
            // AddVehicleBtn
            // 
            AddVehicleBtn.Location = new Point(2035, 1000);
            AddVehicleBtn.Name = "AddVehicleBtn";
            AddVehicleBtn.Size = new Size(522, 63);
            AddVehicleBtn.TabIndex = 14;
            AddVehicleBtn.Text = "Add Vehicle";
            AddVehicleBtn.UseVisualStyleBackColor = true;
            AddVehicleBtn.Click += AddVehicleBtn_Click;
            // 
            // EditVehicleBtn
            // 
            EditVehicleBtn.Location = new Point(2035, 1114);
            EditVehicleBtn.Name = "EditVehicleBtn";
            EditVehicleBtn.Size = new Size(522, 63);
            EditVehicleBtn.TabIndex = 15;
            EditVehicleBtn.Text = "Edit Vehicle";
            EditVehicleBtn.UseVisualStyleBackColor = true;
            // 
            // VehicleDataGrid
            // 
            VehicleDataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            VehicleDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VehicleDataGrid.GridColor = SystemColors.ActiveBorder;
            VehicleDataGrid.Location = new Point(105, 216);
            VehicleDataGrid.Name = "VehicleDataGrid";
            VehicleDataGrid.RowHeadersWidth = 62;
            VehicleDataGrid.RowTemplate.Height = 33;
            VehicleDataGrid.Size = new Size(1544, 961);
            VehicleDataGrid.TabIndex = 16;
            // 
            // SearchTxt
            // 
            SearchTxt.Location = new Point(105, 103);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.PlaceholderText = "Start typing here...";
            SearchTxt.Size = new Size(1190, 50);
            SearchTxt.TabIndex = 17;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(1366, 103);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(283, 50);
            SearchBtn.TabIndex = 18;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // FrontBrakeNum
            // 
            FrontBrakeNum.Location = new Point(2035, 581);
            FrontBrakeNum.Name = "FrontBrakeNum";
            FrontBrakeNum.Size = new Size(522, 50);
            FrontBrakeNum.TabIndex = 19;
            // 
            // RearBrakeNum
            // 
            RearBrakeNum.Location = new Point(2035, 680);
            RearBrakeNum.Name = "RearBrakeNum";
            RearBrakeNum.Size = new Size(522, 50);
            RearBrakeNum.TabIndex = 20;
            // 
            // AntiFreezeStengthNum
            // 
            AntiFreezeStengthNum.Location = new Point(2035, 784);
            AntiFreezeStengthNum.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            AntiFreezeStengthNum.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            AntiFreezeStengthNum.Name = "AntiFreezeStengthNum";
            AntiFreezeStengthNum.Size = new Size(522, 50);
            AntiFreezeStengthNum.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1693, 586);
            label4.Name = "label4";
            label4.Size = new Size(272, 45);
            label4.TabIndex = 22;
            label4.Text = "Front Brake % left";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1693, 685);
            label5.Name = "label5";
            label5.Size = new Size(259, 45);
            label5.TabIndex = 23;
            label5.Text = "Rear Brake % left";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1700, 789);
            label6.Name = "label6";
            label6.Size = new Size(305, 45);
            label6.TabIndex = 24;
            label6.Text = "Anti-freeze strength";
            // 
            // OdometerNum
            // 
            OdometerNum.Location = new Point(2035, 895);
            OdometerNum.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            OdometerNum.Name = "OdometerNum";
            OdometerNum.Size = new Size(522, 50);
            OdometerNum.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1693, 900);
            label7.Name = "label7";
            label7.Size = new Size(166, 45);
            label7.TabIndex = 26;
            label7.Text = "Odometer";
            // 
            // GarageForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2740, 1368);
            Controls.Add(label7);
            Controls.Add(OdometerNum);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(AntiFreezeStengthNum);
            Controls.Add(RearBrakeNum);
            Controls.Add(FrontBrakeNum);
            Controls.Add(SearchBtn);
            Controls.Add(SearchTxt);
            Controls.Add(VehicleDataGrid);
            Controls.Add(EditVehicleBtn);
            Controls.Add(AddVehicleBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ModelTxtBox);
            Controls.Add(MakeTxtBox);
            Controls.Add(label1);
            Controls.Add(RegistrationTxtBox);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "GarageForm";
            Text = "Garage";
            ((System.ComponentModel.ISupportInitialize)VehicleDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)FrontBrakeNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)RearBrakeNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)AntiFreezeStengthNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)OdometerNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RegistrationTxtBox;
        private Label label1;
        private TextBox MakeTxtBox;
        private TextBox ModelTxtBox;
        private Label label2;
        private Label label3;
        private Button AddVehicleBtn;
        private Button EditVehicleBtn;
        private DataGridView VehicleDataGrid;
        private TextBox SearchTxt;
        private Button SearchBtn;
        private NumericUpDown FrontBrakeNum;
        private NumericUpDown RearBrakeNum;
        private NumericUpDown AntiFreezeStengthNum;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown OdometerNum;
        private Label label7;
    }
}
