using UnityEditor.ShaderGraph.Configuration;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIControler : MonoBehaviour{
    public static UIControler instance;
    [SerializeField]
    private Sprite[] healthSprites,Barrel;
    [SerializeField]
    private Image healthImage,barrelimage;
    [SerializeField]
    private GameObject pauseMenu;
    void Awake(){
        instance = this;
    }
    public void changeHealth(int health){
        healthImage.sprite = healthSprites[health];
    }
    public void ChangeBarrel(int ammo){
        barrelimage.sprite = Barrel[ammo];
    }
    void Update()
    {
        if (MainManager.instance.Player.IsAlive == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        } else { 
            return; 
        }
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Resume()
    {
        Time.timeScale = 1f;
    }
    public void Exit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(0);
    }
}
