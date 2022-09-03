namespace SequenceAnalysis
{
    public class Class2
    {

        public void stringAnalyzer(string inputString)
        {
            string tempString = "";

            //Detecting literals
            for(int i=0;i< inputString.Length; i++)
            {
                int tempChar = (int)inputString[i];
                if(tempChar > 64 && tempChar < 91)
                    tempString += inputString[i];
               
            }

            //Sorting 
            tempString = String.Concat(tempString.OrderBy(c => c));

            Console.WriteLine(tempString);
        }
    }
}