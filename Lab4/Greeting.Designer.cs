using System.ComponentModel;

namespace Lab4;

partial class Greeting
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
        this.chooseFileButton = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.commonFileButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // chooseFileButton
        // 
        this.chooseFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.chooseFileButton.Location = new System.Drawing.Point(234, 249);
        this.chooseFileButton.Name = "chooseFileButton";
        this.chooseFileButton.Size = new System.Drawing.Size(327, 61);
        this.chooseFileButton.TabIndex = 0;
        this.chooseFileButton.Text = "Choose File\r\n";
        this.chooseFileButton.UseVisualStyleBackColor = true;
        this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(182, 85);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(461, 98);
        this.label1.TabIndex = 1;
        this.label1.Text = "Hi! To start working I need a file from you :)";
        // 
        // commonFileButton
        // 
        this.commonFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.commonFileButton.Location = new System.Drawing.Point(234, 316);
        this.commonFileButton.Name = "commonFileButton";
        this.commonFileButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        this.commonFileButton.Size = new System.Drawing.Size(327, 61);
        this.commonFileButton.TabIndex = 2;
        this.commonFileButton.Text = "Common File";
        this.commonFileButton.UseVisualStyleBackColor = true;
        this.commonFileButton.Click += new System.EventHandler(this.commonFileButton_Click);
        // 
        // Greeting
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.commonFileButton);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.chooseFileButton);
        this.Name = "Greeting";
        this.Text = "Greeting";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button commonFileButton;

    private System.Windows.Forms.Button chooseFileButton;
    private System.Windows.Forms.Label label1;

    #endregion
}