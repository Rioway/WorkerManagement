using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class WorkerService
    {
        public Worker GetWorkerByWNum(string wnum,List<Worker> objList)
        {
            Worker objWorker = new Worker();
            //遍历List
            foreach (Worker item in objList)
            {
                if(item.WNum.Equals(wnum))
                {
                    objWorker = new Worker
                    {
                        WNum = item.WNum,
                        WName = item.WName,
                        InDay = item.InDay,
                        Mobile = item.Mobile,
                        Position = item.Position,
                        Email = item.Email,
                        PhotoPath = item.PhotoPath,
                        Gender = item.Gender,
                    };
                    break;
                }
            }
            return objWorker;
        }

        //按照学号模糊查询学生信息
        public List<Worker> GetAllWorkerByWNum(string a,List<Worker> objList)
        {
            List<Worker> objListQuery = new List<Worker>();

            foreach (Worker item in objList)
            {
                if (item.WNum.StartsWith(a))
                {
                    objListQuery.Add(
                        new Worker
                        {
                            WNum = item.WNum,
                            WName = item.WName,
                            InDay = item.InDay,
                            Mobile = item.Mobile,
                            Position = item.Position,
                            Email = item.Email,
                            PhotoPath = item.PhotoPath,
                            Gender = item.Gender,
                        }
                    );
                }
            }
            return objListQuery;
        }

        //按照姓名查询
        public List<Worker> GetAllWorkerByName(string name, List<Worker> objList)
        {
            List<Worker> objListQuery = new List<Worker>();

            foreach (Worker item in objList)
            {
                if (item.WName.StartsWith(name))
                {
                    objListQuery.Add(
                        new Worker
                        {
                            WNum = item.WNum,
                            WName = item.WName,
                            InDay = item.InDay,
                            Mobile = item.Mobile,
                            Position = item.Position,
                            Email = item.Email,
                            PhotoPath = item.PhotoPath,
                            Gender = item.Gender,
                        }
                    );
                }
            }
            return objListQuery;
        }

        //按照手机号码查询
        public List<Worker> GetAllWorkerByMobile(string mobile, List<Worker> objList)
        {
            List<Worker> objListQuery = new List<Worker>();

            foreach (Worker item in objList)
            {
                if (item.Mobile.StartsWith(mobile))
                {
                    objListQuery.Add(
                        new Worker
                        {
                            WNum = item.WNum,
                            WName = item.WName,
                            InDay = item.InDay,
                            Mobile = item.Mobile,
                            Position = item.Position,
                            Email = item.Email,
                            PhotoPath = item.PhotoPath,
                            Gender = item.Gender,
                        }
                    );
                }
            }
            return objListQuery;
        }

        //查询学号是否存在
        public bool IsExistWNum(string wnum, List<Worker> objList)
        {
            foreach (Worker item in objList)
            {
                if(item.WNum.StartsWith(wnum))
                {
                    return true;
                }
            }
            return false;

        }

        //添加学生
        public void AddWorker(Worker objWorker,List<Worker> objList)
        {
            try
            {
                objList.Add(objWorker);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //修改学生
        public void UpdateWorker(Worker objWorker, List<Worker> objList)
        {
            try
            {
                for(int i = 0; i < objList.Count; i++)
                {
                    if(objList[i].WNum.StartsWith(objWorker.WNum))
                    {
                        objList.RemoveAt(i);

                        objList.Insert(i, objWorker);

                        break;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //删除学生
        public void DeleteWorker(Worker objWorker, List<Worker> objList)
        {
            try
            {
                for (int i = 0; i < objList.Count; i++)
                {
                    if (objList[i].WNum.StartsWith(objWorker.WNum))
                    {
                        objList.RemoveAt(i);

                        break;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
