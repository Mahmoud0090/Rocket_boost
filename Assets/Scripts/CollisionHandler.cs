using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 1f;
    [SerializeField] ParticleSystem collissionParticle;
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Freindly":
                //Debug.Log("Freindly");
                break;
            case "Finish":
                CheckCoinsToLoadNextLevel();
                break;
            default:
                StartCrachSequence();
                break;
        }
    }

    void StartCrachSequence()
    {
        GetComponent<Movement>().enabled = false;
        collissionParticle.gameObject.SetActive(true);
        Invoke("ReloadScene", levelLoadDelay);
    }

    void CheckCoinsToLoadNextLevel()
    {
        if(FindObjectsOfType<Coin>().Length == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
