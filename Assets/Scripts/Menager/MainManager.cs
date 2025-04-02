using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour{
    public static MainManager instance ;
    public GameObject player;
    [SerializeField]
    private EnemySpawner[] spawners;

    [SerializeField]
    private Image gameoverscreen;
    [SerializeField]
    private Text bounty;
    [SerializeField]
    private int BforE;
    private int Bounty;

    private int enemyCount;

    void Awake(){
        instance = this;
    }
    public void hit(int dmg){
        var p = player.GetComponent<Player>();
        p.ApplyDamage(dmg);
        UIControler.instance.changeHealth(p.ReadHealth());

    }
    public void AddEnemy(){
        enemyCount ++;
    }
    public void DelEnemy(){
        enemyCount --;
        Bounty += BforE;
        bounty.text = "Bounty:" + Bounty;
    }
    private void Update(){
        if(enemyCount > 50){
            stopSpawn();
        }
        else{
            startSpawn();
        }
       
    }
    private void startSpawn(){
        foreach (var sp in spawners){
            sp.start();
        }
    }
    private void stopSpawn(){
        foreach (var sp in spawners){
            sp.stop();
        }
    }
    public void GameOver(){

        gameoverscreen.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

}
