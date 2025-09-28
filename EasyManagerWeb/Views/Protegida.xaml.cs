namespace EasyManagerWeb.Views;

public partial class Protegida : ContentPage
{
    private bool clicouMenu = false; // Para controlar se o usu�rio clicou

    public Protegida()
    {
        InitializeComponent();

        // Carrega o usu�rio logado
        Task.Run(async () =>
        {
            string? usuario_logado = await SecureStorage.Default.GetAsync("usuario_logado");
            MainThread.BeginInvokeOnMainThread(() =>
            {
                lbl_boasvindas.Text = $"Bem-Vindo(a) {usuario_logado}";
            });
        });

        // Inicia o timer de 10 segundos para desconectar automaticamente
        AutoLogout();
    }

    private async void AutoLogout()
    {
        await Task.Delay(10000); // espera 10 segundos

        if (!clicouMenu)
        {
            // Redireciona para login automaticamente
            App.Current.MainPage = new Login();
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        clicouMenu = true; // usu�rio clicou no bot�o

        // Redireciona para a p�gina principal
        App.Current.MainPage = new MainPage(); // <- substitua pelo seu menu principal
    }
}