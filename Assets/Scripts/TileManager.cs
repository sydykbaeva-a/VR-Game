using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tileGenerator;
    public float TileLength = 120;
    public GameObject tile;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTile(3);
        //InvokeRepeating("SpawnTile", delayTime, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        if(tile.transform.position.z <= 0){
            int randTile = Random.Range(0, 4);
            SpawnTile(randTile);
        }
        
    }

    public void SpawnTile(int tileIndex){
        
        tile = Instantiate(tileGenerator[tileIndex], transform.position, transform.rotation);
    }
}
