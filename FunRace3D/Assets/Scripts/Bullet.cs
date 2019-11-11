using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10.0f;
    public float time_to_death = 5.0f;

    [HideInInspector]
    public Vector3 direction = Vector3.zero;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        StartCoroutine(BulletMovement());
    }

    IEnumerator BulletMovement()
    {
        rb.AddForce(direction * speed);
        yield return new WaitForSeconds(time_to_death);
        Destroy(gameObject);
    }

}
