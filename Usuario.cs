public class Usuario
{

    public int id { get; set; }
    public string dni { get; set; }
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string mail { get; set; }
    public string clave { get; set; }
    public int intentosFallidos { get; set; }
    public bool bloqueados { get; set; }

    private List<CajaDeAhorro> cajas;
    private List<PlazoFijo> plazosFijos;
    private List<Tarjeta> tarjetas;
    private List<Pago> pagos;




    public Usuario(int id, string dni, string nombre, string apellido, string mail, string clave)
    {
        this.id = id;
        this.dni = dni;
        this.nombre = nombre;
        this.apellido = apellido;
        this.mail = mail;
        this.clave = clave;
        this.cajas = new List<CajaDeAhorro>();
        this.tarjetas = new List<Tarjeta>();
        this.pagos = new List<Pago>();
        this.plazosFijos = new List<PlazoFijo>();

    }

    public Usuario(string dni, PlazoFijo plazosFijos)
    {


        this.dni = dni;
        this.plazosFijos = new List<PlazoFijo>();

    }

    public void AddPago(Pago pago)
    {

        this.pagos.Add(pago);

    }

    public void RemovePago(Pago pago)
    {

        this.pagos.Remove(pago);

    }

    public void AddPlazoFijo(PlazoFijo plazoFijo)
    {

        this.plazosFijos.Add(plazoFijo);



    }
    public void RemovePlazoFijo(PlazoFijo plazoFijo)
    {

        this.plazosFijos.Remove(plazoFijo);

    }

    public void AddCajaDeAhorro(CajaDeAhorro cajaDeAhorro)
    {

        this.cajas.Add(cajaDeAhorro);

    }

    public void RemoveCajaDeAhorro(CajaDeAhorro cajaDeAhorro)
    {

        this.cajas.Remove(cajaDeAhorro);

    }


    public void AddTarjeta(Tarjeta tarjeta)
    {

        this.tarjetas.Add(tarjeta);

    }

    public void RemoveTarjeta(Tarjeta tarjeta)
    {

        this.tarjetas.Remove(tarjeta);

    }

    public List<Pago> getPagos()
    {
        return pagos.ToList();
    }

    public List<CajaDeAhorro> getCajas()
    {
        return cajas.ToList();
    }


    public List<PlazoFijo> getPlazos()
    {
        return plazosFijos.ToList();
    }


    public List<Tarjeta> getTarjetas()
    {
        return tarjetas.ToList();
    }

    public Tarjeta BuscarTarjetaPorNumero(int numero)
    {
        Tarjeta resultado = null;
        foreach (Tarjeta tarjeta in tarjetas)
        {

            if (tarjeta.numero.Equals(numero))
            {
                resultado = tarjeta;

            }
        }
        return resultado;
    }

    public CajaDeAhorro BuscarCajaPorCbu(string cbu)
    {
        CajaDeAhorro resultado = null;
        foreach (CajaDeAhorro caja in cajas)
        {

            if (caja.cbu == cbu)
            {
                resultado = caja;

            }
        }
        return resultado;
    }


}
