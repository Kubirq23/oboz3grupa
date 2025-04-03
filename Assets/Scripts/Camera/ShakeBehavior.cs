using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.Rendering;

public class ShakeBehavior : MonoBehaviour
{
    [SerializeField]
    private CinemachineCameraOffset cameraOffset;
    public static ShakeBehavior instance;
    // Transform of the GameObject you want to shake
    private Transform transform;
    public Volume volume;

    // Desired duration of the shake effect
    private float shakeDuration = 0f;

    [SerializeField]
    // A measure of magnitude for the shake. Tweak based on your preference
    private float shakeMagnitude = 0.7f;
    [SerializeField]
    // A measure of how quickly the shake effect should evaporate
    private float dampingSpeed = 1.0f;

    // The initial position of the GameObject
    Vector3 initialPosition;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else Destroy(gameObject);
        if (transform == null)
        {
            transform = GetComponent(typeof(Transform)) as Transform;
        }
    }
    void OnEnable()
    {
        initialPosition = cameraOffset.Offset;
    }
    void Update()
    {
        if (shakeDuration > 0)
        {

            cameraOffset.Offset = initialPosition + Random.insideUnitSphere * shakeMagnitude;

            shakeDuration -= Time.deltaTime * dampingSpeed;
        }
        else
        {

            shakeDuration = 0f;
            cameraOffset.Offset = initialPosition;
        }
    }
    [ContextMenu(nameof(TriggerShake))]

    public void TestShake() => TriggerShake();
    public static void TriggerShake()
    {
        TriggerShake(2f);
    }
    public static void TriggerShake(float duration)
    {
        instance.cameraOffset.Offset = instance.transform.localPosition;
        instance.shakeDuration = duration;
    }
}
