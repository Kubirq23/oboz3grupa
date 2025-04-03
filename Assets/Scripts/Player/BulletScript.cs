
using System.Collections;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Rigidbody2D Rb => rb;

    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private TweenBullet tw;
    private float Power;
    private Vector3 dir;
    private void Awake(){
        StartCoroutine(death());

    }

    public void Speed(){
        rb.linearVelocity = Power * dir * tw.easeOutQuart(tw.timer);
        Debug.Log(tw.easeOutQuart(tw.timer));
    }
    public void Shoot(float power, Vector3 direction)
    {
        Power = power;
        dir = direction;
        
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
