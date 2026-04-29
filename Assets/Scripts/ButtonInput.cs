using UnityEngine;

public class ButtonInput : MonoBehaviour
{
    public bool buttonPress;
    public bool buttonExpected;
    public float points;

    // Update is called once per frame
    void Update()
    {
        if (buttonExpected && buttonPress)
        {
            points ++ ;
        }
    }

    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, +0.67)

        if (hit)
        {
            if (hit.distance < 6f)
        }
        else
        {

        }


    }
    // void OnTriggerEnter2D(Collider2D other)
    // {
    //   if (other.gameObject.tag == "Button")
    //   {
    //     buttonExpected = true;
    //   }
    // }

    // void OnTriggerExit2D(Collider2D other)
    // {
    //     if (other.gameObject.tag == "Button")
    //     {
    //         buttonExpected = false;
    //     }
    // }
    
    
}
