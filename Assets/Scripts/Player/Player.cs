using Ami.BroAudio;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private SoundID sd;
    [SerializeField]
    private int Health = 4;
    [SerializeField]
    private int MaxHealth = 4;

    private bool isAlive = true;

    public bool IsAlive => isAlive;
    public void Heal(int amount){
        Health += amount;
        if(Health > MaxHealth){
            Health= MaxHealth;
        }
    }
    public void ApplyDamage(int Damage){
        Health -= Damage;
        if(Health <= 0){
            Health = 0;
            Death();
        }
    }
    public int ReadHealth(){
        return Health;
    }
    private void Death(){
        isAlive = false;
        BroAudio.Play(sd);
        MainManager.instance.GameOver();
        gameObject.GetComponent<playermovment>().enabled = false;
        this.enabled = false;
    }
}
