using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> respawn_points;

    [HideInInspector]
    public int obstacle_pass = 0;

    public void RespawnPlayer(GameObject player_to_instanciate)
    {
        GameObject go = Instantiate(player_to_instanciate,respawn_points[obstacle_pass].transform.position, respawn_points[obstacle_pass].transform.rotation);
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraController>().SetPlayer(go);
        Destroy(player_to_instanciate);
    }
}
