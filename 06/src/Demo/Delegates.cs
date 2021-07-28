using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate void DemoDelegate(DemoDelegateOptions options);
    public delegate void GenericDelegate<T>(T value);
}
