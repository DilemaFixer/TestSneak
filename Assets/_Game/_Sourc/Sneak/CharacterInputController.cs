using System;
using UnityEngine;

namespace Game.Global
{
    public class CharacterInputController : MonoBehaviour
    {
        private IControlablle _controlablle;

        private void Awake()
        {
            _controlablle = GetComponent<IControlablle>();
            if (_controlablle == null) throw new Exception("Controlablle is null");
        } 


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A)) _controlablle.SetNewVectoreDirection(SnakeMuveDirection.Left);
            if (Input.GetKeyDown(KeyCode.D)) _controlablle.SetNewVectoreDirection(SnakeMuveDirection.Right);
            if (Input.GetKeyDown(KeyCode.W)) _controlablle.SetNewVectoreDirection(SnakeMuveDirection.Up);
            if (Input.GetKeyDown(KeyCode.S)) _controlablle.SetNewVectoreDirection(SnakeMuveDirection.Down);
        }
    }
}

