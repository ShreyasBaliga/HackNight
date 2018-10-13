using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {
    public GameObject[] tilePrefab;
    private Transform playerTransform;
    private float spanwz = 0.0f;
    private float tilelength = 6.8f;
    private int amtofTiles = 7;

	// Use this for initialization
	void Start () {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        for(int i=0;i<amtofTiles;i++)
        {
            SpawnTile();
        }
    }
	
	// Update is called once per frame
	void Update () {
       if(playerTransform.position.z>(spanwz - amtofTiles * tilelength))
        {
            SpawnTile();
        }
		
	}
    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(tilePrefab[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spanwz;
        spanwz += tilelength;

    }
}
