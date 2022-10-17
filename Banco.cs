using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WinFormsApp1;


public class Banco
{

    private List<Usuario> usuarios;
    private List<CajaDeAhorro> cajas;
    private List<PlazoFijo> plazos;
    private List<Tarjeta> tarjetas;
    private List<Pago> pagos;
    private List<Movimiento> movimientos;

    public Usuario? UsuarioActual { get; set; }
    private static Banco instancia { get; set; }


    private Banco()
    {
        this.usuarios = new List<Usuario>();
        this.cajas = new List<CajaDeAhorro>();
        this.plazos = new List<PlazoFijo>();
        this.tarjetas = new List<Tarjeta>();
        this.pagos = new List<Pago>();
        this.movimientos = new List<Movimiento>();

    }

    public static Banco GetInstancia()
    {
        if (instancia == null)
        {
            instancia = new Banco();
        }
        return instancia;
    }

    // ABM CLASES

    //agregamos ID 
    public bool AltaDeUsuario(string dni, string nombre, string apellido, string mail, string clave)
    {
        bool resultado = false;

        if (usuarios.Count == 0)
        {
            if (dni != null && nombre != null && apellido != null && mail != null && clave != null)
            {
                usuarios.Add(new Usuario(NewIdUsuario(), dni, nombre, apellido, mail, clave));
                resultado = true;
            }
        }
        else
        {
            foreach (Usuario usuario in usuarios)
            {
                if (!usuario.dni.Equals(dni))
                {
                    if (dni != null && nombre != null && apellido != null && mail != null && clave != null)
                    {
                        usuarios.Add(new Usuario(NewIdUsuario(), dni, nombre, apellido, mail, clave));
                        resultado = true;
                        break;
                    }
                }
            }
        }

        return resultado;
    }

    public bool ModificarMail(string mail)
    {
        bool resultado = false;
        if (mail != "" && ExisteEmail(mail))
        {
            UsuarioActual.mail = mail;
            resultado = true;
        }
        return resultado;
    }

    public bool ModificarContrasenia(string clave)
    {

        bool resultado = false;
        if (clave != "")
        {
            UsuarioActual.clave = clave;
            resultado = true;
        }
        return resultado;
    }

    /*public void ModificarUsuario(int id, string mail, string clave)
    {
        foreach (Usuario usuario in usuarios)
        {
            if (usuario.id.Equals(id))
            {
                usuario.mail = mail;
                usuario.clave = clave;
            }
            else
            {
                // Mostrar mensaje diciendo que no se encontro el id del usuario en la base de datos
            }
        }
    }*/


    // Falta agregar el usuario.remove en todos los forEach del metodo
    public bool EliminarUsuario()
    {
        bool resultado = false;

        if (UsuarioActual.getCajas().Count == 0 && UsuarioActual.getPagos().Count == 0 && UsuarioActual.getPlazos().Count == 0 && UsuarioActual.getTarjetas().Count == 0)
        {
            usuarios.Remove(UsuarioActual);
            resultado = true;
        }
        else
        {

            foreach (CajaDeAhorro caja in UsuarioActual.getCajas())
            {
                MessageBox.Show("Pimer for");
                foreach (PlazoFijo plazoFijos in UsuarioActual.getPlazos())
                {
                    MessageBox.Show("segundo for");
                    foreach (Tarjeta tarjetas in UsuarioActual.getTarjetas())
                    {
                        MessageBox.Show("tercer for");

                        if (BajaPlazoFijo(plazoFijos.id) && BajaTarjetaCredito(tarjetas.id) && BajaCajaAhorro(caja.id))
                        {

                            usuarios.Remove(UsuarioActual);
                            resultado = true;
                        }
                    }
                }
            }
        }
        return resultado;
    }



    public bool AltaCajaAhorro()

