using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLauncher : MonoBehaviour
{
    [SerializeField] GameObject missile;
    [SerializeField] float periodForNextFiring = 1f;
    bool fire = true;
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (fire)
            {
                GameObject NewMissle = Instantiate(missile,
               new Vector3(transform.GetChild(1).position.x, transform.GetChild(1).position.y, transform.GetChild(1).position.z)
               , Quaternion.identity);
                NewMissle.transform.rotation = transform.rotation;
                StartCoroutine(waitTllNextfiring());
            }
            
        }
    }

    IEnumerator waitTllNextfiring()
    {
        fire = false;
        yield return new WaitForSeconds(periodForNextFiring);
        fire = true;
    }
}
