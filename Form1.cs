namespace CalculoMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnCalcMedia_Click(object sender, EventArgs e)
        {
            double NotaEx1, NotaEx2, NotaEnade, NotaPortfolio, NotaProva, Media;
            try
            {
                NotaEx1 = Convert.ToDouble(Exercicio1Nota.Text);
                NotaEx2 = Convert.ToDouble(Exercicio2Nota.Text);
                NotaEnade = Convert.ToDouble(EnadeNota.Text);
                NotaPortfolio = Convert.ToDouble(PorfolioNota.Text);
                NotaProva = Convert.ToDouble(ProvaNota.Text);

                if( (NotaEx1 < 0 || NotaEx1 > 10) ||
                    (NotaEx2 < 0 || NotaEx2 > 10) || 
                    (NotaEnade < 0 || NotaEnade > 10) ||
                    (NotaPortfolio < 0 || NotaPortfolio > 10) ||
                    (NotaProva < 0 || NotaProva > 10) )
                {
                    MessageBox.Show("A Nota só pode ser de 0 a 10", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    Media = (((NotaEx1 + NotaEx2) / 2) * 0.3) + (NotaEnade * 0.1) + (NotaPortfolio * 0.15) + (NotaProva * 0.45);

                    TxtMedia.Text = Media.ToString();

                    if (Media >= 6)
                    {

                        TxtSituacao.Text = "Aprovado";
                        TxtSituacao.ForeColor = Color.Green;
                    }

                    if (Media < 6)
                    {
                        TxtSituacao.Text = "Reprovado";
                        TxtSituacao.ForeColor = Color.Red;
                    }

                }

            } catch
            {
                MessageBox.Show("Ocorreu um erro ao calcular, verifica se todos os campos estão preenchidos ou se são númericos!", 
                                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnLimpaForm_Click(object sender, EventArgs e)
        {
            Exercicio1Nota.Text = "";
            Exercicio2Nota.Text = "";
            EnadeNota.Text = "";
            PorfolioNota.Text = "";
            ProvaNota.Text = "";
            TxtSituacao.Text = "-";
            TxtSituacao.ForeColor = Color.Black;
            TxtMedia.Text = "-";

        }
    }
}