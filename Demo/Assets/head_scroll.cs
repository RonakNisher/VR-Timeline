using UnityEngine;
using System;
using System.Collections;

public class head_scroll : MonoBehaviour {

    public float speed;

    public float threshold;

    public CardboardHead head;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//        transform.position += speed * head.Gaze.direction;
        if(Math.Abs(head.Gaze.direction.x) > threshold)
        {
            Vector3 position = transform.position;
            position.x -= speed * head.Gaze.direction.x;
            transform.position = position;
        }
        
    }
}
