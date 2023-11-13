using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_Project.Pages.Services
{
    public class IsAuthenticated
    {

        public async Task<bool> IsAuthenicatedAsync()
        {

            await Task.Delay(1000);
            return false;
        }

    }
}
