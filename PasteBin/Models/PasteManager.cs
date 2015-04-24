using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Security.Cryptography;
using System.Web.Mvc;
using System.Text;

namespace PasteBin.Models
{
    public class PasteManager
    {
        public static string StorePaste(Paste p)
        {
            var pasteId = HashPaste(p).Substring(0, 4);
            var directoryToWrite = GenerateDirectoryPathFromHash(pasteId);
            System.IO.File.WriteAllText(directoryToWrite + pasteId, p.PasteData);
            return pasteId;
        }

        public static string GetPaste(string id)
        {
            var directoryPath = GenerateDirectoryPathFromHash(id);
            return File.ReadAllText(directoryPath + id);
        }

        private static string HashPaste(Paste p)
        {
            HashAlgorithm algorithm = SHA1.Create();
            var computedHashString = Convert.ToBase64String(algorithm.ComputeHash(Encoding.UTF8.GetBytes(p.PasteData)));
            return Regex.Replace(computedHashString, @"[^a-zA-Z0-9]", string.Empty);
        }

        private static string GenerateDirectoryPathFromHash(string hash)
        {
            var dirs = Path.GetTempPath() + "PasteId" + Path.DirectorySeparatorChar;
            List<char> dirList = new List<char>();
            foreach (char item in hash)
            {
                dirList.Add(item);
                dirList.Add(Path.DirectorySeparatorChar);
            }
            dirs += new string(dirList.ToArray());
            if (!Directory.Exists(dirs))
            {
                Directory.CreateDirectory(dirs);
            }
            return dirs;
        }
    }
}