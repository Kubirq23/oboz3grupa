using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int Health;
    [SerializeField]
    private int MaxHealth;
    
    private void Heal(int amount){
        Health += amount;
    }
    public void ApplyDamage(int Damage){
        Health -= Damage;
        if(Health < 0){
            Death();
        }
    }
    private void Death(){

    }
}
