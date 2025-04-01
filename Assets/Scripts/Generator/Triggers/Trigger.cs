using UnityEngine;
using System;
public class Trigger : MonoBehaviour{
    public Action<int> onPlayerEnter;
    [SerializeField]
    private int ID; 
    void Awake(){
        MapMenagger.instance.add(this);
    }
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            onPlayerEnter?.Invoke(ID);
        }
    }
}
