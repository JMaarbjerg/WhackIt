using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearths : MonoBehaviour {

    public GameObject Hearth;
    public GameObject Hearth2;
    public GameObject Hearth3;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (PlayerHealth.CurrentHealth <= 2)
        {
            Hearth.SetActive(false);
        }

        if (PlayerHealth.CurrentHealth <= 1)
        {
            Hearth2.SetActive(false);
        }

        if (PlayerHealth.CurrentHealth == 0)
        {
            Hearth3.SetActive(false);
        }
	}
}
