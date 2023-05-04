using AppFactorial.Helpers;

namespace AppFactorial.Pages;

public partial class HomePage : ContentPage
{
    private readonly CalcularFatorial _calcularFatorial;
    public HomePage()
	{
		InitializeComponent();
		_calcularFatorial = new CalcularFatorial();
	}

    private void onClicKedCalcularButton(object sender, EventArgs e)
    {
		
        
        
        if (!string.IsNullOrEmpty(entryNumero.Text))
        {
            var numFatorial = int.Parse(entryNumero.Text);
            var resultFatorial = _calcularFatorial.Calcular(numFatorial);
            resultFatorialText.Text = $"Resultado: {resultFatorial}";

        }
        else
        {
            DisplayAlert("Erro", "Informe um número", "OK");
        }
	
    }
}