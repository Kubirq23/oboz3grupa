using UnityEngine;

public class SpawnerParentPosition : MonoBehaviour
{
    [SerializeField] private GameObject spawnerParent;

    private void FixedUpdate()
    {
        transform.position = spawnerParent.transform.position;
    }
}
