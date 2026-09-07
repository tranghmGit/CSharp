using System;
using System.Collections.Generic;
using System.Text;

namespace Poem.XuanQuynh
{
    internal class Song
    {
        //gọi static bằng cách . trực tiếp tên hàm từ class mà không cần khởi tạo đối tượng
        //Hàm static không cần new class mà chỉ . dùng luôn (chấm trực tiếp từ tên class)
        //Dùng static khi thiết kế ra các thư viện dùng nhanh và không cần lưu lại dữ liệu như một số hàm math.sqrt(),.... (xem lại bài 8)
        public static void PrintSongCode()
        {
            Console.WriteLine(@"

        This is a simple poem:

            Roses are red
            Violets are blue
            Sugar is sweet
            And so are you.");
        }
    }
}
