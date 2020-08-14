using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace StoreManagement
{
    class DataManager
    {
        public static List<Customer> Customers = new List<Customer>();

        public static void Load_Customers()
        {
            try
            {
                Customers.Clear();
                string sOutput = File.ReadAllText(@"./customersList.xml");
                XElement sXElement = XElement.Parse(sOutput);

                foreach (var item in sXElement.Descendants("customer"))
                {
                    string Name = item.Element("name").Value;
                    string Sex = item.Element("sex").Value;
                    string Phonenumber = item.Element("phonenumber").Value;
                    string Birthday = item.Element("birthday").Value;
                    DateTime Regdate = item.Element("regdate").Value == "" ? DateTime.Now : DateTime.Parse(item.Element("regdate").Value); //DateTie.Now 대신 DateTime.Now("yyyy-MM-dd")를 입력하면 프로그램 시작한 시점의 시간이 들어감

                    Customer tempcustomer = new Customer()         // 생성자 선언
                    {
                        m_Name = Name,
                        m_Sex = Sex,
                        m_PhoneNum = Phonenumber,
                        m_Birthday = Birthday,
                        m_Regdate = Regdate
                    };
                    Customers.Add(tempcustomer);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("파일이 누락되었습니다!" + Environment.NewLine + exception.Message);
                PrintLog(exception.StackTrace);
                CreateFile_customers_List();
                Save_Customers();
                Load_Customers();
            }
        }

        public static void Save_Customers()
        {
            string CustomersOutput = "";
            CustomersOutput += "<Customers>" + Environment.NewLine;
            if (Customers.Count > 0)
            {
                foreach (var item in Customers)
                {
                    CustomersOutput += "<customer>" + Environment.NewLine;
                    CustomersOutput += "     <name>" + item.m_Name + "</name>" + Environment.NewLine;
                    CustomersOutput += "     <sex>" + item.m_Sex + "</sex>" + Environment.NewLine;
                    CustomersOutput += "     <phonenumber>" + item.m_PhoneNum + "</phonenumber>" + Environment.NewLine;
                    CustomersOutput += "     <birthday>" + item.m_Birthday + "</birthday>" + Environment.NewLine;
                    CustomersOutput += "     <regdate>" + item.m_Regdate + "</regdate>" + Environment.NewLine;
                    CustomersOutput += "</customer>" + Environment.NewLine;
                }
            }
            else // if (Customers.Count < 0) 없을때 
            {
                CustomersOutput += "<customer>" + Environment.NewLine;
                CustomersOutput += "     <name>" + "" + "</name>" + Environment.NewLine;
                CustomersOutput += "     <sex>" + "" + "</sex>" + Environment.NewLine;
                CustomersOutput += "     <phonenumber>" + "" + "</phonenumber>" + Environment.NewLine;
                CustomersOutput += "     <birthday>" + "" + "</birthday>" + Environment.NewLine;
                CustomersOutput += "     <regdate>" + "" + "</regdate>" + Environment.NewLine;
                CustomersOutput += "</customer>" + Environment.NewLine;

            }
            CustomersOutput += "</Customers>" + Environment.NewLine;
            File.WriteAllText(@"./customersList.xml", CustomersOutput);
        }

        public static void CreateFile_customers_List()
        {
            string fileName = @"./customersList.xml";
            StreamWriter textWrite = File.CreateText(fileName); //파일이 없으면 자동으로 해당 파일을 생성한다.
            textWrite.Dispose(); //메모리 해제. using 키워드로도 할 수 있으나 파일생성만 할 것이므로 별 차이 없다. 로그 남길 때 using 키워드 이용함.
        }
        public static void PrintLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("ProgramHistory");
            if (!di.Exists)
            {
                di.Create();
            }
            using (StreamWriter writer = new StreamWriter("ProgramHistory" + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", true))
            {
                writer.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff")}]" + contents);
            }
        }
    }
}
