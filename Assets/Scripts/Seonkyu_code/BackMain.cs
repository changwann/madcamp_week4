using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMain : MonoBehaviour
{
    public void BackSceneBtn() {
        SceneManager.LoadScene("Main Menu");
    }
}
