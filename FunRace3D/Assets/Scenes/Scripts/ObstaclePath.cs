using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePath : MonoBehaviour
{
    [HideInInspector]
    public Vector3 direction = Vector3.zero;

    private void Start()
    {
        switch(tag)
        {
            case "XPath":
                direction = Vector3.right;
                break;
            case "YPath":
                direction = Vector3.up;
                break;
            case "ZPath":
                direction = Vector3.forward;
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerController>().direction = direction;
        }
    }

}


