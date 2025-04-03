using System.Collections;
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
    private int ammo = 6;
    private bool canfire = true;

    private void OnAttack()
    {
        if(!canfire)return;
        ammo--;
        Debug.Log(ammo);
        if(ammo == 0){
            canfire =false;
            StartCoroutine(reload());
        }
        UIControler.instance.ChangeBarrel(ammo);
        Debug.Log("attack");
        var  newBullet = Instantiate(Bullet, shootPosition.position, shootPosition.rotation);
        newBullet.Shoot(power, shootPosition.up);
    }
    private IEnumerator reload(){
        yield return new WaitForSeconds(1f);
        canfire = true;
        ammo = 6;
        UIControler.instance.ChangeBarrel(ammo);
        StopCoroutine(reload());
    }
}