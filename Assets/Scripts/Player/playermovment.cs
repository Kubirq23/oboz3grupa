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
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private Transform guntr;

    private void OnMove(InputValue value){
        rb.linearVelocity  = value.Get<Vector2>() * MovmentSpeed;
        Color r  = Color.black;
        if(value.Get<Vector2>().x > 0){
            anim.Play("WalkLeft");
            guntr.eulerAngles = new Vector3(0,0,-90); 
        }
        else if(value.Get<Vector2>().x < 0){//do porawy
            anim.Play("WalkRight");

            guntr.eulerAngles = new Vector3(0,0,180); 

        }
        else if(value.Get<Vector2>().y > 0){
            anim.Play("WalkUp");

            guntr.eulerAngles = new Vector3(0,0,0); 

        }
        else if(value.Get<Vector2>().y <0){
            anim.Play("WalkDown");

            guntr.eulerAngles = new Vector3(0,0,90); 

        }
        sr.color = r;
    }

    

}
    