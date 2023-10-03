using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _moveDirection;

    private void Update()
    {
        transform.forward = _moveDirection;

        Move();
    }

    public void Init(Vector3 direction)
    {
        direction.y = 0;

        SetMoveDirection(direction);
    }

    private void SetMoveDirection(Vector3 direction)
    {
        _moveDirection = direction;
        _moveDirection.Normalize();
    }

    private void Move()
    {
        transform.Translate(_moveDirection.normalized * _speed * Time.deltaTime, Space.World);
    }
}
