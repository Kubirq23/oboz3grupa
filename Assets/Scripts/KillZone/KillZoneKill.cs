using UnityEngine;

public class KillZoneKill : MonoBehaviour{
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Enemy")){
            collision.gameObject.transform.parent.GetComponent<Enemy>().OnDestruction();
        }
    }
}
