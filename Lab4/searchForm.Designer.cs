using System.ComponentModel;

namespace Lab4;

partial class SearchForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.searchByIdButton = new System.Windows.Forms.Button();
        this.searchByTitleButton = new System.Windows.Forms.Button();
        this.searchByAddressButton = new System.Windows.Forms.Button();
        this.searchTextBox = new System.Windows.Forms.TextBox();
        this.panel1 = new System.Windows.Forms.Panel();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.timer1 = new System.Timers.Timer();
        this.closeTableButton = new System.Windows.Forms.Button();
        this.deleteSelectedButton = new System.Windows.Forms.Button();
        this.changeSelectedButton = new System.Windows.Forms.Button();
        this.commitChangesButton = new System.Windows.Forms.Button();
        this.idTextBox = new System.Windows.Forms.TextBox();
        this.titleTextBox = new System.Windows.Forms.TextBox();
        this.addressTextBox = new System.Windows.Forms.TextBox();
        this.panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
        this.SuspendLayout();
        // 
        // searchByIdButton
        // 
        this.searchByIdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.searchByIdButton.Location = new System.Drawing.Point(33, 21);
        this.searchByIdButton.Name = "searchByIdButton";
        this.searchByIdButton.Size = new System.Drawing.Size(132, 26);
        this.searchByIdButton.TabIndex = 0;
        this.searchByIdButton.Text = "Search by id";
        this.searchByIdButton.UseVisualStyleBackColor = true;
        this.searchByIdButton.Click += new System.EventHandler(this.searchByIdButton_Click);
        // 
        // searchByTitleButton
        // 
        this.searchByTitleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.searchByTitleButton.Location = new System.Drawing.Point(221, 21);
        this.searchByTitleButton.Name = "searchByTitleButton";
        this.searchByTitleButton.Size = new System.Drawing.Size(132, 26);
        this.searchByTitleButton.TabIndex = 1;
        this.searchByTitleButton.Text = "Search by title";
        this.searchByTitleButton.UseVisualStyleBackColor = true;
        this.searchByTitleButton.Click += new System.EventHandler(this.searchByTitleButton_Click);
        // 
        // searchByAddressButton
        // 
        this.searchByAddressButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.searchByAddressButton.Location = new System.Drawing.Point(404, 21);
        this.searchByAddressButton.Name = "searchByAddressButton";
        this.searchByAddressButton.Size = new System.Drawing.Size(137, 26);
        this.searchByAddressButton.TabIndex = 2;
        this.searchByAddressButton.Text = "Search by address";
        this.searchByAddressButton.UseVisualStyleBackColor = true;
        this.searchByAddressButton.Click += new System.EventHandler(this.searchByAddressButton_Click);
        // 
        // searchTextBox
        // 
        this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.searchTextBox.Location = new System.Drawing.Point(34, 61);
        this.searchTextBox.Name = "searchTextBox";
        this.searchTextBox.Size = new System.Drawing.Size(146, 22);
        this.searchTextBox.TabIndex = 3;
        // 
        // panel1
        // 
        this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.panel1.Controls.Add(this.dataGridView1);
        this.panel1.Location = new System.Drawing.Point(33, 115);
        this.panel1.MaximumSize = new System.Drawing.Size(502, 201);
        this.panel1.MinimumSize = new System.Drawing.Size(502, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(502, 29);
        this.panel1.TabIndex = 4;
        // 
        // dataGridView1
        // 
        this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Id, this.Title, this.Address });
        this.dataGridView1.Location = new System.Drawing.Point(1, 30);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.RowTemplate.Height = 24;
        this.dataGridView1.Size = new System.Drawing.Size(501, 0);
        this.dataGridView1.TabIndex = 0;
        // 
        // Id
        // 
        this.Id.HeaderText = "Id";
        this.Id.Name = "Id";
        // 
        // Title
        // 
        this.Title.HeaderText = "Title";
        this.Title.Name = "Title";
        // 
        // Address
        // 
        this.Address.HeaderText = "Address";
        this.Address.Name = "Address";
        // 
        // timer1
        // 
        this.timer1.Enabled = true;
        this.timer1.Interval = 15D;
        this.timer1.SynchronizingObject = this;
        this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
        // 
        // closeTableButton
        // 
        this.closeTableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.closeTableButton.BackColor = System.Drawing.Color.White;
        this.closeTableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.closeTableButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
        this.closeTableButton.FlatAppearance.BorderSize = 0;
        this.closeTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.closeTableButton.Location = new System.Drawing.Point(547, 285);
        this.closeTableButton.Name = "closeTableButton";
        this.closeTableButton.Size = new System.Drawing.Size(91, 27);
        this.closeTableButton.TabIndex = 5;
        this.closeTableButton.Text = "Close table";
        this.closeTableButton.UseVisualStyleBackColor = false;
        this.closeTableButton.Click += new System.EventHandler(this.closeTableButton_Click);
        // 
        // deleteSelectedButton
        // 
        this.deleteSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.deleteSelectedButton.Location = new System.Drawing.Point(548, 229);
        this.deleteSelectedButton.Name = "deleteSelectedButton";
        this.deleteSelectedButton.Size = new System.Drawing.Size(90, 50);
        this.deleteSelectedButton.TabIndex = 6;
        this.deleteSelectedButton.Text = "Delete selected";
        this.deleteSelectedButton.UseVisualStyleBackColor = true;
        this.deleteSelectedButton.Click += new System.EventHandler(this.deleteSelectedButton_Click);
        // 
        // changeSelectedButton
        // 
        this.changeSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.changeSelectedButton.Location = new System.Drawing.Point(548, 173);
        this.changeSelectedButton.Name = "changeSelectedButton";
        this.changeSelectedButton.Size = new System.Drawing.Size(90, 50);
        this.changeSelectedButton.TabIndex = 7;
        this.changeSelectedButton.Text = "Change selected";
        this.changeSelectedButton.UseVisualStyleBackColor = true;
        this.changeSelectedButton.Click += new System.EventHandler(this.changeSelectedButton_Click);
        // 
        // commitChangesButton
        // 
        this.commitChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.commitChangesButton.Location = new System.Drawing.Point(548, 335);
        this.commitChangesButton.Name = "commitChangesButton";
        this.commitChangesButton.Size = new System.Drawing.Size(90, 50);
        this.commitChangesButton.TabIndex = 8;
        this.commitChangesButton.Text = "Change selected";
        this.commitChangesButton.UseVisualStyleBackColor = true;
        this.commitChangesButton.Visible = false;
        this.commitChangesButton.Click += new System.EventHandler(this.commitChangesButton_Click);
        // 
        // idTextBox
        // 
        this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.idTextBox.Location = new System.Drawing.Point(33, 363);
        this.idTextBox.Name = "idTextBox";
        this.idTextBox.Size = new System.Drawing.Size(146, 22);
        this.idTextBox.TabIndex = 9;
        this.idTextBox.Visible = false;
        // 
        // titleTextBox
        // 
        this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.titleTextBox.Location = new System.Drawing.Point(207, 363);
        this.titleTextBox.Name = "titleTextBox";
        this.titleTextBox.Size = new System.Drawing.Size(146, 22);
        this.titleTextBox.TabIndex = 10;
        this.titleTextBox.Visible = false;
        this.titleTextBox.WordWrap = false;
        // 
        // addressTextBox
        // 
        this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.addressTextBox.Location = new System.Drawing.Point(379, 363);
        this.addressTextBox.Name = "addressTextBox";
        this.addressTextBox.Size = new System.Drawing.Size(146, 22);
        this.addressTextBox.TabIndex = 11;
        this.addressTextBox.Visible = false;
        // 
        // SearchForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.Control;
        this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.addressTextBox);
        this.Controls.Add(this.titleTextBox);
        this.Controls.Add(this.idTextBox);
        this.Controls.Add(this.commitChangesButton);
        this.Controls.Add(this.changeSelectedButton);
        this.Controls.Add(this.deleteSelectedButton);
        this.Controls.Add(this.closeTableButton);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.searchTextBox);
        this.Controls.Add(this.searchByAddressButton);
        this.Controls.Add(this.searchByTitleButton);
        this.Controls.Add(this.searchByIdButton);
        this.ForeColor = System.Drawing.Color.Black;
        this.Location = new System.Drawing.Point(15, 15);
        this.Name = "SearchForm";
        this.panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button commitChangesButton;
    private System.Windows.Forms.TextBox idTextBox;
    private System.Windows.Forms.TextBox titleTextBox;
    private System.Windows.Forms.TextBox addressTextBox;

    private System.Windows.Forms.Button changeSelectedButton;

    private System.Windows.Forms.Button deleteSelectedButton;

    private System.Windows.Forms.Button closeTableButton;

    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn Title;
    private System.Windows.Forms.DataGridViewTextBoxColumn Address;

    private System.Timers.Timer timer1;

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.Button searchByIdButton;
    private System.Windows.Forms.Button searchByTitleButton;
    private System.Windows.Forms.Button searchByAddressButton;
    private System.Windows.Forms.TextBox searchTextBox;

    #endregion
}