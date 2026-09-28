namespace CalculadoraVertice
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalcularClicked(object sender, EventArgs e)
        {
            string valorA = txtA.Text;
            string valorB = txtB.Text;
            string valorC = txtC.Text;

            bool AConvert = double.TryParse(valorA, out double a);
            bool BConvert = double.TryParse(valorB, out double b);
            bool CConvert = double.TryParse(valorC, out double c);

            if (AConvert && BConvert && CConvert)
            {
                if (a == 0)
                {
                    DisplayAlert("Atenção", "O valor de A não pode ser zero.", "OK");
                    return;
                }

                double resulDelta = (b * b) - (4 * a * c);

                double VerticeX = -b / (2 * a);
                double VerticeY = -resulDelta / (4 * a);

                
                if (VerticeX == 0) VerticeX = 0;
                if (VerticeY == 0) VerticeY = 0;

                
                string Xformatado = VerticeX.ToString("+0.####;-0.####;0", System.Globalization.CultureInfo.InvariantCulture);
                string Yformatado = VerticeY.ToString("+0.####;-0.####;0", System.Globalization.CultureInfo.InvariantCulture);
                

                
                string xFracao = ConverterParaFracao(VerticeX);
                string yFracao = ConverterParaFracao(VerticeY);

                borderResultado.IsVisible = true;
                borderDelta.IsVisible = true;
                lblResultado.Text = $"Fração: ({xFracao}; {yFracao})\nDecimal: ({Xformatado}; {Yformatado})";
                lblDelta.Text = $"Delta: ({resulDelta})";
            }
            else
            {
                DisplayAlert("Erro", "Por favor, digite valores numéricos válidos.", "OK");
                return;
            }
        }

        private string ConverterParaFracao(double numero)
        {
            if (numero == 0) return "0";

            
            if (numero % 1 == 0) return numero.ToString("+0;-0;0");

            bool ehNegativo = numero < 0;
            double valAbsoluto = Math.Abs(numero);

            double tolerancia = 1.0E-6;
            double h1 = 1, h2 = 0;
            double k1 = 0, k2 = 1;
            double b = valAbsoluto;

            do
            {
                double a = Math.Floor(b);
                double auxH = h1;
                h1 = a * h1 + h2;
                h2 = auxH;

                double auxK = k1;
                k1 = a * k1 + k2;
                k2 = auxK;

                double diferenca = b - a;
                if (diferenca < tolerancia) break;

                b = 1.0 / diferenca;
            } while (Math.Abs(valAbsoluto - h1 / k1) > tolerancia);

            long numerador = (long)h1;
            long denominador = (long)k1;

            if (ehNegativo)
            {
                numerador = -numerador;
            }

            string sinal = numerador > 0 ? "+" : "";
            return $"{sinal}{numerador}/{denominador}";
        }
    }
}