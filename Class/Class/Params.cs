using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{

    class Params
        //Params dùng để truyền số lượng đối sô vào hàm không xác định
    {
        static int sum(params int[] arr)
        {
            int sum = 0;
            foreach(int x in arr)
            {
                sum += x;
            }
            return sum;
        }     
    }
}
