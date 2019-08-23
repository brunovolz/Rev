using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using RevisaoWebApi.Models;

namespace RevisaoWebApiS.Controllers
{
    public class UsuariosController : ApiController
    {
        //excluido private... e trocado todos db. por ContextDB.GetInstance()

        // GET: api/Usuarios
        public IQueryable<Usuario> Getusuarios()
        {
            return ContextDB.GetInstance().usuarios;
        }

        // GET: api/Usuarios/5
        [ResponseType(typeof(Usuario))]
        public async Task<IHttpActionResult> GetUsuario(int id)
        {
            Usuario usuario = await ContextDB.GetInstance().usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }

        // PUT: api/Usuarios/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usuario.Id)
            {
                return BadRequest();
            }

            ContextDB.GetInstance().Entry(usuario).State = EntityState.Modified;

            try
            {
                await ContextDB.GetInstance().SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Usuarios
        [ResponseType(typeof(Usuario))]
        public async Task<IHttpActionResult> PostUsuario(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ContextDB.GetInstance().usuarios.Add(usuario);
            await ContextDB.GetInstance().SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = usuario.Id }, usuario);
        }

        // DELETE: api/Usuarios/5
        [ResponseType(typeof(Usuario))]
        public async Task<IHttpActionResult> DeleteUsuario(int id)
        {
            Usuario usuario = await ContextDB.GetInstance().usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            ContextDB.GetInstance().usuarios.Remove(usuario);
            await ContextDB.GetInstance().SaveChangesAsync();

            return Ok(usuario);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ContextDB.GetInstance().Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UsuarioExists(int id)
        {
            return ContextDB.GetInstance().usuarios.Count(e => e.Id == id) > 0;
        }
    }
}