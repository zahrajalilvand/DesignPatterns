// See https://aka.ms/new-console-template for more information

using Bridge_MailSample.MailService;

RefindMailService mailService = new RefindMailService();
mailService.Send(new MailInfoDTO
{
    Reciver = "TestServiceEmail@gmail.com",
    Title = "Alter Email",
    Message = "This is a message from my app",
});
Console.ReadKey();
