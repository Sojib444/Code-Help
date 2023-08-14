namespace Exceptio_Handling
{
    public class GetComany
    {
        public bool GetAllCompanies(bool trackChange)
        {
            try
            {
                    throw new Exception("Internal server Eror");      
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
