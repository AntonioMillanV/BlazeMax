using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VxComponents
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddLocalization();
        }
    }
}
