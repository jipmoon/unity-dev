using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	// Use this for initialization
	void Start () {
		text.text = "Hello, world!";
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown (KeyCode.Space)) {
			text.text = "Why don't you work harder instead of complaining " +
			 			"Yesterday you said tomorrow, stop making execuses and start producing " +
			 			"It is about time to start building things and it may take a while to see the results.\n\n" +
			 			"Press S to view Sheets, M to view Mirror and L to view Lock";
		}
		
	}
}
