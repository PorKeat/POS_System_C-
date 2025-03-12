using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Products
{
    class MyData
    {
        internal static void LoadProducts(TableLayoutPanel tableLayoutPanel)
        {
            string[] files = Directory.GetFiles("D:\\SETEC\\C#_II\\POS_Products\\Image");

            int r = 0, c = 1;
            int id = 1;
            Random rnd = new Random();
            foreach (string file in files)
            {
                if (!file.ToLower().EndsWith(".jpg"))
                {
                    continue;
                }

                Image img = Image.FromFile(file);
                string pname = Path.GetFileNameWithoutExtension(file);
                double price = rnd.Next(1, 20);
                ProductControl p = new ProductControl()
                {
                    Id = id++,
                    Picture = img,
                    PName = pname,
                    Price = price
                };
                tableLayoutPanel.Controls.Add(p, c, r);
                c++;
                if (c > 4)
                {
                    c = 1;
                    r++;
                }
            }

        }
    }
}
