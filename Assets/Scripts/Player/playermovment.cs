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
}
    