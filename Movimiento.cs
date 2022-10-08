public class Movimiento
    {
        public int id { get; set; }
        public CajaDeAhorro caja { get; set; }
        public string detalle { get; set; }
        public float monto { get; set; }
        public DateTime fecha { get; set; }

        public Movimiento(int id, CajaDeAhorro caja, string detalle, float monto, DateTime fecha)
        {
            this.id = id;
            this.caja = caja;
            this.detalle = detalle;
            this.monto = monto;
            this.fecha = fecha;
        }
    }