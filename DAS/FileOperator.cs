using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.IO;

namespace DAL
{
    public class FileOperator
    {
        //吧某一个路径的文件读取出来，以List
        public List<Worker> ReadFile(string fileName)
        {
            List<Worker> objList = new List<Worker>();
            string line = string.Empty;
            try
            {
                StreamReader sr = new StreamReader(fileName,Encoding.Default);
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] worker = line.Split(',');
                    //string[] worker = new string[8];
                    //for (int i = 0; i < 7; i++)
                    //{
                    //    worker[i] = worker1[i];
                    //}
                    //foreach (var item in worker1)
                    //{
                    //    int i = 0;
                    //    worker[i] = item;
                    //    i++;
                    //}
                    //worker[7] = null;

                    Worker objworker = new Worker();
                    objworker.WNum = worker[0];
                    objworker.WName = worker[1];
                    objworker.InDay = Convert.ToDateTime(worker[2]);
                    objworker.Position = worker[3];
                    objworker.Mobile = worker[4];
                    objworker.Email = worker[5];
                    objworker.PhotoPath = worker[6];
                    objworker.Gender = worker[7];
                    objList.Add(objworker);
                    //推荐写法；类的初始化器
                    //objList.Add(
                    //    new Worker
                    //    {
                    //         WNum = worker[0],
                    //         Name = worker[1],
                    //         InDay = Convert.ToDateTime(worker[2]),
                    //         Postion = worker[3],
                    //         Mobile = worker[5],
                    //         Email = worker[6],
                    //         PhotoPath = worker[7],
                    //    }
                    // );
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return objList;
        }
    }
}
