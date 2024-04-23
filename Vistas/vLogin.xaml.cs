namespace danamiseExamen.Vistas;

public partial class vLogin : ContentPage
{

    string[,] usuarios = {
            {"estudiante2024", "uisrael2024"},
            {"examen1", "parcial1"},
            {"NombreEstudiante", "2024"} };

    public vLogin()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrase�a = txtContrasena.Text;

        bool credencialesCorrectas = false;

        // Verificar si las credenciales son correctas
        for (int i = 0; i < usuarios.GetLength(0); i++)
        {
            if (usuario == usuarios[i, 0] && contrase�a == usuarios[i, 1])
            {
                credencialesCorrectas = true;
                break;
            }
        }

        if (credencialesCorrectas)
        {
            // Abrir la siguiente ventana y enviar el nombre de usuario
            Navigation.PushAsync(new vRegistro(usuario));
        }
        else
        {
            // Mostrar notificaci�n de datos incorrectos
            DisplayAlert("Error", "Usuario o contrase�a incorrectos", "OK");
        }

    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {

    }

 
}