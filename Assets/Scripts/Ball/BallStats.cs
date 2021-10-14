using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/BallStats", fileName = "BallStats") ]
 public class BallStats : ScriptableObject
{
    [SerializeField] private int speed;
    [SerializeField] private Vector3 direction;
    
    [SerializeField] private float thresholdVerticaLDistance;
    public float ThresholdVerticalDistance => thresholdVerticaLDistance;

    public Vector3 VelocityVector()
    {
        return direction.normalized * speed;
    }

    public void InvertDirection(bool invertX)
    {
        if (invertX) InvertXDirection();
        else InvertYDirection();
    }
    
    public void InvertXDirection()
    {
        direction = new Vector3(direction.x * -1, direction.y, direction.z);
    }
    
    public void InvertYDirection()
    {
        direction = new Vector3(direction.x, direction.y  * -1, direction.z);
    }
}
 

