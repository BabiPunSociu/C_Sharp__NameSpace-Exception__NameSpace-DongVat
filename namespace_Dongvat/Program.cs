using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dongvat.Anco;
using Dongvat.Anthit;
using Dongvat.Antap;


namespace namespace_Dongvat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tạo con bò
            Bo conBo = new Bo();
            conBo.ID = "1";
            conBo.Name = "Con Bò";
            conBo.Weight = 100.45f;

            // in con Bò
            Console.WriteLine();
            Console.WriteLine("Bo Detail:");
            Console.WriteLine("ID: " + conBo.ID);
            Console.WriteLine("Name: " + conBo.Name);
            Console.WriteLine("Weight: " + conBo.Weight + " kg");

            // tạo con  Trâu
            Trau conTrau = new Trau();
            conTrau.ID = "2";
            conTrau.Name = "Con Trâu";
            conTrau.Weight = 99.05f;

            // in con Trâu
            Console.WriteLine();
            Console.WriteLine("Trau Detail:");
            Console.WriteLine("ID: " + conTrau.ID);
            Console.WriteLine("Name: " + conTrau.Name);
            Console.WriteLine("Weight: " + conTrau.Weight + " kg");

            // tạo con Dê
            De conDe = new De();
            conDe.ID = "3";
            conDe.Name = "Con Dê";
            conDe.Weight = 40.45f;

            // in con Dê
            Console.WriteLine();
            Console.WriteLine("De Detail:");
            Console.WriteLine("ID: " + conDe.ID);
            Console.WriteLine("Name: " + conDe.Name);
            Console.WriteLine("Weight: " + conDe.Weight + " kg");

            // tạo con Cá Sấu
            CaSau conCaSau = new CaSau();
            conCaSau.ID = "4";
            conCaSau.Name = "Con Cá Sấu";
            conCaSau.Weight = 140.75f;

            // in con Cá Sấu
            Console.WriteLine();
            Console.WriteLine("CaSau Detail:");
            Console.WriteLine("ID: " + conCaSau.ID);
            Console.WriteLine("Name: " + conCaSau.Name);
            Console.WriteLine("Weight: " + conCaSau.Weight + " kg");

            // tạo con Hổ
            Ho conHo = new Ho();
            conHo.ID = "5";
            conHo.Name = "Con Hổ";
            conHo.Weight = 150.25f;

            // in con Hổ
            Console.WriteLine();
            Console.WriteLine("Ho Detail:");
            Console.WriteLine("ID: " + conHo.ID);
            Console.WriteLine("Name: " + conHo.Name);
            Console.WriteLine("Weight: " + conHo.Weight + " kg");

            // tạo con Sư Tử
            SuTu conSuTu = new SuTu();
            conSuTu.ID = "6";
            conSuTu.Name = "Con Sư Tử";
            conSuTu.Weight = 200f;

            // in con Sư Tử
            Console.WriteLine();
            Console.WriteLine("SuTu Detail:");
            Console.WriteLine("ID: " + conSuTu.ID);
            Console.WriteLine("Name: " + conSuTu.Name);
            Console.WriteLine("Weight: " + conSuTu.Weight + " kg");

            // tạo con người
            Nguoi conNguoi = new Nguoi();
            conNguoi.ID = "7";
            conNguoi.Name = "Vu Thu Hien";
            conNguoi.Weight = 48.5f;

            // in con người
            Console.WriteLine();
            Console.WriteLine("Nguoi Detail:");
            Console.WriteLine("ID: " + conNguoi.ID);
            Console.WriteLine("Name: " + conNguoi.Name);
            Console.WriteLine("Weight: " + conNguoi.Weight + " kg");
            
        }
    }
}
