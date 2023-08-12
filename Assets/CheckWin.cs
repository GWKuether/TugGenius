using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckWin : MonoBehaviour
{
    public int sceneBuildIndexWin;
    public int sceneBuildIndexLose;


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entered");

        if (other.tag == "WinCondition")
        {
            Debug.Log("Switching scene to " + sceneBuildIndexWin);
            SceneManager.LoadScene(sceneBuildIndexWin, LoadSceneMode.Single);
        }
        if (other.tag == "LoseCondition")
        {
            Debug.Log("Switching scene to " + sceneBuildIndexLose);
            SceneManager.LoadScene(sceneBuildIndexLose, LoadSceneMode.Single);
        }
    }
}
