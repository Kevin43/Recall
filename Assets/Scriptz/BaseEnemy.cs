using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour {

    protected int health;
    protected int damage;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {

        if (health <= 0)
        {
            Die();
        }

	}

    public void Die()
    {
        Destroy(this.gameObject);
    }
}
