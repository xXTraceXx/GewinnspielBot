using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GewinnspielBot.Interfaces
{
    public interface IDbController
    {
        void ShowAll();

        void ShowUnsolved();

        void ShowSolved();
    }
}
