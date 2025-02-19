using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMain : MonoBehaviour
{
    public void GoToStartScreen()
    {
        Debug.Log("Кнопка 'Quit' нажата!");
        SceneManager.LoadScene("StartMenu");
    }
}
