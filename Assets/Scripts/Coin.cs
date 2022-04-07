using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    CanvasScript canvasScript;
    private void Start()
    {
        canvasScript = FindObjectOfType<CanvasScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            canvasScript.IncreaseNumOfCollectedCoins();
            Destroy(gameObject);
        }
    }
}
