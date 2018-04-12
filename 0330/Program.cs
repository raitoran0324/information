using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0330
{
    class Program
    {
        static void Main(string[] args)
        {
            // 設定顏色
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;


            // 資料陣列
            int[] height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };
            string[] blood = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            string[] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            string[] zodiac = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "雙子", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            string[] name = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "我是陳柏霖2號", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };

            // 宣告變數
            int boycount = 0, girlcount = 0;
            double boyp = 0, girlp = 0;
            int Acount = 0, Bcount = 0, Ocount = 0, ABcount = 0;
            double Ah = 0, Bh = 0, Oh = 0, ABh = 0;
            int sum = 0, boysum = 0, girlsum = 0, ga = 0, ba = 0, all = 0;
            int max = -99999;
            int min = 99999;
            int people = 0;

            // 迴圈計算資料
            for (int i = 0; i < gender.Length; i++)
            {
                // 辦別性別
                if (gender[i] == "男")
                {
                    // 計算人數與百分比
                    boycount += 1;
                    boyp = (boycount / (double)gender.Length) * 100;
                }

                if (gender[i] == "女")
                {
                    girlcount += 1;
                    girlp = (girlcount / (double)gender.Length) * 100;
                }

                // 辨別血型
                if (blood[i] == "A")
                {
                    // 計算人數與百分比
                    Acount += 1;
                    Ah = (Acount / (double)blood.Length) * 100;
                }

                if (blood[i] == "B")
                {
                    Bcount += 1;
                    Bh = (Bcount / (double)blood.Length) * 100;
                }

                if (blood[i] == "O")
                {
                    Ocount += 1;
                    Oh = (Ocount / (double)blood.Length) * 100;
                }

                if (blood[i] == "AB")
                {
                    ABcount += 1;
                    ABh = (ABcount / (double)blood.Length) * 100;
                }

                // 設置身高正常範圍
                if (height[i] > 100 && height[i] < 200)
                {
                    // 計算全班身高總和平均
                    all += 1;
                    sum += height[i];

                    // 計算女生身高總和平均
                    if (gender[i] == "女")
                    {
                        ga += 1;
                        girlsum += height[i];
                    }

                    // 計算男生身高總和平均
                    if (gender[i] == "男")
                    {
                        ba += 1;
                        boysum += height[i];
                    }

                    // 計算最高身高
                    if (height[i] > max)
                    {
                        max = height[i];
                    }

                    // 計算最低身高
                    if (height[i] < min)
                    {
                        min = height[i];
                    }
                }

                // 計算天蠍座O型的人數
                if (zodiac[i] == "天蠍" && blood[i] == "O")
                {
                    people++;
                }

            }

            // 顯示結果
            Console.WriteLine("╔═════════════╗ ");

            Console.WriteLine("║       全班資料清單       ║ ");
            Console.WriteLine("║                          ║ ");

            Console.WriteLine("║  男生人數: {0}   {1:0}%      ║ ", boycount, boyp);
            Console.WriteLine("║  女生人數: {0}   {1:0}%      ║ ", girlcount, girlp);

            Console.WriteLine("║                          ║ ");
            Console.WriteLine("║  A型人數: {0}    {1:0}%      ║ ", Acount, Ah);
            Console.WriteLine("║  B型人數: {0}     {1:0}%      ║ ", Bcount, Bh);
            Console.WriteLine("║  O型人數: {0}    {1:0}%      ║ ", Ocount, Oh);
            Console.WriteLine("║  AB型人數: {0}    {1:0}%       ║ ", ABcount, ABh);

            Console.WriteLine("║                          ║ ");
            Console.WriteLine("║  全班身高總和:" + sum + "      ║ ");
            Console.WriteLine("║  全班身高平均:" + (sum / all) + "        ║ ");

            Console.WriteLine("║                          ║ ");
            Console.WriteLine("║  女生身高總和:" + girlsum + "       ║ ");
            Console.WriteLine("║  女生身高平均:" + (girlsum / ga) + "        ║ ");

            Console.WriteLine("║                          ║ ");
            Console.WriteLine("║  男生身高總和:" + boysum + "       ║ ");
            Console.WriteLine("║  男生身高平均:" + (boysum / ba) + "        ║ ");

            Console.WriteLine("║                          ║ ");
            Console.WriteLine("║  全班最高身高為:" + max + "      ║ ");
            Console.WriteLine("║  全班最低身高為:" + min + "      ║ ");

            Console.WriteLine("║                          ║ ");
            Console.WriteLine("║  天蠍座O型的人數:" + people + "       ║ ");

            // 辨別天蠍座O型的人
            for (int i = 0; i < gender.Length; i++)
            {
                if (zodiac[i] == "天蠍" && blood[i] == "O")
                {
                    Console.WriteLine("║  天蠍座O型的人有:" + name[i] + "  ║ ");
                }
            }

            Console.WriteLine("╚═════════════╝ ");


            // 防止視窗自動關閉
            Console.ReadLine();
        }
    }
}
