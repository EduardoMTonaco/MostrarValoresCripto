using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary
{
    public interface IFindVariable
    {
        double FindValue(Formats format);

        string FindString();

        int FindInt();
    }
    public enum Formats
    {
        Standart,
        Pt
    }
}
