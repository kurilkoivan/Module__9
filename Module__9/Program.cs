static void Main(string[] args)
{
    Exception exception = new Exception("какая то ошибка");
    exception.Data.Add("дата создания исключения", DateTime.Now);
    exception.HelpLink = "www.удачи.kz";
}