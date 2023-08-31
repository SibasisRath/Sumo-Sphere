using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -10)
        {
            Destroy(gameObject);
            if (gameObject.name == "Player")
            {
                GameObject.Find("PauseAndRestart").GetComponent<RestartAndPauseScript>().GameOverMethod();
                Debug.Log("Game over");
            }
        }
    }
}
