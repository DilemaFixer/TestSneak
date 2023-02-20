using UnityEngine;

namespace Game.Global
{
    public class SnakePartFactory : MonoBehaviour
    {
       public PartOfSnake Get(PartOfSnake lastPartOfSnake , PartOfSnake prefab, Vector2 position)
        {
            PartOfSnake partOfSnake = Instantiate(prefab, position, Quaternion.identity);
            lastPartOfSnake.IsMuving += partOfSnake.MuveTo;
            return partOfSnake;
        }
    }
}

