using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : BaseEnemy {

    [SerializeField]
    private int enemyHealth;
    [SerializeField]
    private string enemyName;


	// Use this for initialization
	void Start () {
        health = enemyHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
