using RestSharp;
using RestSharp.Authenticators;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.RegularExpressions;
 

var client = new RestClient("https://mfc.samgk.ru");
var request = new RestRequest("api/groups");
var response = client.ExecuteGet(request);
Console.WriteLine(response.Content );
var data = JsonSerializer.Deserialize<List<Group>>(response.Content!)!;



