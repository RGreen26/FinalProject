using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Vector3 startLocation, endLocation;
    public float movementDuration;
    public int layer = 1 << 6;
    public float currentTimeMoving;

    public bool canMove;

    void Update()
    {
        // count how long we have been moving

        if (canMove == true)
        {
            currentTimeMoving += Time.deltaTime;

            transform.position = Vector3.Lerp(startLocation, endLocation, currentTimeMoving / movementDuration);
        }
    }

    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, +10f, layer);

        if (hit)
        {
            if (hit.distance < 0.75f)
            {
                canMove = false;
            }
            else
            {
                canMove = true;
            }
        }
    }
}
