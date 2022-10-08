public class Pago
{

    public int id { get; set; }
    public Usuario usuario { get; set; }
    public string nombre { get; set; }
    public float monto { get; set; }
    public bool pagado { get; set; }
    public String metodo { get; set; }


    public Pago(int id, Usuario usuario, string nombre, float monto, bool pagado, String metodo)
    {

        this.id = id;
        this.usuario = usuario;
        this.nombre = nombre;
        this.monto = monto;
        this.pagado = false;
        this.metodo = metodo;


    }
}