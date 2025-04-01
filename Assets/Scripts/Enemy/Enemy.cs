using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour{
    [SerializeField] Transform target;

    [SerializeField]
    private bool updatePosition;
    NavMeshAgent agent;



    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        agent.SetDestination(target.position);
    }

    private void OnValidate()
    {
        agent.updateRotation = updatePosition;
    }
}