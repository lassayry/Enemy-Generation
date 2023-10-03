using UnityEngine;

public class RandomSpawnerChooser : MonoBehaviour
{
    [SerializeField] private float _timeBetweenSpawns = 2;

    private Spawner[] _spawners;

    private void Awake()
    {
        _spawners = GetComponentsInChildren<Spawner>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 0, _timeBetweenSpawns);
    }

    private void Spawn()
    {
        int randomIndex = Random.Range(0, _spawners.Length);

        _spawners[randomIndex].Spawn();
    }
}
