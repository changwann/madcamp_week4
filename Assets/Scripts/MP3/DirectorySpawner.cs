using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class DirectorySpawner : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textDirectoryName;
    [SerializeField]
    private Scrollbar verticalScrollbar;

    [SerializeField]
    private GameObject panelDataPrefab;
    [SerializeField]
    private Transform parentContent;

    private DirectoryController directoryController;

    private List<Data> fileList;

    public void Setup(DirectoryController controller)
    {
        directoryController = controller;
        fileList = new List<Data>();
    }

    public void UpdateDirectory(DirectoryInfo currentDirectory)
    {
        for (int i = 0; i < fileList.Count; ++i)
        {
            Destroy(fileList[i].gameObject);
        }
        fileList.Clear();

        textDirectoryName.text = currentDirectory.Name;

        verticalScrollbar.value = 1;

        SpawnData("...", DataType.Directory);

        foreach (DirectoryInfo dir in currentDirectory.GetDirectories())
        {
            SpawnData(dir.Name, DataType.Directory);
        }

        foreach (FileInfo file in currentDirectory.GetFiles())
        {
            SpawnData(file.Name, DataType.File);
        }

        fileList.Sort((a, b) => a.FileName.CompareTo(b.FileName));

        for (int i = 0; i < fileList.Count; ++i)
        {
            fileList[i].transform.SetSiblingIndex(i);

            if (fileList[i].FileName.Equals("..."))
            {
                fileList[i].transform.SetAsFirstSibling();
            }
        }
    }

    public void SpawnData(string fileName, DataType type)
    {
        GameObject clone = Instantiate(panelDataPrefab);

        clone.transform.SetParent(parentContent);
        clone.transform.localScale = Vector3.one;

        Data data = clone.GetComponent<Data>();
        data.Setup(directoryController, fileName, type);

        fileList.Add(data);
    }

}
