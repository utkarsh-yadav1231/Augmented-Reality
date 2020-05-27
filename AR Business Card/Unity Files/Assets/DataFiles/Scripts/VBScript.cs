using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
//Script By Utkarsh Yadav (Gmail- utkarshyadav1231@gmail.com)
public class VBScript : MonoBehaviour,IVirtualButtonEventHandler {
	public GameObject profilego, resumego;
	// Use this for initialization
	void Start () {
		VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour> (); 
		for (int i = 0; i < vrb.Length; i++) 
		{
			vrb [i].RegisterEventHandler (this);
		}
		profilego.SetActive (false);
		resumego.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
		if (vb.VirtualButtonName == "ProfileB") {
			Debug.Log ("Profile Button Pressed ...");
			profilego.SetActive (true);
			resumego.SetActive (false);
		} 
		else if (vb.VirtualButtonName == "ResumeB") {
			Debug.Log ("Resume Button Pressed ...");
			profilego.SetActive (false);
			resumego.SetActive (true);
		} 
		else if (vb.VirtualButtonName == "GitHubB") {
			Debug.Log ("GitHub Button Pressed ...");
			Application.OpenURL ("https://github.com/utkarsh-yadav1231");
		}
		else{
			throw new UnityException (vb.VirtualButtonName + "Virtual Button not supported");
		}
	}
	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
		Debug.Log ("Virtual Button pressed ");
	}
}
