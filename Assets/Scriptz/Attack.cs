using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
    public float distance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit;
        if (Input.GetButtonDown("Attack"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, distance))
            {
                Debug.DrawRay(transform.position, transform.forward, Color.green);
                print("Attack");
                GameObject objectHit = hit.transform.gameObject;
                AttackableObject actionObj = objectHit.GetComponent<AttackableObject>();
                if (actionObj != null)
                {
                    actionObj.DoAction();
                }
            }
            else
            {
                print("No attack");
            }
        }
    }

    void DebugHit()
    {
        print("Attack");
    }
}