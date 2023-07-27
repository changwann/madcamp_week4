using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public enum DataType { Directory = 0, File }

public class Data : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    [SerializeField]
    private Sprite[] spriteIcons;

    private Image imageIcon;
    private TextMeshProUGUI textDataName;

    private DataType dataType;

    private string fileName;
    public string FileName => fileName;

    private int maxFileNameLength = 25;

    private DirectoryController directoryController;

    public void Setup(DirectoryController controller, string fileName, DataType dataType)
    {
        directoryController = controller;

        imageIcon = GetComponentInChildren<Image>();
        textDataName = GetComponentInChildren<TextMeshProUGUI>();

        this.fileName = fileName;
        this.dataType = dataType;

        imageIcon.sprite = spriteIcons[(int)this.dataType];

        textDataName.text = this.fileName;

        if (fileName.Length >= maxFileNameLength)
        {
            textDataName.text = fileName.Substring(0, maxFileNameLength);
            textDataName.text += "..";
        }

        SetTextColor();
    }

    private void SetTextColor()
    {
        if (dataType == DataType.Directory)
        {
            textDataName.color = Color.yellow;
        }
        else
        {
            textDataName.color = Color.white;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        textDataName.color = Color.red;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        directoryController.UpdateInputs(fileName);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        SetTextColor();
    }


}
