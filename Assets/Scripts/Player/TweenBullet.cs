using UnityEngine;

public class TweenBullet : MonoBehaviour
{
    [SerializeField]
    private BulletScript bs;
    public float timer;
    void Update()
    {
        timer += Time.deltaTime * 0.5f;
        bs.Speed();
        if(timer > 1){
            enabled = false;
        }
    }
    public float easeOutQuart(float x) {
        return 1 - Mathf.Pow(1 - x, 4);

    }
    
}
