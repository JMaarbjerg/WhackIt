using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int StartHealth = 3;
    public static int CurrentHealth;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Awake ()
    {
        CurrentHealth = StartHealth;
    }

    private void Update()
    {

    }

}
