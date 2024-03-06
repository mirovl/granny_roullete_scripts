using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnerVase : MonoBehaviour
{
    public GameObject vase;
    public Vector3 vectorvasespawn;
    public GameObject target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(vova());
    }
    IEnumerator vova()
    {
        yield return new WaitForSeconds(5);
        Instantiate(vase, target.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(5);
    }
}
