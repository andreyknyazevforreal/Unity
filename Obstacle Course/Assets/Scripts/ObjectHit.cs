using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Callback, whenever collision event takes place (walls in this case), box collider hits another
    // box collider, will call this function when a collision happens
    // 'other' is what bumped into the wall (or whatever this script applies to)
    private void OnCollisionEnter(Collision other) {
        //Debug.Log("Bumped into a wall");

        // when bump into a wall, change the color
        // get a component that's of type MeshRenderer
        // get it's material's color, set it to right side of =
        // only want to change if it's the player that bumps into you. USE TAGS FOR THIS
        if(other.gameObject.tag == "Player") {
            GetComponent<MeshRenderer>().material.color = Color.red;

            // after make it red, access tag and assign it to "Hit", which is the tag we created
            gameObject.tag = "Hit";
        }
    }
}
