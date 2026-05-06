using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
   public TMP_Text Score;
   public ButtonInput totalpoints;

   void Update()
   {
      Score.text = "totalpoints.points";
   }
}
