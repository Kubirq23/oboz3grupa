using DG.Tweening;
using Ami.BroAudio;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VodkaScript : MonoBehaviour
{
    [SerializeField]
    private GameObject particleStuff;
    [SerializeField]
    private Material coolMaterial;
    [SerializeField]
    private UnityEngine.Rendering.Volume volume;

    [SerializeField]
    private ColorAdjustments adjustements;

    private int maybeDrunk;
    private Tween tween;
    private SoundID sd;

    private void Start()
    {
            volume = ShakeBehavior.instance.volume;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player")){
            collision.gameObject.GetComponent<Player>().Heal(1);
            BroAudio.Play(sd);
            Destroy(gameObject);

            maybeDrunk = Random.Range(0, 3);
            if (maybeDrunk == 1)
            {
                gameObject.SetActive(particleStuff);
                Debug.Log("Drunk");
                if (tween == null)
                {
                    tween = coolMaterial.DOFloat(2f, "_Strength", .5f).SetEase(Ease.InExpo).OnComplete(()=> EndEffect());
                    DOTween.To(() => volume.weight, x => volume.weight = x, 1f, .5f);
                }
            }
        }
    }

    private void EndEffect()
    {
        if (tween != null)
        {
            tween.Kill();
        }
        coolMaterial.DOFloat(0f, "_Strength", 10f).SetEase(Ease.OutSine);
        DOTween.To(() => volume.weight, x => volume.weight = x, 0f, 10f);

    }
    private void OnDisable()
    {
                coolMaterial.SetFloat("_Strength", 0f);
    }
}
