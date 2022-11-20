using System.ComponentModel;

namespace Lab4;

partial class AddData
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
        this.label1 = new System.Windows.Forms.Label();
        this.idTextBox = new System.Windows.Forms.TextBox();
        this.titleTextBox = new System.Windows.Forms.TextBox();
        this.addressTextBox = new System.Windows.Forms.TextBox();
        this.addDataTextButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label1.Location = new System.Drawing.Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(357, 73);
        this.label1.TabIndex = 0;
        this.label1.Text = "So you need to put your data here.";
        // 
        // idTextBox
        // 
        this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.idTextBox.Location = new System.Drawing.Point(18, 112);
        this.idTextBox.Name = "idTextBox";
        this.idTextBox.Size = new System.Drawing.Size(139, 22);
        this.idTextBox.TabIndex = 1;
        // 
        // titleTextBox
        // 
        this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.titleTextBox.Location = new System.Drawing.Point(200, 112);
        this.titleTextBox.Name = "titleTextBox";
        this.titleTextBox.Size = new System.Drawing.Size(139, 22);
        this.titleTextBox.TabIndex = 2;
        // 
        // addressTextBox
        // 
        this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.addressTextBox.Location = new System.Drawing.Point(378, 112);
        this.addressTextBox.Name = "addressTextBox";
        this.addressTextBox.Size = new System.Drawing.Size(139, 22);
        this.addressTextBox.TabIndex = 3;
        // 
        // addDataTextButton
        // 
        this.addDataTextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.addDataTextButton.Location = new System.Drawing.Point(170, 180);
        this.addDataTextButton.Name = "addDataTextButton";
        this.addDataTextButton.Size = new System.Drawing.Size(136, 42);
        this.addDataTextButton.TabIndex = 4;
        this.addDataTextButton.Text = "Done";
        this.addDataTextButton.UseVisualStyleBackColor = true;
        this.addDataTextButton.Click += new System.EventHandler(this.addDataTextButton_Click);
        // 
        // AddData
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(544, 330);
        this.Controls.Add(this.addDataTextButton);
        this.Controls.Add(this.addressTextBox);
        this.Controls.Add(this.titleTextBox);
        this.Controls.Add(this.idTextBox);
        this.Controls.Add(this.label1);
        this.Name = "AddData";
        this.Text = "addData";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button addDataTextButton;

    private System.Windows.Forms.TextBox idTextBox;
    private System.Windows.Forms.TextBox titleTextBox;
    private System.Windows.Forms.TextBox addressTextBox;

    private System.Windows.Forms.Label label1;

    #endregion
}