using Bunifu.Framework.UI;
using Bunifu.Utils;
namespace Lab4
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
        this.comboBox1 = new System.Windows.Forms.ComboBox();
        this.AddData = new System.Windows.Forms.Button();
        this.AboutButton = new System.Windows.Forms.Button();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.menuPanel = new System.Windows.Forms.Panel();
        this.saveAsButton = new System.Windows.Forms.Button();
        this.openButton = new System.Windows.Forms.Button();
        this.saveButton = new System.Windows.Forms.Button();
        this.searchButton = new System.Windows.Forms.Button();
        this.timer1 = new System.Timers.Timer();
        this.menuButton = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.menuPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
        this.SuspendLayout();
        // 
        // comboBox1
        // 
        this.comboBox1.FormattingEnabled = true;
        this.comboBox1.Location = new System.Drawing.Point(0, 0);
        this.comboBox1.Name = "comboBox1";
        this.comboBox1.Size = new System.Drawing.Size(121, 25);
        this.comboBox1.TabIndex = 0;
        // 
        // AddData
        // 
        this.AddData.BackColor = System.Drawing.SystemColors.HotTrack;
        this.AddData.ForeColor = System.Drawing.SystemColors.ButtonFace;
        this.AddData.Location = new System.Drawing.Point(126, 0);
        this.AddData.Name = "AddData";
        this.AddData.Size = new System.Drawing.Size(120, 32);
        this.AddData.TabIndex = 0;
        this.AddData.Text = "Add data";
        this.AddData.UseVisualStyleBackColor = false;
        this.AddData.Click += new System.EventHandler(this.AddData_Click);
        // 
        // AboutButton
        // 
        this.AboutButton.BackColor = System.Drawing.SystemColors.HotTrack;
        this.AboutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
        this.AboutButton.Location = new System.Drawing.Point(252, 0);
        this.AboutButton.Name = "AboutButton";
        this.AboutButton.Size = new System.Drawing.Size(120, 32);
        this.AboutButton.TabIndex = 2;
        this.AboutButton.Text = "About";
        this.AboutButton.UseVisualStyleBackColor = false;
        this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
        // 
        // dataGridView1
        // 
        this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
        this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.id, this.name, this.address });
        this.dataGridView1.GridColor = System.Drawing.SystemColors.Info;
        this.dataGridView1.Location = new System.Drawing.Point(0, 108);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
        this.dataGridView1.RowTemplate.Height = 24;
        this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
        this.dataGridView1.Size = new System.Drawing.Size(400, 266);
        this.dataGridView1.StandardTab = true;
        this.dataGridView1.TabIndex = 3;
        // 
        // id
        // 
        this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        this.id.HeaderText = "Id";
        this.id.Name = "id";
        // 
        // name
        // 
        this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        this.name.HeaderText = "Title";
        this.name.Name = "name";
        // 
        // address
        // 
        this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        this.address.HeaderText = "Address";
        this.address.Name = "address";
        // 
        // menuPanel
        // 
        this.menuPanel.BackColor = System.Drawing.Color.Gainsboro;
        this.menuPanel.Controls.Add(this.saveAsButton);
        this.menuPanel.Controls.Add(this.openButton);
        this.menuPanel.Controls.Add(this.saveButton);
        this.menuPanel.Location = new System.Drawing.Point(0, 0);
        this.menuPanel.MaximumSize = new System.Drawing.Size(120, 106);
        this.menuPanel.MinimumSize = new System.Drawing.Size(120, 32);
        this.menuPanel.Name = "menuPanel";
        this.menuPanel.Size = new System.Drawing.Size(120, 106);
        this.menuPanel.TabIndex = 6;
        // 
        // saveAsButton
        // 
        this.saveAsButton.BackColor = System.Drawing.SystemColors.HotTrack;
        this.saveAsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
        this.saveAsButton.Location = new System.Drawing.Point(-1, 54);
        this.saveAsButton.Name = "saveAsButton";
        this.saveAsButton.Size = new System.Drawing.Size(121, 28);
        this.saveAsButton.TabIndex = 9;
        this.saveAsButton.Text = "Save as";
        this.saveAsButton.UseVisualStyleBackColor = false;
        this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click_1);
        // 
        // openButton
        // 
        this.openButton.BackColor = System.Drawing.SystemColors.HotTrack;
        this.openButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
        this.openButton.Location = new System.Drawing.Point(-1, 28);
        this.openButton.Name = "openButton";
        this.openButton.Size = new System.Drawing.Size(121, 30);
        this.openButton.TabIndex = 8;
        this.openButton.Text = "Open";
        this.openButton.UseVisualStyleBackColor = false;
        this.openButton.Click += new System.EventHandler(this.openButton_Click);
        // 
        // saveButton
        // 
        this.saveButton.BackColor = System.Drawing.SystemColors.HotTrack;
        this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
        this.saveButton.Location = new System.Drawing.Point(-1, 80);
        this.saveButton.Name = "saveButton";
        this.saveButton.Size = new System.Drawing.Size(121, 26);
        this.saveButton.TabIndex = 8;
        this.saveButton.Text = "Save";
        this.saveButton.UseVisualStyleBackColor = false;
        this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
        // 
        // searchButton
        // 
        this.searchButton.BackColor = System.Drawing.SystemColors.HotTrack;
        this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
        this.searchButton.Location = new System.Drawing.Point(390, 0);
        this.searchButton.Name = "searchButton";
        this.searchButton.Size = new System.Drawing.Size(121, 32);
        this.searchButton.TabIndex = 10;
        this.searchButton.Text = "Search";
        this.searchButton.UseVisualStyleBackColor = false;
        this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
        // 
        // timer1
        // 
        this.timer1.Enabled = true;
        this.timer1.Interval = 15D;
        this.timer1.SynchronizingObject = this;
        this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
        // 
        // menuButton
        // 
        this.menuButton.BackColor = System.Drawing.SystemColors.HotTrack;
        this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
        this.menuButton.FlatAppearance.BorderSize = 0;
        this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.menuButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
        this.menuButton.Location = new System.Drawing.Point(0, 0);
        this.menuButton.Name = "menuButton";
        this.menuButton.Size = new System.Drawing.Size(121, 31);
        this.menuButton.TabIndex = 7;
        this.menuButton.Text = "Menu";
        this.menuButton.UseVisualStyleBackColor = false;
        this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoSize = true;
        this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.BackColor = System.Drawing.Color.FloralWhite;
        this.ClientSize = new System.Drawing.Size(800, 509);
        this.Controls.Add(this.searchButton);
        this.Controls.Add(this.menuButton);
        this.Controls.Add(this.menuPanel);
        this.Controls.Add(this.dataGridView1);
        this.Controls.Add(this.AboutButton);
        this.Controls.Add(this.AddData);
        this.Location = new System.Drawing.Point(15, 15);
        this.Name = "Form1";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.menuPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button searchButton;

    private System.Windows.Forms.Button saveButton;

    private System.Windows.Forms.Button saveAsButton;

    private System.Windows.Forms.Button openButton;

    private System.Windows.Forms.DataGridViewTextBoxColumn address;

    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn name;

    private System.Timers.Timer timer1;
    private System.Windows.Forms.Button menuButton;

    private System.Windows.Forms.Panel menuPanel;

    private System.Windows.Forms.ComboBox comboBox1;


    private System.Windows.Forms.Button AboutButton;
    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.Button AddData;

    #endregion

    }
}