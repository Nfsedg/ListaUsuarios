using ProyectooFinal.CONTEXT;
using ProyectooFinal.ENTITIES;
using ProyectooFinal.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectooFinal.SERVICES
{
    public class UsuarioServices
    {

        public void addUser(Usuario request)
        {

            try
            {
                if (request != null)
                {
                    using (var _context = new AppDbContext())
                    {
                        Usuario res = new Usuario();
                        res.Nombre = request.Nombre;
                        res.UserName = request.UserName;
                        res.Password = request.Password;
                        // res.Nombre = request.Nombre;

                        _context.usuario.Add(res);
                        _context.SaveChanges();

                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrio un error" + ex.Message);
            }

        }

        public List<Usuario> getUsuarios()
        {
            try
            {

                using (var _context = new AppDbContext())
                {
                    List<Usuario> usuarios = new List<Usuario>();
                    usuarios = _context.usuario.ToList();
                    return usuarios;
                }

            }
            catch (Exception ex)
            {

                throw new Exception("sucedio un error" + ex.Message);
            }



        }

        public List<Usuario> getRoles()
        {
            try
            {

                using (var _context = new AppDbContext())
                {
                    List<Usuario> usuarios = new List<Usuario>();
                   
                    return usuarios;
                }

            }
            catch (Exception ex)
            {

                throw new Exception("sucedio un error" + ex.Message);
            }
        }
    }       
}
