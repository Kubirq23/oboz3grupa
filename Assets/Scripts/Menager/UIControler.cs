using UnityEngine;
using UnityEngine.UI;

public class UIControler : MonoBehaviour{
    public static UIControler instance;
    [SerializeField]
    private Sprite[] healthSprites,Barrel;
    [SerializeField]
    private Image healthImage,barrelimage;
    void Awake(){
        instance = this;
    }
    public void changeHealth(int health){
        healthImage.sprite = healthSprites[health];
    }
    public void ChangeBarrel(int ammo){
        barrelimage.sprite = Barrel[ammo];
    }
}
