using Back_CRUDs_BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Middle_Armeria_PDV
{
    public class Usuario
    {
        int id;
        string nombre;
        string password;
        Rol rol;
        CRUDs_BD bd;
        public static string msgError;
        public Usuario()
        {
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "dnd_armeria");
        }
        public bool crearUsuario(string nombre, string password, Rol rol)
        {
            List<string> nombresCampos = new List<string>()
            {
                    "usuario_nombre", "usuario_password", "usuario_rol"
            };

            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar(nombre));
            vals.Add(new ValoresAInsertar(password));
            vals.Add(new ValoresAInsertar(rol.ToString()));
            bool resultado = this.bd.insertar("usuarios", nombresCampos, vals);

            if (resultado == false)
                Usuario.msgError = this.bd.msgError;

            return resultado;
        }

        public bool modificarUsuario(string nombre, string password, Rol rol, int id)
        {
            List<string> nombresCampos = new List<string>()
            {
                    "usuario_nombre", "usuario_password", "usuario_rol"
            };

            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar(nombre));
            vals.Add(new ValoresAInsertar(password));
            vals.Add(new ValoresAInsertar(rol.ToString()));

            bool resultado = this.bd.modificar("usuarios", nombresCampos, vals, id);
            //valir el res
            if (resultado == false)
                Usuario.msgError = this.bd.msgError;

            return resultado;
        }
        public bool borrarUsuario(int id)
        {
            bool res = this.bd.borrar("usuarios", id);
            if (res == false)
                Usuario.msgError = this.bd.msgError;
            return res;
        }
        public Usuario login(string nombre, string password)
        {
            Usuario prodResultado = new Usuario();

            List<object[]> res = this.bd.consulta("usuarios", " usuario_nombre='" + nombre + "' AND usuario_password = '" + password + "'");
            if (res.Count == 1)
            {
                object[] tempo = res[0];
                Rol roles = new Rol();
                switch (tempo[3].ToString())
                {
                    case "ADMIN":
                        roles = Rol.ADMIN; break;
                    case "CAJERO":
                        roles = Rol.CAJERO; break;
                    default:
                        roles = Rol.CAJERO;
                        break;
                }

                prodResultado.id = int.Parse(tempo[0].ToString());
                prodResultado.nombre = tempo[1].ToString();
                prodResultado.password = tempo[2].ToString();
                prodResultado.rol = roles;
            }
            else
            {
                Producto.msgError = "No existee el usuario indicado. " + this.bd.msgError;
                prodResultado = null;
            }
            return prodResultado;
        }
        public List<object[]> consultarTodoUsers()
        {
            return this.bd.consulta("usuarios");
        }

    }
}
