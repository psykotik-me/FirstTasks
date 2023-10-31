using System;

namespace MyClasses
{
    public class StringSpecialReverse
    {

        public static string Reverse(string input)
        {
            if (input.Equals("")) return "";

            string res = "";//new List<string>();
            string[] s = input.Split(" ");

            foreach (var sub in s)
            {
                // Console.WriteLine(sub);
                res += " " + ReverseWord(sub);/*.Add(ReverseWord(sub));*/
                // Console.WriteLine(res);
            };
            res = res.Trim();
            return res;
        }

        private static string ReverseWord(string input)
        {
            if (input.Equals("")) return "";

            char[] charArray = input.ToCharArray();
            int left = 0;
            int right = charArray.Length - 1;

            while (left < right)
            {

                // Ігноруємо символи та пробіли
                while (left < right && !char.IsLetter(charArray[left]))
                    left++;
                while (left < right && !char.IsLetter(charArray[right]))
                    right--;

                // Міняємо місцями літери
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;

                left++;
                right--;
            }

            return new string(charArray);
        }

        private static string ReverseWordMy(string input)
        {
            char[] chars = input.ToCharArray();
            List<char> charlist = new List<char>();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i])) charlist.Add(chars[i]);
            }
            charlist.Reverse();


            int counter = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i])) chars[i] = charlist[counter++];
                else chars[i] = chars[i];
            }
            return new string(chars);
        }
    }
}