    {
        bool resultado = false;
        //Usuario titular = BuscarUsuarioPordni(dni);

        Random rd = new Random();

        if (cajas.Count() == 0)
        {
            string rnd = rd.Next(100, 999).ToString();

            CajaDeAhorro nuevaCaja = new CajaDeAhorro(NewIdCaja(), rnd, UsuarioActual);
            UsuarioActual.AddCajaDeAhorro(nuevaCaja);
            cajas.Add(nuevaCaja);
            Movimiento movimiento = new Movimiento(NewIdMovimiento(), nuevaCaja, "Caja creada" + nuevaCaja.cbu, 0, DateTime.Now);
            movimientos.Add(movimiento);
            nuevaCaja.addMovimiento(movimiento);


            resultado = true;
        }
        else
        {
            string nuevoCbu = rd.Next(100, 999).ToString();

            for (int i = 0; i < cajas.Count; i++)
            {
                string cbu = cajas.ElementAt(i).cbu;

                if (!cbu.Equals(nuevoCbu))
                {

                    CajaDeAhorro nuevaCaja = new CajaDeAhorro(NewIdCaja(), nuevoCbu, UsuarioActual);
                    UsuarioActual.AddCajaDeAhorro(nuevaCaja);
                    cajas.Add(nuevaCaja);
                    Movimiento movimiento = new Movimiento(NewIdMovimiento(), nuevaCaja, "Caja creada" + nuevaCaja.cbu, 0, DateTime.Now);
                    movimientos.Add(movimiento);
                    nuevaCaja.addMovimiento(movimiento);
                    resultado = true;
                    break;
                }
            }
        }

        return resultado;
    }




    public bool BajaCajaAhorro(int id)
    {
        bool resultado = false;
        foreach (CajaDeAhorro caja in UsuarioActual.getCajas())
        {
            if (caja.id == id)
            {
                if (caja.saldo == 0)
                {
                    cajas.Remove(caja);
                    UsuarioActual.RemoveCajaDeAhorro(caja);
                    resultado = true;
                }

            }


        }

        return resultado;

    }

    public bool BajaCajaAhorroPorCbu(string cbu)
    {
        bool resultado = false;
        foreach (CajaDeAhorro caja in UsuarioActual.getCajas())
        {
            if (caja.cbu == cbu)
            {
                if (caja.saldo == 0)
                {
                    cajas.Remove(caja);
                    UsuarioActual.RemoveCajaDeAhorro(caja);
                    caja.removeTitular(UsuarioActual);
                    Movimiento movimiento = new Movimiento(NewIdMovimiento(), caja, "Caja eliminada" + caja.cbu, 0, DateTime.Now);
                    movimientos.Add(movimiento);
                    caja.addMovimiento(movimiento);
                    resultado = true;
                }

            }


        }

        return resultado;

    }


    public bool ModificarCajaAhorro(string cbu, string dni, string accion)
    {
        bool resultado = false;
        Usuario titular = BuscarUsuarioPordni(dni);
        CajaDeAhorro caja2 = BuscarCajaPorCbu(cbu);

        if (accion.Equals("agregar"))
        {
            CajaDeAhorro caja = UsuarioActual.BuscarCajaPorCbu(cbu);
            caja.addTitular(titular);
            caja2.addTitular(titular);
            titular.AddCajaDeAhorro(caja);
            Movimiento movimiento = new Movimiento(NewIdMovimiento(), caja, "Caja creada" + caja.cbu, 0, DateTime.Now);
            movimientos.Add(movimiento);
            caja.addMovimiento(movimiento);
            resultado = true;
        }
        else if (accion.Equals("eliminar") && caja2.getTitular().Count > 1)
        {
            CajaDeAhorro caja = UsuarioActual.BuscarCajaPorCbu(cbu);
            caja.removeTitular(titular);
            caja2.removeTitular(titular);
            titular.RemoveCajaDeAhorro(caja);
            Movimiento movimiento = new Movimiento(NewIdMovimiento(), caja, "Caja eliminada" + caja.cbu, 0, DateTime.Now);
            movimientos.Add(movimiento);
            caja.addMovimiento(movimiento);
            resultado = true;
        }

        return resultado;
    }


    public Pago AltaPago(string nombre, double monto, string tipoDePago)
    {
        Usuario usuario = UsuarioActual;
        Pago pago = new Pago(NewIdPago(), usuario, nombre, monto, tipoDePago);


        pagos.Add(pago);
        usuario.AddPago(pago);
        return pago;
    }


