using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/BallStats", fileName = "BallStats") ]
 public class BallStats : ScriptableObject
{
    [SerializeField] private int speed;
    [SerializeField] private Vector3 initialDirection;
    [SerializeField] private Vector3 initialPosition;
    [SerializeField] private float thresholdVerticaLDistance;
    public float ThresholdVerticalDistance => thresholdVerticaLDistance;

    public Vector3 VelocityVector()
    {
        return initialDirection.normalized * speed;
    }

    public void InvertDirection(bool invertX)
    {
        if (invertX) InvertXDirection();
        else InvertYDirection();
    }
    
    public void InvertXDirection()
    {
        initialDirection = new Vector3(initialDirection.x * -1, initialDirection.y, initialDirection.z);
    }
    
    public void InvertYDirection()
    {
        initialDirection = new Vector3(initialDirection.x, initialDirection.y  * -1, initialDirection.z);
    }

    public void Respawn(GameObject ball)
    {
        //ball.SetActive(false);
        ball.transform.position = initialPosition;
        
    }
}
 

