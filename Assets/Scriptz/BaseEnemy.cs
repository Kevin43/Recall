using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour {

    protected int health;
    protected int damage;



	// Use this for initialization
	void Start () {
        health = 1;
		
	}
	
	// Update is called once per frame
	void LateUpdate () {

        Debug.Log("yeet");

        if (health <= 0)
        {
            Die();
        }

	}

    public void Die()
    {
        Destroy(this.gameObject);
    }

    public TakeDamage()
    {
        
    }
}