    public bool BajaPago(Pago pago, string dni)
    {
        bool resultado = false;
        Usuario usuario = BuscarUsuarioPordni(dni);

        if (usuario != null && pago.pagado == true)
        {
            pagos.Remove(pago);
            usuario.RemovePago(pago);
            resultado = true;
        }

        return resultado;
    }


    public bool ModificarPago(string nombre)
    {
        bool resultado = false;
        Pago PagoActual = BuscarPagoPorNombre(nombre);

        if (PagoActual.pagado == false)
        {
            PagoActual.pagado = true;
            resultado = true;

        }

        return resultado;
    }

    public bool PagarPago(string cbu, int numero, string nombre)
    {
        bool resultado = false;
        Pago PagoActual = BuscarPagoPorNombre(nombre);
        CajaDeAhorro cajaActual = BuscarCajaPorCbu(cbu);
        Tarjeta tarjeta = BuscarTarjetaPorNumero(numero);


        if (!numero.Equals("") && tarjeta.limite > PagoActual.monto)
        {

            ModificarPago(nombre);
            //  tarjeta.consumos = tarjeta.consumos +  PagoActual.monto;
            resultado = true;
        }
        else if (cbu != "")
        {

            ModificarPago(nombre);
            //   cajaActual.saldo = cajaActual.saldo - PagoActual.monto;
            resultado = true;
        }


        return resultado;
    }

    public bool AltaPlazoFijo(float monto, DateTime fechaIni, DateTime fechaFin, float tasa)
    {
        bool resultado = false;
        PlazoFijo plazoFijo = new PlazoFijo(NewIdPlazo(), UsuarioActual, monto, fechaIni, fechaFin, tasa);

        plazos.Add(plazoFijo);
        UsuarioActual.AddPlazoFijo(plazoFijo);
        resultado = true;


        return resultado;
    }

    public bool BajaPlazoFijo(int id)

    {
        bool resultado = false;
        foreach (PlazoFijo plazoFijo in plazos)
        {

            if (plazoFijo.id == id)
            {

                if (plazoFijo.pagado)
                {

                    TimeSpan comparacionDeFechas = DateTime.Now.Subtract(plazoFijo.fechaFin);

                    if (comparacionDeFechas.Days >= 30)
                    {

                        plazos.Remove(plazoFijo);
                        UsuarioActual.RemovePlazoFijo(plazoFijo);
                        resultado = true;
                    }
                }
            }

        }
        return resultado;
    }

    /*  public bool AltaTarjetaCredito(string numero, string codigoV, float limite, float consumos)
      {
          bool resultado = false;
          Tarjeta tarjeta = new Tarjeta(NewIdTarjeta(), UsuarioActual, numero, codigoV, limite, consumos);

          tarjetas.Add(tarjeta);
          UsuarioActual.AddTarjeta(tarjeta);
          resultado = true;


          return resultado;
      }*/

    public bool AltaTarjetaCredito()
    {
        bool resultado = false;
        Random num = new Random();
        Random codigo = new Random();

        if (tarjetas.Count() == 0)
        {
            string tarjetanum = num.Next(100, 9999999).ToString();
            string codigotar = codigo.Next(100, 999).ToString();

            Tarjeta nuevaTarjeta = new Tarjeta(NewIdTarjeta(), UsuarioActual, tarjetanum, codigotar, 25000, 0);
            UsuarioActual.AddTarjeta(nuevaTarjeta);
            tarjetas.Add(nuevaTarjeta);
            resultado = true;
        }

        else
        {
            string nuevoNum = num.Next(100, 9999999).ToString();
            string nuevoCog = codigo.Next(100, 999).ToString();

            for (int i = 0; i < tarjetas.Count; i++)
            {
                string codigotar = codigo.Next(100, 999).ToString();
                string tarjetaNum = tarjetas.ElementAt(i).numero;

                if (!tarjetaNum.Equals(nuevoNum))
                {

                    Tarjeta nuevaTar2 = new Tarjeta(NewIdTarjeta(), UsuarioActual, nuevoNum, nuevoCog, 2000000, 0);
                    UsuarioActual.AddTarjeta(nuevaTar2);
                    tarjetas.Add(nuevaTar2);
                    resultado = true;
                    break;
                }
            }
        }
        return resultado;
    }



