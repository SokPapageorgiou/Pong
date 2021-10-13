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
 }
 

