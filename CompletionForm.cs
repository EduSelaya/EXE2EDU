namespace CopyExeEdu_v1
{
    public class CompletionForm : Form
    {
        private readonly Label _label;

        public CompletionForm()
        {
            Text = "Completado";
            Width = 300;
            Height = 150;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            _label = new Label
            {
                Text = "Trabajo Completado",
                Left = 50,
                Top = 40,
                Width = 200,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            Controls.Add(_label);

            Shown += async (s, e) => await CloseAfterDelayAsync();
        }

        private async Task CloseAfterDelayAsync()
        {
            await Task.Delay(3000); // Wait 3 seconds
            Application.Exit(); // Close the entire application
        }
    }
}
