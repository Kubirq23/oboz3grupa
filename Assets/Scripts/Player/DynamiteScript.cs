using System.Collections;
using Ami.BroAudio;
using UnityEngine;

public class DynamiteScript : MonoBehaviour
{
    [SerializeField]
    private SoundID sd;
    [SerializeField]
    private Rigidbody2D rb;
    public Rigidbody2D Rb => rb;
    void Awake(){
        StartCoroutine(GoBoom());
        BroAudio.Play(sd);

    }
    public void Throw(float power, Vector3 direction)
    {
        rb.linearVelocity = power * direction;
    }
    public IEnumerator GoBoom(){
        yield return new WaitForSeconds(2f);
        var colliders = Physics2D.OverlapCircleAll(gameObject.transform.position, 3f);
        foreach (var collider in colliders)
        {
            if(collider.gameObject.CompareTag("Enemy")){
                Debug.Log(collider.gameObject.name);
                collider.gameObject.transform.parent.GetComponent<Enemy>().OnDestruction();
            }
            if(collider.gameObject.CompareTag("Player")){
                Debug.Log("hit");
                collider.gameObject.GetComponent<Player>().ApplyDamage(1);
            }
        }
        Destroy(gameObject);
        
    }
}
