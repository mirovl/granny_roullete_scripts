using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchColliderToDieVase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "VASEDELETer")
        {
            // destroy this object
            Destroy(gameObject);
        }
    }
}
