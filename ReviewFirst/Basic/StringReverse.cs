using System.Text;

namespace ReviewFIRST.Basic;


public class StringReverse
{
    public string ReverseString(string str)
    {
        string temp = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            temp += str[i];
        }

        return temp;
    }
}