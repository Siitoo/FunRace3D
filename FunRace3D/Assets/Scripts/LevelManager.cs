using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> respawn_points;

    [HideInInspector]
    public int obstacle_pass = 0;

    private bool first_tap = true;

    public void RespawnPlayer(GameObject player_to_instanciate)
    {
        GameObject go = Instantiate(player_to_instanciate,respawn_points[obstacle_pass].transform.position, respawn_points[obstacle_pass].transform.rotation);
        go.GetComponent<PlayerController>().enabled = true;
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraController>().SetPlayer(go);
        Destroy(player_to_instanciate);
    }

    public void SwapFirstTap()
    {
        first_tap = !first_tap;

        if (first_tap)
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = false;
        else
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = true;
    }

    public void LoadNewLevel()
    {
        SceneManager.LoadScene("MainScene");
    }


}
