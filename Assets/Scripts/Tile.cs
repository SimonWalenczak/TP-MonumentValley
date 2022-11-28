using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tile : MonoBehaviour
{
    private float Timedistance = 0.5f;
    [SerializeField] private float offSet;

    private Vector2 direction;

    private void Update()
    {
        direction = transform.position - GameCore.instance.Player.transform.position;
    }

    private void OnMouseDown()
    {
        GameCore.instance.Player.transform.DOMove(new Vector3(transform.position.x, transform.position.y + offSet, transform.position.z), Timedistance * Vector3.Distance(transform.position, GameCore.instance.Player.transform.position)).OnComplete(MoveEnd);
        GameCore.instance.animator.SetBool("walking", true);
        GameCore.instance.Player.transform.DORotateQuaternion(Quaternion.LookRotation(-direction, Vector3.up), 0.3f);
    }

    void MoveEnd()
    {
        GameCore.instance.animator.SetBool("walking", false);
    }
}
