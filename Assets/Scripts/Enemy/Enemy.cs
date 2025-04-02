using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour{
    [SerializeField] Transform target;
    
    

    [SerializeField]
    private bool updatePosition;
    [SerializeField]
    NavMeshAgent agent;



    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if(agent.isOnNavMesh){
            agent.SetDestination(target.position);
        }
        //zrobic obracanie enemy do prendkości
    }

    private void OnValidate()
    {
        agent.updateRotation = updatePosition;
    }
}