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

        //List of Users for the app
        List<Users> listOfUsers;
        public List<Users> GetUserInformation()
        {
            //Set the count to 0 and loop through entire table
            int NumberOfUsers = 0;
            foreach(var item in DB.Users)
            {
                //Go through each user and get the information of each user thereafter add it to the list array
                listOfUsers[NumberOfUsers].UserName = item.UserName;
                listOfUsers[NumberOfUsers].UserContact = item.UserContact;
                listOfUsers[NumberOfUsers].UserId = item.UserId;
                NumberOfUsers++;

            }

            System.Console.WriteLine(listOfUsers);

            return listOfUsers;
        }




        string SignUp(String Username, String Password)
        {
            return "";
        }
        string AddAccomadation(String AccomadationName, String Password)
        {
            return "";
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string Login(string Username, string Password)
        {
            throw new NotImplementedException();
        }

        string NextLivingService.SignUp(string Username, string Password)
        {
            throw new NotImplementedException();
        }

        string NextLivingService.AddAccomadation(string AccomadationName, string Password)
        {
            throw new NotImplementedException();
        }
    }
}
