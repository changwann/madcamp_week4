using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] 
public class Sound2 {
    public string name;
    public AudioClip clip;
}
public class MusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update

   // [SerializeField] private AudioClip[] clip2;
    [SerializeField] Sound2[] bgm2 = null;

    [SerializeField] AudioSource bgmPlayer2 = null;
    // Update is called once per frame
    public AudioClip currentSong;
    void Awake()
    {
        bgmPlayer2 = GetComponent<AudioSource>();
    }

    public void PlaySong (string name)
    {
        //StopBGM();
        for (int i = 0; i < bgm2.Length; i++) {
            if (name == bgm2[i].name) {
                Debug.Log("!!!!find song");
                if (currentSong != null && bgmPlayer2.isPlaying)
                {
                    StopBGM();
                }

                currentSong = bgm2[i].clip;
                bgmPlayer2.clip = bgm2[i].clip;
                bgmPlayer2.Play();
                return;
            }
        }
    }

    public void StopBGM() {
        Debug.Log("!!!!!!plz stop");
        bgmPlayer2.Stop();
        currentSong = null;
    }
}
