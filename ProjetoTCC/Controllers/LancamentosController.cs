 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoTCC.Context;
using ProjetoTCC.Models;

namespace ProjetoTCC.Controllers
{
    public class LancamentosController : Controller
    {
        private ProjetoTccContext db = new ProjetoTccContext();

        // GET: Lancamentos
        public ActionResult Index()
        {
            return View(db.Lancamentos.ToList());
        }

        // GET: Lancamentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lancamento lancamento = db.Lancamentos.Find(id);
            if (lancamento == null)
            {
                return HttpNotFound();
            }
            return View(lancamento);
        }

        // GET: Lancamentos/Criar
        public ActionResult Criar()
        {
            return View();
        }

        // POST: Lancamentos/Criar
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar([Bind(Include = "Id,Descricao,Data,Tipo,Valor")] Lancamento lancamento)
        {
            if (ModelState.IsValid)
            {
                db.Lancamentos.Add(lancamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lancamento);
        }

        // GET: Lancamentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lancamento lancamento = db.Lancamentos.Find(id);
            if (lancamento == null)
            {
                return HttpNotFound();
            }
            return View(lancamento);
        }

        // POST: Lancamentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao,Data,Tipo,Valor")] Lancamento lancamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lancamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lancamento);
        }

        // GET: Lancamentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lancamento lancamento = db.Lancamentos.Find(id);
            if (lancamento == null)
            {
                return HttpNotFound();
            }
            return View(lancamento);
        }

        // POST: Lancamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lancamento lancamento = db.Lancamentos.Find(id);
            db.Lancamentos.Remove(lancamento);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
