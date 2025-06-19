using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;
    public float detectionRange = 8f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= detectionRange)
        {
            agent.SetDestination(target.position);
        }
    }
}
