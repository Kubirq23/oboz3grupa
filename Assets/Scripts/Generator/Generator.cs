using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public List<Room> Ysize;
    public List<Room> Acctive;
    [SerializeField]
    private GameObject[] Tiles;
    [SerializeField]
    private float RoomSizeX,RoomSizeY;

    [SerializeField]

    [System.Serializable]
    public class Room
    {
        [SerializeField]
        private List<GameObject> xsize;

        public List<GameObject> Xsize { get => xsize; set => xsize = value; }
    }
    

    private void Start(){
        RandomTiles();
        RandomTiles();
    }
    private void RandomTiles(){
        for(int i = 0; i < Ysize.Count;i++){
            for(int j = 0; j < Ysize[i].Xsize.Count ;j++){
                Ysize[i].Xsize[j] = Tiles[Random.Range(0,Tiles.Length -1)];
            }
        }
    }


    private void firstRoom(){
        GameObject gameob = Ysize[0].Xsize[0];
        Instantiate(gameob,new Vector3(),Quaternion.identity,transform);
        GameObject gameob1 = Ysize[1].Xsize[0];
        Instantiate(gameob1,new Vector3(0,1*RoomSizeY,0),Quaternion.identity,transform);
        GameObject gameob2 = Ysize[0].Xsize[1];
        Instantiate(gameob2,new Vector3(RoomSizeX*1,0,0),Quaternion.identity,transform);
    }

}
