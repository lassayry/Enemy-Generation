using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out EnemyMover enemy))
        {
            Destroy(enemy.gameObject);
        }
    }
}
