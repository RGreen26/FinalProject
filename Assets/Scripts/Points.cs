using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    public TMP_Text Points;
    public ButtonInput totalpoints;

    void Update()
    {
        Points.text = totalpoints.points;
    }
}
