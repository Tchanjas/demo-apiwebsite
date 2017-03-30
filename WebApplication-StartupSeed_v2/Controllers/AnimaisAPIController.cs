using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication_StartupSeed_v2.Models;

namespace WebApplication_StartupSeed_v2.Controllers
{
    public class AnimaisAPIController : ApiController
    {
        private MyDB db = new MyDB();

        // GET: api/AnimaisAPI
        public IQueryable<Animais> GetAnimais()
        {
            return db.Animais;
        }

        // GET: api/AnimaisAPI/5
        [ResponseType(typeof(Animais))]
        public IHttpActionResult GetAnimais(int id)
        {
            Animais animais = db.Animais.Find(id);
            if (animais == null)
            {
                return NotFound();
            }

            return Ok(animais);
        }

        // PUT: api/AnimaisAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAnimais(int id, Animais animais)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != animais.AnimalID)
            {
                return BadRequest();
            }

            db.Entry(animais).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnimaisExists(id))
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

        // POST: api/AnimaisAPI
        [ResponseType(typeof(Animais))]
        public IHttpActionResult PostAnimais(Animais animais)
        {
            animais.AnimalID = int.Parse(db.Animais
                            .OrderByDescending(p => p.AnimalID)
                            .Select(r => r.AnimalID)
                            .First().ToString()) + 1;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Byte[] bitmapData = Convert.FromBase64String(animais.Imagem);
                System.IO.MemoryStream streamBitmap = new System.IO.MemoryStream(bitmapData);
                Bitmap bitImage = new Bitmap((Bitmap)Image.FromStream(streamBitmap));

                Random rng = new Random();
                int imgNum = rng.Next(0, 10);

                String filename = DateTime.Now.ToString("yyyyMMddHHmmssffff") + "_" + imgNum + ".jpg";
                string fullSavePath = HttpContext.Current.Server.MapPath("~/Imagens/" + filename);

                File.WriteAllBytes(fullSavePath, Convert.FromBase64String(animais.Imagem));
                animais.Imagem = filename;

                db.Animais.Add(animais);
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (AnimaisExists(animais.AnimalID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = animais.AnimalID }, animais);
        }

        // DELETE: api/AnimaisAPI/5
        [ResponseType(typeof(Animais))]
        public IHttpActionResult DeleteAnimais(int id)
        {
            Animais animais = db.Animais.Find(id);
            if (animais == null)
            {
                return NotFound();
            }

            db.Animais.Remove(animais);
            db.SaveChanges();

            return Ok(animais);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AnimaisExists(int id)
        {
            return db.Animais.Count(e => e.AnimalID == id) > 0;
        }
    }
}