
//nested try catch block

using Exceptio_Handling;

int GetNum(string s)
{
    try
    {
        return  int.Parse(s);
        
    }
    catch(Exception ex)
    {
        throw;
        
    }
}

try
{
    GetNum("dsd");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


//Custom exception

ZeroException zeroException = new();

try
{
    zeroException.divide(1, 0);  ///If you used return function in custom exception you have to use 
                                 /// calling are with try catch block also.
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
