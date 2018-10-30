using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

    public GameObject GameOver;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (PlayerHealth.CurrentHealth > 0)
        {
            GameOver.SetActive(false);
        }

        if (PlayerHealth.CurrentHealth == 0)
        {
            GameOver.SetActive(true);

            //if (Input.GetMouseButtonDown(0))
           // {
             //  SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //}
            
        }

    }
}
