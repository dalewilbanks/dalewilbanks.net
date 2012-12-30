using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Expressions;

namespace dalewilbanks.net.Controllers
{
    public class LambdaController : Controller
    {
        //
        // GET: /Lambda/

        public ActionResult Index()
        {
            var kv = new KeyValuePair<string, object>("display", "Mr. 89");
            
            //ViewData is a dictionary with key value pairs.
            ViewData.Add(kv);

            //dynanmic properties, Peanuts is totally made up at this point, now aint' this cool!
            ViewBag.Peanuts = "ate some peanuts";

            int i = 4;
            
            //you can't send this function to another process, system, etc. cause the value of i is lost.
            Func<double, double> PiMe = n => n * i;

            ViewBag.HowMuchPie = PiMe(7);


            
            //dyanmic code compilation!!!  the value of i is compiled into the tree, now THIS ROCKS!
            // you CAN send this to another process, system etc., especially since it is now data (still figurring that one out).
            
            // I guess an expression can be turned into a binary tree as a way of producing a result, rather than being
            // code that calls a math library, etc.   The values in the binary tree are the possible results. Not sure
            // how such a tree could contain an infinite number of results, but it will be interesting to learn.
            Expression<Func<double, double>> expressionTree = n => n * i;
                        
            var compiledExpressionTree = expressionTree.Compile();

            ViewBag.ExpressionTreeResult = compiledExpressionTree(2);

            return View("Lambda");
        }

        //
        // GET: /Lambda/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Lambda/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Lambda/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Lambda/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Lambda/Edit/5

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
        // GET: /Lambda/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Lambda/Delete/5

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
    }
}
