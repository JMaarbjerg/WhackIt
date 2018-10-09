using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMaker : MonoBehaviour {

	public GameObject spawner;
    public GameObject[] clones;
    public int sizeX = 10;
    public int sizeY = 10;

	// Use this for initialization
	void Start () {
        MakeGrid();
	}
	
	// Update is called once per frame
	void MakeGrid () {
		for (int x = 0; x <= sizeX; x++) {
            for (int y = 0; y <= sizeY; y++) {
                Instantiate(spawner, new Vector3(x, 0, y), Quaternion.identity);
            }			
		}
        clones = GameObject.FindGameObjectsWithTag("Spawner");

	}
}
