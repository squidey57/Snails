using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartController : MonoBehaviour {
    
    
    private void OnMouseDown()
    {
        LoadScene();
    }

    void LoadScene()
    {
        SceneManager.LoadScene("main");
    }
}
