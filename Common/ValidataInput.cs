using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Common
{
    public static class ValidataInput
    {
        public static bool IsNumber(string txt)  //判断是否为数字
        {
            Regex objRegex = new Regex(@"^[0-9]*$");
            return objRegex.IsMatch(txt);
        }
        public static bool IsWNum(string txt) //判断是否为学号：10开头的5位数字
        {
            Regex objRegex = new Regex(@"^10\d{3}$");
            return objRegex.IsMatch(txt);
        }
        public static bool IsChinese(string txt)  //判断是否为汉字
        {
            Regex objRegex = new Regex(@"^[\u4e00-\u9fa5]{0,}$");
            return objRegex.IsMatch(txt);
        }
        public static bool IsGender(string txt)  //判断是否填写的男或女
        {
            Regex objRegex = new Regex(@"^男|女$");
            return objRegex.IsMatch(txt);
        }
        public static bool IsMobile(string txt)  //判断手机号码
        {
            Regex objRegex = new Regex(@"^1\d{10}$");
            return objRegex.IsMatch(txt);
        }
        public static bool IsEmail(string txt)  //判断邮箱
        {
            Regex objRegex = new Regex(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            return objRegex.IsMatch(txt);
        }
    }
}
