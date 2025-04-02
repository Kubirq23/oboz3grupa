using System.Collections;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D rb;
   
    public Rigidbody2D Rb => rb;
    private void Awake(){
        StartCoroutine(death());
    }
    public void Shoot(float power, Vector3 direction)
    {
        rb.linearVelocity = power * direction;
    }
    private IEnumerator death(){
        yield return new WaitForSeconds(4f);
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy")){
            collision.gameObject.GetComponent<Enemy>().OnDestruction();
        }
        Destroy(gameObject);
    }
}
