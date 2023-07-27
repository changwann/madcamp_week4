using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterFlame : MonoBehaviour
{
    private MP3Loader mp3Loader;
    private FileLoaderSystem fileLoaderSystem;
    bool musicStart = false;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!musicStart)
        {
            if (collision.CompareTag("Note"))
            {
                AudioManager.instance.PlayBGM("BGM0");
                musicStart = true;
            }
        }
    }
}
