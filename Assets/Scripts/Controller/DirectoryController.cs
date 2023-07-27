using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


public class DirectoryController : MonoBehaviour
{
    [SerializeField]
    private FileLoaderSystem fileLoaderSystem;

    private DirectoryInfo defaultDirectory;
    private DirectoryInfo currentDirectory;
    private DirectorySpawner directorySpawner;

    private void Awake()
    {
        Application.runInBackground = true;

        directorySpawner = GetComponent<DirectorySpawner>();
        directorySpawner.Setup(this);

        string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        defaultDirectory = new DirectoryInfo(desktopFolder);
        currentDirectory = new DirectoryInfo(desktopFolder);
        UpdateDirectory(currentDirectory);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UpdateDirectory(defaultDirectory);
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            MoveToParentFolder(currentDirectory);
        }
    }

    private void UpdateDirectory(DirectoryInfo directory)
    {
        currentDirectory = directory;
        directorySpawner.UpdateDirectory(currentDirectory);
    }

    private void MoveToParentFolder(DirectoryInfo directory)
    {
        if (directory.Parent == null) return;
        UpdateDirectory(directory.Parent);
    }

    public void UpdateInputs(string data)
    {
        if (data.Equals("..."))
        {
            MoveToParentFolder(currentDirectory);
            return;
        }
        foreach (DirectoryInfo dir in currentDirectory.GetDirectories())
        {
            if (data.Equals(dir.Name))
            {
                UpdateDirectory(dir);
                return;
            }
        }
        foreach (FileInfo file in currentDirectory.GetFiles())
        {
            if (data.Equals(file.Name))
            {
                fileLoaderSystem.LoadFile(file);
                return;
            }
        }
    }
}
