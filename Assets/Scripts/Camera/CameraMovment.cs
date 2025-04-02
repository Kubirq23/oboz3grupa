using UnityEngine;

public class CameraMovment : MonoBehaviour{
    [SerializeField]
    private GameObject player;
    private void Update(){
        var p = player.transform;
        transform.position = new Vector3(p.position.x,p.position.y,transform.position.z);
    }
}
