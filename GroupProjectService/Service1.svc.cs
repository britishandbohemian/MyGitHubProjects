using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GroupProjectService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : NextLivingService
    {

        DataClassesDataContext DB = new DataClassesDataContext();


        //_______________________________________
        //Admin Side

        public void AddAdmin(string Password, string userName)
        {

            Admin objAdmin = new Admin();
            objAdmin.AdminPassword = Password;
            objAdmin.AdminUsername = userName;


            DB.Admins.InsertOnSubmit(objAdmin);

            try
            {
                DB.SubmitChanges();
            }
            catch
            {

            }

        }

        //Delete The Users Information From the database
        public void DeleteAdmin(int AdminId)
        {

            var objAdmin = from objAdminVar in DB.Admins where objAdminVar.AdminId == AdminId select objAdminVar;

            Admin admin = objAdmin.FirstOrDefault();

            if (objAdmin != null)
            {
                DB.Admins.DeleteOnSubmit(admin);
            }

            try{
                DB.SubmitChanges();
            }
            catch
            {

            }

        }
        //Edit The Users Information
        void EditAdmin(int AdminId, string UserName, string Password)
        {

            //Create New admin var
            Admin newobjAdmin = new Admin();
            newobjAdmin.AdminPassword = Password;
            newobjAdmin.AdminUsername = UserName;


            //Seach for that var in mthe db
            var objAdminTemp  = from objAdmin in DB.Admins where objAdmin.AdminId == AdminId select objAdmin; 


            if (objAdminTemp != null)
            {

                DB.Admins.InsertOnSubmit(newobjAdmin);


                try
                {
                    DB.SubmitChanges();
                }
            }


        }





        //_______________________________________
        //Add Owner
        public void AddOwner()
        {
            
        }






        //Add Students
        //_______________________________________
        //Students
        public void AddStudent(string fundingStatus)
        {
            throw new NotImplementedException();
        }


        //Add User
        //_______________________________________

        public void AddUser(string Name, string Surname, string Contact, string UserType)
        {

            //Add user details
            var newUser = new User();
            {
                string username = Name;
                string userSurname = Surname;
                string userContact = Contact;
                string usertype = UserType;

            };


            //Insert Data On submit
            DB.Users.InsertOnSubmit(newUser);
            try
            {
                //Submit Changes
                DB.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return false;
            }
        }




        //Accomadation Settings
        public string EditAccomadation(int Id, string AccomadationName, string Location, string AccomadationRating, string AccomadationFaclities, string AccomadationDescription)
        {
            throw new NotImplementedException();
        }


        //Get All the avaible accomadations
        //_______________________________________

        public List<Accomdation> getAllAccomodations()
        {
            var accommodations = new List<Accomdation>();

            var accommodation = (from a in DB.Accomdations
                                 select a);

            foreach (Accomdation a in accommodation)
            {
                accommodations.Add(a);
            }
            return accommodations; ;
        }


        //Filter Accomadations

        public Accomdation getFiltering(string filter)
        {
            dynamic accommodation = new List<Accomdation>();

            var accommodationInfo = (from a in DB.Accomdations
                                     where a.AccomadationName.Equals(filter)
                                     select a).DefaultIfEmpty();

            foreach (Accomdation a in accommodationInfo)
            {
                var filteredAccommodation = new Accomdation
                {
                    AccomadationID = a.AccomadationID,
                    AccomadationName = a.AccomadationName,
                    AccomadationLocation = a.AccomadationLocation,
                    AccomadationFacilities = a.AccomadationFacilities,
                    AccomadationBooking = a.AccomadationBooking,
                    AccomadationRating = a.AccomadationRating,
                    AccomadationDescription = a.AccomadationLocation
                };
                accommodation.Add(filteredAccommodation);
            }
            return accommodation;
        }









        //Student

        public bool EditStudent(int studentId, int userId, string Name, string Surname, string Contact, string UserType)
        {
            var editstudent = (from e in DB.Users
                               where e.UserId.Equals(studentId) && e.Students.Equals(studentId)
                               select e).FirstOrDefault();

            if (editstudent != null)
            {
                editstudent.UserName = Name;
                editstudent.UserSurname = Surname;
                //Omitted student id, needs to be added in correct table
                editstudent.UserContact = Contact;
                editstudent.UserType = UserType;


            }

            DB.Users.InsertOnSubmit(editstudent);

            try
            {
                DB.SubmitChanges();
                return true;

            }
            catch (Exception e)
            {
                e.GetBaseException();
                return false;
            }
        }

      






        //Admin

        public bool IsAdmin(int AdminId)
        {

            var admin = (from a in DB.Users
                         where a.AdminId.Equals(AdminId)
                         select a).FirstOrDefault();

            String adminstrator = "Adminstrator";

            if (admin != null)
            {
                if (adminstrator.Equals(admin.UserType))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;
        }

        public int updatePassword(int id, string oldPassword, string newPassword)
        {
            var admin = (from a in DB.Admins
                         where a.AdminId.Equals(id)
                         select a).FirstOrDefault();

            if (admin == null)
            {
                return 0;
            }
            else
            {
                if (admin.AdminPassword != oldPassword)
                {
                    return -2;
                }
                else
                {
                    admin.AdminPassword = newPassword;
                    try
                    {
                        DB.SubmitChanges();
                        return 1;
                    }
                    catch (Exception e)
                    {
                        e.GetBaseException();
                        return -1;
                    }
                }
            }
        }


        //User 
        public int UserLogin(string Name, string Password)
        {
            var stuUser = (from s in DB.Admins
                           where s.AdminUsername.Equals(Name) && s.AdminPassword.Equals(Password)
                           select s).FirstOrDefault();

            if (stuUser != null)
            {
                return stuUser.AdminId;
            }
            else
            {
                return 0;
            }
        }
    }
}

