using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace iosha.Unity.ObjectPool
{
    public class Pooler : MonoBehaviour, IPooler
    {
        private Dictionary<string, List<IPoolEntity>> _pulls = new Dictionary<string, List<IPoolEntity>>();

        public T Resolve<T>(T pullObject, object objectParams = null) where T : MonoBehaviour, IPoolEntity
        {
            IPoolEntity entity = null;
            List<IPoolEntity> pull = null;

            var objectType = typeof(T).ToString(); // pullObject.gameObject.name;

            if (_pulls.ContainsKey(objectType))
            {
                pull = _pulls[objectType];
            }
            else
            {
                pull = new List<IPoolEntity>();
                _pulls.Add(objectType, pull);
            }

            entity = pull.FirstOrDefault(e => e.IsInPool);

            if (entity == null)
            {
                entity = Instantiate(pullObject, this.transform);
                pull.Add(entity);
            }

            entity.Initialize(objectParams);

            return (T)entity;
        }

        public 

        
    }
}
