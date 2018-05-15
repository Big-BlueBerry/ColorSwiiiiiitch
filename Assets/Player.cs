using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    int currentIndex;

	void Start ()
    {
        GetComponent<MeshRenderer>().material.color = Huddle.colors[currentIndex];
    }
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentIndex++;
            if (currentIndex == Huddle.colors.Length)
                currentIndex = 0;

            GetComponent<MeshRenderer>().material.color = Huddle.colors[currentIndex];
        }
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (!other.CompareTag("Cube"))
            return;
        if (other.gameObject.GetComponent<Huddle>().ColorIndex != currentIndex)
        {
            Debug.Log("다름 웅애웅");
        }
    }
}
