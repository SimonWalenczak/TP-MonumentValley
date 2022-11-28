using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCore : MonoBehaviour
{
    public static GameCore instance;

    public Animator animator;
    private void Awake()
    {
        instance = this;
        animator = Player.GetComponent<Animator>();
    }
    
    public GameObject Player;
}
