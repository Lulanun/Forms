using WinFormsApp1;

public class Tarjeta
{

    public int id { get; set; }
    public Usuario titular { get; set; }
    public string numero { get; set; }
    public string codigoV { get; set; }
    public float limite { get; set; }
    public float consumos { get; set; }



    public Tarjeta(int id, Usuario titular, string numero, string codigoV, float limite, float consumos)
    {
        this.id = id;
        this.titular = titular;
        this.numero = numero;
        this.codigoV = codigoV;
        this.limite = limite;
        this.consumos = consumos;

    }
}