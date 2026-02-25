namespace CopyExeEdu_v1
{
    public class CompletionForm : Form
    {
        private readonly Label _label;
        private readonly Button _btnVolverMenu;
        private readonly Button _btnSalir;

        public CompletionForm()
        {
            Text = "Completado";
            Width = 350;
            Height = 180;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            _label = new Label
            {
                Text = "Trabajo Completado",
                Left = 75,
                Top = 20,
                Width = 200,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            _btnVolverMenu = new Button
            {
                Text = "Volver al Menú",
                Left = 60,
                Top = 70,
                Width = 120,
                Height = 35
            };
            _btnVolverMenu.Click += (s, e) =>
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            _btnSalir = new Button
            {
                Text = "Salir",
                Left = 190,
                Top = 70,
                Width = 100,
                Height = 35
            };
            _btnSalir.Click += (s, e) =>
            {
                Application.Exit();
            };

            Controls.Add(_label);
            Controls.Add(_btnVolverMenu);
            Controls.Add(_btnSalir);
        }
    }
}
