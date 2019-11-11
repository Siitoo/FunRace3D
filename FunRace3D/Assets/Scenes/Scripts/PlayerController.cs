using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private Touch t;

    private Rigidbody rb = null;

    [HideInInspector]
    public Vector3 direction = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        bool move_player = false;

        if(Input.touchSupported)
        {
            t = Input.GetTouch(0);

            if (t.phase != TouchPhase.Ended || t.phase != TouchPhase.Canceled)
                move_player = true;
        }
        else
        {
            if (Input.GetMouseButton(0))
                move_player = true;
        }

        if(move_player)
        {
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
        }

    }
}
