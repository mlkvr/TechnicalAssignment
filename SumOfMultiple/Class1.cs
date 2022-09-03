namespace SumOfMultiple
{
    public class Class1
    {


        public void sumFinder(int inputVal)
        {
            int sum = 0;
            for (int i = 1; i < inputVal+1; i++) {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum+=i;
                   
                }
            }
            Console.WriteLine(sum);
        }
    }
}