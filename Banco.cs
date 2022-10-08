using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Banco
    {
        private List<Usuario> usuarios;
        private List<CajaDeAhorro> cajas;
        private List<PlazoFijo> plazos;
        private List<Tarjeta> tarjetas;
        private List<Pago> pagos;
        private List<Movimiento> movimientos;


        public Banco()
        {
            usuarios = new List<Usuario>();
            cajas = new List<CajaDeAhorro>();
            plazos = new List<PlazoFijo>();
            tarjetas = new List<Tarjeta>();
            pagos = new List<Pago>();
            movimientos = new List<Movimiento>();
        }
        public bool agregarUsuario(string user, string pass, string dni)
        {

            if (user != null && pass.Length != null && dni.Length != null) // agregar validaciones 
            {
                usuarios.Add(new Usuario(user, pass, dni));
                return true;
            }

            else
            {
                return false;
            }

        }

        /*    public void eliminarUsuario(int dni)
            {

            }*/
        public bool iniciarSesion(string usuario, string pass, string dni)
        {
            bool encontre = false;
            foreach (Usuario user in usuarios)
            {
                if (user.nombre.Equals(usuario) && user.pass.Equals(pass))
                    encontre = true;
            }
            return encontre;
        }
        public List<Usuario> obtenerUsuarios()
        {
            return usuarios.ToList();
        }


    }
}
