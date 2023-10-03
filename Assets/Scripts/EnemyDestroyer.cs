using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out Enemy enemy))
        {
            Destroy(enemy.gameObject);
        }
    }
}
