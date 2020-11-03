using System;

class Solution
{

    
    static long repeatedString(string s, long n)
    {
        long q = 0, r = 0, TotalCountofA = 0;
        q = n / (s.Length);
        r = n % (s.Length);
        TotalCountofA = (q * getCount(s, s.Length)) + getCount(s, r); 

    return TotalCountofA;
    }

    //Get count of 'a' in the given string till length (n)
    static long getCount(string s, long n)
    {
        long count = 0;
        for (int i = 0; i < n; i++)
        {
            if (s[i] == 'a') 
            {
                count++;
            }
        }
        return count;
    }


    static void Main(string[] args)
    {
        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        Console.WriteLine(result);

        Console.WriteLine("Count of 'a' in string '{0}' for {1} characters is: {2}", s, n ,result);
       
    }
}
