using System;
using System.IO;
using System.Text;

namespace CommentingAndUncommentingCsFiles
{
    public class CommentingStartup
    {
        private const string path = @"D:\Dev\VCSharpPrj\Bella\SEE_EED_Process_ToolRules";

        public static void Main()
        {
            var files = Directory.GetFiles(path, "*.cs");

            Console.WriteLine($"Files found: {files.Length} Directory: {path}");
            Console.WriteLine("This program can uncomment comments, done only by this program!");
            Console.WriteLine($"Type commenting/uncommenting \"c\"/\"u\"");
            string command = Console.ReadLine();

            int uncommented = 0;
            int commented = 0;

            ApplyCommandToFiles(files, command, ref uncommented, ref commented);

            if (command.ToLower() == "c" || command.ToLower() == "commenting")
                Console.WriteLine($"Commented files: {commented}");
            else if (command.ToLower() == "u" || command.ToLower() == "uncommenting")
                Console.WriteLine($"Uncommented files: {uncommented}");
            else
                Console.WriteLine($"Wrong command: {command}");
        }

        private static void ApplyCommandToFiles(string[] files, string command, ref int uncommented, ref int commented)
        {
            foreach (var file in files)
            {
                var allLines = File.ReadAllLines(file);

                if (allLines[0].StartsWith("//COMMENTED BY DONCHO\u2122") &&
                    (command.ToLower() == "u" || command.ToLower() == "uncommenting"))
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i < allLines.Length; i++)
                    {
                        if (allLines[i].StartsWith("//"))
                        {
                            sb.AppendLine(allLines[i].Substring(2));
                        }
                        else
                        {
                            sb.AppendLine(allLines[i]);
                        }
                    }

                    File.WriteAllText(file, sb.ToString());
                    uncommented++;
                }
                else if (!allLines[0].StartsWith("//COMMENTED BY DONCHO\u2122") &&
                    command.ToLower() == "c" || command.ToLower() == "commenting")
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("//COMMENTED BY DONCHO\u2122");
                    foreach (var line in allLines)
                    {
                        sb.AppendLine("//" + line);
                    }

                    File.WriteAllText(file, sb.ToString());
                    commented++;
                }
            }
        }
    }
}
