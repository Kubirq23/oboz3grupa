using UnityEngine;

public class DynamiteScript : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
    public Rigidbody2D Rb => rb;
    public void Throw(float power, Vector3 direction)
    {
        rb.linearVelocity = power * direction;
    }
}
