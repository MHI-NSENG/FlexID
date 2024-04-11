namespace FlexID
{
    partial class Menu
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
            this.Label_Nuclide = new System.Windows.Forms.Label();
            this.comboBox_Nuclide = new System.Windows.Forms.ComboBox();
            this.Label_Progeny = new System.Windows.Forms.Label();
            this.radioButton_Yes = new System.Windows.Forms.RadioButton();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.Label_Route = new System.Windows.Forms.Label();
            this.comboBox_Route = new System.Windows.Forms.ComboBox();
            this.label_Commitment = new System.Windows.Forms.Label();
            this.textBox_Commitment = new System.Windows.Forms.TextBox();
            this.comboBox_Commitment = new System.Windows.Forms.ComboBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.label_OutPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_OutPath = new System.Windows.Forms.TextBox();
            this.button_OutPath = new System.Windows.Forms.Button();
            this.label_CalcMesh = new System.Windows.Forms.Label();
            this.textBox_CalcMesh = new System.Windows.Forms.TextBox();
            this.button_CalcMesh = new System.Windows.Forms.Button();
            this.label_OutMesh = new System.Windows.Forms.Label();
            this.textBox_OutMesh = new System.Windows.Forms.TextBox();
            this.button_OutMesh = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Age_EIR = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Radionuclide_EIR = new System.Windows.Forms.ComboBox();
            this.btn_OutMesh_EIR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CalcMesh_EIR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OutMesh_EIR = new System.Windows.Forms.TextBox();
            this.Progeny_EIR = new System.Windows.Forms.RadioButton();
            this.btn_OutPath_EIR = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CalcMesh_EIR = new System.Windows.Forms.TextBox();
            this.Route_EIR = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OutputPath_EIR = new System.Windows.Forms.TextBox();
            this.text_Commitment_EIR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_Commitment_EIR = new System.Windows.Forms.ComboBox();
            this.Button_start_EIR = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Nuclide
            // 
            this.Label_Nuclide.AutoSize = true;
            this.Label_Nuclide.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label_Nuclide.Location = new System.Drawing.Point(25, 70);
            this.Label_Nuclide.Name = "Label_Nuclide";
            this.Label_Nuclide.Size = new System.Drawing.Size(56, 16);
            this.Label_Nuclide.TabIndex = 4;
            this.Label_Nuclide.Text = "Nuclide";
            // 
            // comboBox_Nuclide
            // 
            this.comboBox_Nuclide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Nuclide.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_Nuclide.FormattingEnabled = true;
            this.comboBox_Nuclide.Location = new System.Drawing.Point(165, 67);
            this.comboBox_Nuclide.Name = "comboBox_Nuclide";
            this.comboBox_Nuclide.Size = new System.Drawing.Size(280, 24);
            this.comboBox_Nuclide.TabIndex = 5;
            this.comboBox_Nuclide.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Nuclide_SelectedIndexChanged);
            // 
            // Label_Progeny
            // 
            this.Label_Progeny.AutoSize = true;
            this.Label_Progeny.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label_Progeny.Location = new System.Drawing.Point(25, 115);
            this.Label_Progeny.Name = "Label_Progeny";
            this.Label_Progeny.Size = new System.Drawing.Size(116, 32);
            this.Label_Progeny.TabIndex = 6;
            this.Label_Progeny.Text = "Application of \r\nProgeny Nuclide";
            // 
            // radioButton_Yes
            // 
            this.radioButton_Yes.AutoSize = true;
            this.radioButton_Yes.Enabled = false;
            this.radioButton_Yes.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton_Yes.Location = new System.Drawing.Point(235, 122);
            this.radioButton_Yes.Name = "radioButton_Yes";
            this.radioButton_Yes.Size = new System.Drawing.Size(50, 20);
            this.radioButton_Yes.TabIndex = 7;
            this.radioButton_Yes.Text = "Yes";
            this.radioButton_Yes.UseVisualStyleBackColor = true;
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Checked = true;
            this.radioButton_No.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton_No.Location = new System.Drawing.Point(325, 122);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(44, 20);
            this.radioButton_No.TabIndex = 8;
            this.radioButton_No.TabStop = true;
            this.radioButton_No.Text = "No";
            this.radioButton_No.UseVisualStyleBackColor = true;
            // 
            // Label_Route
            // 
            this.Label_Route.AutoSize = true;
            this.Label_Route.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label_Route.Location = new System.Drawing.Point(25, 175);
            this.Label_Route.Name = "Label_Route";
            this.Label_Route.Size = new System.Drawing.Size(109, 32);
            this.Label_Route.TabIndex = 9;
            this.Label_Route.Text = "Route /\r\nChemical Form";
            // 
            // comboBox_Route
            // 
            this.comboBox_Route.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Route.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_Route.FormattingEnabled = true;
            this.comboBox_Route.Location = new System.Drawing.Point(165, 177);
            this.comboBox_Route.Name = "comboBox_Route";
            this.comboBox_Route.Size = new System.Drawing.Size(280, 24);
            this.comboBox_Route.TabIndex = 10;
            // 
            // label_Commitment
            // 
            this.label_Commitment.AutoSize = true;
            this.label_Commitment.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_Commitment.Location = new System.Drawing.Point(25, 345);
            this.label_Commitment.Name = "label_Commitment";
            this.label_Commitment.Size = new System.Drawing.Size(142, 16);
            this.label_Commitment.TabIndex = 17;
            this.label_Commitment.Text = "Commitment Period";
            // 
            // textBox_Commitment
            // 
            this.textBox_Commitment.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_Commitment.Location = new System.Drawing.Point(196, 342);
            this.textBox_Commitment.Name = "textBox_Commitment";
            this.textBox_Commitment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Commitment.Size = new System.Drawing.Size(60, 23);
            this.textBox_Commitment.TabIndex = 18;
            this.textBox_Commitment.Text = "50";
            // 
            // comboBox_Commitment
            // 
            this.comboBox_Commitment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Commitment.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox_Commitment.FormattingEnabled = true;
            this.comboBox_Commitment.Items.AddRange(new object[] {
            "days",
            "months",
            "years"});
            this.comboBox_Commitment.Location = new System.Drawing.Point(315, 342);
            this.comboBox_Commitment.Name = "comboBox_Commitment";
            this.comboBox_Commitment.Size = new System.Drawing.Size(100, 24);
            this.comboBox_Commitment.TabIndex = 19;
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Start.Location = new System.Drawing.Point(305, 435);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(100, 40);
            this.button_Start.TabIndex = 20;
            this.button_Start.Text = "Run";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // label_OutPath
            // 
            this.label_OutPath.AutoSize = true;
            this.label_OutPath.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_OutPath.Location = new System.Drawing.Point(25, 15);
            this.label_OutPath.Name = "label_OutPath";
            this.label_OutPath.Size = new System.Drawing.Size(120, 16);
            this.label_OutPath.TabIndex = 1;
            this.label_OutPath.Text = "Output File Path";
            // 
            // textBox_OutPath
            // 
            this.textBox_OutPath.AllowDrop = true;
            this.textBox_OutPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_OutPath.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_OutPath.Location = new System.Drawing.Point(165, 12);
            this.textBox_OutPath.Name = "textBox_OutPath";
            this.textBox_OutPath.Size = new System.Drawing.Size(200, 23);
            this.textBox_OutPath.TabIndex = 2;
            this.textBox_OutPath.Text = "out\\";
            this.textBox_OutPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.OutputDragDrop);
            this.textBox_OutPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.MenuDragEnter);
            // 
            // button_OutPath
            // 
            this.button_OutPath.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_OutPath.Location = new System.Drawing.Point(370, 12);
            this.button_OutPath.Name = "button_OutPath";
            this.button_OutPath.Size = new System.Drawing.Size(75, 23);
            this.button_OutPath.TabIndex = 3;
            this.button_OutPath.Text = "Browse";
            this.button_OutPath.UseVisualStyleBackColor = true;
            this.button_OutPath.Click += new System.EventHandler(this.Button_Output_Click);
            // 
            // label_CalcMesh
            // 
            this.label_CalcMesh.AutoSize = true;
            this.label_CalcMesh.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_CalcMesh.Location = new System.Drawing.Point(25, 227);
            this.label_CalcMesh.Name = "label_CalcMesh";
            this.label_CalcMesh.Size = new System.Drawing.Size(82, 32);
            this.label_CalcMesh.TabIndex = 11;
            this.label_CalcMesh.Text = "Calculation\r\nTime Mesh";
            // 
            // textBox_CalcMesh
            // 
            this.textBox_CalcMesh.AllowDrop = true;
            this.textBox_CalcMesh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_CalcMesh.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_CalcMesh.Location = new System.Drawing.Point(165, 232);
            this.textBox_CalcMesh.Name = "textBox_CalcMesh";
            this.textBox_CalcMesh.Size = new System.Drawing.Size(200, 23);
            this.textBox_CalcMesh.TabIndex = 12;
            this.textBox_CalcMesh.Text = "lib\\time.dat";
            this.textBox_CalcMesh.DragDrop += new System.Windows.Forms.DragEventHandler(this.CalcMeshDragDrop);
            this.textBox_CalcMesh.DragEnter += new System.Windows.Forms.DragEventHandler(this.MenuDragEnter);
            // 
            // button_CalcMesh
            // 
            this.button_CalcMesh.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_CalcMesh.Location = new System.Drawing.Point(370, 232);
            this.button_CalcMesh.Name = "button_CalcMesh";
            this.button_CalcMesh.Size = new System.Drawing.Size(75, 23);
            this.button_CalcMesh.TabIndex = 13;
            this.button_CalcMesh.Text = "Browse";
            this.button_CalcMesh.UseVisualStyleBackColor = true;
            this.button_CalcMesh.Click += new System.EventHandler(this.Button_CalcMesh_Click);
            // 
            // label_OutMesh
            // 
            this.label_OutMesh.AutoSize = true;
            this.label_OutMesh.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_OutMesh.Location = new System.Drawing.Point(25, 280);
            this.label_OutMesh.Name = "label_OutMesh";
            this.label_OutMesh.Size = new System.Drawing.Size(80, 32);
            this.label_OutMesh.TabIndex = 14;
            this.label_OutMesh.Text = "Output\r\nTime Mesh";
            // 
            // textBox_OutMesh
            // 
            this.textBox_OutMesh.AllowDrop = true;
            this.textBox_OutMesh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_OutMesh.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_OutMesh.Location = new System.Drawing.Point(165, 287);
            this.textBox_OutMesh.Name = "textBox_OutMesh";
            this.textBox_OutMesh.Size = new System.Drawing.Size(200, 23);
            this.textBox_OutMesh.TabIndex = 15;
            this.textBox_OutMesh.Text = "lib\\out-time.dat";
            this.textBox_OutMesh.DragDrop += new System.Windows.Forms.DragEventHandler(this.OutMeshDragDrop);
            this.textBox_OutMesh.DragEnter += new System.Windows.Forms.DragEventHandler(this.MenuDragEnter);
            // 
            // button_OutMesh
            // 
            this.button_OutMesh.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_OutMesh.Location = new System.Drawing.Point(370, 287);
            this.button_OutMesh.Name = "button_OutMesh";
            this.button_OutMesh.Size = new System.Drawing.Size(75, 23);
            this.button_OutMesh.TabIndex = 16;
            this.button_OutMesh.Text = "Browse";
            this.button_OutMesh.UseVisualStyleBackColor = true;
            this.button_OutMesh.Click += new System.EventHandler(this.Button_OutMesh_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 510);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.comboBox_Nuclide);
            this.tabPage1.Controls.Add(this.button_OutMesh);
            this.tabPage1.Controls.Add(this.Label_Nuclide);
            this.tabPage1.Controls.Add(this.button_CalcMesh);
            this.tabPage1.Controls.Add(this.Label_Progeny);
            this.tabPage1.Controls.Add(this.textBox_OutMesh);
            this.tabPage1.Controls.Add(this.radioButton_Yes);
            this.tabPage1.Controls.Add(this.button_OutPath);
            this.tabPage1.Controls.Add(this.radioButton_No);
            this.tabPage1.Controls.Add(this.label_OutMesh);
            this.tabPage1.Controls.Add(this.Label_Route);
            this.tabPage1.Controls.Add(this.textBox_CalcMesh);
            this.tabPage1.Controls.Add(this.comboBox_Route);
            this.tabPage1.Controls.Add(this.label_CalcMesh);
            this.tabPage1.Controls.Add(this.label_Commitment);
            this.tabPage1.Controls.Add(this.textBox_OutPath);
            this.tabPage1.Controls.Add(this.textBox_Commitment);
            this.tabPage1.Controls.Add(this.label_OutPath);
            this.tabPage1.Controls.Add(this.comboBox_Commitment);
            this.tabPage1.Controls.Add(this.button_Start);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OIR";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.Age_EIR);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.Radionuclide_EIR);
            this.tabPage2.Controls.Add(this.btn_OutMesh_EIR);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_CalcMesh_EIR);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.OutMesh_EIR);
            this.tabPage2.Controls.Add(this.Progeny_EIR);
            this.tabPage2.Controls.Add(this.btn_OutPath_EIR);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.CalcMesh_EIR);
            this.tabPage2.Controls.Add(this.Route_EIR);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.OutputPath_EIR);
            this.tabPage2.Controls.Add(this.text_Commitment_EIR);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.combo_Commitment_EIR);
            this.tabPage2.Controls.Add(this.Button_start_EIR);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "EIR";
            // 
            // Age_EIR
            // 
            this.Age_EIR.BackColor = System.Drawing.SystemColors.Window;
            this.Age_EIR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Age_EIR.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Age_EIR.FormattingEnabled = true;
            this.Age_EIR.Items.AddRange(new object[] {
            "3months old",
            "1years old",
            "5years old",
            "10years old",
            "15years old",
            "Adult"});
            this.Age_EIR.Location = new System.Drawing.Point(165, 390);
            this.Age_EIR.Name = "Age_EIR";
            this.Age_EIR.Size = new System.Drawing.Size(121, 24);
            this.Age_EIR.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(25, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Intake Age";
            // 
            // Radionuclide_EIR
            // 
            this.Radionuclide_EIR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Radionuclide_EIR.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Radionuclide_EIR.FormattingEnabled = true;
            this.Radionuclide_EIR.Location = new System.Drawing.Point(165, 67);
            this.Radionuclide_EIR.Name = "Radionuclide_EIR";
            this.Radionuclide_EIR.Size = new System.Drawing.Size(280, 24);
            this.Radionuclide_EIR.TabIndex = 25;
            this.Radionuclide_EIR.SelectedIndexChanged += new System.EventHandler(this.Radionuclide_EIR_SelectedIndexChanged);
            // 
            // btn_OutMesh_EIR
            // 
            this.btn_OutMesh_EIR.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_OutMesh_EIR.Location = new System.Drawing.Point(370, 287);
            this.btn_OutMesh_EIR.Name = "btn_OutMesh_EIR";
            this.btn_OutMesh_EIR.Size = new System.Drawing.Size(75, 23);
            this.btn_OutMesh_EIR.TabIndex = 36;
            this.btn_OutMesh_EIR.Text = "Browse";
            this.btn_OutMesh_EIR.UseVisualStyleBackColor = true;
            this.btn_OutMesh_EIR.Click += new System.EventHandler(this.Btn_OutMesh_EIR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(25, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nuclide";
            // 
            // btn_CalcMesh_EIR
            // 
            this.btn_CalcMesh_EIR.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_CalcMesh_EIR.Location = new System.Drawing.Point(370, 232);
            this.btn_CalcMesh_EIR.Name = "btn_CalcMesh_EIR";
            this.btn_CalcMesh_EIR.Size = new System.Drawing.Size(75, 23);
            this.btn_CalcMesh_EIR.TabIndex = 33;
            this.btn_CalcMesh_EIR.Text = "Browse";
            this.btn_CalcMesh_EIR.UseVisualStyleBackColor = true;
            this.btn_CalcMesh_EIR.Click += new System.EventHandler(this.Btn_CalcMesh_EIR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "Application of \r\nProgeny Nuclide";
            // 
            // OutMesh_EIR
            // 
            this.OutMesh_EIR.AllowDrop = true;
            this.OutMesh_EIR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutMesh_EIR.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OutMesh_EIR.Location = new System.Drawing.Point(165, 287);
            this.OutMesh_EIR.Name = "OutMesh_EIR";
            this.OutMesh_EIR.Size = new System.Drawing.Size(200, 23);
            this.OutMesh_EIR.TabIndex = 35;
            this.OutMesh_EIR.Text = "lib\\out-time.dat";
            this.OutMesh_EIR.DragDrop += new System.Windows.Forms.DragEventHandler(this.OutMeshDragDrop_EIR);
            this.OutMesh_EIR.DragEnter += new System.Windows.Forms.DragEventHandler(this.MenuDragEnter);
            // 
            // Progeny_EIR
            // 
            this.Progeny_EIR.AutoSize = true;
            this.Progeny_EIR.Enabled = false;
            this.Progeny_EIR.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Progeny_EIR.Location = new System.Drawing.Point(235, 122);
            this.Progeny_EIR.Name = "Progeny_EIR";
            this.Progeny_EIR.Size = new System.Drawing.Size(50, 20);
            this.Progeny_EIR.TabIndex = 27;
            this.Progeny_EIR.Text = "Yes";
            this.Progeny_EIR.UseVisualStyleBackColor = true;
            // 
            // btn_OutPath_EIR
            // 
            this.btn_OutPath_EIR.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_OutPath_EIR.Location = new System.Drawing.Point(370, 12);
            this.btn_OutPath_EIR.Name = "btn_OutPath_EIR";
            this.btn_OutPath_EIR.Size = new System.Drawing.Size(75, 23);
            this.btn_OutPath_EIR.TabIndex = 23;
            this.btn_OutPath_EIR.Text = "Browse";
            this.btn_OutPath_EIR.UseVisualStyleBackColor = true;
            this.btn_OutPath_EIR.Click += new System.EventHandler(this.Btn_OutPath_EIR_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton2.Location = new System.Drawing.Point(325, 122);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 20);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(25, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 32);
            this.label3.TabIndex = 34;
            this.label3.Text = "Output\r\nTime Mesh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(25, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 32);
            this.label4.TabIndex = 29;
            this.label4.Text = "Route /\r\nChemical Form";
            // 
            // CalcMesh_EIR
            // 
            this.CalcMesh_EIR.AllowDrop = true;
            this.CalcMesh_EIR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CalcMesh_EIR.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CalcMesh_EIR.Location = new System.Drawing.Point(165, 232);
            this.CalcMesh_EIR.Name = "CalcMesh_EIR";
            this.CalcMesh_EIR.Size = new System.Drawing.Size(200, 23);
            this.CalcMesh_EIR.TabIndex = 32;
            this.CalcMesh_EIR.Text = "lib\\time.dat";
            this.CalcMesh_EIR.DragDrop += new System.Windows.Forms.DragEventHandler(this.CalcMeshDragDrop_EIR);
            this.CalcMesh_EIR.DragEnter += new System.Windows.Forms.DragEventHandler(this.MenuDragEnter);
            // 
            // Route_EIR
            // 
            this.Route_EIR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Route_EIR.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Route_EIR.FormattingEnabled = true;
            this.Route_EIR.Location = new System.Drawing.Point(165, 177);
            this.Route_EIR.Name = "Route_EIR";
            this.Route_EIR.Size = new System.Drawing.Size(280, 24);
            this.Route_EIR.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(25, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 32);
            this.label5.TabIndex = 31;
            this.label5.Text = "Calculation\r\nTime Mesh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(25, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Commitment Period";
            // 
            // OutputPath_EIR
            // 
            this.OutputPath_EIR.AllowDrop = true;
            this.OutputPath_EIR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputPath_EIR.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OutputPath_EIR.Location = new System.Drawing.Point(165, 12);
            this.OutputPath_EIR.Name = "OutputPath_EIR";
            this.OutputPath_EIR.Size = new System.Drawing.Size(200, 23);
            this.OutputPath_EIR.TabIndex = 22;
            this.OutputPath_EIR.Text = "out\\";
            this.OutputPath_EIR.DragDrop += new System.Windows.Forms.DragEventHandler(this.OutputDragDrop_EIR);
            this.OutputPath_EIR.DragEnter += new System.Windows.Forms.DragEventHandler(this.MenuDragEnter);
            // 
            // text_Commitment_EIR
            // 
            this.text_Commitment_EIR.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.text_Commitment_EIR.Location = new System.Drawing.Point(196, 342);
            this.text_Commitment_EIR.Name = "text_Commitment_EIR";
            this.text_Commitment_EIR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_Commitment_EIR.Size = new System.Drawing.Size(60, 23);
            this.text_Commitment_EIR.TabIndex = 38;
            this.text_Commitment_EIR.Text = "50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(25, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Output File Path";
            // 
            // combo_Commitment_EIR
            // 
            this.combo_Commitment_EIR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Commitment_EIR.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.combo_Commitment_EIR.FormattingEnabled = true;
            this.combo_Commitment_EIR.Items.AddRange(new object[] {
            "days",
            "months",
            "years"});
            this.combo_Commitment_EIR.Location = new System.Drawing.Point(315, 342);
            this.combo_Commitment_EIR.Name = "combo_Commitment_EIR";
            this.combo_Commitment_EIR.Size = new System.Drawing.Size(100, 24);
            this.combo_Commitment_EIR.TabIndex = 39;
            // 
            // Button_start_EIR
            // 
            this.Button_start_EIR.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_start_EIR.Location = new System.Drawing.Point(305, 435);
            this.Button_start_EIR.Name = "Button_start_EIR";
            this.Button_start_EIR.Size = new System.Drawing.Size(100, 40);
            this.Button_start_EIR.TabIndex = 41;
            this.Button_start_EIR.Text = "Run";
            this.Button_start_EIR.UseVisualStyleBackColor = true;
            this.Button_start_EIR.Click += new System.EventHandler(this.Button_start_EIR_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 521);
            this.Controls.Add(this.tabControl1);
            this.Name = "Menu";
            this.Text = "FlexID";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Label label_OutPath;
        private System.Windows.Forms.TextBox textBox_OutPath;
        private System.Windows.Forms.Button button_OutPath;
        private System.Windows.Forms.Label Label_Nuclide;
        private System.Windows.Forms.ComboBox comboBox_Nuclide;
        private System.Windows.Forms.Label Label_Progeny;
        private System.Windows.Forms.RadioButton radioButton_Yes;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.Label Label_Route;
        private System.Windows.Forms.ComboBox comboBox_Route;
        private System.Windows.Forms.Label label_CalcMesh;
        private System.Windows.Forms.TextBox textBox_CalcMesh;
        private System.Windows.Forms.Button button_CalcMesh;
        private System.Windows.Forms.Label label_OutMesh;
        private System.Windows.Forms.TextBox textBox_OutMesh;
        private System.Windows.Forms.Button button_OutMesh;
        private System.Windows.Forms.Label label_Commitment;
        private System.Windows.Forms.TextBox textBox_Commitment;
        private System.Windows.Forms.ComboBox comboBox_Commitment;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox Radionuclide_EIR;
        private System.Windows.Forms.Button btn_OutMesh_EIR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CalcMesh_EIR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutMesh_EIR;
        private System.Windows.Forms.RadioButton Progeny_EIR;
        private System.Windows.Forms.Button btn_OutPath_EIR;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CalcMesh_EIR;
        private System.Windows.Forms.ComboBox Route_EIR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OutputPath_EIR;
        private System.Windows.Forms.TextBox text_Commitment_EIR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo_Commitment_EIR;
        private System.Windows.Forms.Button Button_start_EIR;
        private System.Windows.Forms.ComboBox Age_EIR;
        private System.Windows.Forms.Label label8;
    }
}
