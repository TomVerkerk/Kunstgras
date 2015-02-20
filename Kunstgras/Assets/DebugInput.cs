using UnityEngine;
using System.Collections;

public class DebugInput : MonoBehaviour {

	private string henk = "henkie";

	// Update is called once per frame
	void OnGUI () {
		if(Input.GetKey(KeyCode.Ampersand)){
			henk = "Ampersand";
		}
		if(Input.GetKey(KeyCode.AltGr)){
			henk = "AltGr";
		}
		if(Input.GetKey(KeyCode.Asterisk)){
			henk = "Asterisk";
		}
		if(Input.GetKey(KeyCode.At)){
			henk = "At";
		}
		if(Input.GetKey(KeyCode.BackQuote)){
			henk = "BackQuote";
		}
		if(Input.GetKey(KeyCode.Backslash)){
			henk = "Backslash";
		}
		if(Input.GetKey(KeyCode.Backspace)){
			henk = "Backspace";
		}
		if(Input.GetKey(KeyCode.Break)){
			henk = "Break";
		}
		if(Input.GetKey(KeyCode.Caret)){
			henk = "Caret";
		}
		if(Input.GetKey(KeyCode.Clear)){
			henk = "Clear";
		}
		if(Input.GetKey(KeyCode.Colon)){
			henk = "Colon";
		}
		if(Input.GetKey(KeyCode.Home)){
			henk = "Home";
		}
		if(Input.GetKey(KeyCode.Hash)){
			henk = "Hash";
		}
		if(Input.GetKey(KeyCode.None)){
			henk = "None";
		}
		if(Input.GetKey(KeyCode.Return)){
			henk = "Return";
		}
		if(Input.GetKey(KeyCode.Space)){
			henk = "Space";
		}
		if(Input.GetKey(KeyCode.Tab)){
			henk = "Tab";
		}
		//GUI.TextField(new Rect(150,0,100,100),henk);
	}
}
