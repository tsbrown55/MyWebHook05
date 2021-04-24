using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio.AspNet.Common;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;

namespace MyWebHook05.Controllers
{
    public class HelloWorldController : TwilioController
    {
        // GET: HelloWorld
        //[HttpPost]
        //public TwiMLResult Index(SmsRequest request)
        //public ActionResult Index(SmsRequest request)
        public TwiMLResult Index(SmsRequest request)
        {
            string message = "Hi world from Ti Brown using Twilio!\nNow about those credits... 😉";
            message = string.Format(
                "hello {0}. need help? email Ti at this address and put 'SmsBot help' in the subject: {1}. thx!", request.From, "ti55@yahoo.com");
            if (request.Body.Contains("@ti55"))
                message = "now you're just showing off...";
            if (request.Body.Contains("@gk55"))
                message = string.Format("From: {0}\nTo: {1}", 
                    request.From, request.To);
            var response = new MessagingResponse();
            response.Message(message);
            return TwiML(response);
        }

        //public ActionResult Index1()
        //{
        //    return View();
        //}

        // GET: HelloWorld/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HelloWorld/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HelloWorld/Create
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

        // GET: HelloWorld/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HelloWorld/Edit/5
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

        // GET: HelloWorld/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HelloWorld/Delete/5
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
