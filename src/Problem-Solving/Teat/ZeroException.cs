namespace Exceptio_Handling
{
    public class ZeroException
    {
        public int divide(int num1,int num2)
        {
            try
            {
                if(num2 == 0)
                {
                    throw new CustomException("Num2 can't be Zero");
                }

                return num1 / num2;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
