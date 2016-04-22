using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class load_scene : MonoBehaviour {

	public void LoadScene(string name)
    {
        Debug.Log(name);
        SceneManager.LoadScene(name);
    }
}
