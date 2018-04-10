using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleToggler : MonoBehaviour
{
    public GameObject particleGenObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            particleGenObject.SetActive(true);
        }
        else
        {
            particleGenObject.SetActive(false); 
        }
    }
}
