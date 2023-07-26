using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TextSongTitle : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text SongTitleText;
    public List<string> buttonNamesList = new List<string>();
    public int songIndex;
    /*void Start()
    {
          SongTitleText.text = "What kind of song's rhythm do you want to feel?";  
    }*/

    void Start()
    {
        buttonNamesList.Add("Feel My Rhythm");
        buttonNamesList.Add("Bad Habits");
        buttonNamesList.Add("Bang Bang Bang");
        buttonNamesList.Add("Attention");
        buttonNamesList.Add("Sugar");
        buttonNamesList.Add("Closer");
    }

    public void OnClickButtonA() {
        Debug.Log("A");
        SongTitleText.text = "Feel My Rhythm";
        MusicPlayer musicPlayer = GetComponent<MusicPlayer>();
        musicPlayer.PlaySong("FeelMyRhythm");
    }
    public void OnClickButtonB() {
        Debug.Log("B");
        SongTitleText.text = "Bad Habits";
        MusicPlayer musicPlayer = GetComponent<MusicPlayer>();
        musicPlayer.PlaySong("BadHabits");
    }

    public void OnClickButtonC() {
        Debug.Log("C");
        SongTitleText.text = buttonNamesList[2];
    }
    public void OnClickButtonD() {
        Debug.Log("D");
        SongTitleText.text = buttonNamesList[3];
    }

    public void OnClickButtonE() {
        SongTitleText.text = buttonNamesList[4];
    }
    public void OnClickButtonF() {
        SongTitleText.text = buttonNamesList[5];
    }
    // Update is called once per frame
}
