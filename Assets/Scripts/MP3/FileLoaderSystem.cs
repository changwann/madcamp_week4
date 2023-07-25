using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileLoaderSystem : MonoBehaviour
{
    private MP3Loader mp3Loader;

    private void Awake()
    {
        mp3Loader = GetComponent<MP3Loader>();
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
}
