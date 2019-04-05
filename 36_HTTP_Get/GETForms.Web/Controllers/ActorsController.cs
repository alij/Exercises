using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;
using GETForms.Web.DAL;

namespace GETForms.Web.Controllers
{
    public class ActorsController : Controller
    {

        private IActorDAL actorDAL;

        public ActorsController(IActorDAL actorDAL)
        {
            this.actorDAL = actorDAL;
        }

        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            Actor actor = new Actor();
            return View(actor);
        }

        /// <summary>
        /// The request to display search results.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        public IActionResult SearchResult(Actor actor)
        {

            /* Call the DAL and pass the values as a model back to the View */
            ActorDAL actorDAL = new ActorDAL(@"Data Source=.\SQLEXPRESS;Initial Catalog=dvdstore;Integrated Security=True");
            IList<Actor> actorList = actorDAL.FindActors(actor.LastName);

            return View(actorList);
        }
    }
}