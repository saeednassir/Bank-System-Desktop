using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.NetworkInformation;
using static Bank_System_Project.clsBankClient;

namespace Bank_System_Project
{
    public class clsBankClient : clsPerson
    {

        private enum enMode { EmptyMode = 0, UpdateMode = 1, AddNewMode = 2 };

        private enMode Mode;

        private string AccountNumber;

        private string PinCode;

        private double AccountBalance;

        private bool MarkedForDelete = false;

        private string PerpareTransferLogRecord(double Amount, clsBankClient DestinationClient, string UserName, string Seperator = "#//#")
        {
            string TransferLogRecord = "";
            TransferLogRecord += DateTime.Now.ToString() + Seperator;
            TransferLogRecord += GetAccountNumber() + Seperator;
            TransferLogRecord += DestinationClient.GetAccountNumber() + Seperator;
            TransferLogRecord += Amount.ToString() + Seperator;
            TransferLogRecord += GetAccountBalance().ToString() + Seperator;
            TransferLogRecord += DestinationClient.GetAccountBalance() + Seperator;
            TransferLogRecord += UserName;

            return TransferLogRecord;
        }

        private void RegisterTransferLog(double Amount, clsBankClient DestinationClient, string UserName)
        {
            string stDataLine = PerpareTransferLogRecord(Amount, DestinationClient, UserName);

            StreamWriter writer = new StreamWriter("TransferLog.txt", true, Encoding.UTF8);

            writer.WriteLine(stDataLine);

            writer.Close();

        }

        
        public struct stTransferLog
        {
           public string DateTime;
           public string AccountNumberSourceClient;
           public string AccountNumberDestinationClient;
           public double Amount;
           public double BalanceSourceClient;
           public double BalanceDestinationClient;
           public string UserName;
        };

       
        private static stTransferLog ConvertTransferLogLineToRecord(string Line, string Seperator = "#//#")
        {
            stTransferLog TransferLog;

            string[] sep = new string[1];

            sep[0] = Seperator;

            string[] listTransferLog = Line.Split(sep,System.StringSplitOptions.RemoveEmptyEntries);

            TransferLog.DateTime = listTransferLog[0];
            TransferLog.AccountNumberSourceClient = listTransferLog[1];
            TransferLog.AccountNumberDestinationClient = listTransferLog[2];
            TransferLog.Amount = Convert.ToDouble(listTransferLog[3]);
            TransferLog.BalanceSourceClient = Convert.ToDouble(listTransferLog[4]);
            TransferLog.BalanceDestinationClient = Convert.ToDouble(listTransferLog[5]);
            TransferLog.UserName = listTransferLog[6];

            return TransferLog;
        }

        clsBankClient(enMode Mode, string FirstName, string LastName, string Email, string Phone,
            string AccountNumber, string PinCode, double AccountBalance) : base(FirstName, LastName,Email,Phone)
        {
            this.Mode = Mode;
            this.AccountNumber = AccountNumber;
            this.PinCode = PinCode;
            this.AccountBalance = AccountBalance;
        }


        private static clsBankClient GetEmptyClientObject()
        {
            clsBankClient clsBankClient = new clsBankClient(enMode.EmptyMode, "", "", "", "", "", "", 0);
            return clsBankClient;
        }

        public string GetAccountNumber()
        {
            return this.AccountNumber;
        }

        public string GetPinCode()
        {
            return this.PinCode;
        }

        public void SetPinCode(string PinCode)
        {
            this.PinCode = PinCode;
        }

        public double GetAccountBalance()
        {
            return this.AccountBalance;
        }

        public void SetAccountBalance(double AccountBalance)
        {
            this.AccountBalance = AccountBalance;
        }

        public bool IsEmpty()
        {
            return (this.Mode == enMode.EmptyMode);
        }

        public bool IsMarkedForDelete()
        {
            return this.MarkedForDelete;
        }

        private static clsBankClient ConvertLinetoClientObject(string Line, string Seperator = "#//#")
        {
            string[] sep = new string[1];

            sep[0] = Seperator;

            string[] ClientData;

            ClientData = Line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            clsBankClient Client = new clsBankClient(enMode.UpdateMode, ClientData[0], 
                ClientData[1],ClientData[2], ClientData[3], ClientData[4], ClientData[5],
                Convert.ToDouble(ClientData[6]));

            return Client;
        }

        public static clsBankClient Find(string AccountNumber)
        {
            StreamReader reader = new StreamReader("Clients.txt",Encoding.UTF8);

            string Line;

            while((Line = reader.ReadLine()) != null)
            {
           
                clsBankClient Client = ConvertLinetoClientObject(Line);

                if(Client.GetAccountNumber() == AccountNumber)
                {
                    reader.Close();
                    return Client;
                }

            }

            reader.Close();

            return GetEmptyClientObject();
           
        }

        public static clsBankClient Find(string AccountNumber, string PinCode)
        {
            clsBankClient client = Find(AccountNumber);

            if(client.PinCode == PinCode)
            {
                return client;
            }else
            {
                return GetEmptyClientObject();
            }

        }

        public static bool IsClientExist(string AccountNumber)
        {
            clsBankClient Client = clsBankClient.Find(AccountNumber);
            return (!Client.IsEmpty());
        }

