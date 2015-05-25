using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace cnode.Converter
{
    public class tap : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string resstr;
            string i = value.ToString();
            switch (i)
            {
                case "share":
                    resstr = "分享";
                    break;
                case "ask":
                    resstr = "问答";
                    break;
                case "top":
                    resstr = "置顶";
                    break;
                //case "share":
                //    resstr = "招聘";
                //    break;
                default:
                    resstr = "招聘";
                    break;
            }

            return resstr;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
