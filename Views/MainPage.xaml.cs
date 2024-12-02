using PDMI6_TP03.ViewModels;
using PDMI6_TP03.Views;

namespace PDMI6_TP03
{
    public partial class MainPage : ContentPage
    {
        ViewModel vm;
        public MainPage()
        {
            InitializeComponent();
            vm = new ViewModel(Navigation);
            this.BindingContext = vm;
        }
        public async void OnVerificarClicked(object sender, EventArgs e)
        {
            bool pacoteEncontrado = await vm.VerDetalhes(entryCodRastreio.Text, Navigation);

            if (!pacoteEncontrado)
            {
                await DisplayAlert("Aviso", "Pacote não encontrado. Verifique o código de rastreio", "OK");
            }
            entryCodRastreio.Text = "";
        }
        public async void OnCreditosClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Creditos());
        }
        public void OnTextChanged(object sender, EventArgs e)
        {
            if (entryCodRastreio.Text == "")
            {
                btnVerificar.IsEnabled = false;
            }
            else
            {
                btnVerificar.IsEnabled = true;
            }
        }
    }
}
