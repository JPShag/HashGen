using System.IO;
using System.Windows.Forms;

namespace MD5HashGenerator
{
    public static class FileManager
    {
        public static void SaveToFile(string text)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "Text Files (*.txt)|*.txt" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, text);
            }
        }

        public static string LoadFromFile()
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Text Files (*.txt)|*.txt" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return File.ReadAllText(ofd.FileName);
            }
            return "";
        }
    }
}
