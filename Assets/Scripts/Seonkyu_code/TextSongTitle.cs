using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Song 
{
    public string Name;
    //public string composer;
    public int bpm;
    //public Sprite sprite;
}

public class TextSongTitle : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text SongTitleText;
    public List<string> buttonNamesList = new List<string>();
    
    [SerializeField] Song[] songList = null;
    [SerializeField] Text txtSongName = null;
    [SerializeField] Text txtSongComposer = null;
    [SerializeField] Image imgDisk = null;
    [SerializeField] GameObject TitleMenu = null;
    public int songIndex;
    int currentSong = 0;

    void SettingSong() {
        //txtSongName.text = songList[currentSong].name;
        //txtSongComposer.text = songList[currentSong].composer;
       // imgDisk.sprite = songList[currentSong].sprite;
        //AudioManager.instance.PlayBGM("BGM" + currentSong);
    }
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
        buttonNamesList.Add("Original Rhythm");
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
    public void OnClickButtonG() {
        SongTitleText.text = buttonNamesList[6];
        MusicPlayer musicPlayer = GetComponent<MusicPlayer>();
        musicPlayer.PlaySong("FeelMyRhythm");
    }
    // Update is called once per frame
}
