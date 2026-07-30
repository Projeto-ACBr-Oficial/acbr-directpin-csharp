using System;
using System.Globalization;

namespace Lib.Utils.Classes
{
    public static class ConvertHelper
    {
        public static short ToInt16(object _valor, short _default = 0)
        {
            try
            {
                return Convert.ToInt16(_valor, CultureInfo.InvariantCulture);
            }
            catch
            {
                return _default;
            }
        }

        public static int ToInt32(object _valor, int _default = 0)
        {
            try
            {
                return Convert.ToInt32(_valor, CultureInfo.InvariantCulture);
            }
            catch
            {
                return _default;
            }
        }

        public static long ToInt64(object _valor, long _default = 0)
        {
            try
            {
                return Convert.ToInt64(_valor, CultureInfo.InvariantCulture);
            }
            catch
            {
                return _default;
            }
        }

        public static decimal ToDecimal(object _valor, decimal _default = 0)
        {
            try
            {
                return Convert.ToDecimal(_valor, CultureInfo.InvariantCulture);
            }
            catch
            {
                return _default;
            }
        }

        public static double ToDouble(object _valor, double _default = 0)
        {
            try
            {
                return Convert.ToDouble(_valor, CultureInfo.InvariantCulture);
            }
            catch
            {
                return _default;
            }
        }

        public static bool ToBoolean(object _valor, bool _default = false)
        {
            try
            {
                return Convert.ToBoolean(_valor, CultureInfo.InvariantCulture);
            }
            catch
            {
                return _default;
            }
        }

        public static string ToString(object _valor, string _default = "")
        {
            try
            {
                return _valor == null ? _default : Convert.ToString(_valor, CultureInfo.InvariantCulture);
            }
            catch
            {
                return _default;
            }
        }

        public static DateTime ToDateTime(object _valor, DateTime _default)
        {
            try
            {
                return Convert.ToDateTime(_valor, CultureInfo.InvariantCulture);
            }
            catch
            {
                return _default;
            }
        }

        public static DateTime? ToDateTimeOrNull(object _valor)
        {
            try
            {
                return Convert.ToDateTime(_valor, CultureInfo.InvariantCulture);
            }
            catch
            {
                return null;
            }
        }
    }
}
