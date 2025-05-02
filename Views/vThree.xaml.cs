namespace LoginSimple.Views;

public partial class vThree : ContentPage
{
	public vThree()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(clave.Text)) {
			DisplayAlert("Error", "Porfavor complete todod los datos ", "Cancelar");
		}

		App.usuarios.Add(name.Text);
		App.claves.Add(clave.Text);

		DisplayAlert("Exitoso", "Regristro Correcto", "Cancelar");

		Navigation.PopAsync();


		
    }
}