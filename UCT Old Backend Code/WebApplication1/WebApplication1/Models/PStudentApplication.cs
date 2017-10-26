using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Accenture.Models
{
    public enum sa_citizenship { Yes, No }
  
    public enum race { African, Coloured, White, Indian }

    public enum current_university
    {
        [Display(Name = "University of Cape Town")] uct,
        [Display(Name = "University of the Western Cape")] uwc,
        [Display(Name = "Rhodes University")] ru,
        [Display(Name = "University of Pretoria")] up,
        [Display(Name = "University of Johannesburg")] uj,
        [Display(Name = "University of Witwatersrand")] wits
    }

    public enum degree_name
    {
        [Display(Name = "Computer Science")] cs,
        [Display(Name = "Information Systems")] ifs,
        [Display(Name = "Computer Engineering")] ce,
        [Display(Name = "Electrical Engineering (Light Current)")] eelc,
        [Display(Name = "Electronic Engineering")] ee,
        [Display(Name = "Information Engineering")] ife,
        [Display(Name = "Industrial Engineering")] ie
    }

    public enum current_year_of_study
    {
        [Display(Name = "First Year")] first,
        [Display(Name = "Second Year")] second,
        [Display(Name = "Third Year")] third,
        [Display(Name = "Fourth Year")] fourth
    }

    public enum accomodation
    {
        [Display(Name = "University Residence")] ur,
        Home,
        [Display(Name = "Private Residence")] pr
    }

    public enum current_finance { Bursary, Loan, Scholarship, Self }

    public enum scholarship_awareness
    {
        [Display(Name = "Friend/Fellow Student")] friend,
        [Display(Name = "Career Exhibition")] expo,
        [Display(Name = "University Email")] email,
        [Display(Name = "Accenture Website")] accenture,
        Internet,
        Other
    }

    public enum previously_applied_for_scholarship { Yes, No }

    public class PStudentApplication
    {
        public int p_student_application_id { get; set; }
        public int application_id { get; set; }
        public string id_number { get; set; }
        public string date_of_birth { get; set; }
        public string permanent_residential_address { get; set; }
        public string postal_address { get; set; }
        public int postal_postal_code { get; set; }
        public int permanent_postal_code { get; set; }
        public string next_of_kin_name { get; set; }
        public string next_of_kin_contact_number { get; set; }
        public sa_citizenship sa_citizenship { get; set; }
        public race race { get; set; }
        public string name_of_secondary_school { get; set; }
        public string town_of_secondary_school { get; set; }
        public string province_of_secondary_school { get; set; }
        public current_university current_university { get; set; }
        public degree_name degree_name { get; set; }
        public current_year_of_study current_year_of_study { get; set; }
        public string student_no { get; set; }
        public string first_semester_courses { get; set; }
        public string second_semester_courses { get; set; }
        public accomodation accomodation { get; set; }
        public current_finance current_finance { get; set; }
        public string bursary_obligations { get; set; }
        public scholarship_awareness scholarship_awareness { get; set; }
        public string extension_for_scholarship_awareness { get; set; }
        public string how_will_the_qualification_benefit_the_society_in_south_africa { get; set; }
        public previously_applied_for_scholarship previously_applied_for_scholarship { get; set; }
        public string extention_previously_applied_for_scholarship { get; set; }
        public string father_name { get; set; }
        public string father_occupation { get; set; }
        public string father_monthly_income { get; set; }
        public string mother_name { get; set; }
        public string mother_occupation { get; set; }
        public string mother_monthly_income { get; set; }
        public string guardian_name { get; set; }
        public string guardian_occupation { get; set; }
        public string guardian_monthly_income { get; set; }
        public string other_income_source { get; set; }
    }
    public class PStudentApplicationContext : DbContext
    {
        public PStudentApplicationContext()
        { }
        public DbSet<PStudentApplication> PStudentApplications { get; set; }
    }
}