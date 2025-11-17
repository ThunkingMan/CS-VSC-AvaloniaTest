using System.Net.Http;
using System.Threading.Tasks;
using Tmds.DBus.Protocol;

namespace CS_VSC_AvaloniaTest;

internal static class Network
{
    static readonly HttpClient Http_Client = new HttpClient();

    static Network() { }

    internal static (bool, string) TestConnect(string URL)
    {
        string ReturnString = "";
        HttpRequestMessage Http_Request = new HttpRequestMessage();
        Http_Request.RequestUri = new System.Uri("rmm.itmasters.net.au");
        Http_Request.Method = HttpMethod.Get;

        HttpResponseMessage Http_Response = Http_Client.Send(Http_Request);
        

        return (true, ReturnString);
    }
    

}