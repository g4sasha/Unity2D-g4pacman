using InputSystem;
using UnityEngine;

namespace Gameplay
{
    public class Pacman : MonoBehaviour
    {
        [SerializeField] private DesktopInput _input;
        [SerializeField] private float _speed;

        private Vector2 _moveDirection;

        private void OnEnable() => _input.OnMoveChanged += direction => _moveDirection = direction;

        private void OnDisable() => _input.OnMoveChanged += direction => _moveDirection = direction;

        private void Update() => transform.Translate(_speed * Time.deltaTime * _moveDirection);
    }
}