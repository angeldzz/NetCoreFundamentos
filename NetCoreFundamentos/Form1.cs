namespace NetCoreFundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {   
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //Solo Escribimis aqui
            Random random = new Random();
            this.txtNombre.Location = new Point(random.Next(100), random.Next(100));
            this.txtNombre.Width = 200;
            this.txtNombre.Height = 200;
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            this.txtNombre.BackColor = Color.Red;
            this.txtNombre.Text = "Soy un texto nuevo!!";
        }
    }
}
