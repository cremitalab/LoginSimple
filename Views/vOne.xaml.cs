namespace LoginSimple.Views;

public partial class vOne : ContentPage
{
	public vOne()
	{
		InitializeComponent();

	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
       

        for (int i = 0; i < App.usuarios.Count; i++)
        {
            if (App.usuarios[i] ==entryName.Text && entryClave.Text== App.claves[i])
            {
                Navigation.PushAsync(new Views.vTwo());
                return;
            }
        }
        DisplayAlert("error", "Contraseña o Clave Incorrecta", "Cancelar");
       
    }

    private void OnRegistrer (object sender ,EventArgs e)
    {
        Navigation.PushAsync(new Views.vThree());
    }
}