using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private Vector3 _direction;

    public void Spawn()
    {
        Enemy newEnemy = Instantiate(_prefab, transform.position, Quaternion.identity);
        newEnemy.GetComponent<Enemy>().Init(_direction);
    }
}
