namespace Teat
{
    public class Car:Exception
    {
        public int  GetFirstCharacter(int num1,int num2)
        {
                try
                {
                    if (num2 == 0)
                    {
                          throw new ArgumentException("Division by zero is not allowed.");                    
                    }

                    int d = num1 / num2;
                    return d;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }               
        }

        //public void division(int num1, int num2)
        //{
        //    try
        //    {
        //        int result = num1 / num2;
        //    }
        //    catch (DivideByZeroException e)
        //    {
        //        Console.WriteLine("Exception caught: {0}", e);
        //    }

        //}

    }
}
