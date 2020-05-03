using System;
using System.IO;

namespace Coutaq
{
    public class FileExpert
    {
        /// <summary>
        /// Saves the text to a relative path.
        /// </summary>
        /// <param name="content">The content of the file.</param>
        /// <param name="filePath">The path to the file.</param>
        public static void SaveToRelativePath(String filePath, String content)
        {
            if (Environment.OSVersion.Platform.ToString().Contains("Win"))
                File.WriteAllText(".\\"+filePath, content);
            else
                File.WriteAllText("/"+filePath, content);
        }
        /// <summary>
        /// Saves the text to an absolute path.
        /// </summary>
        /// <param name="content">The content of the file.</param>
        /// <param name="filePath">The path to the file.</param>
        public static void SaveToAbsolutePath(String filePath, String content)
        {
            filePath.Replace('/', '\\');
            if (Environment.OSVersion.Platform.ToString().Contains("Win"))
                File.WriteAllText(filePath, content);
            else
                File.WriteAllText( filePath.Replace('\\', '/'), content);
        }
        /// <summary>
        /// Reads the text from a relative path.
        /// </summary>
        /// <returns>
        /// Text from the file.
        /// </returns>
        /// <param name="filePath">The path to the file.</param>
        public static string ReadFromRelativePath(String filePath)
        {
            if (Environment.OSVersion.Platform.ToString().Contains("Win"))
                return File.ReadAllText(".\\" + filePath);
            else
                return File.ReadAllText("/" + filePath);
        }
        /// <summary>
        /// Reads the text from an absolute path.
        /// </summary>
        /// <returns>
        /// Text from the file.
        /// </returns>
        /// <param name="filePath">The path to the file.</param>
        public static string ReadFromAbsolutePath(String filePath)
        {
            filePath.Replace('/', '\\');
            if (Environment.OSVersion.Platform.ToString().Contains("Win"))
                return File.ReadAllText(filePath);
            else
                return File.ReadAllText(filePath.Replace('\\', '/'));
        }
    }

}
