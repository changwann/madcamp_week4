using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TextSongTitle : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text SongTitleText;
    /*void Start()
    {
          SongTitleText.text = "What kind of song's rhythm do you want to feel?";  
    }*/

    public void OnClickButtonA() {
        Debug.Log("Click A");
        SongTitleText.text = "Feel My Rhythm";
    }
    public void OnClickButtonOther() {
        Debug.Log("Click B");
        SongTitleText.text = "other Song";
    }
    // Update is called once per frame
}
