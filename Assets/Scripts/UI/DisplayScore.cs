using System;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    [SerializeField] private Score score;
    private Text[] points;

    private void Start()
    {
        points = GetComponentsInChildren<Text>();
        score.ResetScore();
    }

    private void Update()
    {
        points[0].text = score.LeftPoints.ToString();
        points[1].text = score.RightPoints.ToString();
    }
}
