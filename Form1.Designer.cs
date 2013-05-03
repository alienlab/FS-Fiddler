namespace Alienlab.Tools.FSFiddler2
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.cmdClear = new System.Windows.Forms.Button();
      this.cbIncludeSubFolders = new System.Windows.Forms.CheckBox();
      this.txtFilter = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtPath = new System.Windows.Forms.TextBox();
      this.cmdStop = new System.Windows.Forms.Button();
      this.cmdStart = new System.Windows.Forms.Button();
      this.lbResults = new System.Windows.Forms.ListBox();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer1.IsSplitterFixed = true;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.cmdClear);
      this.splitContainer1.Panel1.Controls.Add(this.cbIncludeSubFolders);
      this.splitContainer1.Panel1.Controls.Add(this.txtFilter);
      this.splitContainer1.Panel1.Controls.Add(this.label2);
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      this.splitContainer1.Panel1.Controls.Add(this.txtPath);
      this.splitContainer1.Panel1.Controls.Add(this.cmdStop);
      this.splitContainer1.Panel1.Controls.Add(this.cmdStart);
      this.splitContainer1.Panel1MinSize = 30;
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.lbResults);
      this.splitContainer1.Size = new System.Drawing.Size(929, 473);
      this.splitContainer1.SplitterDistance = 46;
      this.splitContainer1.SplitterWidth = 1;
      this.splitContainer1.TabIndex = 0;
      // 
      // cmdClear
      // 
      this.cmdClear.Location = new System.Drawing.Point(840, 12);
      this.cmdClear.Name = "cmdClear";
      this.cmdClear.Size = new System.Drawing.Size(75, 23);
      this.cmdClear.TabIndex = 6;
      this.cmdClear.Text = "Clear";
      this.cmdClear.UseVisualStyleBackColor = true;
      this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
      // 
      // cbIncludeSubFolders
      // 
      this.cbIncludeSubFolders.AutoSize = true;
      this.cbIncludeSubFolders.Checked = true;
      this.cbIncludeSubFolders.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbIncludeSubFolders.Location = new System.Drawing.Point(426, 16);
      this.cbIncludeSubFolders.Name = "cbIncludeSubFolders";
      this.cbIncludeSubFolders.Size = new System.Drawing.Size(124, 17);
      this.cbIncludeSubFolders.TabIndex = 1;
      this.cbIncludeSubFolders.Text = "+ Include sub-folders";
      this.cbIncludeSubFolders.UseVisualStyleBackColor = true;
      // 
      // txtFilter
      // 
      this.txtFilter.Location = new System.Drawing.Point(594, 14);
      this.txtFilter.Name = "txtFilter";
      this.txtFilter.Size = new System.Drawing.Size(78, 20);
      this.txtFilter.TabIndex = 2;
      this.txtFilter.Text = "*";
      this.txtFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(556, 17);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Filter:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Folder:";
      // 
      // txtPath
      // 
      this.txtPath.Location = new System.Drawing.Point(57, 14);
      this.txtPath.Name = "txtPath";
      this.txtPath.Size = new System.Drawing.Size(362, 20);
      this.txtPath.TabIndex = 0;
      this.txtPath.Text = "C:\\";
      // 
      // cmdStop
      // 
      this.cmdStop.Enabled = false;
      this.cmdStop.Location = new System.Drawing.Point(759, 12);
      this.cmdStop.Name = "cmdStop";
      this.cmdStop.Size = new System.Drawing.Size(75, 23);
      this.cmdStop.TabIndex = 4;
      this.cmdStop.Text = "Stop";
      this.cmdStop.UseVisualStyleBackColor = true;
      this.cmdStop.Click += new System.EventHandler(this.button2_Click);
      // 
      // cmdStart
      // 
      this.cmdStart.Location = new System.Drawing.Point(678, 12);
      this.cmdStart.Name = "cmdStart";
      this.cmdStart.Size = new System.Drawing.Size(75, 23);
      this.cmdStart.TabIndex = 3;
      this.cmdStart.Text = "Start";
      this.cmdStart.UseVisualStyleBackColor = true;
      this.cmdStart.Click += new System.EventHandler(this.button1_Click);
      // 
      // lbResults
      // 
      this.lbResults.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbResults.FormattingEnabled = true;
      this.lbResults.Location = new System.Drawing.Point(0, 0);
      this.lbResults.Name = "lbResults";
      this.lbResults.Size = new System.Drawing.Size(929, 426);
      this.lbResults.TabIndex = 0;
      this.lbResults.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(929, 473);
      this.Controls.Add(this.splitContainer1);
      this.ForeColor = System.Drawing.Color.Black;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(945, 511);
      this.Name = "Form1";
      this.Text = "FS Fiddler2";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TextBox txtPath;
    private System.Windows.Forms.Button cmdStop;
    private System.Windows.Forms.Button cmdStart;
    private System.Windows.Forms.ListBox lbResults;
    private System.Windows.Forms.TextBox txtFilter;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox cbIncludeSubFolders;
    private System.Windows.Forms.Button cmdClear;
  }
}

