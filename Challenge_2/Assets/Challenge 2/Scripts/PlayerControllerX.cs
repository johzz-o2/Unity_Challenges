using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float timeDelay = 1;
    private float timeCounter;
    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        // On spacebar press & after a set delay, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timeCounter > timeDelay)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeCounter = 0;
        }
    }
}
