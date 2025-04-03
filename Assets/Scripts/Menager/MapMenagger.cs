using System.Collections.Generic;
using UnityEngine;

public class MapMenagger : MonoBehaviour{
    public static MapMenagger instance;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Generator gen;
    [SerializeField]
    private int posx,posy;
    void Awake()
    {
        instance = this;
    }
    public void add(Trigger trigg){
        trigg.onPlayerEnter += Trigger;

    }
    private void Trigger(int ID){//1 --top 2 -- left 3-- botton 4 -- right
        switch (ID)//borders
        {
            case 1:
                Debug.Log("top");
                posy += 1;
                if(posy > gen.Ysize.Count){
                    posy = gen.Ysize.Count;
                    return;
                }
                player.transform.position += new Vector3(0,40,0);
                break;
            case 2:
                Debug.Log("left");
                posx -= 1;
                if(posx < 0){
                    posx = 0;
                    return;
                }
                player.transform.position += new Vector3(-20,0,0);
                break;
            case 3:
                Debug.Log("bottom");
                posy -= 1;
                if(posy < 0){
                    posy = 0;
                    return;
                }
                player.transform.position += new Vector3(0,-40,0);
                break;
            case 4:
                Debug.Log("right");
                posx += 1;
                if(posx > gen.Ysize[0].Xsize.Count){
                    posx = gen.Ysize[0].Xsize.Count;
                    return;
                } 
                player.transform.position += new Vector3(20,0,0);
                break;
        }

    }
}
