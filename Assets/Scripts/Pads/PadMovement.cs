using System;
using UnityEngine;

public class PadMovement : MonoBehaviour
{
    public PadsStats padsStats;

    private Vector3 _direction;

    private void Start()
    {
        _direction = new Vector3(0, 0, 0);
    }

    private void Update()
    {
        if (Input.GetKey(padsStats.UpInput)) MoveUp();
        
        if (Input.GetKey(padsStats.DownInput)) MoveDown();
    }

    private void MoveUp()
    {
        _direction.y = 1;
        MoveVertical();
    }

    private void MoveDown()
    {
        _direction.y = -1;
        MoveVertical();
    }

    private void MoveVertical()
    {
        transform.Translate(_direction * padsStats.Speed * Time.deltaTime);
    }
}
