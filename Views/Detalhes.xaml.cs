using PDMI6_TP03.Models;

namespace PDMI6_TP03.Views;

public partial class Detalhes : ContentPage
{
	public Detalhes(Pacote pacoteEncontrado)
	{
		InitializeComponent();
		BindingContext = pacoteEncontrado;
	}
}