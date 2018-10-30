using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float Health = 3;
    public int scoreValue;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && (hit.transform.gameObject == transform.gameObject))
            {
                Health -= 1;
                    if (Health <= 0)
                    {
                        ScoreManager.score += scoreValue;
                        Destroy(this.gameObject);
                    }

            }

        }
    }
}