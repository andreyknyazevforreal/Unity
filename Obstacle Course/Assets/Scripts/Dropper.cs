using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer; //container for the renderer
    Rigidbody rigidBody;
    float timeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        // get mesh renderer, set it to false (no mesh, invisible on start)
        // also get use gravity, should not have gravity at first so it won't fall
        renderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        // print out the time every second
        // Debug.Log(Time.time);
        float time = Time.time;
        if(time > timeToWait) {
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
