using System;

namespace CnslApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char alpha, tggl;

            Console.Write("영어 알파벳 한 문자를 입력하세요: ");
            alpha = (char)Console.Read();

            tggl = ToggleAlphabet(alpha);
            Console.WriteLine("{0}의 변환된 문자는 {1}입니다.", alpha, tggl);
        }

        static char ToggleAlphabet(char ch)
        {
            if (65 <= ch && ch <= 90)
                return (char)(ch + 32);
            else
                return (char)(ch - 32);
        }
    }
}