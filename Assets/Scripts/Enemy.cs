using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] ParticleSystem deathParticle;
    [SerializeField] float enemyDeathDelayTime = 0.2f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Missile")
        {
            deathParticle.gameObject.SetActive(true);
            deathParticle.Play();
            Invoke("EnemyDeath", enemyDeathDelayTime);
        }
    }

    void EnemyDeath()
    {
        Destroy(gameObject);
    }

}
