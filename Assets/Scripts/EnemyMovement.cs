using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public enum EnemyState { Idle, Chase, Attack };
    public EnemyState currentState = EnemyState.Idle;
    public Transform target;
    public NavMeshAgent agent;
    public float detectionRange = 8f;
    public float attackRange = 1f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        switch (currentState)
        {
            case EnemyState.Idle:
                if (distance < detectionRange)
                {
                    currentState = EnemyState.Chase;
                }
                break;

            case EnemyState.Chase:
                agent.SetDestination(target.position);

                if (distance < attackRange)
                {
                    currentState = EnemyState.Attack;
                }
                else if (distance > detectionRange * 1.2f)
                {
                    currentState = EnemyState.Idle;
                    agent.ResetPath();
                }
                break;

            case EnemyState.Attack:
                if (distance > attackRange)
                {
                    currentState = EnemyState.Chase;
                }
                else
                {
                    // Placeholder: Game over
                    Debug.Log("Game Over! Player caught.");
                }
                break;
        }
    }
}
