using UnityEngine;
using System.Collections;

public class toggle_image : MonoBehaviour {

	public GameObject image;
	private bool show;
	// Use this for initialization
	void Start () {
		show = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void toggle()
	{
		if (show) {
			image.SetActive(true);
			show = false;
		} 
		else {
			image.SetActive(false);
			show = true;
		}
	}
}
