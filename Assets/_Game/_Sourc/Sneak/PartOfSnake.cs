using System;
using UnityEngine;

namespace Game.Global
{
    public class PartOfSnake : MonoBehaviour
    {
        public Action<Vector2> IsMuving;
        private Vector2 currentPosition;
        public void MuveTo(Vector2 muvePosition)
        {
            currentPosition = transform.position;
            transform.position = muvePosition;
            IsMuving?.Invoke(currentPosition);
        }


    }
}

