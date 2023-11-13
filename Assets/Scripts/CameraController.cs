using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform playerPos;
    public float spinSpeed;

    void Update()
    {
        if(playerPos != null)
        {
            transform.LookAt(playerPos.position + Vector3.up * (playerPos.localScale.y * 0.9f));
            transform.parent.position = playerPos.position;
            transform.parent.Rotate(Vector3.up * spinSpeed);
        }
    }

    public void SetPlayerPos(Transform playerPos)
    {
        this.playerPos = playerPos;
    }
}
