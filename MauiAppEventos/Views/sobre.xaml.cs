namespace MauiAppEventos.Views
{
    public partial class sobre : ContentPage
    {
        public sobre()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            try
            {

                App.Current.MainPage = new contratacaodahospedagem();

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");



            }
        }
    }
}