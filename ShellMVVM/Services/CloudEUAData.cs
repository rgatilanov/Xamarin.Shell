using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShellMVVM.Models;
namespace ShellMVVM.Services
{
    public class CloudEUAData : IDataCloud<Cloud>
    {
        readonly List<Cloud> items;

        public CloudEUAData()
        {
            items = new List<Cloud>()
            {
                new Cloud { Name = "AWS", Location= "California",Details="Nube de Jeff Bezos",ImageUrl="https://commons.wikimedia.org/w/index.php?title=Special%3ASearch&search=haswbstatement%3AP180%3DQ3884&ns0=1&ns6=1&ns12=1&ns14=1&ns100=1&ns106=1#/media/File:Amazon.com_Gift_Cards_in_hand.jpg" },
                 new Cloud { Name = "Azure", Location= "Redmond, Washington",Details="Nube de Bill Gates",ImageUrl="https://commons.wikimedia.org/w/index.php?search=logo+de+microsoft&title=Special%3ASearch&go=Go&ns0=1&ns6=1&ns12=1&ns14=1&ns100=1&ns106=1#/media/File:Microsoft_logo_(1982).svg" },
                      new Cloud { Name = "Google", Location= "California",Details="Nube de Larry Page",ImageUrl="https://upload.wikimedia.org/wikipedia/commons/f/fb/Logo_google%2B_2015.png" },
            };
        }
        public async Task<IEnumerable<Cloud>> GetCloudAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
