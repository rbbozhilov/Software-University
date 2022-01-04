using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingPizzaAsynchronous
{
   public interface IPizza
    {

        Task PotatoesAsync();

        Task TomatoesAsync();

        Task MushRoomsAsync();

        Task DoughAsync();

        Task CheeseAsync();

    }
}
