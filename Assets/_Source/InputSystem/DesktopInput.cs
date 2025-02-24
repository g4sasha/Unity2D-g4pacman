using System;
using UnityEngine;

namespace InputSystem
{
    public class DesktopInput : MonoBehaviour
    {
        public event Action<Vector2> OnMoveChanged;

        private void Update()
        {
            HandleMove();
        }

        private void HandleMove()
        {
            var direction = Vector2.zero;

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                direction = Vector2.left;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                direction = Vector2.right;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                direction = Vector2.up;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                direction = Vector2.down;
            }

            if (direction != Vector2.zero)
            {
                OnMoveChanged?.Invoke(direction);
            }
        }
    }
}