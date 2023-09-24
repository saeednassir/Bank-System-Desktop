using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bank_System_Project
{
    public class clsCurrency
    {



        private enum enMode { EmptyMode = 0, UpdateMode = 1 };
        private enMode Mode;

        private string Country;
        private string CurrencyCode;
        private string CurrencyName;
        private double Rate;

        clsCurrency(enMode Mode, string Country, string CurrencyCode, string CurrencyName, double Rate)
        {
            this.Mode = Mode;
            this.Country = Country;
            this.CurrencyCode = CurrencyCode;
            this.CurrencyName = CurrencyName;
            this.Rate = Rate;
        }

        private static clsCurrency ConvertLineToCurrencyObject(string Line, string Seperator = "#//#")
        {
            string[] sep = new string[1];
            sep[0] = Seperator;

            string[] arrCurrencyData;

            arrCurrencyData = Line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            clsCurrency currency = new clsCurrency(enMode.UpdateMode, arrCurrencyData[0],
                arrCurrencyData[1], arrCurrencyData[2], Convert.ToDouble(arrCurrencyData[3]));

            return currency;
        }

        private static List<clsCurrency> LoadCurrencyDataFromFile()
        {
            List<clsCurrency> ListCurrencyData = new List<clsCurrency>();

            StreamReader reader = new StreamReader("Currencies.txt", Encoding.UTF8);

            string Line;

            while ((Line = reader.ReadLine()) != null)
            {
                clsCurrency Currency = ConvertLineToCurrencyObject(Line);
                ListCurrencyData.Add(Currency);
            }

            reader.Close();

            return ListCurrencyData;
        }

        private static string ConvertCurrencyObjectToLine(clsCurrency Currency, string Seperator = "#//#")
        {
            string RecordLine = "";

            RecordLine += Currency.Country + Seperator;
            RecordLine += Currency.CurrencyCode + Seperator;
            RecordLine += Currency.CurrencyName + Seperator;
            RecordLine += Currency.Rate.ToString() + Seperator;

            return RecordLine;
        }

        private static void SaveCurrencyDataToFile(List<clsCurrency> Currencys)
        {

            StreamWriter writeData = new StreamWriter("Currencies.txt", false, Encoding.UTF8);

            string dataLine = "";

            foreach (clsCurrency Currency in Currencys)
            {
                dataLine = ConvertCurrencyObjectToLine(Currency);
                writeData.WriteLine(dataLine);

            }

            writeData.Close();


        }


        private void Update()
        {
            List<clsCurrency> ListCurrencys = LoadCurrencyDataFromFile();

            foreach (clsCurrency Currency in ListCurrencys)
            {
                if (Currency.CurrencyCode == CurrencyCode)
                {

                    Currency.Mode = Mode;
                    Currency.Country = Country;
                    Currency.CurrencyCode = CurrencyCode;
                    Currency.CurrencyName = CurrencyName;
                    Currency.Rate = Rate;

                    break;
                }
            }

            SaveCurrencyDataToFile(ListCurrencys);
        }

        private static clsCurrency GetEmptyCurrencyObject()
        {
            clsCurrency currency = new clsCurrency(enMode.EmptyMode, "", "", "", 0);

            return currency;
        }

        public bool IsEmpty()
        {
            return (Mode == enMode.EmptyMode);
        }

        public string GetCountry()
        {
            return Country;
        }

        public string GetCurrencyCode()
        {
            return CurrencyCode;
        }

        public string GetCurrencyName()
        {
            return CurrencyName;
        }

        public double GetRate()
        {
            return Rate;
        }

        public void UpdateRate(double Rate)
        {
            this.Rate = Rate;
            Update();
        }


        public static clsCurrency FindByCode(string CurrencyCode)
        {

            StreamReader reader = new StreamReader("Currencies.txt", Encoding.UTF8);

            string Line;

            while ((Line = reader.ReadLine()) != null)
            {

                clsCurrency Currency = ConvertLineToCurrencyObject(Line);

                if (Currency.CurrencyCode.ToLower() == CurrencyCode.ToLower())
                {
                    reader.Close();
                    return Currency;
                }

            }

            reader.Close();

            return GetEmptyCurrencyObject();



        }

        public static clsCurrency FindByCountry(string Country)
        {

            StreamReader reader = new StreamReader("Currencies.txt", Encoding.UTF8);

            string Line;

            while ((Line = reader.ReadLine()) != null)
            {

                clsCurrency Currency = ConvertLineToCurrencyObject(Line);

                if (Currency.Country.ToLower() == Country.ToLower())
                {
                    reader.Close();
                    return Currency;
                }

            }

            reader.Close();

            return GetEmptyCurrencyObject();


        }

        public static bool IsCurrencyExist(string CurrencyCode)
        {
            clsCurrency Currency = FindByCode(CurrencyCode);

            return (!Currency.IsEmpty());
        }

        public static List<clsCurrency> GetCurrenciesList()
        {
            return LoadCurrencyDataFromFile();
        }

        public double ConvertToUSD(double Amount)
        {
            return (double)(Amount / GetRate());
        }

        public double ConvertToOtherCurrency(double Amount, clsCurrency Currency2)
        {
            double AmountInUSD = ConvertToUSD(Amount);

            if (Currency2.GetCurrencyCode() == "USD")
            {
                return AmountInUSD;
            }

            return (double)(AmountInUSD * Currency2.GetRate());

        }




    }
}
