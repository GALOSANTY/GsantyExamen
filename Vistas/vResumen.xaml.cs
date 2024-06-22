namespace GsantyExamen.Vistas;

public partial class vResumen : ContentPage
{
    public vResumen(string nombre, string apellido, string edad, string fecha, string pais, string ciudad, string montoInicial, string pagoMensual)
    {
        InitializeComponent();


        lblNombre.Text = nombre;
        lblApellido.Text = apellido;
        lblEdad.Text = edad;
        lblFecha.Text = fecha;
        lblCiudad.Text = ciudad;
        lblPais.Text = pais;
        lblMontoInicial.Text = montoInicial;
        lblPagoMensual.Text = pagoMensual;
        

        

    }
}
