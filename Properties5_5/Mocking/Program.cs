using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties5_5.Mocking
{
    public static void Main()
    {
        var service = new VideoService();
        var title = service.ReadVideoTitle(new FileReader());
    }
}
