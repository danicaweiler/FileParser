// -----------------------------------------------
// File   : ParseContent.cs
// By     : Danica Weiler
// Date   : May 8, 2019
// Purpose: Methods for handling parsing of data
// -----------------------------------------------

using System;
using System.IO;
using System.Linq;


namespace FileReadParser
{
    public class ParseContent
    {
        ///<summary>
        /// "CountLines" method counts all the lines in the file given their is a file path
        /// </summary>
        /// <param name="filePath">Path file to read</param>
        /// <returns>int - Total count results of lines in file</returns>
        public static int CountLines(string filePath)
        {
            return File.ReadLines(filePath).Count();
        }


        /// <summary>
        /// "CountWords" method Counts the words from the local string of filecontent which has been filled by the file reader
        /// by spliting at anything that is not a letter and counting results
        /// </summary>
        /// <param name="fileContent">Contents to use</param>
        /// <returns>int - Total count results of words in fileContent</returns>
        public static int CountWords(string fileContent)
        {
            string[] fields = fileContent.Split("!@#$%^&*()_+-={}[];:,./<>? ~123456790".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);
            return fields.Length;
        }


        /// <summary>
        /// "CountUpper" method counts the uppercase letters from the local string of filecontent
        /// </summary>
        /// <param name="fileContent">Contents to use</param>
        /// <returns>int - Total count results of uppercase letters in fileContent</returns>
        public static int CountUpper(string fileContent)
        {
            return fileContent.Count(c => char.IsUpper(c));
        }


        /// <summary>
        /// "CountLower" method counts the lowercase letters from the local string of filecontent 
        /// </summary>
        /// <param name="fileContent">Contents to use</param>
        /// <returns>int - Total count results of lowercase letters in fileContent</returns>   
        public static int CountLower(string fileContent)
        {
            return fileContent.Count(c => char.IsLower(c));
        }


        /// <summary>
        /// "CountNumbers" method counts the numbers from the local string of filecontent 
        /// </summary>
        /// <param name="fileContent">Contents to use</param>
        /// <returns>int - Total count results of number char in fileContent</returns>
        public static int CountNumbers(string fileContent)
        {
            return fileContent.Count(c => char.IsNumber(c));
        }


        /// <summary>
        /// "CountOtherChar" method counts the other characters from the local string of filecontent
        /// </summary>      
        /// <param name="fileContent">Contents to use</param>
        /// <returns>int - Total count results of other char in fileContent</returns>
        public static int CountOtherChar(string fileContent)
        {
            return fileContent.Count(c => char.IsPunctuation(c));
        }
    }
}
