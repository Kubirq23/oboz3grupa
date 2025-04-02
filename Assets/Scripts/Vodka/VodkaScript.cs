using UnityEngine;

public class VodkaScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Player")){
            collision.gameObject.GetComponent<Player>().Heal(1);
            Destroy(gameObject);
        }   
    }
}
