using UnityEngine;

public class ArrowMove : MonoBehaviour
{
    public Vector3 startLocation, endLocation;
    public float movementDuration;

    public float currentTimeMoving;

    void Update()
    {

        // mark as not moving once target is reached
        if (currentTimeMoving > movementDuration)
        {
            Destroy (transform.gameObject);
        }

        // count how long we have been moving

        currentTimeMoving += Time.deltaTime;

        transform.position = Vector3.Lerp(startLocation, endLocation, currentTimeMoving / movementDuration);
    }
}

