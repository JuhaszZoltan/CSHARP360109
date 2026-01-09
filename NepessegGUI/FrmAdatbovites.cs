using System.Text;

namespace NepessegGUI
{
    public partial class FrmAdatbovites : Form
    {
        const string OutputPath = "..\\..\\..\\data\\ujadat.txt";

        public FrmAdatbovites()
        {
            InitializeComponent();
            btnKilepes.Click += BtnKilepesClick;
            btnMentes.Click += BtnMentesClick;
        }

        private void BtnMentesClick(object? sender, EventArgs e)
        {
            try
            {
                int nepesseg = int.Parse(txtNepesseg.Text);
                int fvLakossag = int.Parse(txtFovarosLakossag.Text);
                int terulet = int.Parse(txtTerulet.Text);

                if (fvLakossag > nepesseg)
                {
                    lblInfo.Text = "A fõváros lakossága nem lehet nagyobb a népességnél!";
                    txtFovarosLakossag.Text = $"{nepesseg}";
                    return;
                }

                using StreamWriter sw = new(OutputPath, true, Encoding.UTF8);
                sw.WriteLine($"{txtOrszagNev.Text};{terulet};{nepesseg};{txtFovaros.Text};{fvLakossag}");
                lblInfo.Text = "A mentés sikeres!";
            }
            catch(Exception)
            {
                lblInfo.Text = "nem megfelelõ számformûátum!";
            }
        }

        private void BtnKilepesClick(object? sender, EventArgs e) 
            => Application.Exit();
    }
}
