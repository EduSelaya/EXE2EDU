namespace CopyExeEdu_v1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button BtnExe2Edu;
    private System.Windows.Forms.Button BtnEdu2Exe;

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
        components = new System.ComponentModel.Container();
        label1 = new System.Windows.Forms.Label();
        BtnExe2Edu = new System.Windows.Forms.Button();
        BtnEdu2Exe = new System.Windows.Forms.Button();
        SuspendLayout();
        //
        // label1
        //
        label1.AutoSize = true;
        label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        label1.Location = new System.Drawing.Point(75, 50);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(350, 21);
        label1.TabIndex = 0;
        label1.Text = "Seleccione Carpeta para Renombrar Archivos";
        // 
        // BtnExe2Edu
        // 
        BtnExe2Edu.Location = new System.Drawing.Point(85, 100);
        BtnExe2Edu.Name = "BtnExe2Edu";
        BtnExe2Edu.Size = new System.Drawing.Size(100, 30);
        BtnExe2Edu.TabIndex = 1;
        BtnExe2Edu.Text = "EXE to EDU";
        BtnExe2Edu.UseVisualStyleBackColor = true;
        BtnExe2Edu.Click += new System.EventHandler(BtnExe2Edu_Click);
        // 
        // BtnEdu2Exe
        // 
        BtnEdu2Exe.Location = new System.Drawing.Point(295, 100);
        BtnEdu2Exe.Name = "BtnEdu2Exe";
        BtnEdu2Exe.Size = new System.Drawing.Size(100, 30);
        BtnEdu2Exe.TabIndex = 2;
        BtnEdu2Exe.Text = "EDU to EXE";
        BtnEdu2Exe.UseVisualStyleBackColor = true;
        BtnEdu2Exe.Click += new System.EventHandler(BtnEdu2Exe_Click);
        // 
        // Form1
        //
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(480, 200);
        StartPosition = FormStartPosition.CenterScreen;
        Controls.Add(label1);
        Controls.Add(BtnExe2Edu);
        Controls.Add(BtnEdu2Exe);
        Name = "Form1";
        Text = "Realiza Una Copia De Archivos .EXE Con Extension .EDU";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
