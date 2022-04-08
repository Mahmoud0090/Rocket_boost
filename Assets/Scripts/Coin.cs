using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    CanvasScript canvasScript;
    bool IncreaseCollectionNum = true;
    private void Start()
    {
        canvasScript = FindObjectOfType<CanvasScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (IncreaseCollectionNum)
            {
                canvasScript.IncreaseNumOfCollectedCoins();
                IncreaseCollectionNum = false;
                Destroy(gameObject);
            }
            
        }
    }
}
