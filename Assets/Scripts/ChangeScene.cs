using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    
   

	public void ChangeToScene (string scene)
    {
        SceneManager.LoadScene(scene);
	}

}
