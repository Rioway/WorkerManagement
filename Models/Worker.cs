using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Worker
    {
        //工号
        public string  WNum { get; set; }
        //姓名
        public string WName { get; set; }
        //入职日期
        public DateTime InDay { get; set; }
        //职位
        public string Position { get; set; }
        //手机号码
        public string  Mobile { get; set; }
        //邮箱
        public string Email { get; set; }
        //照片路径
        public string PhotoPath { get; set; }
        //性别
        public string Gender { get; set; }
    }
}
