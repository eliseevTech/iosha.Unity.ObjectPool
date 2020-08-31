using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace iosha.Unity.ObjectPool
{
    public interface IPooler
    {
        T Resolve<T>(T pullObject, object objectParams = null) where T : MonoBehaviour, IPoolEntity;
    }
}
