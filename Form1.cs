namespace CopyExeEdu_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExe2Edu_Click(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog();
            fbd.Description = "Selecciona la carpeta raíz donde buscar los archivos .EXE";
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string root = fbd.SelectedPath;
                this.Hide();
                var progressForm = new ProgressForm(root);
                progressForm.FormClosed += (s, args) =>
                {
                    var completionForm = new CompletionForm();
                    var result = completionForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.Show();
                    }
                    else
                    {
                        Application.Exit();
                    }
                };
                progressForm.ShowDialog();
            }
        }

        private void BtnEdu2Exe_Click(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog();
            fbd.Description = "Selecciona la carpeta raíz donde buscar los archivos .EXE.EDU";
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string root = fbd.SelectedPath;
                this.Hide();
                var progressForm = new ProgressFormReverse(root);
                progressForm.FormClosed += (s, args) =>
                {
                    var completionForm = new CompletionForm();
                    var result = completionForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.Show();
                    }
                    else
                    {
                        Application.Exit();
                    }
                };
                progressForm.ShowDialog();
            }
        }
    }
}
