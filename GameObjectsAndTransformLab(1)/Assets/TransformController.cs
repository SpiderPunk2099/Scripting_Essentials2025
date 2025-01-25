using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        // Move the target GameObject
        var x = Mathf.PingPong(Time.time, 3);  // No need to use named arguments
        var p = new Vector3(0, x, 0);  // Create a Vector3 with x as the Y value
        transform.position = p;  // Apply the new position

        // Rotate the target GameObject
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);  // Rotate with a fixed speed

    }
}

