using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    private EnemyMovement enemyMovement;
    void OnDrawGizmos()
    {
        if (enemyMovement == null)
        {
            enemyMovement = GetComponentInParent<EnemyMovement>();
        }

        if (enemyMovement != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, enemyMovement.detectionRange);
        }
    }
}
