using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Update is called once per frame
    [SerializeField] float x = 0;
    [SerializeField] float y = 0;
    [SerializeField] float z = 0;
    void Update()
    {
        // references transform object
        // rotate whatever thing this script is attached to
        transform.Rotate(x,y,z);
    }
}
