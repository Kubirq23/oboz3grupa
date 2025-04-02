using UnityEngine;

public class DynamiteThrowingHand : MonoBehaviour
{
    [SerializeField]
    private DynamiteScript Dynamite;
    [SerializeField]
    private Transform shootPosition;
    [SerializeField]
    private float power;
    private Vector2 ExplodePosition;

    void OnThrowBoom()
    {
        var newDynamite = Instantiate(Dynamite, shootPosition.position, shootPosition.rotation);
        newDynamite.Throw(power, transform.up);
        Destroy(newDynamite, 2f);
        Invoke(nameof(GoBoom), 2f);
    }
    void GoBoom()
    {
        var colliders = Physics2D.OverlapCircleAll(ExplodePosition, 1.5f);
        foreach (var collider in colliders)
        {
            Destroy(collider.gameObject);
        }
    }
}
