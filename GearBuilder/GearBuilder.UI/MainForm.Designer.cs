namespace GearBuilder.UI
{
	partial class MainForm
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
			this.m_InputGroupBox = new System.Windows.Forms.GroupBox();
			this.m_PinionCountTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.m_WheelCountTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.m_ModuleTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.m_CreateSVGButton = new System.Windows.Forms.Button();
			this.label19 = new System.Windows.Forms.Label();
			this.m_PitchDiameterPinionTextBox = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.m_PitchDiameterWheelTextBox = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.m_AddendumRadiusTextBox = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.m_AddendumTextBox = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.m_PracticalAddendumFactorTextBox = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.m_GearRatioTextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.m_DedendumTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.m_CirdularPitchTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.m_WheelHoleDiameterTextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.m_PinionHoleDiameterTextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.m_InputGroupBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_InputGroupBox
			// 
			this.m_InputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.m_InputGroupBox.Controls.Add(this.m_PinionHoleDiameterTextBox);
			this.m_InputGroupBox.Controls.Add(this.label11);
			this.m_InputGroupBox.Controls.Add(this.m_WheelHoleDiameterTextBox);
			this.m_InputGroupBox.Controls.Add(this.label9);
			this.m_InputGroupBox.Controls.Add(this.m_PinionCountTextBox);
			this.m_InputGroupBox.Controls.Add(this.label6);
			this.m_InputGroupBox.Controls.Add(this.m_WheelCountTextBox);
			this.m_InputGroupBox.Controls.Add(this.label4);
			this.m_InputGroupBox.Controls.Add(this.label2);
			this.m_InputGroupBox.Controls.Add(this.m_ModuleTextBox);
			this.m_InputGroupBox.Controls.Add(this.label1);
			this.m_InputGroupBox.Location = new System.Drawing.Point(12, 12);
			this.m_InputGroupBox.Name = "m_InputGroupBox";
			this.m_InputGroupBox.Size = new System.Drawing.Size(540, 96);
			this.m_InputGroupBox.TabIndex = 0;
			this.m_InputGroupBox.TabStop = false;
			this.m_InputGroupBox.Text = "Inputs";
			// 
			// m_PinionCountTextBox
			// 
			this.m_PinionCountTextBox.Location = new System.Drawing.Point(137, 65);
			this.m_PinionCountTextBox.Name = "m_PinionCountTextBox";
			this.m_PinionCountTextBox.Size = new System.Drawing.Size(100, 20);
			this.m_PinionCountTextBox.TabIndex = 7;
			this.m_PinionCountTextBox.Leave += new System.EventHandler(this.OnInputLeave);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 68);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(114, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Number of pinion teeth";
			// 
			// m_WheelCountTextBox
			// 
			this.m_WheelCountTextBox.Location = new System.Drawing.Point(137, 39);
			this.m_WheelCountTextBox.Name = "m_WheelCountTextBox";
			this.m_WheelCountTextBox.Size = new System.Drawing.Size(100, 20);
			this.m_WheelCountTextBox.TabIndex = 4;
			this.m_WheelCountTextBox.Leave += new System.EventHandler(this.OnInputLeave);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Number of wheel teeth";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(243, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "mm";
			// 
			// m_ModuleTextBox
			// 
			this.m_ModuleTextBox.Location = new System.Drawing.Point(137, 13);
			this.m_ModuleTextBox.Name = "m_ModuleTextBox";
			this.m_ModuleTextBox.Size = new System.Drawing.Size(100, 20);
			this.m_ModuleTextBox.TabIndex = 1;
			this.m_ModuleTextBox.Leave += new System.EventHandler(this.OnInputLeave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Module";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.m_CreateSVGButton);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.m_PitchDiameterPinionTextBox);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.m_PitchDiameterWheelTextBox);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.m_AddendumRadiusTextBox);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.m_AddendumTextBox);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.m_PracticalAddendumFactorTextBox);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.m_GearRatioTextBox);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.m_DedendumTextBox);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.m_CirdularPitchTextBox);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(12, 114);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(540, 227);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Outputs";
			// 
			// m_CreateSVGButton
			// 
			this.m_CreateSVGButton.Location = new System.Drawing.Point(459, 189);
			this.m_CreateSVGButton.Name = "m_CreateSVGButton";
			this.m_CreateSVGButton.Size = new System.Drawing.Size(75, 23);
			this.m_CreateSVGButton.TabIndex = 27;
			this.m_CreateSVGButton.Text = "SVG";
			this.m_CreateSVGButton.UseVisualStyleBackColor = true;
			this.m_CreateSVGButton.Click += new System.EventHandler(this.OnSVGButtonClick);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(243, 195);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(23, 13);
			this.label19.TabIndex = 26;
			this.label19.Text = "mm";
			// 
			// m_PitchDiameterPinionTextBox
			// 
			this.m_PitchDiameterPinionTextBox.Location = new System.Drawing.Point(137, 191);
			this.m_PitchDiameterPinionTextBox.Name = "m_PitchDiameterPinionTextBox";
			this.m_PitchDiameterPinionTextBox.Size = new System.Drawing.Size(100, 20);
			this.m_PitchDiameterPinionTextBox.TabIndex = 25;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(6, 194);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(117, 13);
			this.label20.TabIndex = 24;
			this.label20.Text = "Pitch diameter of pinion";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(243, 169);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(23, 13);
			this.label17.TabIndex = 23;
			this.label17.Text = "mm";
			// 
			// m_PitchDiameterWheelTextBox
			// 
			this.m_PitchDiameterWheelTextBox.Location = new System.Drawing.Point(137, 166);
			this.m_PitchDiameterWheelTextBox.Name = "m_PitchDiameterWheelTextBox";
			this.m_PitchDiameterWheelTextBox.Size = new System.Drawing.Size(100, 20);
			this.m_PitchDiameterWheelTextBox.TabIndex = 22;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(6, 169);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(117, 13);
			this.label18.TabIndex = 21;
			this.label18.Text = "Pitch diameter of wheel";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(243, 144);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(23, 13);
			this.label15.TabIndex = 20;
			this.label15.Text = "mm";
			// 
			// m_AddendumRadiusTextBox
			// 
			this.m_AddendumRadiusTextBox.Location = new System.Drawing.Point(137, 141);
			this.m_AddendumRadiusTextBox.Name = "m_AddendumRadiusTextBox";
			this.m_AddendumRadiusTextBox.Size = new System.Drawing.Size(100, 20);
			this.m_AddendumRadiusTextBox.TabIndex = 19;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(6, 144);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(89, 13);
			this.label16.TabIndex = 18;
			this.label16.Text = "Addendum radius";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(243, 119);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(23, 13);
			this.label13.TabIndex = 17;
			this.label13.Text = "mm";
			// 
			// m_AddendumTextBox
			// 
			this.m_AddendumTextBox.Location = new System.Drawing.Point(137, 116);
			this.m_AddendumTextBox.Name = "m_AddendumTextBox";
			this.m_AddendumTextBox.Size = new System.Drawing.Size(100, 20);
			this.m_AddendumTextBox.TabIndex = 16;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(6, 119);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(58, 13);
			this.label14.TabIndex = 15;
			this.label14.Text = "Addendum";
			// 
			// m_PracticalAddendumFactorTextBox
			// 
			this.m_PracticalAddendumFactorTextBox.Location = new System.Drawing.Point(137, 91);
			this.m_PracticalAddendumFactorTextBox.Name = "m_PracticalAddendumFactorTextBox";
			this.m_PracticalAddendumFactorTextBox.Size = new System.Drawing.Size(100, 20);
			this.m_PracticalAddendumFactorTextBox.TabIndex = 13;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 94);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(131, 13);
			this.label12.TabIndex = 12;
			this.label12.Text = "Practical addendum factor";
			// 
			// m_GearRatioTextBox
			// 
			this.m_GearRatioTextBox.Location = new System.Drawing.Point(137, 65);
			this.m_GearRatioTextBox.Name = "m_GearRatioTextBox";
			this.m_GearRatioTextBox.Size = new System.Drawing.Size(100, 20);
			this.m_GearRatioTextBox.TabIndex = 10;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 68);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(53, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "Gear ratio";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(243, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(23, 13);
			this.label7.TabIndex = 8;
			this.label7.Text = "mm";
			// 
			// m_DedendumTextBox
			// 
			this.m_DedendumTextBox.Location = new System.Drawing.Point(137, 39);
			this.m_DedendumTextBox.Name = "m_DedendumTextBox";
			this.m_DedendumTextBox.Size = new System.Drawing.Size(100, 20);
			this.m_DedendumTextBox.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 42);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Dedendum";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(243, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "mm";
			// 
			// m_CirdularPitchTextBox
			// 
			this.m_CirdularPitchTextBox.Location = new System.Drawing.Point(137, 13);
			this.m_CirdularPitchTextBox.Name = "m_CirdularPitchTextBox";
			this.m_CirdularPitchTextBox.Size = new System.Drawing.Size(100, 20);
			this.m_CirdularPitchTextBox.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Circular pitch";
			// 
			// m_WheelHoleDiameterTextBox
			// 
			this.m_WheelHoleDiameterTextBox.Location = new System.Drawing.Point(390, 39);
			this.m_WheelHoleDiameterTextBox.Name = "m_WheelHoleDiameterTextBox";
			this.m_WheelHoleDiameterTextBox.Size = new System.Drawing.Size(100, 20);
			this.m_WheelHoleDiameterTextBox.TabIndex = 9;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(259, 42);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(104, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Center hole diameter";
			// 
			// m_PinionHoleDiameterTextBox
			// 
			this.m_PinionHoleDiameterTextBox.Location = new System.Drawing.Point(390, 65);
			this.m_PinionHoleDiameterTextBox.Name = "m_PinionHoleDiameterTextBox";
			this.m_PinionHoleDiameterTextBox.Size = new System.Drawing.Size(100, 20);
			this.m_PinionHoleDiameterTextBox.TabIndex = 11;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(259, 68);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(104, 13);
			this.label11.TabIndex = 10;
			this.label11.Text = "Center hole diameter";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 353);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.m_InputGroupBox);
			this.Name = "MainForm";
			this.Text = "Cycloidal Gear Calculator";
			this.m_InputGroupBox.ResumeLayout(false);
			this.m_InputGroupBox.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox m_InputGroupBox;
		private System.Windows.Forms.TextBox m_PinionCountTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox m_WheelCountTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox m_ModuleTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox m_PitchDiameterPinionTextBox;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox m_PitchDiameterWheelTextBox;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox m_AddendumRadiusTextBox;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox m_AddendumTextBox;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox m_PracticalAddendumFactorTextBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox m_GearRatioTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox m_DedendumTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox m_CirdularPitchTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button m_CreateSVGButton;
		private System.Windows.Forms.TextBox m_PinionHoleDiameterTextBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox m_WheelHoleDiameterTextBox;
		private System.Windows.Forms.Label label9;
	}
}

