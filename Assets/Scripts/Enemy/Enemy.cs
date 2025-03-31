using UnityEngine;

public class Enemy : MonoBehaviour{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float speed;
    [SerializeField]
    private Rigidbody2D rb;
    void FixedUpdate(){
        Vector3 pos = player.transform.position  - gameObject.transform.position;
        rb.linearVelocity =pos * speed;
    }
}