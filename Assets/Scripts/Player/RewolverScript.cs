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
        Quaternion myRotation = Quaternion.identity;
        myRotation.eulerAngles = new Vector3(0,0,transform.rotation.z +90);
        var  newBullet = Instantiate(Bullet, shootPosition.position, shootPosition.rotation);
        newBullet.Shoot(power, shootPosition.up);
    }
}