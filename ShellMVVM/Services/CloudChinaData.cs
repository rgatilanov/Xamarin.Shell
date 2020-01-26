using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShellMVVM.Models;
namespace ShellMVVM.Services
{
    public class CloudChinaData : IDataCloud<Cloud>
    {
        readonly List<Cloud> items;

        public CloudChinaData()
        {
            items = new List<Cloud>()
            {
                new Cloud { Name = "Alibaba", Location= "Shangai",Details="Nube Tachidito",ImageUrl="https://s3.amazonaws.com/cdn.wp.m4ecmx/wp-content/uploads/2017/08/18161256/AlibabaGroup2.png" },
                 new Cloud { Name = "Takaka", Location= "Pekin",Details="Nube Sinsulancha",ImageUrl="https://s3.amazonaws.com/cdn.wp.m4ecmx/wp-content/uploads/2017/08/18161256/AlibabaGroup2.png" }
            };
        }
        public async Task<IEnumerable<Cloud>> GetCloudAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
