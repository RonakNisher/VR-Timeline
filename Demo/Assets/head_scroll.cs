using UnityEngine;
using System;
using System.Collections;

public class head_scroll : MonoBehaviour {

    public float speed = 1.5f;

    public float threshold1 = 0.5f;

	public float threshold2 = 0.8f;

	public float threshold3 = 0.9f;

    public CardboardHead head;

    // Use this for initialization
    void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		//if (transform.position.x > -5250 && transform.position.x < 5250) {
//        transform.position += speed * head.Gaze.direction;
			if (Math.Abs (head.Gaze.direction.x) > threshold3) {
				Vector3 position = transform.position;
				position.x -= 3 * speed * head.Gaze.direction.x;
				transform.position = position;
			}
			if (Math.Abs (head.Gaze.direction.x) > threshold2) {
				Vector3 position = transform.position;
				position.x -= 2 * speed * head.Gaze.direction.x;
				transform.position = position;
			}
			if (Math.Abs (head.Gaze.direction.x) > threshold1) {
				Vector3 position = transform.position;
				position.x -= speed * head.Gaze.direction.x;
				transform.position = position;
			}

		//} else if (transform.position.x <= -5250)
		//{
			//Debug.Log (transform.position.x);
			//Vector3 position = transform.position;
			//position.x = -5200;
			//transform.position = position;
		//}
		//else if (transform.position.x >= 5250)
		//{
			//Debug.Log (transform.position.x);
			//Vector3 position = transform.position;
			//position.x = 5200;
			//transform.position = position;
		//}
    }
}
