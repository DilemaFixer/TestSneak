using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Global
{
    public class SnakeHead : MonoBehaviour , IControlablle
    {
        public Action<Vector2> IsMuving;

        [SerializeField] private float _step;
        [SerializeField] private float _timeBeforeNextStep;
        [SerializeField] private PartOfSnake _secondPartOfSnake;

        private List<PartOfSnake> _Snake;

        private SnakeMuveDirection _lastMuveDirection = SnakeMuveDirection.Left;
        private Vector2 _lastPosition;

        private void Awake() 
        {
            IsMuving += _secondPartOfSnake.MuveTo;
            StartCoroutine(Muve());
        }
       
        private IEnumerator Muve()
        {
            _lastPosition = transform.position;
            switch (_lastMuveDirection)
            {
                case SnakeMuveDirection.Left:
                    transform.position = new Vector2(transform.position.x - _step, transform.position.y);
                    break;
                case SnakeMuveDirection.Right:
                    transform.position = new Vector2(transform.position.x + _step, transform.position.y);
                    break;
                case SnakeMuveDirection.Up:
                    transform.position = new Vector2(transform.position.x, transform.position.y + _step);
                    break;
                case SnakeMuveDirection.Down:
                    transform.position = new Vector2(transform.position.x, transform.position.y - _step);
                    break;
            }
            IsMuving?.Invoke(_lastPosition);
            yield return new WaitForSeconds(_timeBeforeNextStep);
            StartCoroutine(Muve());
        }
        public void SetNewVectoreDirection(SnakeMuveDirection snakeMuveDirection)
        {
            _lastMuveDirection = snakeMuveDirection;
        }
    }

    public enum SnakeMuveDirection
    {
        Left,
        Right,
        Up,
        Down,
    }
}

