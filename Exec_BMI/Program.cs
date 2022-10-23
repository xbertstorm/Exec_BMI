using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("計算BMI");
            Console.Write("請輸入身高：(單位為公尺)");
            string inputheight = Console.ReadLine();
            float numheight = float.Parse(inputheight);
            Console.Write("請輸入體重：(單位為公斤)");
            string inputweight = Console.ReadLine();
            int numweight = int.Parse(inputweight);

            BMI Setting = new BMI();
            Setting.setheight = numheight;
            Setting.setweight = numweight;
            double result = Setting.BMIResult();
            Console.WriteLine(result.ToString("0.0"));

            Console.Read();
        }
    }
    class BMI
    {
        private float height;
        private int weight;

        public float setheight
        {
            get { return height; }
            set { height = value; }
        }
        public int setweight
        {
            get { return weight; }
            set { weight = value; }
        }
        public double BMIResult()
        {
            return weight / Math.Pow(height, 2);
        }
    }
}
