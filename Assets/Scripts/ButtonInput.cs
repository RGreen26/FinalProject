using UnityEngine;

public class ButtonInput : MonoBehaviour
{
    public bool buttonPress;
    public bool buttonExpected;
    public float points;
    public int layer = 1 << 6;
    public KeyCode ExpectedKey;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(ExpectedKey))
        {
            buttonPress = true;
        }

        if (buttonExpected && buttonPress)
        {
            points ++ ;
            buttonPress = false;
        }
    }

    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, +10f, layer);

        if (hit)
        {
            if (hit.distance < 0.75f)
            {
                buttonExpected = true;
            }
            else
            {
                buttonExpected = false;
            }
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
