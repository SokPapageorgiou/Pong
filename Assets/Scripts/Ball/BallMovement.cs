
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallMovement : MonoBehaviour
{
    public BallStats ballStats;

    private Rigidbody2D _rigidbody;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = ballStats.VelocityVector();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        string obstacle = other.gameObject.tag;

        switch (obstacle)
        {
            case "Pads":
                ballStats.InvertXDirection();
                break;
            
            case "Border":
                ballStats.InvertYDirection();
                break;
            
            case "Goal":
                ballStats.InvertXDirection();
                break;
        }
    }
}
