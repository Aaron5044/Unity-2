using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float slowDown = 20.0f;
    

    // Update is called once per frame
    void Update()
    {
        slowDown -= 0.1f;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            slowDown = 20.0f;
        }
         
        
        
    }
}
