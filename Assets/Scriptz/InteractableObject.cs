using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour {
    public UnityEvent myUnityEvent;
	// Use this for initialization
	void Awake () {
        if (myUnityEvent == null)
            myUnityEvent = new UnityEvent();
	}
	
	// Update is called once per frame
	public void DoAction () {
        myUnityEvent.Invoke();
	}
}
