using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GroupProjectService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract] // must Be here
    public interface NextLivingService
    {


        //_______________________________________
        //Admin

        [OperationContract]
        //Add A user to the database
        void AddAdmin(string Password, string userName);
        //Delete The Users Information From the database
        void DeleteAdmin(int AdminId);
        //Edit The Users Information
        void EditAdmin(int AdminId, string UserName, string Password);



        //____________________________________

        //Add User Tab
        [OperationContract]
        //Add A user to the database
        void AddUser(string Name, string Surname, string Contact, string UserType);
        //Delete The Users Information From the database
        void DeleteUser(int UserId);
        //Edit The Users Information
        void EditUserData(int UserId, string Name, string Surname, string Contact, string UserType);





        //Add A user to the database
        //Student_____________________________

        //Add Student
        [OperationContract]
        void AddStudent(string fundingStatus);

        [OperationContract]
        //Delete The Users Information From the database
        void DeleteStudent(int studentId);
       
        [OperationContract]
        //Edit The Users Information
        void EditStudent(int studentId,int userId, string Name, string Surname, string Contact, string UserType);







        //______________________
        //Owner


        //Delete Owner
        [OperationContract]
        void DeleteOwner(int Id);

        //Add Owner
        [OperationContract]
        void AddOwner();

        //Edit Owner
        [OperationContract]
        void EditOwner(int userId, String Name, String Contact, int Admin);


        //______________________




        //Accomadation Table___________________________
        //Add Accoomdation
        [OperationContract]
        string AddAccomadation(String AccomadationName, String Location, String AccomadationRating, String AccomadationFaclities, String AccomadationDescription);

        //Edit Accomadation
        [OperationContract]
        string EditAccomadation(int Id, String AccomadationName, String Location, String AccomadationRating, String AccomadationFaclities, String AccomadationDescription);

        //Get Accomadation via ID
        [OperationContract]
        Accomdation getAccomadation(int Id);

        //Get Accomadation via ID
        [OperationContract]
        Accomdation DeleteAccomadation(int Id);

        //___________________________________


        //Bookmark Accomadation
        [OperationContract]
        void BookmarkAccomadation(int StudID, int BookmarkID, int AccomdationId);

        [OperationContract]
        void DeleteBookmark(int BookmarkID);


        [OperationContract]
        void EditBookmark(int StudID, int BookmarkID, int AccomdationId);


    }


}
