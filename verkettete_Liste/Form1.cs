namespace verkettete_Liste
{
    public partial class Form1 : Form
    {
        Zahlenspeicher zahlenspeicher = new Zahlenspeicher();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            zahlenspeicher.Add(Convert.ToInt32(NumberInputText.Text));
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            NumberOutputBox.Text = string.Join(", ", zahlenspeicher.Get());
        }
    }
}