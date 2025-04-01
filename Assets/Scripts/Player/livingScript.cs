using JetBrains.Annotations;
using UnityEngine;

public class LivingScript : MonoBehaviour
{
    private int health;
    public void LoseHealth()
    {
        health--;
    }
    void Update()
    {
        if (health == 0) Die();
    }
    private void Die()
    {
        Time.timeScale = 0f;
    }
}
