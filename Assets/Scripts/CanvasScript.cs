using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinsText;
    int numOfCollectedCoins = 0;
    int numOfCoinsInLevel;
    void Start()
    {
        numOfCoinsInLevel = FindObjectsOfType<Coin>().Length;
    }

    public void IncreaseNumOfCollectedCoins()
    {
        numOfCollectedCoins++;
    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = "Coins " + numOfCollectedCoins + "/" + numOfCoinsInLevel;
    }
}
