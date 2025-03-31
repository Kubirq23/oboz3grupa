using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour{
    [SerializeField] Transform target;

    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updatePosition = false;
    }

    void Update()
    {
        agent.SetDestination(target.position);
    }
}