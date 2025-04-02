using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int Health;
    [SerializeField]
    private int MaxHealth;
    
    private void Heal(int amount){
        Health += amount;
        if(Health > MaxHealth){
            Health= MaxHealth;
        }
    }
    public void ApplyDamage(int Damage){
        Health -= Damage;
        if(Health < 0){
            Health = 0;
            Death();
        }
    }
    public int ReadHealth(){
        return Health;
    }
    private void Death(){
        MainManager.instance.GameOver();
        gameObject.GetComponent<playermovment>().enabled = false;
        this.enabled = false;
    }
}
