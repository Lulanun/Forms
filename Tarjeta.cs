using WinFormsApp1;

public class Tarjeta
{

    public int id { get; set; }
    public Usuario titular { get; set; }
    public int numero { get; set; }
    public int codigoV { get; set; }
    public float limite { get; set; }
    public float consumos { get; set; }



    public Tarjeta(int id, Usuario titular, int numero, int codigoV, float limite, float consumos)
    {
        this.id = id;
        this.titular = titular;
        this.numero = numero;
        this.codigoV = codigoV;
        this.limite = limite;
        this.consumos = consumos;

    }
}