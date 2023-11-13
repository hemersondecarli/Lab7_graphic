using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    void Update()
    {
        // Move the object upward in world space 1 unit/second.
  
        if (Input.GetKeyDown(KeyCode.Space))
        {
          transform.Translate(0, Time.deltaTime * 30, 0, Space.World);
            Debug.Log("Space key is pressed.");
        }
    }
}