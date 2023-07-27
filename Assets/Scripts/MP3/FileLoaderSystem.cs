using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileLoaderSystem : MonoBehaviour
{
    public MP3Loader mp3Loader;

    void Start()
    {
        mp3Loader = GetComponent<MP3Loader>();
        if (mp3Loader == null)
        {
            Debug.LogError("MP3Loader not found on this GameObject!");
        }
    }

    public void LoadFile(FileInfo file)
    {
        OffAllPanel();

        if (file.Extension == ".mp3")
        {
            mp3Loader.OnLoad(file);
        }
    }

    private void OffAllPanel()
    {
        mp3Loader.OffLoad();
    }

    public string GetFileName()
    {
        return mp3Loader.GetFileName();
    }
}
