using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject[] goGameUI = null;
    public static GameManager instance;

    NoteManager theNote;
    [SerializeField] CenterFlame theMusic = null;
    public bool start = false;
    void Start()
    {
        instance = this;
        theNote = FindObjectOfType<NoteManager>();

    }

    // Update is called once per frame
    public void GameStart(string p_songName, int p_bpm) {
        Debug.Log("GameStartvist");
        start = true;
        theNote.bpm = p_bpm;
        theMusic.bgmName = p_songName;

        for (int j = 0; j < goGameUI.Length; j++) {
            goGameUI[j].SetActive(true);
        }
    }
}
