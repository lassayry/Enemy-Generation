using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private EnemyMover _prefab;
    [SerializeField] private Vector3 _direction;

    public void Spawn()
    {
        EnemyMover newEnemy = Instantiate(_prefab, transform.position, Quaternion.identity);
        newEnemy.GetComponent<EnemyMover>().Init(_direction);
    }
}