    public bool BajaTarjetaCredito(int id)
    {
        bool resultado = false;


        foreach (Tarjeta tarjeta in UsuarioActual.getTarjetas())
        {
            if (tarjeta.Equals(id) && tarjeta.consumos == 0)
            {

                tarjetas.Remove(tarjeta);
                UsuarioActual.RemoveTarjeta(tarjeta);

            }

        }

        return resultado;
    }

    public void ModificarTarjetaCredito(int id)
    {
        float nuevoLimite = 0;
        foreach (Tarjeta tarjeta in tarjetas)
        {

            if (tarjeta.Equals(id))
            {
                tarjeta.limite = nuevoLimite;
            }
        }
    }

    // MOSTRAR DATOS



    public List<CajaDeAhorro> MostrarCajasDeAhorroUsuarioActual()
    {
        return UsuarioActual.getCajas().ToList();
    }


    public List<Movimiento> MostrarMovimientosUsuarioActual(string cbu)
    {
        foreach (CajaDeAhorro caja in UsuarioActual.getCajas())
        {
            if (caja.cbu == cbu)
            {
                return caja.getMovimientos().ToList();

            }

        }
        return null;
    }
    public List<Pago> MostrarPagosPendiente()
    {
        List<Pago> random = new List<Pago>();

        foreach (Pago pago in UsuarioActual.getPagos())
        {
            if (!pago.pagado)
            {
                random.Add(pago);
            }
        }

        return random;

    }

    public List<Pago> MostrarPagosRealizado()
    {
        List<Pago> random = new List<Pago>();

        foreach (Pago pago in UsuarioActual.getPagos())
        {
            if (pago.pagado)
            {
                random.Add(pago);
            }
        }

        return random;
    }


    public List<PlazoFijo> MostrarPlazosFijos()
    {
        return UsuarioActual.getPlazos().ToList();
    }


    public List<Tarjeta> MostrarTarjetasDeCredito()
    {
        return UsuarioActual.getTarjetas().ToList();
    }


    public List<Tarjeta> MostrarTarjetasDeCreditoUsuarioActual()
    {
        return UsuarioActual.getTarjetas().ToList();
    }

    // METODOS COMPLEMENTARIOS 

    private Usuario BuscarUsuarioPordni(string dni)
    {
        Usuario resultado = null;
        foreach (Usuario usuario in usuarios)
        {

            if (usuario.dni.Equals(dni))
            {

                resultado = usuario;

            }
        }
        return resultado;
    }

