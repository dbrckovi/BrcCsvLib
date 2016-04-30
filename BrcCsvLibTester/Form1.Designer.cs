namespace BrcCsvLibTester
{
  partial class Form1
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
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.panel2 = new System.Windows.Forms.Panel();
      this.dataSave = new System.Windows.Forms.DataGridView();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.panel1 = new System.Windows.Forms.Panel();
      this.dataLoad = new System.Windows.Forms.DataGridView();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.btnSave = new System.Windows.Forms.Button();
      this.chkSave_IncludeHeader = new System.Windows.Forms.CheckBox();
      this.lblSave_Separator = new System.Windows.Forms.Label();
      this.cmbSave_Separator = new System.Windows.Forms.ComboBox();
      this.chkSave_AddQuotes = new System.Windows.Forms.CheckBox();
      this.tabPage2.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataSave)).BeginInit();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataLoad)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.dataSave);
      this.tabPage2.Controls.Add(this.panel2);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(958, 578);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Saving";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.chkSave_AddQuotes);
      this.panel2.Controls.Add(this.cmbSave_Separator);
      this.panel2.Controls.Add(this.lblSave_Separator);
      this.panel2.Controls.Add(this.chkSave_IncludeHeader);
      this.panel2.Controls.Add(this.btnSave);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(3, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(952, 37);
      this.panel2.TabIndex = 2;
      // 
      // dataSave
      // 
      this.dataSave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataSave.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataSave.Location = new System.Drawing.Point(3, 40);
      this.dataSave.Name = "dataSave";
      this.dataSave.Size = new System.Drawing.Size(952, 535);
      this.dataSave.TabIndex = 1;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.dataLoad);
      this.tabPage1.Controls.Add(this.panel1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(958, 578);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Loading";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(952, 56);
      this.panel1.TabIndex = 1;
      // 
      // dataLoad
      // 
      this.dataLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataLoad.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataLoad.Location = new System.Drawing.Point(3, 59);
      this.dataLoad.Name = "dataLoad";
      this.dataLoad.Size = new System.Drawing.Size(952, 516);
      this.dataLoad.TabIndex = 0;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(966, 604);
      this.tabControl1.TabIndex = 1;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(416, 8);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(80, 24);
      this.btnSave.TabIndex = 0;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // chkSave_IncludeHeader
      // 
      this.chkSave_IncludeHeader.AutoSize = true;
      this.chkSave_IncludeHeader.Location = new System.Drawing.Point(192, 8);
      this.chkSave_IncludeHeader.Name = "chkSave_IncludeHeader";
      this.chkSave_IncludeHeader.Size = new System.Drawing.Size(116, 17);
      this.chkSave_IncludeHeader.TabIndex = 1;
      this.chkSave_IncludeHeader.Text = "Include header line";
      this.chkSave_IncludeHeader.UseVisualStyleBackColor = true;
      // 
      // lblSave_Separator
      // 
      this.lblSave_Separator.AutoSize = true;
      this.lblSave_Separator.Location = new System.Drawing.Point(8, 8);
      this.lblSave_Separator.Name = "lblSave_Separator";
      this.lblSave_Separator.Size = new System.Drawing.Size(53, 13);
      this.lblSave_Separator.TabIndex = 2;
      this.lblSave_Separator.Text = "Separator";
      // 
      // cmbSave_Separator
      // 
      this.cmbSave_Separator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSave_Separator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.cmbSave_Separator.FormattingEnabled = true;
      this.cmbSave_Separator.Items.AddRange(new object[] {
            ";",
            ","});
      this.cmbSave_Separator.Location = new System.Drawing.Point(64, 8);
      this.cmbSave_Separator.Name = "cmbSave_Separator";
      this.cmbSave_Separator.Size = new System.Drawing.Size(32, 21);
      this.cmbSave_Separator.TabIndex = 3;
      // 
      // chkSave_AddQuotes
      // 
      this.chkSave_AddQuotes.AutoSize = true;
      this.chkSave_AddQuotes.Location = new System.Drawing.Point(320, 8);
      this.chkSave_AddQuotes.Name = "chkSave_AddQuotes";
      this.chkSave_AddQuotes.Size = new System.Drawing.Size(80, 17);
      this.chkSave_AddQuotes.TabIndex = 4;
      this.chkSave_AddQuotes.Text = "Add quotes";
      this.chkSave_AddQuotes.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(966, 604);
      this.Controls.Add(this.tabControl1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.tabPage2.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataSave)).EndInit();
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataLoad)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.DataGridView dataSave;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.DataGridView dataLoad;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.CheckBox chkSave_IncludeHeader;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Label lblSave_Separator;
    private System.Windows.Forms.ComboBox cmbSave_Separator;
    private System.Windows.Forms.CheckBox chkSave_AddQuotes;
  }
}

