using WinFormsApp1;

public class Pago
{

    public int id { get; set; }
    public Usuario usuario { get; set; }
    public string nombre { get; set; }
    public double monto { get; set; }
    public bool pagado { get; set; }
    public TipoDePago metodo { get; set; }


    public Pago(int id, Usuario usuario, string nombre, float monto, TipoDePago metodo)
    {

        this.id = id;
        this.usuario = usuario;
        this.nombre = nombre;
        this.monto = monto;
        this.pagado = false;
        this.metodo = metodo;


    }

    public Pago(string nombre, double monto, TipoDePago pago) 
    {
        this.nombre = nombre;
        this.monto = monto;
        this.metodo = pago;


    }


    public enum TipoDePago { 
        
        EFECTIVO,
        CREDITO,
        DEBITO
    
    }
}
