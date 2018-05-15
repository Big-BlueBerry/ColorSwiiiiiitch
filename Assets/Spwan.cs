using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwan : MonoBehaviour {
    public int num;
    public GameObject[] cubes;
    private float time;
    private int Wtime = 3;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time > Wtime)
        {
            SpawnCube();
            time = 0;
        }
    }

    public void SpawnCube()
    {
        num = Random.Range(0, 4);
        Instantiate<GameObject>(cubes[num], new Vector2(0f, 6f), Quaternion.identity);
    }
}
