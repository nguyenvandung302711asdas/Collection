using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Viết một chương trình quản lý sản phẩm. Mỗi khi có sự thay đổi về giá của sản phẩm, 
 * chương trình sẽ phát sinh một sự kiện để thông báo giá mới. 
 * Bạn sẽ cần phải tạo một lớp SanPham với các thuộc tính Ten và Gia.
 * Khi thuộc tính Gia thay đổi, chương trình sẽ kích hoạt một sự kiện GiaThayDoi.

Yêu cầu:

Tạo một lớp SanPham với các thuộc tính Ten và Gia.
Tạo sự kiện GiaThayDoi.
Viết một hàm xử lý sự kiện để in ra thông báo khi giá thay đổi.
*/
namespace Collections
{
        public delegate void stringDeeagte(string name);
        class program
        {
            static void main(string[] ags)
            {
                Hocsinh hs = new Hocsinh();
                hs.NameChanged += Hs_NameChanged;
                hs.Name = "Nguyen";
                hs.Name = "Van";
            }

            private static void Hs_NameChanged(string name)
            {
                Console.WriteLine("Ten da thay doi " + name);
            }
        }
        class Hocsinh
        {
            public event stringDeeagte NameChanged;
            private string _Name;
            public string Name
            {
                get => _Name;
                set
                {
                    _Name = value;
                    if (NameChanged != null)
                    {

                        NameChanged(value);
                    }
                }
            }
        }
    }


