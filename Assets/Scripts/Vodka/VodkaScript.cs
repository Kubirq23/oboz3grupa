using Ami.BroAudio;
using UnityEngine;

public class VodkaScript : MonoBehaviour
{
    [SerializeField]
    private SoundID sd;
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Player")){
            collision.gameObject.GetComponent<Player>().Heal(1);
            BroAudio.Play(sd);
            Destroy(gameObject);
        }   
    }
}
