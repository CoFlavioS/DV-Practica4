using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject player;
    private Vector3 position;
    private Quaternion rotation;
    private CameraController cc;
    private GameObject playerObj;

    void Start()
    {
        cc = GetComponent<CameraController>();
        position = Vector3.right * Random.Range(-10,10) + Vector3.forward * Random.Range(-10, 10);
        rotation = Quaternion.Euler(0, Random.Range(0, 359), 0);
        playerObj = Instantiate(player, position, rotation);
        cc.SetPlayerPos(playerObj.transform);
    }
}
