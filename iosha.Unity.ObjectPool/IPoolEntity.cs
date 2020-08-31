using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iosha.Unity.ObjectPool
{
    public interface IPoolEntity
    {
        bool IsInPool { get; set; }

        void Initialize(object obj = null);
    }
}
