using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObjects/Score", fileName = "Score")]
public class Score : ScriptableObject
{
   public int LeftPoints { get; set; }
   public int RightPoints { get; set; }

   public void ResetScore()
   {
      LeftPoints = 0;
      RightPoints = 0;
   }
}
