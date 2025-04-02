using System.Collections;
using UnityEngine;

public class DynamiteScript : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
    public Rigidbody2D Rb => rb;
    void Awake(){
        StartCoroutine(GoBoom());
    }
    public void Throw(float power, Vector3 direction)
    {
        rb.linearVelocity = power * direction;
    }
    public IEnumerator GoBoom(){
        yield return new WaitForSeconds(2f);
        var colliders = Physics2D.OverlapCircleAll(gameObject.transform.position, 1f);
        foreach (var collider in colliders)
        {
            if(collider.gameObject.CompareTag("Enemy")){
                collider.gameObject.GetComponent<Enemy>().OnDestruction();
            }
            if(collider.gameObject.CompareTag("Player")){
                Debug.Log("hit");
                collider.gameObject.GetComponent<Player>().ApplyDamage(1);
            }
        }
        Destroy(gameObject);
        
    }
}
