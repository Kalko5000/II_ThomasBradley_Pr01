using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class announceObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("A " + gameObject.tag + " is born!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello I am a " + gameObject.tag);
    }
}
