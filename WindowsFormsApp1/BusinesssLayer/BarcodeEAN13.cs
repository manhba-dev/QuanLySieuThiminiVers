using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesssLayer
{
    public class BarcodeEAN13
    {
        public BarcodeEAN13()
        {

        }
        public static string BuidEan13(string code)
        {
            int iSum = 0;
            int iDigit = 0;
            // tính số kiểm tra
            for (int i = code.Length; i >= 1; i--)
            {
                iDigit = Convert.ToInt32(code.Substring(i - 1, 1));
                if(i % 2 == 0)
                {
                    //chẵn
                    iSum += iDigit * 3;
                }
                else
                {
                    // lẻ
                    iSum += iDigit * 1;
                }
            }
            int checkSum = (10 - (iSum % 10)) % 10;
            code += checkSum.ToString();
            return code;
        }
    }
}
