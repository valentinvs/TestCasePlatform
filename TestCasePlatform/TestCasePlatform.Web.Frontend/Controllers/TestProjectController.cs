using System.Web.Mvc;
using TestCasePlatform.Data;
using TestCasePlatform.Web.Frontend.Models;

namespace TestCasePlatform.Web.Frontend.Controllers
{
    public class TestProjectController : Controller
    {
        public TestCasePlatformDbContext dbContext = new TestCasePlatformDbContext();
        //
        // GET: /TestProject/
        public ActionResult Index()
        {
            var model = dbContext.TestProjects;
            return View(model);
        }

        //
        // GET: /TestProject/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /TestProject/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TestProject/Create
        [HttpPost]
        public ActionResult Create(CreateTestProjectViewModel model)
        {
            try
            {
                dbContext.TestProjects.Add(
                    new TestProject
                    {
                        Title = model.Title,
                        Description = model.Description
                    });
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /TestProject/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /TestProject/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /TestProject/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /TestProject/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
