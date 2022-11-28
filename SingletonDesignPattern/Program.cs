// See https://aka.ms/new-console-template for more information
using SingletonDesignPattern.Start;

Console.WriteLine("------------------------------------------------------------------------------------");

MemoryLogger logger;

AssignVoucher("dabas@hotmail.com" , "112546");

UseVoucher("112546");

logger.ShowLog();

Console.ReadKey();
void AssignVoucher(string email, string voucher)
{
    logger = new MemoryLogger();

    // Logic Here
    logger.LogInfo($"Voucher '{voucher}' assigned ");

    // Another Logic Here
    logger.LogError($"Voucher unable to send email '{email}'");

}

void UseVoucher(string voucher)
{
    logger = new MemoryLogger();


    // Logic Here
    logger.LogWarning($"3 attempts made to validate the voucher");


    // Another Logic Here
    logger.LogInfo($"'{voucher}'  is Used ...");

}