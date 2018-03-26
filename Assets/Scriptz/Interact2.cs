using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact2 : MonoBehaviour {

    public float distance;

   // GameObject player = GameObject.Find("Player");
    //public PlayerMovement playerMovement;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit;
        if (Input.GetButtonDown("Interact"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, distance))
            {
                Debug.DrawRay(transform.position, transform.forward, Color.green);
                print("Hit");
                GameObject objectHit = hit.transform.gameObject;
                InteractableObject actionObj = objectHit.GetComponent<InteractableObject>();
                if (actionObj != null)
                {
                    actionObj.DoAction();
                }
            }
            else
            {
                print("No hit");
            }
        }
	} 
    
    void DebugHit()
    {
        print("hit");
    }
}
