using System;
using System.Diagnostics;
using System.IO;
using ADODB;
using CDO;

namespace EmlReader.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: email_1.eml [email_n.eml]");
            }

            foreach (var arg in args)
            {
                try
                {
                    PrintMail(arg);
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine("Failed to open email: {0}", arg);
                    Console.Error.WriteLine("Exception: {0}", e.Message);
                }
            }
            
            Console.WriteLine("Press any key to quit");
            Console.ReadKey(false);
        }

        private static void PrintMail(string fileName)
        {
            var stream = new StreamClass();
            stream.Open();
            stream.LoadFromFile(fileName);
            stream.Flush();

            var mail = new MessageClass();
            mail.DataSource.OpenObject(stream, "_Stream");
            mail.DataSource.Save();

            Console.WriteLine("From: {0}", mail.From);
            Console.WriteLine("To: {0}", mail.To);
            Console.WriteLine("CC: {0}", mail.CC);
            Console.WriteLine("BCC: {0}", mail.BCC);
            Console.WriteLine("Subject: {0}", mail.Subject);
            Console.WriteLine("Body:");
            Console.WriteLine(mail.TextBody);
            Console.WriteLine();
            Console.WriteLine("Attachments:");
            foreach (IBodyPart attachment in mail.Attachments)
            {
                Console.Write(attachment.FileName);
                Console.Write(" Open it? [y/N] ");
                var key = Console.ReadKey();
                Console.WriteLine();
                if (key.KeyChar != 'Y' && key.KeyChar != 'y') continue;

                var tempFile = Path.Combine(Path.GetTempPath(), attachment.FileName);
                var contentStream = attachment.GetDecodedContentStream();
                contentStream.SaveToFile(tempFile, SaveOptionsEnum.adSaveCreateOverWrite);
                Process.Start(tempFile);
            }
            stream.Close();
        }
    }
}
