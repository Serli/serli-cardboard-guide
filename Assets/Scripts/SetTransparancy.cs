using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetTransparancy : MonoBehaviour {
	public Button myButton;
	// Use this for initialization
	void Start () {
		myButton.image.color = new Color(255f,255f,255f,.2f);
	}

	// Update is called once per frame
	void Update () {

	}
}