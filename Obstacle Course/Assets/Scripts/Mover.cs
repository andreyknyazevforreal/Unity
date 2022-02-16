using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    float moveSpeed = 10;
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        movePlayer();
    }

    void movePlayer() {
        // access transform of game object(player)
        // within the transform of player, call 'Translate' which is to move
        // 'Input' keyword accesses Input manager
         // left and right
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        // forward and back
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed; 
        transform.Translate(xValue, 0, zValue);
    }
}
