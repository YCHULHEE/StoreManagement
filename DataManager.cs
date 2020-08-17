using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using winform_reservation;

namespace StoreManagement
{
    class DataManager
    {
        public static List<TableInfo> TableInfos = new List<TableInfo>();
        public static List<Reservation> Reservations = new List<Reservation>();

        public static void Load_TableInfo()
        {
            try
            {
                TableInfos.Clear();
                string sOutput = File.ReadAllText(@"./tableinfo.xml");
                XElement sXElement = XElement.Parse(sOutput);

                foreach (var item in sXElement.Descendants("tableInfo"))
                {
                    string tableName = item.Element("tableName").Value;
                    int tableNumber = int.Parse(item.Element("tableNumber").Value);
                    int price = int.Parse(item.Element("price").Value);
                    int kidNumber = int.Parse(item.Element("kidNumber").Value);
                    int adultNumber = int.Parse(item.Element("adultNumber").Value);
                    DateTime temp_inTime = item.Element("inTime").Value == "" ? DateTime.Now : DateTime.Parse(item.Element("inTime").Value); //DateTie.Now 대신 DateTime.Now("yyyy-MM-dd")를 입력하면 프로그램 시작한 시점의 시간이 들어감
                    DateTime temp_outTime = item.Element("outTime").Value == "" ? DateTime.Now : DateTime.Parse(item.Element("outTime").Value); //DateTie.Now 대신 DateTime.Now("yyyy-MM-dd")를 입력하면 프로그램 시작한 시점의 시간이 들어감
                    int check = int.Parse(item.Element("check").Value);

                    TableInfo tempTableInfo = new TableInfo()
                    {
                        tableName = tableName,
                        tableNumber = tableNumber,
                        price = price,
                        kidNumber = kidNumber,
                        adultNumber = adultNumber,
                        inTime = temp_inTime,
                        outTime = temp_outTime,
                        check = check
                    };
                    TableInfos.Add(tempTableInfo);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("파일이 누락되었습니다!" + Environment.NewLine + exception.Message);
                PrintLog(exception.StackTrace);
                /*CreateFile_tableinfo();*/
                Save_TableInfo();
                Load_TableInfo();
            }
        }
        public static void Save_TableInfo()
        {
            string tableInfosOutput = "";
            tableInfosOutput += "<TableInfos>" + Environment.NewLine;
            if (TableInfos.Count > 0)
            {
                foreach (var item in TableInfos)
                {
                    tableInfosOutput += "<tableInfo>" + Environment.NewLine;
                    tableInfosOutput += "     <tableName>" + item.tableName + "</tableName>" + Environment.NewLine;
                    tableInfosOutput += "     <tableNumber>" + item.tableNumber + "</tableNumber>" + Environment.NewLine;
                    tableInfosOutput += "     <price>" + item.price + "</price>" + Environment.NewLine;
                    tableInfosOutput += "     <kidNumber>" + item.kidNumber + "</kidNumber>" + Environment.NewLine;
                    tableInfosOutput += "     <adultNumber>" + item.adultNumber + "</adultNumber>" + Environment.NewLine;
                    tableInfosOutput += "     <inTime>" + item.inTime + "</inTime>" + Environment.NewLine;
                    tableInfosOutput += "     <outTime>" + item.outTime + "</outTime>" + Environment.NewLine;
                    tableInfosOutput += "     <check>" + item.check + "</check>" + Environment.NewLine;
                    tableInfosOutput += "</tableInfo>" + Environment.NewLine;
                }
            }
            else
            {
                tableInfosOutput += "<tableInfo>" + Environment.NewLine;
                tableInfosOutput += "     <tableName>" + "" + "</tableName>" + Environment.NewLine;
                tableInfosOutput += "     <tableNumber>" + "" + "</tableNumber>" + Environment.NewLine;
                tableInfosOutput += "     <price>" + "" + "</price>" + Environment.NewLine;
                tableInfosOutput += "     <kidNumber>" + "" + "</kidNumber>" + Environment.NewLine;
                tableInfosOutput += "     <adultNumber>" + "" + "</adultNumber>" + Environment.NewLine;
                tableInfosOutput += "     <inTime>" + "" + "</inTime>" + Environment.NewLine;
                tableInfosOutput += "     <outTime>" + "" + "</outTime>" + Environment.NewLine;
                tableInfosOutput += "     <check>" + "" + "</check>" + Environment.NewLine;
                tableInfosOutput += "</tableInfo>" + Environment.NewLine;
            }

            tableInfosOutput += "</TableInfos>" + Environment.NewLine;
            File.WriteAllText(@"./tableinfo.xml", tableInfosOutput);

        }
        public static void CreateFile_tableinfo()
        {
            string fileName = @"./tableinfo.xml";
            StreamWriter textWrite = File.CreateText(fileName); //파일이 없으면 자동으로 해당 파일을 생성한다.
            textWrite.Dispose(); //메모리 해제. using 키워드로도 할 수 있으나 파일생성만 할 것이므로 별 차이 없다. 로그 남길 때 using 키워드 이용함.
        }


        public static void Load_Reservations()
        {
            try
            {
                Reservations.Clear();
                string sOutput = File.ReadAllText(@"./Reservation_List.xml");
                XElement sXElement = XElement.Parse(sOutput);

                foreach (var item in sXElement.Descendants("reservation"))
                {
                    string name = item.Element("name").Value;
                    string phone_number = item.Element("phone_number").Value;
                    string person = item.Element("person").Value;
                    string time = item.Element("time").Value;
                    string table_number = item.Element("table_number").Value;
                    DateTime temp_RegDate = item.Element("regDate").Value == "" ? DateTime.Now : DateTime.Parse(item.Element("regDate").Value); //DateTie.Now 대신 DateTime.Now("yyyy-MM-dd")를 입력하면 프로그램 시작한 시점의 시간이 들어감

                    Reservation tempReservation = new Reservation()
                    {
                        mName = name,
                        mphone_number = phone_number,
                        mperson = person,
                        mtime = time,
                        mtable_number = table_number,
                        RegDate = temp_RegDate
                    };
                    Reservations.Add(tempReservation);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("파일이 누락되었습니다!" + Environment.NewLine + exception.Message);
                PrintLog(exception.StackTrace);
                CreateFile_Reservations();
                Save_Reservations();
                Load_Reservations();
            }
        }

        public static void Save_Reservations()
        {
            string ReservationsOutput = "";
            ReservationsOutput += "<Reservations>" + Environment.NewLine;
            if (Reservations.Count > 0)
            {
                foreach (var item in Reservations)
                {
                    ReservationsOutput += "<reservation>" + Environment.NewLine;
                    ReservationsOutput += "     <name>" + item.mName + "</name>" + Environment.NewLine;
                    ReservationsOutput += "     <phone_number>" + item.mphone_number + "</phone_number>" + Environment.NewLine;
                    ReservationsOutput += "     <person>" + item.mperson + "</person>" + Environment.NewLine;
                    ReservationsOutput += "     <time>" + item.mtime + "</time>" + Environment.NewLine;
                    ReservationsOutput += "     <table_number>" + item.mtable_number + "</table_number>" + Environment.NewLine;
                    ReservationsOutput += "     <regDate>" + item.RegDate + "</regDate>" + Environment.NewLine;
                    ReservationsOutput += "</reservation>" + Environment.NewLine;
                }
            }
            else
            {
                ReservationsOutput += "<reservation>" + Environment.NewLine;
                ReservationsOutput += "     <name>" + "" + "</name>" + Environment.NewLine;
                ReservationsOutput += "     <phone_number>" + "" + "</phone_number>" + Environment.NewLine;
                ReservationsOutput += "     <person>" + "" + "</person>" + Environment.NewLine;
                ReservationsOutput += "     <time>" + "" + "</time>" + Environment.NewLine;
                ReservationsOutput += "     <table_number>" + "" + "</table_number>" + Environment.NewLine;
                ReservationsOutput += "     <regDate>" + "" + "</regDate>" + Environment.NewLine;
                ReservationsOutput += "</reservation>" + Environment.NewLine;

            }

            ReservationsOutput += "</Reservations>" + Environment.NewLine;

            File.WriteAllText(@"./Reservation_List.xml", ReservationsOutput);

        }
        public static void CreateFile_Reservations()
        {
            string fileName = @"./Reservation_List.xml";
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