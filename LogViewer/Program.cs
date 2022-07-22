// See https://aka.ms/new-console-template for more information


using System.Reflection;



Console.WriteLine("Hi! Wlcome to LogViewer");
Console.WriteLine("-------------------");
Console.WriteLine("|       L         |");
Console.WriteLine("|       O         |");
Console.WriteLine("|       O         |");
Console.WriteLine("|       G         |");
Console.WriteLine("-------------------");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Plase Insert Path log Files: ");

//string? path = Path.GetDirectoryName(path: Assembly.GetExecutingAssembly().Location);
var path = Console.ReadLine();
string[]? files;

do
{

    do
    {
        Console.WriteLine("Plase Insert Really Path log Files: ");
        path = Console.ReadLine();

    } while (path == null || string.IsNullOrWhiteSpace(path) || !Directory.Exists(path));

    files = Directory.GetFiles(path, "INFO_*.log");

} while (files.Length == 0);


List<string> Block = new();
List<LogInfo> Blocks = new();

#region FindBlock
foreach (var file in files)
{
    var txt = File.ReadAllText(file);
    var Splittxt = txt.Split(" -------------- INFO (");
    Block.AddRange(Splittxt.Where(x => x != ""));
}
foreach (var file in Block)
{
    LogInfo logInfo = new();
    foreach (var myString in file.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
    {
        if (myString.Contains(") --------------"))
        {
            logInfo.Datetime = myString.Replace(") --------------", "");
        }
        else if (myString.Contains("Address: "))
        {
            logInfo.Address = myString.Replace("Address: ", "");
        }
        else if (myString.Contains("Host: "))
        {
            logInfo.Host = myString.Replace("Host: ", "");
        }
        else if (myString.Contains("Url: "))
        {
            logInfo.Url = myString.Replace("Url: ", "");
        }
        else if (myString.Contains("Controller: "))
        {
            logInfo.Controller = myString.Replace("Controller: ", "");
        }
        else if (myString.Contains("Action: "))
        {
            logInfo.Action = myString.Replace("Action: ", "");
        }
        else if (myString.Contains("Method: "))
        {
            logInfo.Method = myString.Replace("Method: ", "");
        }
        else if (myString.Contains("Status Code: "))
        {
            logInfo.StatusCode = myString.Replace("Status Code: ", "");
        }
        else if (myString.Contains("Form: "))
        {
            logInfo.Form = myString.Replace("Form: ", "");
        }
        else if (myString.Contains("Content Type: "))
        {
            logInfo.ContentType = myString.Replace("Content Type: ", "");
        }
        else if (myString.Contains("Body: "))
        {
            logInfo.Body = myString.Replace("Body: ", "");
        }
        else if (myString.Contains("Query String: "))
        {
            logInfo.QueryString = myString.Replace("Query String: ", "");
        }
        else if (myString.Contains("IP: "))
        {
            logInfo.IP = myString.Replace("IP: ", "");
        }
        else if (myString.Contains("User Agent: "))
        {
            logInfo.UserAgent = myString.Replace("User Agent: ", "");
        }
        else if (myString.Contains("UserName: "))
        {
            logInfo.UserName = myString.Replace("UserName: ", "");
        }
        else if (myString.Contains("Additional Info: "))
        {
            logInfo.AdditionalInfo = myString.Replace("Additional Info: ", "");
        }
    }
    Blocks.Add(logInfo);
}
#endregion


Console.ReadLine();

public class LogInfo
{
    public string Datetime { get; set; }
    public string Address { get; set; }
    public string Host { get; set; }
    public string Url { get; set; }
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Method { get; set; }
    public string StatusCode { get; set; }
    public string Form { get; set; }
    public string ContentType { get; set; }
    public string Body { get; set; }
    public string QueryString { get; set; }
    public string IP { get; set; }
    public string UserAgent { get; set; }
    public string UserName { get; set; }
    public string AdditionalInfo { get; set; }
}


