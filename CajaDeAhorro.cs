using WinFormsApp1;

public class CajaDeAhorro
{
    public int id { get; set; }
    public int cbu { get; set; }

    private List<Usuario> titulares;
    public float saldo { get; set; }
    private List<Movimiento> movimientos;

    public CajaDeAhorro(int id, int cbu, Usuario titular)
    {
        this.id = id;
        this.cbu = cbu;
        this.titulares = new List<Usuario>();
        titulares.Add(titular);
        this.saldo = 0;
        this.movimientos = new List<Movimiento>();

    }

    /* Preguntar por esto 
    public CajaDeAhorro()
    {
        this.titulares = new List<Usuario>();
        this.movimientos = new List<Movimiento>();
    }*/

    public void addMovimiento(Movimiento nuevoMovimiento)
    {
        movimientos.Add(nuevoMovimiento);
    }


    public List<Movimiento> getMovimientos()
    {
        return movimientos.ToList();
    }

    public void addTitular(Usuario nuevoTitular)
    {
        titulares.Add(nuevoTitular);
    }

    public List<Usuario> getTitular()
    {
        return titulares.ToList();
    }

    public void removeTitular(Usuario titular)
    {
        titulares.Remove(titular);
    }



}