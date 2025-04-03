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
    private Vector2 moveinput;

    private void OnMove(InputValue value){
        moveinput = value.Get<Vector2>();
        rb.linearVelocity  = moveinput * MovmentSpeed;
        if(moveinput.x > 0){
            anim.Play("WalkRight");
            guntr.eulerAngles = new Vector3(0,0,-90); 
        }
        else if(moveinput.x < 0){
            anim.Play("WalkLeft");
            guntr.eulerAngles = new Vector3(0,0,90); 

        }
        else if(moveinput.y > 0){
            anim.Play("WalkUp");
            guntr.eulerAngles = new Vector3(0,0,0); 
        }
        else if(moveinput.y <0){
            anim.Play("WalkDown");
            guntr.eulerAngles = new Vector3(0,0,180); 
        }
        Debug.Log(moveinput);
        if(moveinput == new Vector2(0,0)){
            anim.Play("Idle");
        }
    }

    

}
    