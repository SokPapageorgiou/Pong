using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/PadsStats", fileName = "PadsStats") ]
public class PadsStats : ScriptableObject
{
    [SerializeField] private float speed = 5;
    [SerializeField] private string upInput;
    [SerializeField] private string downInput;
}
