using UnityEngine;
using UnityEngine.UI;

public class UIControler : MonoBehaviour{
    public static UIControler instance;
    [SerializeField]
    private Sprite[] healthSprites;
    [SerializeField]
    private Image healthImage;
    void Awake(){
        instance = this;
    }
    public void changeHealth(int health){
        healthImage.sprite = healthSprites[health];
    }
    
}
