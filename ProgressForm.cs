namespace CopyExeEdu_v1
{
    public class ProgressForm : Form
    {
        private readonly string _root;
        private readonly ProgressBar _progress;
        private readonly Label _status;
        private readonly Button _btnClose;

        public ProgressForm(string root)
        {
            _root = root;
            Text = "Copiar .EXE -> .EXE.EDU";
            Width = 500;
            Height = 140;
            StartPosition = FormStartPosition.CenterScreen;

            _status = new Label { Left = 10, Top = 10, Width = 460, Text = "Iniciando..." };
            _progress = new ProgressBar { Left = 10, Top = 35, Width = 460, Style = ProgressBarStyle.Continuous };
            _btnClose = new Button { Left = 380, Top = 70, Width = 90, Text = "Cerrar", Enabled = false };
            _btnClose.Click += (s, e) => Close();

            Controls.Add(_status);
            Controls.Add(_progress);
            Controls.Add(_btnClose);

            Shown += async (s, e) => await RunCopyAsync();
        }

        private async Task RunCopyAsync()
        {
            try
            {
                _status.Text = "Buscando archivos .EXE...";
                string[] files = Directory.GetFiles(_root, "*.exe", SearchOption.AllDirectories);
                int total = files.Length;
                if (total == 0)
                {
                    _status.Text = "No se encontraron archivos .EXE.";
                    _btnClose.Enabled = true;
                    return;
                }

                _progress.Maximum = total;
                int count = 0;
                foreach (var file in files)
                {
                    try
                    {
                        string dest = file + ".edu";
                        // copy with overwrite
                        File.Copy(file, dest, true);
                    }
                    catch (Exception exFile)
                    {
                        // opcional: registrar error, aquí solo se muestra en el status
                        Console.Error.WriteLine($"Error copiando '{file}': {exFile.Message}");
                    }

                    count++;
                    _progress.Value = Math.Min(count, _progress.Maximum);
                    _status.Text = $"Procesados {count} de {total} archivos.";
                    // allow UI to update
                    await Task.Delay(1);
                }

                _status.Text = $"Completado: {count} archivos procesados.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _status.Text = "Error durante el proceso.";
            }
            finally
            {
                _btnClose.Enabled = true;
            }
        }
    }
}
