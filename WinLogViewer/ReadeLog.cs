using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinLogViewer
{
    public class ReadeLog
    {
        public List<LogInfoViewModel> Read(string[] files)
        {
            List<string> Block = new();
            List<LogInfoViewModel> Blocks = new();

            #region FindBlock
            foreach (var file in files)
            {
                var txt = File.ReadAllText(file);
                var Splittxt = txt.Split(" -------------- INFO (");
                Block.AddRange(Splittxt.Where(x => x != ""));
            }
            foreach (var file in Block)
            {
                LogInfoViewModel logInfo = new();
                foreach (var myString in file.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (myString.Contains(") --------------"))
                    {
                        logInfo.Datetime = myString.Replace(") --------------", "");
                    }
                    else if (myString.Contains("Address:"))
                    {
                        logInfo.Address = myString.Replace("Address:", "");
                    }
                    else if (myString.Contains("Host:"))
                    {
                        logInfo.Host = myString.Replace("Host:", "");
                    }
                    else if (myString.Contains("Url:"))
                    {
                        logInfo.Url = myString.Replace("Url:", "");
                    }
                    else if (myString.Contains("Controller:"))
                    {
                        logInfo.Controller = myString.Replace("Controller:", "");
                    }
                    else if (myString.Contains("Action:"))
                    {
                        logInfo.Action = myString.Replace("Action:", "");
                    }
                    else if (myString.Contains("Method:"))
                    {
                        logInfo.Method = myString.Replace("Method:", "");
                    }
                    else if (myString.Contains("Status Code:"))
                    {
                        logInfo.StatusCode = myString.Replace("Status Code:", "");
                    }
                    else if (myString.Contains("Form:"))
                    {
                        logInfo.Form = myString.Replace("Form:", "");
                    }
                    else if (myString.Contains("Content Type:"))
                    {
                        logInfo.ContentType = myString.Replace("Content Type:", "");
                    }
                    else if (myString.Contains("Body:"))
                    {
                        logInfo.Body = myString.Replace("Body:", "");
                    }
                    else if (myString.Contains("Query String:"))
                    {
                        logInfo.QueryString = myString.Replace("Query String:", "");
                    }
                    else if (myString.Contains("IP:"))
                    {
                        logInfo.IP = myString.Replace("IP:", "");
                    }
                    else if (myString.Contains("User Agent:"))
                    {
                        logInfo.UserAgent = myString.Replace("User Agent:", "");
                    }
                    else if (myString.Contains("UserName:"))
                    {
                        logInfo.UserName = myString.Replace("UserName:", "");
                    }
                    else if (myString.Contains("Additional Info:"))
                    {
                        logInfo.AdditionalInfo = myString.Replace("Additional Info:", "");
                    }
                }
                Blocks.Add(logInfo);
            }
            #endregion

            return Blocks;
        }
    }
}
