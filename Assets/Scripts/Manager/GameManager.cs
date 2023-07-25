using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject[] goGameUI = null;
    public static GameManager instance;

    public bool start = false;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    public void GameStart() {
        start = true;
        for (int j = 0; j < goGameUI.Length; j++) {
            goGameUI[j].SetActive(true);
        }
    }
}
