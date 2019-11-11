using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonObstacle : MonoBehaviour
{
    public GameObject bullet;
    public float seconds_to_shoot = 2.0f;
    private Transform bullet_point;
    // Start is called before the first frame update
    void Start()
    {
        bullet_point = transform.GetChild(0).transform;
        StartCoroutine(InstanciateBullet());
    }

    IEnumerator InstanciateBullet()
    {
        GameObject go;

        for(; ;)
        {
            go = Instantiate(bullet, bullet_point);
            go.GetComponent<Bullet>().direction = bullet_point.position - transform.position;
            yield return new WaitForSeconds(seconds_to_shoot);
        }


    }
   
}
