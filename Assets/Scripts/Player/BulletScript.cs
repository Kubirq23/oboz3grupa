using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
   
    public Rigidbody2D Rb => rb;

    public void Shoot(float power, Vector3 direction)
    {
        rb.linearVelocity = power * direction;
    }
}
