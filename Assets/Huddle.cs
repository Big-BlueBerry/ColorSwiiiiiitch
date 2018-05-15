using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huddle : MonoBehaviour {
    public static Color[] colors = { Color.black, new Color(1, 1, 0), new Color(0, 1, 1) };
    public int ColorIndex;
    public Color color { get { return colors[ColorIndex]; } }
    public Color hehe;
    // Use this for initialization
    void Start () {
        ColorIndex = Random.Range(0, colors.Length);
        GetComponent<MeshRenderer>().material.color = color;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(transform.position.x, transform.position.y - 0.1f);
        if (transform.position.y <= -6)
        {
            Destroy(this.gameObject);
        }
    }


}
