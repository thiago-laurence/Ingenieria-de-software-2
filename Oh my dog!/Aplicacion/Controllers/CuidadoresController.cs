﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Aplicacion.Models;
using System.Web;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Nancy.Json;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Net.Mail;
using System.Net;

namespace Aplicacion.Controllers
{
    public class CuidadoresController : Controller
    {
        private readonly OhmydogdbContext _context;

        public CuidadoresController(OhmydogdbContext context)
        {
            _context = context;
        }

        // GET: Cuidadores
        public async Task<IActionResult> Index()
        {
            return _context.Cuidadores != null ?
                        View(await _context.Cuidadores.ToListAsync()) :
                        Problem("Entity set 'OhmydogdbContext.Cuidadores'  is null.");
        }

        // GET: Cuidadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cuidadores == null)
            {
                return NotFound();
            }

            var cuidadore = await _context.Cuidadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cuidadore == null)
            {
                return NotFound();
            }

            return View(cuidadore);
        }

        // GET: Cuidadores/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Insertar(Cuidadore cuidadore)
            {
            
            
            if (ModelState.IsValid)
            {
                _context.Add(cuidadore);
                await _context.SaveChangesAsync();
                return Json(true) ;
            }

            return Json(false);
        }
        /*_context.Add(cuidadore);
                await _context.SaveChangesAsync();
                return Json(true);
            
            
        }*/

        // POST: Cuidadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Apellido,Email,HorarioIn,HorarioOut,Foto,Latitud,Longitud,Ubicacion")] Cuidadore cuidadore)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cuidadore);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cuidadore);
        }

        // GET: Cuidadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cuidadores == null)
            {
                return NotFound();
            }

            var cuidadore = await _context.Cuidadores.FindAsync(id);
            if (cuidadore == null)
            {
                return NotFound();
            }
            return View(cuidadore);
        }

        // POST: Cuidadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Apellido,Email,HorarioIn,HorarioOut,Foto,Latitud,Longitud,Ubicacion")] Cuidadore cuidadore)
        {
            if (id != cuidadore.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cuidadore);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CuidadoreExists(cuidadore.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cuidadore);
        }

        // GET: Cuidadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cuidadores == null)
            {
                return NotFound();
            }

            var cuidadore = await _context.Cuidadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cuidadore == null)
            {
                return NotFound();
            }

            return View(cuidadore);
        }
        [HttpGet]
        public string obtenerCuidadores()
        {
            return JsonSerializer.Serialize(_context.Cuidadores.ToList());

        }

        [HttpPost]
        public async Task<ActionResult> existeCuidador(Cuidadore cuidador)
        {
            
            Cuidadore _cuidador = await _context.Cuidadores.FirstOrDefaultAsync(m => m.Email == cuidador.Email && m.Ubicacion== cuidador.Ubicacion);

            if (_cuidador != null)
            {
                return Json(true);
            }
            

            return Json(false);
        }
        // POST: Cuidadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cuidadores == null)
            {
                return Problem("Entity set 'OhmydogdbContext.Cuidadores'  is null.");
            }
            var cuidadore = await _context.Cuidadores.FindAsync(id);
            if (cuidadore != null)
            {
                _context.Cuidadores.Remove(cuidadore);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


      



        public async Task<IActionResult> SendEmail(string origen, string destino, string titulo, string mensaje)
        {
            var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("753b469e9e376d", "06af1e23c346ae"),
                EnableSsl = true
            };
            client.Send(origen, destino, titulo, mensaje);
            return RedirectToAction(nameof(Index));
        }





        private bool CuidadoreExists(int id)
        {
          return (_context.Cuidadores?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
