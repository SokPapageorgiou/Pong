using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/PadsStats", fileName = "PadsStats") ]
public class PadsStats : ScriptableObject
{
    [SerializeField] private float speed = 5;
    [SerializeField] private float minimunDistanceToEdges;
    [SerializeField] private string upInput;
    [SerializeField] private string downInput;

    public float Speed => speed;
    public float MinimunDistanceToEdges => minimunDistanceToEdges;
    public string UpInput => upInput;
    public string DownInput => downInput;

}
