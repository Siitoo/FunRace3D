using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset = Vector3.zero;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag ("Player");
        offset = player.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position - offset;
        transform.LookAt(player.transform);
       
    }

    public void SetPlayer(GameObject new_player)
    {
        player = new_player;
    }

}
