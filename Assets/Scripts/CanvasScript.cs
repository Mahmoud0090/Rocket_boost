using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinsText;
    [SerializeField] TextMeshProUGUI missilesText;
    int numOfCollectedCoins = 0;
    int numOfCoinsInLevel;
    void Start()
    {
        numOfCoinsInLevel = FindObjectsOfType<Coin>().Length;
        missilesText.text = "Missiles : " + FindObjectOfType<MissileLauncher>().NumOfMissiles.ToString();
    }

    public void IncreaseNumOfCollectedCoins()
    {
        numOfCollectedCoins++;
    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = "Coins " + numOfCollectedCoins + "/" + numOfCoinsInLevel;
        missilesText.text = "Missiles : " + FindObjectOfType<MissileLauncher>().NumOfMissiles.ToString();
    }
}
