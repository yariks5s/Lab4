using System.ComponentModel;

namespace Lab4;

partial class aboutForm
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
        this.okButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(82, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(527, 200);
        this.label1.TabIndex = 0;
        this.label1.Text = "This is the form for displaying and editing JSON files.\r\nAuthor is Yaroslav Briuk" + "hovetskyi\r\nHere you can: Upload your data, save it, save in different file, sear" + "ch by different criterias, edit data";
        // 
        // okButton
        // 
        this.okButton.BackColor = System.Drawing.SystemColors.HotTrack;
        this.okButton.ForeColor = System.Drawing.SystemColors.HighlightText;
        this.okButton.Location = new System.Drawing.Point(223, 280);
        this.okButton.Name = "okButton";
        this.okButton.Size = new System.Drawing.Size(204, 41);
        this.okButton.TabIndex = 1;
        this.okButton.Text = "OK";
        this.okButton.UseVisualStyleBackColor = false;
        this.okButton.Click += new System.EventHandler(this.okButton_Click);
        // 
        // aboutForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.okButton);
        this.Controls.Add(this.label1);
        this.Name = "aboutForm";
        this.Text = "aboutForm";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button okButton;

    #endregion
}