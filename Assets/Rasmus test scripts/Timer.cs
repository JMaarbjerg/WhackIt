using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    float timerSpeed = 1f;
    public int damage = 1;

    public GameObject Enemy;

    private float lastTimerstamp;
	
	// Update is called once per frame
	private void Update () {
		
        if (Time.time - lastTimerstamp >= timerSpeed)
        {
            lastTimerstamp = Time.time;
            Destroy(gameObject, timerSpeed);
            Enemy.SetActive(false);
            PlayerHealth.CurrentHealth -= damage;
        }

	}
}
