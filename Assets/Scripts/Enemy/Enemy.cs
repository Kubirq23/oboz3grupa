using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.PlayerLoop;

public class Enemy : MonoBehaviour{
    [SerializeField] Transform target;
    [SerializeField]
    private int VodkaChance;
    [SerializeField]
    private GameObject Vodka;
    [SerializeField]
    private Animator anim;
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
        else{
            Destroy(gameObject);
        }
        changeSprites();
        //zrobic obracanie enemy do prendkości
    }

    private void OnValidate()
    {
        agent.updateRotation = updatePosition;
    }
    public void OnDestruction(){
        MainManager.instance.DelEnemy();
        float los = Random.Range(0,101);
        if(VodkaChance >los){
            Instantiate(Vodka,transform.position,Quaternion.identity);
        }
        Destroy(gameObject);
    }
    private void changeSprites(){
        if(agent.path.corners.Length <= 1) return;
        var point = agent.path.corners[1];
        var p = transform.position - point;
        //Debug.Log(point+" "+p);
        if(Mathf.Abs(p.x) > Mathf.Abs(p.y))
        {
            if(Mathf.Sign(p.x) >= 0)
            {
                anim.Play("WalkRight");
            }
            else {
                anim.Play("EnemyLeft");
            }
        }
        else{
            if(Mathf.Sign(p.y) >= 0){
                anim.Play("WalkDown");
            }
            else {
                anim.Play("WalkUp");
            }
        }

    }
}