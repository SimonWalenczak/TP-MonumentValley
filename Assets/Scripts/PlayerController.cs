using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform _startPos;
    public float OffSetY;

    private void Start()
    {
        transform.position = _startPos.position + new Vector3(0, OffSetY, 0);
    }
    
    
}
