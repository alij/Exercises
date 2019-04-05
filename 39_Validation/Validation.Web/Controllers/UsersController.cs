using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Validation.Web.Models;


namespace Validation.Web.Controllers
{
    public class UsersController : Controller
    {
        // GET: User
        public IActionResult Index()
        {
            return View("Index");
        }

        // GET: User/Register
        // Return the empty registration view
        [HttpGet]
        public IActionResult RegistrationView()
        {
            RegistrationViewModel registrationViewModel = new RegistrationViewModel();
            return View(registrationViewModel);
        }

        // POST: User/Register
        // Validate the model and redirect to confirmation (if successful) or return the 
        // registration view (if validation fails)       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegistrationView(RegistrationViewModel registrationViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("RegistrationView");
            }

            return RedirectToAction("RegistrationSuccessful");
        }

        public IActionResult RegistrationSuccessful()
        {
            return View();
        }

        // GET: User/Login
        // Return the empty login view
        [HttpGet]
        public IActionResult LoginView()
        {
            LoginViewModel loginViewModel = new LoginViewModel();

            return View(loginViewModel);
        }

        // POST: User/Login  
        // Validate the model and redirect to login (if successful) or return the 
        // login view (if validation fails)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LoginView(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("LoginView");
            }

            return RedirectToAction("LoginSuccessful");
        }

        // GET: User/Confirmation
        // Return the confirmation view
        public IActionResult LoginSuccessful()
        {
            return View();
        }
    }
}