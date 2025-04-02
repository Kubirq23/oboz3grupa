using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour{
    public static MainManager instance ;
    public GameObject player;
    [SerializeField]
    private EnemySpawner[] spawners;
    [SerializeField]
    private Text text;
    [SerializeField]
    private Image gameoverscreen;
    private int Bounty;
    private int enemyCount;

    void Awake(){
        instance = this;
    }
    public void hit(int dmg){
        var p = player.GetComponent<Player>();
        p.ApplyDamage(dmg);
        text.text = p.ReadHealth().ToString();

    }
    public void AddEnemy(){
        enemyCount ++;
    }
    public void DelEnemy(){
        enemyCount --;
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
    }

}
