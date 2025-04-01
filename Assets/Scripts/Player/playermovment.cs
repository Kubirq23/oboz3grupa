using UnityEngine;
using UnityEngine.InputSystem;

public class playermovment : MonoBehaviour
{
    [SerializeField]
    private float MovmentSpeed;
    [SerializeField]
    private Rigidbody2D rb;


    private void OnMove(InputValue value){
        Debug.Log(value.Get<Vector2>());
        rb.linearVelocity  = value.Get<Vector2>() * MovmentSpeed;
    }
    private void Update(){
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = mousePos - new Vector2(transform.position.x,transform.position.y);
        SwichSprites();
    }

    
    private void SwichSprites(){
        Debug.Log(transform.eulerAngles.z);
        if(transform.eulerAngles.z < 20 && transform.eulerAngles.z > -20){
            sr.color = Color.black;
        }
        if(transform.eulerAngles.z > 70 && transform.eulerAngles.z < 110){
            sr.color = Color.green;
        }
        if(transform.eulerAngles.z > 160  && transform.eulerAngles.z < 200){
            sr.color = Color.gray;
        }
        if(transform.eulerAngles.z > 250 && transform.eulerAngles.z < 290){
            sr.color = Color.blue;
            
        }
        
    }
}
    