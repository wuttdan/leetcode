using CodinGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.Problems
{
    public class Problem_DetectiveGeek : IRunable
    {
        private readonly List<string> Months = new List<string>
        {
                "jan",
                "feb",
                "mar",
                "apr",
                "may",
                "jun",
                "jul",
                "aug",
                "sep",
                "oct",
                "nov",
                "dec",
        };

        public void Run()
        {
            (string time1, string address1) = Solution("#*######*#*", "mayjul sepsep octapr octsep sepjun octjan");
            Debug.WriteLine($"Time: {time1}, Address: {address1}");//15:30, 6hotel

            (string time2, string address2) = Solution("#**##**###*", "sepjul octjul sepjun octaug sepsep junsep sepjun sepjun sepmay marsep octjul sepjun octaug octsep sepfeb octoct octjul sepfeb octmar octsep");
            Debug.WriteLine($"Time: {time2}, Address: {address2}");//12:30, freshDeed restaurant

            (string time3, string address3) = Solution("##*#**#**", "maysep mayfeb marsep junoct octjan marsep jundec sepsep octapr octjul sepjul sepfeb marsep junoct octjan marsep augjan octapr sepaug sepfeb octjul sepjun novfeb sepfeb marsep juldec octsep aprnov marsep julnov sepfeb octfeb octjan marsep juldec octsep sepfeb octsep sepoct octapr octmar");
            Debug.WriteLine($"Time: {time3}, Address: {address3}");//04:20, 81 El Ghorfa El Togareya St.Raml Station

            (string time4, string address4) = Solution("######*###", "maymay maymar aprdec mayapr mayfeb aprsep marsep julaug octmay octmay marsep junaug marsep mayfeb mayfeb mayapr aprsep marsep juljul sepjun octdec marsep juljun octapr octsep sepoct marsep juljul sepfeb sepaug sepfeb octjul");
            Debug.WriteLine($"Time: {time4}, Address: {address4}");//10:15, 42/31, Opp C 113, New Moti Nagar

            (string time5, string address5) = Solution("#***#*#**###", "mayfeb mayaug mayfeb aproct mayfeb mayjan maysep mayaug aprsep marsep augjun sepfeb octjul sepfeb sepoct sepapr sepsep octapr aprsep marsep juldec sepsep sepoct octmar sepnov octoct sepdec octoct aproct sepdec octoct aprsep marsep augjan octapr sepdec novfeb octapr");
            Debug.WriteLine($"Time: {time5}, Address: {address5}");//22:15, 171-1087, Yaraicho, Shinjuku-ku, Tokyo

            (string time6, string address6) = Solution("##**##*#***", "augmar sepoct sepfeb marsep julmay sepjun octapr octmay sepfeb octjul sepmay sepoct marsep mayaug mayjun");
            Debug.WriteLine($"Time: {time6}, Address: {address6}");//16:40, Via Leopardi 75

            (string time7, string address7) = Solution("##*#*###", "mayfeb maymar mayjun aproct mayaug aprsep marsep augapr octapr octmar octmay novfeb sepjun octapr octmar sepaug marsep maymar aprmay sepoct aprjun aproct sepmay octapr octmar sepaug aprsep marsep jundec octoct octfeb sepoct aproct octaug sepoct aprsep marsep jundec novfeb sepjun octapr octmar sepaug octaug sepfeb octmar sepaug sepmar octoct sepdec aproct sepmay octapr");
            Debug.WriteLine($"Time: {time7}, Address: {address7}");//02:15, 125-7, Wonpyeong 2(i)-dong, Gumi-si, Gyeongsangbuk-do
        }

        private (string, string) Solution(string time, string address)
        {
            time = time.Replace("#", "1").Replace("*", "0");
            var awnser1 = SplitToChunk($"{Convert.ToInt32(time, 2)}", 2).FirstOrDefault();
            var awnser2 = string.Join("", SplitToChunk(address, 3, true, ' ').ToArray());
            return (awnser1, awnser2);
        }

        public IEnumerable<string> SplitToChunk(string message, int chunkLength, bool isMonth = false, char splitter = default(char))
        {
            if (!isMonth && message.Length % 2 != 0) message = $"0{message}";
            foreach (var item in message.Split(splitter))
            {
                var a = item.Substring(0, chunkLength).ToLower();
                var b = item.Substring(chunkLength, chunkLength).ToLower();

                if (!isMonth) yield return $"{a}:{b}";
                var c = ConvertToBase12ToAscii($"{Months.IndexOf(a)}{Months.IndexOf(b)}");
                yield return $"{c}";
            }
        }

        public char ConvertToBase12ToAscii(string aString, int base12 = 12)
        {
            int n = aString.Length;
            int summary = 0;
            int first = int.Parse(aString.Substring(0, 1));
            int second = int.Parse(aString.Substring(1));
            /**ดักเคสที่เกิด bug 101 มันจะแปลงเป็นฐาน10 ได้ 13 เสร็จแล้วจะแปลงเป็น ascii ได้ \r ซึ่งที่จริงควจจะเป็น 121 จะได้ ascii = y*/
            if (int.Parse(aString.Substring(1, 1)[0].ToString()) == 0 && aString.Substring(1).Length > 1)
            {
                summary = int.Parse((first * base12).ToString() + second.ToString());
            }
            else
            {
                summary = (first * base12) + second; // การแปลงฐาน10 แบบ3หลัก เป็น 12 เช่น 511 => 12*5+11 = 71 นำหลักแรกคูณ 2 แล้วที่เหลือก็บวกต่อ 
            }
            char result = Convert.ToChar(summary);
            return result;// convert base10 to ascii  
        }
    }

}
