using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearSceneController : MonoBehaviour
{
    public void OnReturnToTitleButtonPressed()
    {
        SceneManager.LoadScene("TitleScene");
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