    private bool ExisteEmail(string mail)
    {
        bool resultado = true;
        foreach (Usuario usuario in usuarios)
        {

            if (usuario.dni.Equals(mail))
            {

                resultado = false;

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

    public CajaDeAhorro BuscarCajaPorCbuUsuarioActual(string cbu)
    {
        CajaDeAhorro resultado = null;
        foreach (CajaDeAhorro caja in UsuarioActual.getCajas())
        {

            if (caja.cbu == cbu)
            {
                resultado = caja;

            }
        }
        return resultado;
    }


    private bool ExisteCajaPorCbu(string cbu)
    {
        bool resultado = false;
        foreach (CajaDeAhorro caja in cajas)
        {

            if (caja.cbu == cbu)
            {
                resultado = true;

            }
        }
        return resultado;
    }


    private Tarjeta BuscarTarjetaPorNumero(int numero)
    {
        Tarjeta resultado = null;
        foreach (Tarjeta tarjeta in UsuarioActual.getTarjetas())
        {

            if (tarjeta.numero.Equals(numero))
            {
                resultado = tarjeta;

            }
        }
        return resultado;
    }

    public Pago BuscarPagoPorNombre(string nombre)
    {
        Pago resultado = null;
        foreach (Pago pago in pagos)
        {

            if (pago.nombre == nombre)
            {
                resultado = pago;

            }
        }
        return resultado;
    }

    //OPERACIONES DEL USUARIO

    public bool IniciarSesion(string Usuario, string Contraseña)
    {
        int intentos = 0;
        foreach (Usuario usuario in usuarios)
        {

            if (usuario.nombre.Equals(Usuario) && usuario.clave.Equals(Contraseña) && !usuario.bloqueados /*&& intentos > 2*/)
            {

                UsuarioActual = usuario;
                return true;
            }
            else
            {
                intentos++;
                if (intentos == 3)
                {
                    usuario.bloqueados = true;
                }
            }
        }

        return false;
    }

    public void CerrarSesion()
    {
        this.UsuarioActual = null;
    }

    public bool CrearCajaAhorro(CajaDeAhorro cajaIn)
    {

        bool resultado = false;

        foreach (CajaDeAhorro caja in cajas)
        {

            if (caja.id != cajaIn.id)
            {

                cajas.Add(cajaIn);
                resultado = true;
            }
        }

        return resultado;

    }

    public bool Depositar(string cbu, float monto)
    {

        bool resultado = false;
        CajaDeAhorro cajaBanco = BuscarCajaPorCbu(cbu);
        CajaDeAhorro cajaUsuario = BuscarCajaPorCbuUsuarioActual(cbu);

        if (monto > 0)
        {
            cajaBanco.saldo = cajaBanco.saldo + monto;

            Movimiento movimiento = new Movimiento(NewIdMovimiento(), cajaUsuario, "Deposito" + cajaUsuario.cbu, monto, DateTime.Now);
            movimientos.Add(movimiento);
            cajaUsuario.addMovimiento(movimiento);

            resultado = true;
        }

        return resultado;
    }

    public bool Retirar(string cbu, float monto)
    {
        bool resultado = false;
        CajaDeAhorro cajaBanco = BuscarCajaPorCbu(cbu);
        CajaDeAhorro cajaUsuario = BuscarCajaPorCbuUsuarioActual(cbu);

        if (cajaBanco.saldo >= monto)
        {
            cajaBanco.saldo = cajaBanco.saldo - monto;
            Movimiento movimiento = new Movimiento(NewIdMovimiento(), cajaUsuario, "Retiro" + cajaUsuario.cbu, monto, DateTime.Now);
            movimientos.Add(movimiento);
            cajaUsuario.addMovimiento(movimiento);

            resultado = true;
        }
        return resultado;
    }

    public bool Transferir(string origen, string destino, float Monto)
    {
        bool resultado = false;
        CajaDeAhorro cajaOrigen = BuscarCajaPorCbu(origen);

        if (ExisteCajaPorCbu(destino) && cajaOrigen.saldo >= Monto)
        {
            CajaDeAhorro cajaDestino = BuscarCajaPorCbu(destino);

            cajaOrigen.saldo = cajaOrigen.saldo - Monto;
            cajaDestino.saldo = cajaDestino.saldo + Monto;
            Movimiento movimientoOrigen = new Movimiento(NewIdMovimiento(), cajaOrigen, "Transferencia" + cajaOrigen.cbu, Monto, DateTime.Now);
            Movimiento movimientoDestino = new Movimiento(NewIdMovimiento(), cajaDestino, "Transferencia" + cajaDestino.cbu, Monto, DateTime.Now);
            movimientos.Add(movimientoOrigen);
            movimientos.Add(movimientoDestino);
            cajaOrigen.addMovimiento(movimientoOrigen);
            cajaDestino.addMovimiento(movimientoDestino);

            resultado = true;
        }

        return resultado;
    }

    public List<Movimiento> BuscarMovimiento(string cbu, string detalle, DateTime fecha, float monto)
    {

        List<Movimiento> resultado = new List<Movimiento>();
        CajaDeAhorro cajaDeAhorro = BuscarCajaPorCbu(cbu);

        foreach (CajaDeAhorro caja in UsuarioActual.getCajas())
        {
            foreach (Movimiento movimiento in cajaDeAhorro.getMovimientos())
            {
                if (caja.id == cajaDeAhorro.id)
                {
                    if (detalle != "" && fecha.Equals("") && monto.Equals("") && movimiento.detalle.Equals(detalle))
                    {

                        // Tengo que crear un metodo en caja o movimientos ? que devuelta solo la lista con los detalles ?

                        // devolver los movimientos del detalle. 

                        resultado.Add(movimiento);

                    }
                    else if (detalle == "" && !fecha.Equals("") && !monto.Equals("") && movimiento.fecha.Equals(fecha) && movimiento.monto.Equals(monto))
                    {

                        // devolver los mivimientos de fecha y monto


                        resultado.Add(movimiento);


                    }
                    else if (detalle == "" && fecha.Equals("") && !monto.Equals("") && movimiento.monto.Equals(monto))
                    {

                        // devolver los movimientos de monto
                        resultado.Add(movimiento);

                    }
                    else if (detalle == "" && !fecha.Equals("") && monto.Equals("") && movimiento.fecha.Equals(fecha))
                    {

                        // devuelve los movimientos de la fecha
                        resultado.Add(movimiento);

                    }
                    else if (detalle != "" && !fecha.Equals("") && monto.Equals("") && movimiento.fecha.Equals(fecha) && movimiento.detalle.Equals(detalle))
                    {

                        // devuelve los movimientos de la fecha y el detalle 
                        resultado.Add(movimiento);


                    }
                    else if (detalle != "" && fecha.Equals("") && !monto.Equals("") && movimiento.detalle.Equals(detalle) && movimiento.monto.Equals(monto))
                    {

                        // devuelve los detalles y el monto
                        resultado.Add(movimiento);

                    }
                }
            }
        }

        return resultado;
    }

    public bool PagarTarjeta(int numero, string cbu)
    {

        bool resultado = false;
        CajaDeAhorro caja = UsuarioActual.BuscarCajaPorCbu(cbu);
        Tarjeta tarjeta = UsuarioActual.BuscarTarjetaPorNumero(numero);

        if (caja.saldo >= tarjeta.consumos)
        {

            float monto = caja.saldo = caja.saldo - tarjeta.consumos;
            tarjeta.consumos = 0;
            // agregar movimiento

            caja.addMovimiento(new Movimiento(caja.id, caja, "Pago Tarjeta", monto, DateTime.Today));
            movimientos.Add(new Movimiento(caja.id, caja, "Pago Tarjeta", monto, DateTime.Today));
            resultado = true;

        }

        return resultado;
    }
    private int NewIdUsuario()
    {

        int resultado = 1;
        int numero = 0;
        int mayor = 0;

        for (int i = 0; i < usuarios.Count; i++)

        {
            numero = usuarios.ElementAt(i).id;

            if (numero > mayor)
            {
                mayor = numero;
            }

            resultado = mayor + 1;
        }

        return resultado;

    }
    private int NewIdPlazo()
    {

        int resultado = 1;
        int numero = 0;
        int mayor = 0;

        for (int i = 0; i < plazos.Count; i++)

        {
            numero = plazos.ElementAt(i).id;

            if (numero > mayor)
            {
                mayor = numero;
            }

            resultado = mayor + 1;
        }

        return resultado;

    }
    private int NewIdMovimiento()
    {

        int resultado = 1;
        int numero = 0;
        int mayor = 0;

        for (int i = 0; i < movimientos.Count; i++)

        {
            numero = movimientos.ElementAt(i).id;

            if (numero > mayor)
            {
                mayor = numero;
            }

            resultado = mayor + 1;
        }

        return resultado;

    }
    private int NewIdCaja()
    {

        int resultado = 1;
        int numero = 0;
        int mayor = 0;

        for (int i = 0; i < cajas.Count; i++)

        {
            numero = cajas.ElementAt(i).id;

            if (numero > mayor)
            {
                mayor = numero;
            }

            resultado = mayor + 1;
        }

        return resultado;

    }
    private int NewIdPago()
    {

        int resultado = 1;
        int numero = 0;
        int mayor = 0;

        for (int i = 0; i < pagos.Count; i++)

        {
            numero = pagos.ElementAt(i).id;

            if (numero > mayor)
            {
                mayor = numero;
            }

            resultado = mayor + 1;
        }

        return resultado;

    }
    private int NewIdTarjeta()
    {

        int resultado = 1;
        int numero = 0;
        int mayor = 0;

        for (int i = 0; i < tarjetas.Count; i++)
        {
            numero = tarjetas.ElementAt(i).id;

            if (numero > mayor)
            {
                mayor = numero;
            }
            resultado = mayor + 1;
        }
        return resultado;
    }

}