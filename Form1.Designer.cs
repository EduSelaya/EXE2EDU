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
    private System.Windows.Forms.Button BtnAceptar;

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
        BtnAceptar = new System.Windows.Forms.Button();
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
        // BtnAceptar
        //
        BtnAceptar.Location = new System.Drawing.Point(195, 100);
        BtnAceptar.Name = "BtnAceptar";
        BtnAceptar.Size = new System.Drawing.Size(100, 30);
        BtnAceptar.TabIndex = 1;
        BtnAceptar.Text = "COMENZAR";
        BtnAceptar.UseVisualStyleBackColor = true;
        BtnAceptar.Click += new System.EventHandler(BtnAceptar_Click);
        //
        // Form1
        //
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(480, 200);
        Controls.Add(label1);
        Controls.Add(BtnAceptar);
        Name = "Form1";
        Text = "Realiza Una Copia De Archivos .EXE Con Extension .EDU";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
