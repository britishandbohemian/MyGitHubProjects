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




        //User Tab
        [OperationContract]
        //Add A user to the database
        void AddUser(String Name, String Surname, String Contact);

        //Delete The Users Information From the database
        void DeletUser(int UserId);
        //Edit The Users Information
        void EditUserData(String Name, String Surname, string Contact);




        //Add Accoomdation
        [OperationContract]
        string AddAccomadation(String AccomadationName, String Location, String AccomadationRating, String AccomadationFaclities, String AccomadationDescription,int BookingId);

        //Get Accomadation via ID
        [OperationContract]
        Accomdations getAccomadation(int Id);

        //Get Accomadation via ID
        [OperationContract]
        Accomdations DeleteAccomadation(int Id);


        //______________________
        //Done User Funcitons
        //Add User
        [OperationContract]
        Users AddUser(string Name, string Contact,string Surname,string UserType);

        //Edit User
        [OperationContract]
        Users EditUser(int Id,String Name, string Contact, string Surname);


        //Delete User
        [OperationContract]
        Users DeleteUser(int Id);




        //______________________



        //Owner
        [OperationContract]
        Owner DeleteOwner(int Id);

        //Delete User
        [OperationContract]
        Owner AddOwner();

        //Delete User
        [OperationContract]
        Owner DelteOwner(String Name, String Contact, int AccomdationID, int userId, int Admin);




        //Booking
        //______________________

        [OperationContract]

        void BookAccomadation();





        //______________________




    }


}
