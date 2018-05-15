using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EcryptorWeb.Models;

namespace EcryptorWeb.Controllers
{
    public class EcryptorRequestsController : Controller
    {
        private readonly EcryptorDBContext _context;

        public EcryptorRequestsController(EcryptorDBContext context)
        {
            _context = context;
        }

        // GET: EcryptorRequests
        public async Task<IActionResult> Index()
        {
            var ecryptorDBContext = _context.EcryptorRequest.Include(e => e.FileR).Include(e => e.UserRequestorR);
            return View(await ecryptorDBContext.ToListAsync());
        }

        // GET: EcryptorRequests/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ecryptorRequest = await _context.EcryptorRequest
                .Include(e => e.FileR)
                .Include(e => e.UserRequestorR)
                .SingleOrDefaultAsync(m => m.EcryptorRequestRowid == id);
            if (ecryptorRequest == null)
            {
                return NotFound();
            }

            return View(ecryptorRequest);
        }

        // GET: EcryptorRequests/Create
        public IActionResult Create()
        {
            ViewData["FileRid"] = new SelectList(_context.File, "FileRid", "FileName");
            ViewData["UserRequestorRid"] = new SelectList(_context.User, "UserRid", "UserName");
            return View();
        }

        // POST: EcryptorRequests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EcryptorRequestRowid,UserRequestorRid,ResquestStatus,FileRid,RequestSession,RequestDate,RequestorNotes,RequestIsActive,TenantRid,WorkloadRid,EvisordwCorrelationId,SourceLoadSession,SourceLoadDate,LastChangeDateTime,LastChangeSession,RowVersion")] EcryptorRequest ecryptorRequest)
        {
            if (ModelState.IsValid)
            {
                ecryptorRequest.EcryptorRequestRowid = Guid.NewGuid();
                _context.Add(ecryptorRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FileRid"] = new SelectList(_context.File, "FileRid", "FileName", ecryptorRequest.FileRid);
            ViewData["UserRequestorRid"] = new SelectList(_context.User, "UserRid", "UserName", ecryptorRequest.UserRequestorRid);
            return View(ecryptorRequest);
        }

        // GET: EcryptorRequests/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ecryptorRequest = await _context.EcryptorRequest.SingleOrDefaultAsync(m => m.EcryptorRequestRowid == id);
            if (ecryptorRequest == null)
            {
                return NotFound();
            }
            ViewData["FileRid"] = new SelectList(_context.File, "FileRid", "FileName", ecryptorRequest.FileRid);
            ViewData["UserRequestorRid"] = new SelectList(_context.User, "UserRid", "UserName", ecryptorRequest.UserRequestorRid);
            return View(ecryptorRequest);
        }

        // POST: EcryptorRequests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("EcryptorRequestRowid,UserRequestorRid,ResquestStatus,FileRid,RequestSession,RequestDate,RequestorNotes,RequestIsActive,TenantRid,WorkloadRid,EvisordwCorrelationId,SourceLoadSession,SourceLoadDate,LastChangeDateTime,LastChangeSession,RowVersion")] EcryptorRequest ecryptorRequest)
        {
            if (id != ecryptorRequest.EcryptorRequestRowid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ecryptorRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EcryptorRequestExists(ecryptorRequest.EcryptorRequestRowid))
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
            ViewData["FileRid"] = new SelectList(_context.File, "FileRid", "FileName", ecryptorRequest.FileRid);
            ViewData["UserRequestorRid"] = new SelectList(_context.User, "UserRid", "UserName", ecryptorRequest.UserRequestorRid);
            return View(ecryptorRequest);
        }

        // GET: EcryptorRequests/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ecryptorRequest = await _context.EcryptorRequest
                .Include(e => e.FileR)
                .Include(e => e.UserRequestorR)
                .SingleOrDefaultAsync(m => m.EcryptorRequestRowid == id);
            if (ecryptorRequest == null)
            {
                return NotFound();
            }

            return View(ecryptorRequest);
        }

        // POST: EcryptorRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var ecryptorRequest = await _context.EcryptorRequest.SingleOrDefaultAsync(m => m.EcryptorRequestRowid == id);
            _context.EcryptorRequest.Remove(ecryptorRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EcryptorRequestExists(Guid id)
        {
            return _context.EcryptorRequest.Any(e => e.EcryptorRequestRowid == id);
        }
    }
}
