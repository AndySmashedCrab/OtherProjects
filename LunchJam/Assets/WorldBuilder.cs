using System.Collections.Generic;
using UnityEngine;

public class WorldBuilder : MonoBehaviour
{
    [SerializeField]
    Transform[] tile;
    List<GameObject> world;
    void Start()
    {        
        world = new List<GameObject>();
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                world.Add(Instantiate(tile[Random.Range(0,tile.Length)], new Vector3(i-10, (Random.value - 0.5f)*0.1f, j-10), Quaternion.identity).gameObject);
            }
        }
    }
}
