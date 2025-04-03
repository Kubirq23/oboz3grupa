using UnityEngine;

public class DynamiteThrowingHand : MonoBehaviour
{
    [SerializeField]
    private DynamiteScript Dynamite;
    [SerializeField]
    private Transform shootPosition;
    [SerializeField]
    private float power;

    void OnThrowBoom()
    {
        var newDynamite = Instantiate(Dynamite, shootPosition.position, shootPosition.rotation);
        newDynamite.Throw(power, shootPosition.up);

    }

}
