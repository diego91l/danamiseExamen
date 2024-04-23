namespace danamiseExamen.Vistas;

public partial class vRegistro : ContentPage
{
    private const double costoCurso = 3000;
    private const int numeroCuotas = 3;
    private const double porcentajeIncremento = 0.05;

    public vRegistro(string usuario)
	{
		InitializeComponent();
        DisplayAlert("Bienvenido", usuario, "Cerrar");
        lblUsuario.Text = "Usuario conectado: " + usuario;
    }

    private void btnCalcularPM_Clicked(object sender, EventArgs e)
    {
        double montoInicial;
        if (!double.TryParse(txtMontoinicial.Text, out montoInicial))
        {
            DisplayAlert("Error", "Por favor ingrese un monto inicial válido.", "OK");
            return;
        }

        // Calcular el monto de cada cuota
        double montoRestante = costoCurso - montoInicial;
        double montoPorCuota = montoRestante / numeroCuotas;

        // Aplicar el incremento del 5% a cada cuota
        double montoIncrementado = montoPorCuota * (1 + porcentajeIncremento);

        // Mostrar el monto mensual en el campo correspondiente
        txtPagoMensual.Text = montoIncrementado.ToString("0.00");
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        Estudiante estudiante = new Estudiante
        {
            Nombre = txtNombre.Text,
            Apellido = txtApellido.Text,
            Edad = Convert.ToInt32(txtEdad.Text),
            Fecha = pkFecha.Date,
            Pais = pkPais.SelectedItem.ToString(),
            Ciudad = pkCiudad.SelectedItem.ToString(),
            MontoInicial = Convert.ToDouble(txtMontoinicial.Text),
            PagoMensual = Convert.ToDouble(txtPagoMensual.Text)
        };

        // Abrir la ventana de resumen y pasar el objeto estudiante como parámetro
        Navigation.PushAsync(new vResumen(estudiante));
    }

    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public DateTime Fecha { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public double MontoInicial { get; set; }
        public double PagoMensual { get; set; }
    }
}