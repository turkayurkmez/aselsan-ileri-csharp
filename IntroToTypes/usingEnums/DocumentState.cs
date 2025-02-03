using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingEnums
{
    public enum DocumentState
    {
        Open,
        Closed,
        Pending,
        Draft,
        Published
    }

    public enum ErkekAkrabalikTipleri
    {
        Baba =1,
        Dede = 2,
        Amca = 4,
        Dayi = 8,
        Kayinpeder=16,
        Abi = 32
    }
}