        private static string ConvertClientObjectToLine(clsBankClient Client, string Seperator = "#//#")
        {
            string stClientRecord = "";

            stClientRecord += Client.GetFirstName() + Seperator;
            stClientRecord += Client.GetLastName()+ Seperator;
            stClientRecord += Client.GetEmail()+ Seperator;
            stClientRecord += Client.GetPhone()+ Seperator;
            stClientRecord += Client.GetAccountNumber()+ Seperator;
            stClientRecord += Client.GetPinCode()+ Seperator;
            stClientRecord += Client.GetAccountBalance().ToString();

            return stClientRecord;

        }

        private void AddDataLineToFile(string stDataLine)
        {
            StreamWriter writeData = new StreamWriter("Clients.txt",true,Encoding.UTF8);

            writeData.WriteLine(stDataLine);

            writeData.Close();
        }

        private void AddNew()
        {
            AddDataLineToFile(ConvertClientObjectToLine(this));
        }

        public static clsBankClient GetAddNewClientObject(string AccountNumber)
        {
            clsBankClient clsBankClient = new clsBankClient(enMode.AddNewMode, "", "", "", "", AccountNumber, "", 0);
            return clsBankClient;
        }

        private static List<clsBankClient> LoadClientsDataFromFile()
        {

            List<clsBankClient> Clients = new List<clsBankClient>();


            StreamReader reader = new StreamReader("Clients.txt", Encoding.UTF8);

            string Line;

            while ((Line = reader.ReadLine()) != null)
            {
                clsBankClient Client = ConvertLinetoClientObject(Line);

                Clients.Add(Client);
            }
            reader.Close();
            return Clients;
        }

        private static void SaveClientsDataToFile(List<clsBankClient> Clients)
        {
            StreamWriter writeData = new StreamWriter("Clients.txt", false, Encoding.UTF8);

            string dataLine = "";
            
            foreach(clsBankClient Client in Clients)
            {
                if(Client.IsMarkedForDelete() == false)
                {
                    dataLine = ConvertClientObjectToLine(Client);
                    writeData.WriteLine(dataLine);
                }
               
            }

            writeData.Close();

        }

        private void Update()
        {

            List<clsBankClient> Clients = new List<clsBankClient>();

            Clients = LoadClientsDataFromFile();

            foreach(clsBankClient Client in Clients)
            {
                if(Client.GetAccountNumber() == this.GetAccountNumber())
                {
                    Client.AccountNumber = this.GetAccountNumber();

                    Client.SetFirstName(this.GetFirstName());
                    Client.SetLastName(this.GetLastName());
                    Client.SetEmail(this.GetEmail());
                    Client.SetPhone(this.GetPhone());
                    Client.SetPinCode(this.GetPinCode());
                    Client.SetAccountBalance(this.GetAccountBalance());

                    break;
                }
            }

            SaveClientsDataToFile(Clients);

        }

        public bool Delete()    
        {
            List<clsBankClient> Clients = new List<clsBankClient>();

            Clients = LoadClientsDataFromFile();

            foreach (clsBankClient Client in Clients)
            {
                if(Client.GetAccountNumber() == this.GetAccountNumber())
                {
                    Client.MarkedForDelete = true;
                    break;
                }
            }

            SaveClientsDataToFile(Clients);
            return true;
        }

        public static List<clsBankClient> GetClientsList()
        {
            return LoadClientsDataFromFile();
        }

        public enum enSaveResults
        {
            svFaildEmptyObject = 0, svSucceeded = 1,
            svFaildAccountNumberExists = 2
        };

        public enSaveResults Save()
        {
            switch(this.Mode)
            {
                case enMode.EmptyMode:
                    return enSaveResults.svFaildEmptyObject;

                case enMode.UpdateMode:
                    Update();
                    return enSaveResults.svSucceeded;

                case enMode.AddNewMode:
                    if (clsBankClient.IsClientExist(AccountNumber))
                    {
                        return enSaveResults.svFaildAccountNumberExists;
                    }
                    else
                    {
                        AddNew();
                        Mode = enMode.UpdateMode;
                        return enSaveResults.svSucceeded;
                    }


                default:
                    return enSaveResults.svFaildEmptyObject;
            }
        }

        public static double GetTotalBalances()
        {
            List<clsBankClient> listClient = new List<clsBankClient>();

            listClient = GetClientsList();

            double TotalBalances = 0;

            foreach (clsBankClient client in listClient)
            {
                TotalBalances += client.GetAccountBalance();
            }

            return TotalBalances;

        }

        public void Deposit(double Amount)
        {
            SetAccountBalance((GetAccountBalance() + Amount));
            Save();
        }

        public bool Withdraw(double Amount)
        {
            if (Amount > GetAccountBalance())
                return false;
            else
            {
                SetAccountBalance(GetAccountBalance() - Amount);
                Save();
                return true;
            }

        }

        public bool Transfer(double Amount, clsBankClient DestinationClient, string UserName)
        {
            if(Amount >  GetAccountBalance())
                return false;

            Withdraw(Amount);
            DestinationClient.Deposit(Amount);
            RegisterTransferLog(Amount, DestinationClient, UserName);

            return true;

        }

        public static List<stTransferLog> GetTransferLogList()
        {
            List<stTransferLog> ListTransferLog = new List<stTransferLog>();

            StreamReader reader = new StreamReader("TransferLog.txt", Encoding.UTF8);

            string Line;

            while ((Line = reader.ReadLine()) != null)
            {
                stTransferLog TransferLog;

                TransferLog = ConvertTransferLogLineToRecord(Line);

                ListTransferLog.Add(TransferLog);

            }
            
            reader.Close();

            return ListTransferLog;

            
        }

        

    }
}
