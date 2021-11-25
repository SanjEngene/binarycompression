
static void WriteBinaryCompression()
{
    string alphabet = "abcdefghijklmnopqrstuvwxyz";

    using (StreamReader sr = new StreamReader(@".\input.txt"))
    {    
        using(StreamWriter sw = new StreamWriter(@".\output.txt", false))
        {
            string line;
            int countOfZeros = 0;
            while ((line = sr.ReadLine()) != null)
            {
                string output = "";
              
                foreach (var i in line)
                {
                    if (i == '1')
                    {
                        if (countOfZeros > alphabet.Length - 1)
                        {
                            for (int j = 0; j <= countOfZeros - (alphabet.Length - 1); j++)
                            {
                                output += "0";
                            }
                            output += alphabet[alphabet.Length - 1];
                        }
                        else
                            output += alphabet[countOfZeros];
                        countOfZeros = 0;
                    }
                    else
                    {
                        countOfZeros++;
                    }
                }
                Console.WriteLine(output);
                sw.WriteLine(output);
            }
        }
    }
}
WriteBinaryCompression();