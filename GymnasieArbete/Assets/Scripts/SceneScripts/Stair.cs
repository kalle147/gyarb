using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stair : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Enter");
        if(other.tag == "Player")
        {
            Debug.Log("Changing Scene");
            SceneManager.LoadSceneAsync("Map3");
        }
    }

}
