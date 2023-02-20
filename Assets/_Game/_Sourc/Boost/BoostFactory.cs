using UnityEngine;

namespace Game.Global
{
    public class BoostFactory : MonoBehaviour
    {
        public Boost Get(Boost prefab , Vector2 position)
        {
            return Instantiate(prefab, position, Quaternion.identity);
        }
    }
}

