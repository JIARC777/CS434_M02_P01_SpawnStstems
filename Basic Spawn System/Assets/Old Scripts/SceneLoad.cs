using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    // scripts for the buttons - one will go to the next scene the other will go back
    public void OnButtonPressSceneOne()
    {
        SceneManager.LoadScene(1);
    }
    public void OnButtonPressSceneTwo()
    {
        SceneManager.LoadScene(0);
    }
}
