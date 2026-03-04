using System.Net.Http.Json;
using System.Text.Json.Nodes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.AccessControl;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.Design;

namespace WalkTheWait.Pages;

public class IndexModel : PageModel
{
    public SelectList? parkOptions { get; set; }

    public void OnGet()
    {
        getParks();
    }

    private void getParks()
    {
        Dictionary<int, string> parkIdList = new Dictionary<int, string>
        {
            {8, "Animal Kingdom"},
            {17, "Disney California Adventure"},
            {7, "Disney Hollywood Studios"},
            {6, "Disney Magic Kingdom"},
            {16, "Disneyland"},
            {5, "EPCOT"},
            {334, "Epic Universe"},
            {64, "Islands Of Adventure At Universal Orlando"},
            {65, "Universal Studios At Universal Orlando"},
            {66, "Universal Studios Hollywood"},
            {37, "Six Flags Great Adventure"}
            
        };

        parkOptions = new SelectList(parkIdList.OrderBy(key => key.Value), "Key", "Value");
    }
}
