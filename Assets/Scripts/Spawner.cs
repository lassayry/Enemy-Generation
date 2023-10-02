using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Vector3 _direction;

    public void Spawn()
    {
        GameObject newEnemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
        newEnemy.GetComponent<Enemy>().Init(_direction);
    }
}
