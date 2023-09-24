using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using static Bank_System_Project.clsBankClient;
using static Bank_System_Project.clsUser;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bank_System_Project
{
    public class clsUser : clsPerson
    {

        private enum enMode { EmptyMode = 0, UpdateMode = 1, AddNewMode = 2 };

        private enMode Mode;
        private string UserName;
        private string Password;
        private int Permissions;
        private bool MarkedForDelete = false;



        public struct stLoginRegisterRecord
        {
            public string DateTime;
            public string UserName;
            public string Password;
            public int Permissions;
        };

        private static stLoginRegisterRecord ConvertLoginRegisterLineToRecord(string Line, string Seperator = "#//#")
        {

            stLoginRegisterRecord RegisterLogIn;

            string[] sep = new string[1];

            sep[0] = Seperator;

            string[] ListRegisterLogInData = Line.Split(sep, System.StringSplitOptions.RemoveEmptyEntries);

            RegisterLogIn.DateTime = ListRegisterLogInData[0];
            RegisterLogIn.UserName = ListRegisterLogInData[1];
            RegisterLogIn.Password = ListRegisterLogInData[2];
            RegisterLogIn.Permissions = Convert.ToInt32(ListRegisterLogInData[3]);

            return RegisterLogIn;
        }

        private static clsUser ConvertLinetoUserObject(string Line, string Seperator = "#//#")
        {
            string[] sep = new string[1];
            sep[0] = Seperator;

            string[] vUserData;
            vUserData = Line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            clsUser user = new clsUser(enMode.UpdateMode, vUserData[0], vUserData[1],
                vUserData[2], vUserData[3], vUserData[4], vUserData[5], Convert.ToInt32(vUserData[6]));


            return user;


        }

        private static string ConvertUserObjectToLine(clsUser User, string Seperator = "#//#")
        {
            string stUserRecord = "";
            stUserRecord += User.GetFirstName() + Seperator;
            stUserRecord += User.GetLastName() + Seperator;
            stUserRecord += User.GetEmail() + Seperator;
            stUserRecord += User.GetPhone() + Seperator;
            stUserRecord += User.UserName + Seperator;
            stUserRecord += User.Password + Seperator;
            stUserRecord += User.Permissions.ToString();

            return stUserRecord;
        }

        private static List<clsUser> LoadUsersDataFromFile()
        {
            List<clsUser> lUsers = new List<clsUser>();

            StreamReader reader = new StreamReader("Users.txt", Encoding.UTF8);

            string Line;

            while ((Line = reader.ReadLine()) != null)
            {
                clsUser User = ConvertLinetoUserObject(Line);
                lUsers.Add(User);
            }

            reader.Close();

            return lUsers;


        }

        private static void SaveUsersDataToFile(List<clsUser> Users)
        {

            StreamWriter writeData = new StreamWriter("Users.txt", false, Encoding.UTF8);

            string dataLine = "";

            foreach (clsUser User in Users)
            {
                if (User.MarkedForDelete == false)
                {
                    dataLine = ConvertUserObjectToLine(User);
                    writeData.WriteLine(dataLine);
                }

            }

            writeData.Close();


        }

        private void Update()
        {
            List<clsUser> Users;
            Users = LoadUsersDataFromFile();

            foreach (clsUser U in Users)
            {
                if (U.UserName == UserName)
                {
                    U.SetFirstName(this.GetFirstName());
                    U.SetLastName(this.GetLastName());
                    U.SetEmail(this.GetEmail());
                    U.SetPhone(this.GetPhone());
                    U.UserName = UserName;
                    U.Password = Password;
                    U.Permissions = Permissions;

                    break;
                }
            }

            SaveUsersDataToFile(Users);
        }

        private void AddDataLineToFile(string stDataLine)
        {
            StreamWriter writeData = new StreamWriter("Users.txt", true, Encoding.UTF8);

            writeData.WriteLine(stDataLine);

            writeData.Close();


        }

        private void AddNew()
        {
            AddDataLineToFile(ConvertUserObjectToLine(this));
        }

        private static clsUser GetEmptyUserObject()
        {
            clsUser User = new clsUser(enMode.EmptyMode, "", "", "", "", "", "", 0);

            return User;
        }

        string PerpareLogInRecord(string Seperator = "#//#")
        {

            string LoginRecord = "";
            LoginRecord += DateTime.Now.ToString() + Seperator;
            LoginRecord += UserName + Seperator;
            LoginRecord += Password + Seperator;
            LoginRecord += Permissions;

            return LoginRecord;
        }

        clsUser(enMode Mode, string FirstName, string LastName, string Email, string Phone, string UserName, string Password, int Permissions) : base
            (FirstName, LastName, Email, Phone)
        {
            this.Mode = Mode;
            this.UserName = UserName;
            this.Password = Password;
            this.Permissions = Permissions;
        }

        public enum enPermissions
        {
            eAll = -1, pListClients = 1, pAddNewClient = 2, pDeleteClient = 4,
            pUpdateClients = 8, pFindClient = 16, pTranactions = 32,
            pManageUsers = 64, pRegisterLogin = 128, pCurrencyExchange = 256
        };

        public bool IsEmpty()
        {
            return (Mode == enMode.EmptyMode);
        }

        public bool IsMarkedForDelete()
        {
            return MarkedForDelete;
        }

        public string GetUserName()
        {
            return UserName;
        }

        public void SetUserName(string UserName)
        {
            UserName = this.UserName;
        }

        public string GetPassword()
        {
            return Password;
        }

        public void SetPassword(string Password)
        {
            this.Password = Password;
        }

        public int GetPermissions()
        {
            return Permissions;
        }

        public void SetPermissions(int Permissions)
        {
            this.Permissions = Permissions;
        }

        public static clsUser Find(string UserName)
        {

            StreamReader reader = new StreamReader("Users.txt", Encoding.UTF8);

            string Line;

            while ((Line = reader.ReadLine()) != null)
            {

                clsUser User = ConvertLinetoUserObject(Line);

                if (User.UserName.ToLower() == UserName.ToLower())
                {
                    reader.Close();
                    return User;
                }

            }

            reader.Close();

            return GetEmptyUserObject();


        }

        public static clsUser Find(string UserName, string Password)
        {

            clsUser User = Find(UserName);

            if (User.Password == Password)
                return User;
            else
                return GetEmptyUserObject();
        }

        public static bool IsUserExist(string UserName)
        {
            clsUser User = clsUser.Find(UserName);
            return (!User.IsEmpty());
        }

        public enum enSaveResults
        {
            svFaildEmptyObject = 0, svSucceeded = 1,
            svFaildUserExists = 2
        };

        public enSaveResults Save()
        {
            switch (Mode)
            {
                case clsUser.enMode.EmptyMode:
                    return enSaveResults.svFaildEmptyObject;
            
                case clsUser.enMode.UpdateMode:
                    Update();
                    return enSaveResults.svSucceeded;
                   
                case clsUser.enMode.AddNewMode:
                    if (clsUser.IsUserExist(UserName))
                        return enSaveResults.svFaildUserExists;
                    else
                    {
                        AddNew();

                        //We need to set the mode to update after and new
                        Mode = enMode.UpdateMode;
                        return enSaveResults.svSucceeded;
                    }
                default:
                    return enSaveResults.svFaildEmptyObject;

            }
        }


        public static clsUser GetAddNewUserObject(string UserName)
        {
            clsUser user = new clsUser(enMode.AddNewMode, "", "", "", "", UserName, "", 0);
            return user;
        }


        public bool Delete()
        {
            List<clsUser> Users;

            Users = LoadUsersDataFromFile();

            foreach (clsUser U in Users)
            {
                if (U.GetUserName() == UserName)
                {
                    U.MarkedForDelete = true;
                    break;
                }
            }

            SaveUsersDataToFile(Users);

            

            return true;
        }

        public static List<clsUser> GetUsersList()
        {
            return LoadUsersDataFromFile();
        }

        public bool CheckAccessPermission(enPermissions Permissions)
        {
            if (Permissions == enPermissions.eAll)
                return true;

            if (((int)Permissions & this.Permissions) == (int)Permissions)
                return true;
            else
                return false;

        }


        public void RegisterLogIn()
        {


            string stDataLine = PerpareLogInRecord();

            StreamWriter writer = new StreamWriter("LogFile.txt", true, Encoding.UTF8);

            writer.WriteLine(stDataLine);

            writer.Close();

            

        }

        public static List<stLoginRegisterRecord> GetLoginRegisterList()
        {

            List<stLoginRegisterRecord> ListLoginRegisterRecord = new List<stLoginRegisterRecord>();


            StreamReader reader = new StreamReader("LogFile.txt", Encoding.UTF8);

            string Line;

            while ((Line = reader.ReadLine()) != null)
            {
                stLoginRegisterRecord Log;

                Log = ConvertLoginRegisterLineToRecord(Line);

                ListLoginRegisterRecord.Add(Log);
            }

            reader.Close();

            return ListLoginRegisterRecord;

           

        }

        public enSaveResults ResetPassword(string NewPassword)
        {
            this.Password = NewPassword;
            return Save();

        }




    }
}
