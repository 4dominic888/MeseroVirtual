using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public interface IBucles<T>
    {
        public void For_Each(Action<T> funcion);
    }
}
