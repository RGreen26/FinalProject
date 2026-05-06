using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
   public TMP_Text Score;
   public ButtonInput A_totalpoints;
   public ButtonInput W_totalpoints;
   public ButtonInput S_totalpoints;
   public ButtonInput D_totalpoints;

   void Update()
   {
      Score.text = A_totalpoints.points + W_totalpoints.points + S_totalpoints.points + D_totalpoints.points + "";
   }
}
