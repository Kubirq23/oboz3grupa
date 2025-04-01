using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovment : MonoBehaviour
{
    [SerializeField]
    private float MovmentSpeed;
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private SpriteRenderer sr;


    private void OnMove(InputValue value){
        rb.linearVelocity  = value.Get<Vector2>() * MovmentSpeed;
    }
    private void Update(){
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = mousePos - new Vector2(transform.position.x,transform.position.y);
        SwichSprites();
    }

    
    private void SwichSprites(){
        if( transform.rotation.z < 10 && transform.rotation.z > -10){
            sr.color = Color.black;
        }
        if(transform.rotation.z > 80 && transform.rotation.z < 100){
            sr.color = Color.green;
        }
        if(transform.rotation.z > 170  && transform.rotation.z < 190){
            sr.color = Color.gray;
        }
        if(transform.rotation.z < 260 && transform.rotation.z < 280){
            sr.color = Color.blue;
        }
        
    }
}
