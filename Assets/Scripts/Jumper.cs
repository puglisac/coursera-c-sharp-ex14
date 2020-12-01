using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    //jump location support
    const float minX = -6;
    const float maxX = 6;
    const float minY = 0;
    const float maxY = 4;

    //timer support
    const float TotalJumpDelaySeconds = 1;
    float elapsedJumpDelaySeconds = 0;

    


    // Update is called once per frame
    void Update()
    {
        //update timer and check if it's done
        elapsedJumpDelaySeconds += Time.deltaTime;
        if (elapsedJumpDelaySeconds >= TotalJumpDelaySeconds)
        {
            elapsedJumpDelaySeconds = 0;
            Vector3 newVector = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
            transform.position = newVector;
        }
    }
}
