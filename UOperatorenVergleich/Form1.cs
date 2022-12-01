namespace UOperatorenVergleich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            bool vergleich = false;

            if (12 - 3 >= 4 * 2.5) 
            { 
                vergleich = true;
            }
        
            LblAnzeige.Text = $"12 - 3 >= 4 * 2,5 is {vergleich}!";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            bool vergleich = false;

            if ("Mayer" != "Maier") vergleich = true;
            LblAnzeige.Text = $"Mayer != Maier is {vergleich}!";
        }

        private void CmdSchliessen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}