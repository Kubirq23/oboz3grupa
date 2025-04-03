using UnityEngine;

public class RewolverScript : MonoBehaviour
{
    [SerializeField]
    private BulletScript Bullet;
    [SerializeField]
    private Transform shootPosition;
    [SerializeField]
    private float power;
    [SerializeField]
    private Quaternion rotatedPosition;
    [SerializeField]
    private float spreadAngle = 15f; // Adjust for more or less spread

    public void OnAttack()
    {
        var newBullet = Instantiate(Bullet, shootPosition.position, shootPosition.rotation);
        newBullet.Shoot(power, shootPosition.up);
    }

    void OnAttack2()
    {
        for (int i = 0; i < 2; i++)
        {
            RandomizeRotation();
            var newBullet = Instantiate(Bullet, shootPosition.position, rotatedPosition);
            newBullet.Shoot(power, rotatedPosition * Vector3.up);
            
        }
    }

    void RandomizeRotation()
    {
        float randomAngle = Random.Range(-spreadAngle, spreadAngle);
        rotatedPosition = Quaternion.Euler(0, 0, shootPosition.eulerAngles.z + randomAngle);
    }
}
