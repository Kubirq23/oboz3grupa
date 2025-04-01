using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

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


    void OnAttack()
    {
        var  newBullet = Instantiate(Bullet, shootPosition.position, shootPosition.rotation);
        newBullet.Shoot(power, transform.up);
    }
}