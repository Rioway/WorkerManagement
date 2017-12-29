using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class BuildName
    {
        public static string BuildPhotoName(string fileName)
        {
            //产生名称
            string photoName = DateTime.Now.ToString("yyyyMMddHHmmss");

            //生成随机数
            Random rdm = new Random();
            photoName += rdm.Next(0,99).ToString("00");

            //添加原上传文件的类型
            photoName += fileName.Substring(fileName.Length - 4);

            return photoName;
        }
    }
}
