using UnityEngine;

public class CollDetectEnemy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision){
        Debug.Log("cos");
        if(collision.gameObject.CompareTag("Player")){
            MainManager.instance.hit(1);
        }
    }
}
