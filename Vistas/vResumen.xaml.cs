using static danamiseExamen.Vistas.vRegistro;

namespace danamiseExamen.Vistas;

public partial class vResumen : ContentPage
{
    private Estudiante estudiante;

    public vResumen(Estudiante estudiante)
	{
		InitializeComponent();
        this.estudiante = estudiante;
        MostrarResumen();
    }

    private void MostrarResumen()
    {
        // Mostrar la información del estudiante en la interfaz de usuario
        labelNombre.Text = estudiante.Nombre;
        labelApellido.Text = estudiante.Apellido;
        labelEdad.Text = estudiante.Edad.ToString();
        labelFecha.Text = estudiante.Fecha.ToShortDateString();
        labelPais.Text = estudiante.Pais;
        labelCiudad.Text = estudiante.Ciudad;
        labelMontoInicial.Text = estudiante.MontoInicial.ToString("0.00");
        labelPagoMensual.Text = estudiante.PagoMensual.ToString("0.00");
        labelPagoTotal.Text = (estudiante.MontoInicial + (estudiante.PagoMensual * 3)).ToString("0.00");
    }
}