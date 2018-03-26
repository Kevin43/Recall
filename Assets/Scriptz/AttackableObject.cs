using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AttackableObject : MonoBehaviour {
    public UnityEvent myUnityEvent2;

	// Use this for initialization
	void Awake () {
        if (myUnityEvent2 == null)
            myUnityEvent2 = new UnityEvent();
    }

    // Update is called once per frame
    public void DoAction()
    {
        myUnityEvent2.Invoke();
    }

}
