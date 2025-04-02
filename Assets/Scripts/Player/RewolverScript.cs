using UnityEngine;

public class RewolverScript : MonoBehaviour
{
    [SerializeField]
    private BulletScript Bullet;
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private Transform shootPosition;

    [SerializeField]
    private float power;


    private void OnAttack()
    {
        Debug.Log("attack");
        var  newBullet = Instantiate(Bullet, shootPosition.position, shootPosition.rotation);
        newBullet.Shoot(power, transform.up);
    }
}