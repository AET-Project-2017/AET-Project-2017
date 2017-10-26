using Accenture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Configuration;
using System.Data.SqlClient;

namespace Accenture.Controllers
{
    public class PStudentApplicationController : Controller
    {
        private PStudentApplicationContext db = new PStudentApplicationContext();
        static string sConn = "Accenture.Properties.Settings.PStudentApplicationContext";
        static ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[sConn];
        SqlConnection conn = new SqlConnection(settings.ConnectionString);

        // GET: PStudentApplication
        /*public string Index()
        {
            return "Hello World, this is ASP.Net MVC Tutorials";
        }*/
        public ActionResult Index() {
            /*var studentApplications = from e in db.PStudentApplications;
            orderby e.p_student_application_id;
            select e;*/
            return View();
        }

        // GET: PStudentApplication/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PStudentApplication/Create
        public ActionResult Create(PStudentApplication app)
        {
            try
            {
                db.PStudentApplications.Add(app);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }

        // POST: PStudentApplication/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                PStudentApplication application = new PStudentApplication();
                application.p_student_application_id = Int32.Parse(collection["p_student_application_id"]);
                application.application_id = Int32.Parse(collection["application_id"]);
                application.id_number = collection["id_number"];
                //DateTime jDate;
                //DateTime.TryParse(collection["date_of_birth"], out jDate);
                application.permanent_residential_address = collection["permanent_residential_address"];
                application.permanent_postal_code = Int32.Parse(collection["permanent_postal_code"]);
                application.postal_address = collection["postal_addess"];
                application.postal_postal_code = Int32.Parse(collection["postal_postal_code"]);
                application.next_of_kin_name = collection["next_of_kin_name"];
                application.next_of_kin_contact_number = collection["next_of_kin_contact_number"];
                application.sa_citizenship = (sa_citizenship)Enum.Parse(typeof(sa_citizenship), collection["sa_citizenship"]);
                application.race = (race)Enum.Parse(typeof(race), collection["race"]);
                application.name_of_secondary_school = collection["name_of_secondary_school"];
                application.town_of_secondary_school = collection["town_of_secondary_school"];
                application.province_of_secondary_school = collection["province_of_secondary_school"];
                application.current_university = (current_university)Enum.Parse(typeof(current_university), collection["current_university"]);
                application.degree_name = (degree_name)Enum.Parse(typeof(degree_name), collection["degree_name"]);
                application.current_year_of_study = (current_year_of_study)Enum.Parse(typeof(current_year_of_study), collection["current_year_of_study"]);
                application.student_no = collection["student_no"];
                application.first_semester_courses = collection["first_semester_courses"];
                application.second_semester_courses = collection["second_semester_courses"];
                application.accomodation = (accomodation)Enum.Parse(typeof(accomodation), collection["accomodation"]);
                application.current_finance = (current_finance)Enum.Parse(typeof(current_finance), collection["current_finance"]);
                application.bursary_obligations = collection["bursary_obligations"];
                application.scholarship_awareness = (scholarship_awareness)Enum.Parse(typeof(scholarship_awareness), collection["scholarship_awareness"]);
                application.extension_for_scholarship_awareness = collection["extension_for_scholarship_awareness"];
                application.how_will_the_qualification_benefit_the_society_in_south_africa = collection["how_will_the_qualification_benefit_the_society_in_south_africa"];
                application.previously_applied_for_scholarship = (previously_applied_for_scholarship)Enum.Parse(typeof(previously_applied_for_scholarship), collection["previously_applied_for_scholarship"]);
                application.extention_previously_applied_for_scholarship = collection["extention_previously_applied_for_scholarship"];
                application.father_name = collection["father_name"];
                application.father_occupation = collection["father_occupation"];
                application.father_monthly_income = collection["father_monthly_income"];
                application.mother_name = collection["mother_name"];
                application.mother_occupation = collection["mother_occupation"];
                application.mother_monthly_income = collection["mother_monthly_income"];
                application.guardian_name = collection["guardian_name"];
                application.guardian_occupation = collection["guardian_occupation"];
                application.guardian_monthly_income = collection["guardian_monthly_income"];
                application.other_income_source = collection["other_income_source"];
                //applicationList.Add(application);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PStudentApplication/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PStudentApplication/Edit/5
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

        // GET: PStudentApplication/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PStudentApplication/Delete/5
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
