using System;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private Score score;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (transform.position.x < 0) score.LeftPoints++;
        else score.RightPoints++;
    }
}
