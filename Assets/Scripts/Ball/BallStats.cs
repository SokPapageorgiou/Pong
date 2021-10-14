using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/BallStats", fileName = "BallStats") ]
 public class BallStats : ScriptableObject
{
    [SerializeField]
    private int speed;
    [SerializeField]
    private Vector3 direction;

    public Vector3 VelocityVector()
    {
        return direction.normalized * speed;
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
 

