using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Telelportal : MonoBehaviour
{ 
  
    public void LoadNextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            //Do what you need here
            LoadNextScene();
        }
    }
}
