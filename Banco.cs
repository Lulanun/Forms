using System;
using System.Collections;
using System.Collections.Generic;
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

    private List<Usuario> usuarios = new List<Usuario>();
    private List<CajaDeAhorro> cajas = new List<CajaDeAhorro>();
    private List<PlazoFijo> plazos = new List<PlazoFijo>();
    private List<Tarjeta> tarjetas = new List<Tarjeta>();
    private List<Pago> pagos = new List<Pago>();
    private List<Movimiento> movimientos = new List<Movimiento>();

    public Usuario? UsuarioActual { get; set; }


    // ABM CLASES

    //agregamos ID o no ? 
    public bool AltaDeUsuario(string dni, string nombre, string apellido, string mail, string clave)
    {
        bool resultado = false;

        if (dni != "" && nombre != "" && apellido != "" && mail != "" && clave != "")
        {
            usuarios.Add(new Usuario(dni, nombre, apellido, mail, clave));
            resultado = true;
        }
        return resultado;
    }

    public bool ModificarMail(int id, string mail)
    {
        bool resultado = false;
        foreach (Usuario usuario in usuarios)
        {
            if (usuario.id.Equals(id))
            {
                usuario.mail = mail;
                resultado = true;

            }

        }
        return resultado;
    }

    public bool ModificarContraseña(int id, string clave)
    {

        bool resultado = false;
        foreach (Usuario usuario in usuarios)
        {

            if (usuario.id.Equals(id))
            {

                usuario.clave = clave;
                resultado = true;

            }
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

    // Antes de esto se deben crear los metodos eliminar cajadeahorro, plazo fijo y tarjetas.
    // Falta agregar el usuario.remove en todos los forEach del metodo
    public bool EliminarUsuario(string dni)
    {
        bool resultado = false;
        Usuario titular = BuscarUsuarioPordni(dni);

        if (titular != null)
        {
            foreach (CajaDeAhorro caja in cajas)
            {
                foreach (PlazoFijo plazoFijos in plazos)
                {
                    foreach (Tarjeta tarjetas in tarjetas)
                    {

                        if (BajaPlazoFijo(plazoFijos.id, dni) && BajaTarjetaCredito(tarjetas.id, dni) && BajaCajaAhorro(caja.cbu, dni))
                        {

                            usuarios.Remove(titular);
                            resultado = true;
                        }
                        else
                        {
                            // "El usuario no se pudo dar de baja. Verifique el estado de sus cuentas"
                        }

                    }
                }
            }

        }

        return resultado;
    }

    public List<Usuario> obtenerUsuarios()
    {
        return usuarios.ToList();
    }



    public bool AltaCajaAhorro(string cbu, string dni)

    {
        bool resultado = false;
        Usuario titular = BuscarUsuarioPordni(dni);

        foreach (CajaDeAhorro caja in cajas)
        {

            if (caja.cbu != cbu)
            {
                resultado = true;
                cajas.Add(new CajaDeAhorro(0, cbu, titular));
                titular.AddCajaDeAhorro(caja);
            }
        }

        return resultado;
    }




    public bool BajaCajaAhorro(string cbu, string dni)
    {
        bool resultado = false;
        Usuario titular = BuscarUsuarioPordni(dni);
        foreach (CajaDeAhorro caja in cajas)
        {
            if (caja.cbu == cbu)
            {
                if (caja.saldo == 0)
                {
                    cajas.Remove(caja);
                    titular.RemoveCajaDeAhorro(caja);
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
        CajaDeAhorro caja = BuscarCajaPorCbu(cbu);

        if (accion.Equals("agregar"))
        {
            caja.addTitular(titular);
            resultado = true;
        }
        else if (accion.Equals("quitar") && caja.getTitular().Count > 1)
        {

            caja.removeTitular(titular);
            resultado = true;
        }

        return resultado;
    }


    public void AltaMovimiento(string cbuCaja, Movimiento nuevoMovimiento)
    {
        CajaDeAhorro caja = BuscarCajaPorCbu(cbuCaja);
        movimientos.Add(nuevoMovimiento);
        caja.addMovimiento(nuevoMovimiento);


    }


    public void AltaPago(Pago pago, string dni)
    {
        Usuario usuario = BuscarUsuarioPordni(dni);
        pagos.Add(pago);
        usuario.AddPago(pago);

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

    // Preguntar al profe que exactamente se debe modificar 
    public bool ModificarPago(string dni)
    {
        bool resultado = false;
        Usuario usuario = BuscarUsuarioPordni(dni);
        foreach (Pago pago in pagos)
        {
            if (usuario != null && pago.pagado == false)
            {
                pago.pagado = true;
                resultado = true;

            }
        }
        return resultado;
    }



    public bool AltaPlazoFijo(string dni, PlazoFijo plazoFijo, DateOnly fechaFin)
    {
        bool resultado = false;
        Usuario usuario = BuscarUsuarioPordni(dni);
        if (usuario != null)
        {

            plazos.Add(plazoFijo);
            usuario.AddPlazoFijo(plazoFijo);
            resultado = true;

        }

        return resultado;
    }




    public bool BajaPlazoFijo(int id, string dni)

    {
        bool resultado = false;
        Usuario usuario = BuscarUsuarioPordni(dni);
        foreach (PlazoFijo plazoFijo in plazos)
        {

            if (usuario.dni.Equals(dni) && plazoFijo.id == id)
            {

                if (plazoFijo.pagado)
                {

                    TimeSpan comparacionDeFechas = DateTime.Now.Subtract(plazoFijo.fechaFin);

                    if (comparacionDeFechas.Days >= 30)
                    {

                        plazos.Remove(plazoFijo);
                        usuario.RemovePlazoFijo(plazoFijo);
                        resultado = true;
                    }
                }
            }

        }
        return resultado;
    }



    public bool AltaTarjetaCredito(string dni, Tarjeta tarjeta)
    {
        bool resultado = false;
        Usuario usuario = BuscarUsuarioPordni(dni);
        if (usuario != null)
        {

            tarjetas.Add(tarjeta);
            usuario.AddTarjeta(tarjeta);
            resultado = true;
        }

        return resultado;
    }

    public bool BajaTarjetaCredito(int id, string dni)
    {
        bool resultado = false;
        Usuario usuario = BuscarUsuarioPordni(dni);
        if (usuario != null)
        {
            foreach (Tarjeta tarjeta in tarjetas)
            {
                if (tarjeta.Equals(id) && tarjeta.consumos == 0)
                {

                    tarjetas.Remove(tarjeta);
                    usuario.RemoveTarjeta(tarjeta);

                }

            }
        }
        return resultado;
    }



    public void ModificarTarjetaCredito(int id)
    {
        float nuevoLimite = 0;
        foreach (Tarjeta tarjeta in tarjetas)

            if (tarjeta.Equals(id))
            {
                tarjeta.limite = nuevoLimite;
            }

    }


    // MOSTRAR DATOS

    public List<CajaDeAhorro> MostrarCajasDeAhorro(int dni)
    {

        foreach (Usuario usuario in usuarios)
        {

            if (usuario.dni.Equals(dni))
            {
                return usuario.getCajas().ToList();
            }

        }
        return null;
    }
    public List<Movimiento> MostrarMovimientos(in CajaDeAhorro cajaIn)
    {
        foreach (CajaDeAhorro cajas in cajas)
        {

            if (cajas.id == cajaIn.id)
            {

                return cajas.getMovimientos().ToList();

            }

        }
        return null;
    }
    public List<Pago> MostrarPagos(int dni)
    {
        foreach (Usuario usuario in usuarios)
        {
            if (usuario.dni.Equals(dni))
            {

                return usuario.getPagos().ToList();

            }
        }

        return null;
    }
    public List<PlazoFijo> MostrarPlazosFijos(int dni)
    {
        foreach (Usuario usuario in usuarios)
        {
            if (usuario.dni.Equals(dni))
            {

                return usuario.getPlazos().ToList();

            }
        }

        return null;
    }
    public List<Tarjeta> MostrarTarjetasDeCredito(int dni)
    {
        foreach (Usuario usuario in usuarios)
        {
            if (usuario.dni.Equals(dni))
            {

                return usuario.getTarjetas().ToList();

            }
        }

        return null;
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

    private CajaDeAhorro BuscarCajaPorCbu(string cbu)
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




    //OPERACIONES DEL USUARIO


    public bool IniciarSesion(string Usuario, string Contraseña)
    {
        int intentos = 0;
        foreach (Usuario usuario in usuarios)
        {
            if (usuario.nombre.Equals(Usuario) && usuario.clave.Equals(Contraseña) && usuario.bloqueados != true)
            {
                UsuarioActual = usuario;
                return true;
            }
            else
            {
                intentos++;
            }
            if (intentos == 3)
            {
                usuario.bloqueados = true;
            }
        }

        return false;
    }

    public void CerrarSesion()
    {
        UsuarioActual = null;
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

    public bool Depositar(in CajaDeAhorro cajaIn, float monto)
    {

        bool resultado = false;

        foreach (CajaDeAhorro caja in cajas)
        {
            if (caja.id == cajaIn.id)
            {

                caja.saldo = caja.saldo + monto;
                resultado = true;

            }

        }

        return resultado;


    }

    public bool Retirar(in CajaDeAhorro cajaIn, float monto)
    {

        bool resultado = false;

        foreach (CajaDeAhorro caja in cajas)
        {
            if (caja.id == cajaIn.id && caja.saldo >= monto)
            {


                caja.saldo = caja.saldo - monto;
                resultado = true;

            }


        }

        return resultado;


    }



    public bool Transferir(in CajaDeAhorro origen, in CajaDeAhorro destino, float Monto)
    {
        bool resultado = false;

        foreach (CajaDeAhorro caja in cajas)
        {
            if (caja.id == origen.id && caja.id == destino.id)
            {

                if (origen.saldo >= Monto)
                {
                    origen.saldo = origen.saldo - Monto;
                    destino.saldo = destino.saldo + Monto;
                    resultado = true;
                }
            }
        }

        return resultado;
    }


    public void BuscarMovimiento(CajaDeAhorro cajaIn, string detalle, TimeSpan Fecha, float Monto)
    {
        bool resultado = false;

        List<Movimiento> movimientosRandom = new List<Movimiento>();

        foreach (Movimiento movimiento in movimientos)
        {
            if (detalle != null && movimiento.detalle.Equals(detalle))
            {
                if (Fecha != null && Fecha.Equals(movimiento.fecha))
                {
                    List<Movimiento> devuelto = movimientos.Where(Movimiento => Movimiento.detalle != null).ToList();
                }
            }
            else if (Fecha != null)
            {

            }
            else if (Monto != null)
            {
            }

        }



        /*           int opt = 3;
         *           switch (opt)
                     {
                         case 1:
                                        List<Movimiento> devuelto = movimientos.Where(Movimiento => Movimiento.detalle != null).ToList();
                         break;
                         case 2:
                             List<Movimiento> devuelto = movimientos.Where(Movimiento => Movimiento.detalle != null &&).ToList();
                             break;
                         case 3:
                             break;
                     }
                     return resultado;
          */
    }



    /* public List<Movimiento> BuscarMovimiento(in CajaDeAhorro cajaIn, in string detalle, in DateOnly fecha, in float monto)
     {
         foreach (CajaDeAhorro caja in cajas)
         {
             if (caja.id == cajaIn.id)
             {
                 if (detalle != null)
                 {
                 }
                 return caja.getMovimientos().ToList();
             }
         }
         return null;
     }*/






    public void PagarTarjeta(Tarjeta tarjetaIn, CajaDeAhorro cajaIn)
    {

        foreach (Tarjeta tarjeta in tarjetas)
        {
            foreach (CajaDeAhorro caja in cajas)
            {

                if (caja.id == cajaIn.id && cajaIn.saldo >= tarjetaIn.consumos)
                {

                    tarjetaIn.consumos = 0;
                    float monto = cajaIn.saldo = cajaIn.saldo - tarjetaIn.consumos;
                    // agregar movimiento

                    caja.addMovimiento(new Movimiento(0, cajaIn, "Pago Tarjeta", monto, DateTime.Today)); /* no se como agregar el id*/
                }
            }
        }
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
}



