using System;
using System.Collections.Generic;
using System.Text;

namespace GUI
{
    internal sealed class cUtils
    {
        internal static string GenStr(int iLenght)
        {
            Random rRandom = new Random();
            const string sSymbols = "ABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";

            char[] cResult = new char[iLenght];

            for (int i = 0; i < iLenght; i++)
            {
                cResult[i] = sSymbols[rRandom.Next(0, sSymbols.Length)];
            }

            return new string(cResult);
        }
    }
}
