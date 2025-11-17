using System.Net.Http;
using System.IO;
using System.Threading.Tasks;
using Avalonia.Media;
using Tmds.DBus.Protocol;

namespace CS_VSC_AvaloniaTest;

internal static class NetworkClass
{
    static readonly HttpClient Http_Client = new HttpClient();
    internal static string ResponseStatucCode = "";
    internal static string ResponseMessage = "";

    static NetworkClass() { }

    internal static (bool, string) TestConnect(string URL)
    {
        string ReturnString = "";
        HttpRequestMessage Http_Request = new HttpRequestMessage();
        Http_Request.RequestUri = new System.Uri("http://rmm.itmasters.net.au/index.php"); 
        Http_Request.Method = HttpMethod.Get;
        //Http_Request.Content = new StringContent("{ 'some': 'value' }", Encoding.UTF8, "application/json")

        HttpResponseMessage Http_Response = Http_Client.Send(Http_Request);
        ResponseStatucCode = Http_Response.StatusCode.ToString();
        StreamReader ResponseStream = new StreamReader(Http_Response.Content.ReadAsStream());
        ResponseMessage = ResponseStream.ReadToEnd();
        
        return (true, ReturnString);
    }
    

}