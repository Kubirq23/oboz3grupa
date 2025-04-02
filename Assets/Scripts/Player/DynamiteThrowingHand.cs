using UnityEngine;

public class DynamiteThrowingHand : MonoBehaviour
{
    [SerializeField]
    private DynamiteScript Dynamite;
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private Transform shootPosition;
    [SerializeField]
    private float power;

    void OnThrowBoom()
    {
        Debug.Log("ddd");
        var newDynamite = Instantiate(Dynamite, shootPosition.position, shootPosition.rotation);
        newDynamite.Throw(power, transform.up);

    }

}
