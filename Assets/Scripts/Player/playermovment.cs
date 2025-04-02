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
        Color r  = Color.black;
        if(value.Get<Vector2>().x > 0){
            r = Color.red;
        }
        else if(value.Get<Vector2>().x < 0){
            r = Color.blue;
        }
        else if(value.Get<Vector2>().y >0){
            r = Color.green;
        }
        else if(value.Get<Vector2>().y <0){
            r= Color.magenta;
        }
        sr.color = r;
    }

    

}
    