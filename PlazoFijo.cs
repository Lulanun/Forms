public class PlazoFijo
{
    public int id { get; set; }
    public Usuario titular { get; set; }
    public float monto { get; set; }
    public DateTime fechaIni { get; set; }
    public DateTime fechaFin { get; set; }
    public float tasa { get; set; }
    public bool pagado { get; set; }


    public PlazoFijo(int id, Usuario titular, float monto, DateTime fechaIni, DateTime fechaFin, float tasa)
    {
        this.id = id;
        this.titular = titular;
        this.monto = monto;
        this.tasa = tasa;
        this.fechaIni = fechaIni;
        this.fechaFin = fechaFin;
        this.pagado = false;

    }










}