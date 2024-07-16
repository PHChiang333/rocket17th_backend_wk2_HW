using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ch2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2-1
            //寫一程式，輸入x和y，如果x>=y，則列印x，否則列印y

            //double x, y;

            //Console.WriteLine("2-1");
            //Console.WriteLine("輸入x和y，如果x>=y，則列印x，否則列印y");
            //Console.WriteLine("請輸入x=");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入y=");
            //y = Convert.ToDouble(Console.ReadLine());

            //if (x >= y) {
            //    Console.WriteLine(x);
            //}
            //else
            //{
            //    Console.WriteLine(y);
            //};

            //Console.ReadKey();

            //-----------------------------------------------------

            //2-2
            //寫一程式，輸入x和y，如果x和y都是正數，令z=1，如兩者均為負數，令z=-1，否則令z=0

            //double x, y;
            //double z;

            //Console.WriteLine("2-2");
            //Console.WriteLine("寫一程式，輸入x和y，如果x和y都是正數，令z=1，如兩者均為負數，令z=-1，否則令z=0");
            //Console.WriteLine("請輸入x=");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入y=");
            //y = Convert.ToDouble(Console.ReadLine());

            //if (x > 0 && y > 0)
            //{
            //    z = 1;
            //}
            //else if (x < 0 && y < 0)
            //{
            //    z = -1;
            //}
            //else
            //{
            //    z = 0;
            //}
            //Console.WriteLine($"z={z}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //2-3
            //寫一程式，輸入x、y、u、v，如果(x+y)>(u+v)，則令z=x+y，否則令z=u+v

            //double x, y,u, v;
            //double z;

            //Console.WriteLine("2-3");
            //Console.WriteLine("輸入x、y、u、v，如果(x+y)>(u+v)，則令z=x+y，否則令z=u+v");
            //Console.WriteLine("請輸入x=");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入y=");
            //y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入u=");
            //u = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入v=");
            //v = Convert.ToDouble(Console.ReadLine());

            //if ((x + y) > (u + v))
            //{
            //    z = x + y;
            //}
            //else
            //{
            //    z = u + v;
            //}

            //Console.WriteLine($"z={z}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //2-4
            //寫一程式，輸入x、y、u、v，如果((𝑥+𝑦))/((𝑢+𝑣))>=2，令z=x+y，否則令z=u+v。

            //double x, y, u, v;
            //double z;

            //Console.WriteLine("2-4");
            //Console.WriteLine("輸入x、y、u、v，如果((x+y))/((u+v))>=2，令z=x+y，否則令z=u+v");

            //Console.WriteLine("請輸入x=");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入y=");
            //y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入u=");
            //u = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入v=");
            //v = Convert.ToDouble(Console.ReadLine());

            //if ((x + y) / (u + v) >= 2)
            //{
            //    z = x + y;
            //}
            //else
            //{
            //    z = u + v;
            //}

            //Console.WriteLine($"z={z}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //2-5
            //寫一程式，輸入x和y，如果x>=y，令z=x^2，否則令z=y^2

            //double x, y;
            //double z;

            //Console.WriteLine("2-5");
            //Console.WriteLine("寫一程式，輸入x和y，如果x>=y，令z=x^2，否則令z=y^2");

            //Console.WriteLine("請輸入x=");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入y=");
            //y = Convert.ToDouble(Console.ReadLine());

            //if (x >= y)
            //{
            //    z = Math.Pow(x, 2);
            //}
            //else
            //{
            //    z = Math.Pow(y, 2);
            //}

            //Console.WriteLine($"z={z}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //2-6
            //稅額計算：請輸入收入，如果收入

            //double income;
            //double rate, difference;
            //double tax;

            //Console.WriteLine("2-6");
            //Console.WriteLine("稅額計算");

            //Console.WriteLine("請輸入income=");
            //income = Convert.ToDouble(Console.ReadLine());

            //if (income > 4090000)
            //{
            //    rate = 0.4;
            //    difference = 721100;
            //}
            //else if (income >= 2180000)
            //{
            //    rate = 0.3;
            //    difference = 312100;
            //}
            //else if (income >= 1090000)
            //{
            //    rate = 0.21;
            //    difference = 115900;
            //}
            //else if (income >= 410000)
            //{
            //    rate = 0.13;
            //    difference = 28700;
            //}
            //else
            //{
            //    rate = 0.06;
            //    difference = 0;
            //}

            //tax = (income * rate) - difference;
            //Console.WriteLine($"您的tax = ({income}*{rate})-{difference}={tax}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //2-7
            //座標象限判斷

            //double x, y;

            //Console.WriteLine("2-7");
            //Console.WriteLine("二元座標象限判斷");

            //Console.WriteLine("請輸入二元座標，依序輸入x,y");
            //Console.WriteLine("請輸入x=");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入y=");
            //y = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine($"座標({x},{y})在:");

            //if (x > 0)
            //{
            //    if (y > 0)
            //    {
            //        Console.WriteLine("1st quadrant\n");
            //    }
            //    else if (y == 0)
            //    {
            //        Console.WriteLine("X-axis\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("4th quadrant\n");
            //    }
            //}
            //else if (x == 0)
            //{
            //    if (y == 0)
            //    {
            //        Console.WriteLine("Origin\n");
            //    }
            //    else { Console.WriteLine("Y-axis\n"); }
            //}
            //else
            //{
            //    if (y > 0)
            //    {
            //        Console.WriteLine("2nd quadrant\n");
            //    }
            //    else if (y == 0)
            //    {
            //        Console.WriteLine("X-axis\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("3rd quadrant\n");
            //    }
            //}

            //Console.ReadKey();

            //-----------------------------------------------------
            //補充習題1
            //Eason 是一位高中電腦老師，這學期正在教學生寫C++程式。他的評分標準是依照每一位學生在 ZeroJudge 系統上解出的題數，去計算出對應的得分。規則如下：
            //答對題數在 0~10 者，每題給6分。
            //題數在 11~20 者，從第11題開始，每題給2分。(前10題還是每題給6分)
            //題數在 21~40 者，從第21題開始，每題給1分。
            //題數在 40 以上者，一律100分。
            //請輸入答對題數，輸出統計後分數 。

            //double numCorrect;
            //double score;

            //Console.WriteLine("補充習題1");
            //Console.WriteLine("評分分數計算");

            //Console.WriteLine("請輸入學生答對題數=");
            //numCorrect = Convert.ToDouble(Console.ReadLine());

            //if (numCorrect > 40)
            //{
            //    //題數在 40 以上者，一律100分。
            //    score = 100;
            //}
            //else if (numCorrect > 20)
            //{
            //    //答對題數在 0~10 者，每題給6分。
            //    //題數在 11~20 者，從第11題開始，每題給2分。(前10題還是每題給6分)
            //    //題數在 21~40 者，從第21題開始，每題給1分。
            //    score = 6 * 10 + 2 * 10 + 1 * (numCorrect - 20);
            //}
            //else if (numCorrect > 10)
            //{
            //    //答對題數在 0~10 者，每題給6分。
            //    //題數在 11~20 者，從第11題開始，每題給2分。(前10題還是每題給6分)
            //    score = 6 * 10 + 2 * (numCorrect - 10);
            //}
            //else {
            //    //答對題數在 0~10 者，每題給6分。
            //    score = 6 * numCorrect;
            //}

            //Console.WriteLine($"該學生的分數為{score}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //補充習題2
            //請輸入身高體重，輸出BMI並顯示這樣的BMI是正常還是過輕、過重。

            //double height, bodyWeight;
            //double BMI;

            //Console.WriteLine("補充習題2");
            //Console.WriteLine("請輸入身高體重，輸出BMI並顯示這樣的BMI是正常還是過輕、過重");

            //Console.WriteLine("請輸入身高___m");
            //height = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入體重___m");
            //bodyWeight = Convert.ToDouble(Console.ReadLine());

            //BMI = bodyWeight / Math.Pow(height, 2);

            //Console.WriteLine($"您的BMI經計算為{BMI}，屬於:");

            //if (BMI >= 24)
            //{
            //    Console.WriteLine("過重(BMI >= 24)");
            //}
            //else if (BMI >= 18.5)
            //{
            //    Console.WriteLine("正常(24 > BMI >= 18.5)");
            //}
            //else
            //{
            //    Console.WriteLine("過輕 (BMI <18.5)");
            //}
            //Console.ReadKey();

            //-----------------------------------------------------
            //補充習題3
            //請隨意輸入三個數，請由大到小依序印出。

            //double x, y, z;
            //double t;

            //Console.WriteLine("補充習題3");
            //Console.WriteLine("請隨意輸入三個數，請由大到小依序印出");

            //Console.WriteLine("請依敘述入任意3個數字");
            //Console.WriteLine("請輸入第1個數字");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入第2個數字");
            //y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入第3個數字");
            //z = Convert.ToDouble(Console.ReadLine());

            ////每個數字依序往後比較，如果較大就換位，反之就不動作
            ////利用另一個t來依序取代
            //if (x < y)
            //{
            //    t = x; x = y; y = t;
            //    //利用t把x,y互換
            //}
            //if (x < z)
            //{
            //    t = x; x = z; z = t;
            //    //利用t把x,z互換
            //}
            //if (y < z)
            //{
            //    t = y; y = z; z = t;
            //    //利用t把y,z互換
            //}

            //Console.WriteLine($"三個數字由大到小排列為{x},{y},{z}");

            //Console.ReadKey();

            //-----------------------------------------------------
            //補充習題4
            //企業發放的獎金根據利潤提成。
            //利潤低於或等於10萬元時，獎金可提10 %；
            //利潤高于10萬元，低於20萬元時，低於10萬元的部分按10 % 提成，高於10萬元的部分，可提成7.5 %；
            //20萬到40萬之間時，高於20萬元的部分，可提成5 %；
            //40萬到60萬之間時高於40萬元的部分，可提成3 %；
            //60萬到100萬之間時，高於60萬元的部分，可提成1.5 %;
            //高於100萬元時，超過100萬元的部分按1 % 提成。
            //請寫一程式，輸入當月利潤，輸出發放獎金總數？

            //double profit, bonus;

            //Console.WriteLine("補充習題4");
            //Console.WriteLine("根據利潤計算獎金");

            //Console.WriteLine("請輸入利潤=______");
            //profit = Convert.ToDouble(Console.ReadLine());

            //if (profit > (100 * 10000))
            //{
            //    bonus = 10 * 10000 * 0.1 + (20 - 10) * 10000 * 0.075 + (40 - 20) * 10000 * 0.075 + (60 - 40) * 10000 * 0.03 + (100 - 60) * 10000 * 0.015 + (profit / 10000 - 100) * 10000 * 0.01;
            //}
            //else if (profit > (60 * 10000))
            //{
            //    bonus = 10 * 10000 * 0.1 + (20 - 10) * 10000 * 0.075 + (40 - 20) * 10000 * 0.075 + (60 - 40) * 10000 * 0.03 + (profit / 10000 - 60) * 10000 * 0.015;
            //}
            //else if (profit > (40 * 10000))
            //{
            //    bonus = 10 * 10000 * 0.1 + (20 - 10) * 10000 * 0.075 + (40 - 20) * 10000 * 0.075 + (profit / 10000 - 40) * 10000 * 0.03;
            //}
            //else if (profit > (20 * 10000))
            //{
            //    bonus = 10 * 10000 * 0.1 + (20 - 10) * 10000 * 0.075 + (profit / 10000 - 20) * 10000 * 0.075;
            //}
            //else if (profit > (10 * 10000))
            //{
            //    bonus = 10 * 10000 * 0.1 + (profit - 10) * 10000 * 0.075;
            //}
            //else
            //{
            //    bonus = profit / 10000 * 10000 * 0.1;
            //}

            //Console.WriteLine($"獎金經計算後為{bonus}");

            //Console.ReadKey();

            //-----------------------------------------------------

            //Ch2增加一題：
            //使用switch改寫：輸入一個學生的分數，輸出該成績級別
            //90分以上→A\n
            //80~89分→B\n
            //70~79分→C\n
            //60~69分→D\n
            //60分以下→F\n

            //double score;

            //Console.WriteLine("Ch2增加一題");
            //Console.WriteLine("使用switch改寫：輸入一個學生的分數，輸出該成績級別");
            //Console.WriteLine("90分以上→A \n80~89分→B\n70~79分→C\n60~69分→D\n60分以下→F");

            //Console.WriteLine("請輸入分數=______，分數需介於0~100");
            //score = Convert.ToDouble(Console.ReadLine());

            //switch (Math.Floor(score / 10))
            //{
            //    case 10: Console.WriteLine("成績級別:A"); break;
            //    case 9: Console.WriteLine("成績級別:A"); break;
            //    case 8: Console.WriteLine("成績級別:B"); break;
            //    case 7: Console.WriteLine("成績級別:C"); break;
            //    case 6: Console.WriteLine("成績級別:D"); break;
            //    default: Console.WriteLine("成績級別:F"); break;
            //}

            //Console.ReadKey();


        }
    }
}
