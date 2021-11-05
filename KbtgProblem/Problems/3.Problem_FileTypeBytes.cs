using KbtgProblem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KbtgProblem.Problems
{
    public class Problem_FileTypeBytes : IRunable
    {
        public void Run()
        {

            var question1 = string.Join(Environment.NewLine, new[]
            {
                "my.song.mp3 11b",
                "greatSing.flac 1000b",
                "not3.txt 5b",
                "video.mp4 200b",
                "game.exe 100b",
                "mov!e.mkv 10000b",
            });
            var answer1 = Solution(question1);

            Console.WriteLine($"answer1:{Environment.NewLine}{answer1}");
        }

        private string Solution(string S)
        {
            var results = new Dictionary<string, int>();
            results["music"] = 0;
            results["images"] = 0;
            results["movies"] = 0;
            results["other"] = 0;

            foreach (var item in S.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                var temp = item.Trim().Split(' ');
                var file = temp.First().Trim();
                var size = int.Parse(temp.Last().Replace("b", ""));
                var type = GetGroupType(file);
                results[type] += size;
                Console.WriteLine($"File: {file}, Size: {size}");
            }

            var message = new StringBuilder();
            foreach (var item in results)
            {
                message.AppendLine($"{item.Key} {item.Value}b");
            }
            return message.ToString();
        }

        private string GetGroupType(string fileName)
        {
            string _type = "." + fileName.Trim().Split('.').Last();
            switch (_type)
            {
                case ".mp3": return "music";
                case ".aac": return "music";
                case ".flac": return "music";

                case ".jpg": return "images";
                case ".bmp": return "images";
                case ".gif": return "images";

                case ".mp4": return "movies";
                case ".avi": return "movies";
                case ".mkv": return "movies";

                default:
                    return "other";
            }
        }
    }
}
