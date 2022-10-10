using System;
using System.Collections.Generic;
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



        //Latest Upadte Saved 10/10/2022 version 1.0
        //Done 
        //__________________________________________________________

        public bool AddAccomadation(string AccomadationName, string Location, string AccomadationRating, string AccomadationFaclities, string AccomadationDescription)
        {
            var newAccommodation = new Accomdation();
            {
                string Name = AccomadationName;
                string Rating = AccomadationRating;
                string Description = AccomadationDescription;

            };

            DB.Accomdations.InsertOnSubmit(newAccommodation);
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

        public int AddAdmin(string Password, string userName)
        {

            var sysUser = (from s in DB.Admins
                           where s.AdminUsername.Equals(userName) && s.AdminPassword.Equals(Password)
                           select s).FirstOrDefault();
            if (sysUser != null)
            {
                return sysUser.AdminId;
            }
            else
            {
                return 0;
            }
        }

        public void AddOwner(int Userid)
        {


            Owner objOwner = new Owner();
            objOwner.UserId = Userid;


            DB.Owners.InsertOnSubmit(objOwner);


            try
            {
                DB.SubmitChanges();
            }
            catch
            {

            }

            throw new NotImplementedException();
        }

        public void AddStudent(int UserId, string fundingStatus)
        {

            Student student = new Student();
            student.UserId = UserId;
            student.FundingStatus = fundingStatus;


            DB.Students.InsertOnSubmit(student);

            try
            {
                DB.SubmitChanges();
            }
            catch
            {

            }


            throw new NotImplementedException();
        }

        public bool AddUser(string Name, string Surname, string Contact, string UserType)
        {
            var newUser = new User();
            {
                string username = Name;
                string usersurname = Surname;
                string usercontact = Contact;
                string usertype = UserType;

            };

            DB.Users.InsertOnSubmit(newUser);
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

        public void BookmarkAccomadation(int StudID, int BookmarkID, int AccomdationId)
        {

            BookMark NewBooking = new BookMark();

            NewBooking.AccomadationID = AccomdationId;
            NewBooking.StudentId = StudID;
            NewBooking.BookmarkID = BookmarkID;

            DB.BookMarks.InsertOnSubmit(NewBooking);


            try
            {
                DB.SubmitChanges();
            }
            catch
            {
                Console.Write("Could Not Submit Bookmark");
            }


            throw new NotImplementedException();
        }

        //Done
        public void DeleteAccomadation(int Id)
        {

            dynamic objAccomdation = from objAccom in DB.Accomdations where objAccom.AccomadationID == Id select objAccom;

            DB.Accomdations.DeleteOnSubmit(objAccomdation);

            SubmitChanges();


            throw new NotImplementedException();
        }

        //Ghost Function to submit changes
        private void SubmitChanges()
        {
            try
            {
                DB.SubmitChanges();

            }
            catch (Exception e)
            {
                e.GetBaseException();
    
            }
        }
        public void DeleteAdmin(int AdminId)
        {

            dynamic objAdminToDelete = from obj in DB.Admins where obj.AdminId == AdminId select obj;

            DB.Admins.DeleteOnSubmit(objAdminToDelete);



            throw new NotImplementedException();
        }


        public void DeleteBookmark(int BookmarkID)
        {

            dynamic objBookmark = from objB in DB.BookMarks where objB.BookmarkID == BookmarkID select objB;

            DB.BookMarks.DeleteOnSubmit(objBookmark);

            SubmitChanges();
            throw new NotImplementedException();
        }

        public void DeleteOwner(int Id)
        {

            dynamic obj = from objOwner in DB.Owners where objOwner.OwnerId == Id select objOwner;

            DB.Owners.DeleteOnSubmit(obj);

            SubmitChanges();


            throw new NotImplementedException();
        }
        //Done
        public void DeleteStudent(int studentId)
        {
            dynamic obj = from student in DB.Students where student.StudentId == studentId select student;

            DB.Students.DeleteOnSubmit(obj);

            SubmitChanges();

            throw new NotImplementedException();
        }
        //Done
        public void DeleteUser(int UserId)
        {

            dynamic userTodelete = from objUser in DB.Users where objUser.UserId == UserId select objUser;

            DB.Users.DeleteOnSubmit(userTodelete);

            SubmitChanges();
            throw new NotImplementedException();
        }

        public void EditBookmark(int StudID, int BookmarkID, int AccomdationId)
        {

            var bookmark = from objBookMark in DB.BookMarks where objBookMark.BookmarkID == BookmarkID select objBookMark;


            foreach (BookMark obj in bookmark)
            {
                obj.StudentId = StudID;
                obj.AccomadationID = AccomdationId;
                DB.BookMarks.InsertOnSubmit(obj);
            }

            SubmitChanges();


            throw new NotImplementedException();
        }



        public void EditStudent(int studentId, int userId, string Name, string Surname, string Contact, string UserType)
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


        }

        public Accomdation getAccomadation(int Id)
        {
            Accomdation objToReturn = new Accomdation();
            var accomdation = from objAccom in DB.Accomdations where objAccom.AccomadationID == Id select objAccom;

            foreach (Accomdation objAccomdarion in accomdation)
            {
                objToReturn.AccomadationBooking = objAccomdarion.AccomadationBooking;
                objToReturn.AccomadationRating = objAccomdarion.AccomadationRating;
                objToReturn.AccomadationDescription = objAccomdarion.AccomadationDescription;
                objToReturn.AccomadationLocation = objAccomdarion.AccomadationLocation;
                objToReturn.AccomadationName = objAccomdarion.AccomadationName;
                objToReturn.OwnerId = objAccomdarion.OwnerId;

            }

            return objToReturn;
            throw new NotImplementedException();
        }

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

        public string EditAccomadation(int Id, string AccomadationName, string Location, string AccomadationRating, string AccomadationFaclities, string AccomadationDescription)
        {

            var AccomadationCollection = from objAcom in DB.Accomdations where objAcom.AccomadationID == Id select objAcom;




            foreach (Accomdation item in AccomadationCollection)
            {
                item.AccomadationName = AccomadationName;
                item.AccomadationLocation = Location;
                item.AccomadationDescription = AccomadationDescription;
                item.AccomadationRating = Int32.Parse(AccomadationRating);
                item.AccomadationFacilities = AccomadationFaclities;
                item.AccomadationDescription = AccomadationDescription;

            }

            SubmitChanges();
            throw new NotImplementedException();
        }


        public void EditAdmin(int AdminId, string UserName, string Password)
        {
            var admin = from objadmin in DB.Admins where objadmin.AdminId == AdminId select objadmin;

            foreach (Admin obj in admin)
            {
                obj.AdminUsername = UserName;
                obj.AdminPassword = Password;
            }
            SubmitChanges();

            throw new NotImplementedException();
        }

        public void EditUserData(int UserId, string Name, string Surname, string Contact, string UserType)
        {


            var owner = from objUser in DB.Users where objUser.UserId == UserId select objUser ;

            foreach (User obj in owner)
            {
                obj.UserName = Name;
                obj.UserSurname = Name;
                obj.UserContact = Name;
                obj.UserType = UserType;

            }
            SubmitChanges();

            throw new NotImplementedException();
        }

        public void EditOwner(int UserId, string Name, string Contact, int Admin)
        {

            var ownerList = from objowner in DB.Users where objowner.UserId == UserId select objowner;

            foreach(User obj in ownerList)
            {
                obj.UserName = Name;
                obj.UserContact = Contact;
            }

            SubmitChanges();

            throw new NotImplementedException();
        }



        //End Of Done
        //__________________________________




    }
}

