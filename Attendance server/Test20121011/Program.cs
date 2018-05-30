using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;

namespace Test20121011
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }
        String Data;
        public Program() {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any,9990);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipep);
            server.Listen(20);
            while (true){
                Socket client = server.Accept();
                try
                {
                    String file = Recieve(client);
                    FileInfo FI = new FileInfo(file);
                    Console.WriteLine("-------------------");
                    client.Send(Header(client,FI,Data));
                }
                catch { }
                finally {
                    client.Close();
                }
            }
        }
        public String Recieve(Socket client) {
            String _data_str = "";
            byte[] _data = new byte[4096];
            client.Receive(_data);
            //Console.WriteLine(Encoding.Default.GetString(_data).Trim('\0'));
            //String[] a = Regex.Split(Encoding.Default.GetString(_data).Trim('\0'), "GET");
            //String[] b = Regex.Split(a[0], "HTTP");
            String[] a = Encoding.Default.GetString(_data).Trim('\0').Split(new string[] { "GET /" },StringSplitOptions.None);
            //Console.WriteLine(a[1]);
            String[] b = a[1].Split(new string[] { "HTTP" }, StringSplitOptions.None);
         
            //Console.WriteLine(b[0]);
            Data = b[0];
            String[] _buf = Encoding.Default.GetString(_data).Split("\r\n".ToCharArray());
            if (_buf[0].IndexOf("GET") != -1)
            {
                _data_str = _buf[0].Replace("GET ", "").Replace("HTTP/1.1", "").Trim();
            }
            else {
                _data_str = _buf[0].Replace("POST ", "").Replace("HTTP/1.1", "").Trim();
            }
            if (_data_str.Trim() == "/") {
                _data_str += "index.html";
            }
            int pos = _data_str.IndexOf("?");
            if (pos > 0)
            {
                _data_str = _data_str.Remove(pos);
            }
            return "web"+_data_str;
        }


        public byte[] Header(Socket client,FileInfo FI, String data) {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            string str;
            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"D:\data.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;

            
            

            String user = data.Split('.')[0];
            String month = data.Split('.')[1];
            String no = data.Split('.')[2];

            String _data2 = "";
            int count = 2;
            //str = (string)(range.Cells[1, ] as Excel.Range).Value2;
        
            while(Convert.ToInt32(month) == Convert.ToInt32((range.Cells[count,1] as Excel.Range).Value2))
            {
                _data2 += (range.Cells[count, Convert.ToInt32(no) + 2] as Excel.Range).Value2 + " ";
                count++;
            }
            Console.WriteLine(_data2);
            //Console.WriteLine(str);

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();


            //byte[] _data2 = Encoding.Default.GetBytes("유저 : " + user + "\r\n달 : " + month + "\r\n번호 : " + no);

            
                String _buf = "HTTP/1.0 200 ok\r\n";
                _buf += "Data: " + FI.CreationTime.ToString() + "\r\n";
                _buf += "server: Myung server\r\n";
                _buf += "Content-Length: " + _data2.Length.ToString() + "\r\n";
                _buf += "content-type:text/html\r\n";
                _buf += "\r\n";
                client.Send(Encoding.Default.GetBytes(_buf));

            return Encoding.Default.GetBytes(_data2);
        }
    }
}
