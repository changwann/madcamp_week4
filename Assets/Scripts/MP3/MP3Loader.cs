using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Networking;

public class MP3Loader : MonoBehaviour
{
    [Header("MP3 Player Panel, File Name")]
    [SerializeField]
    private GameObject panelMP3Player;
    [SerializeField]
    private TextMeshProUGUI textFileName;

    [Header("MP3 Play Time (Slider, Text)")]
    [SerializeField]
    private Slider silderPlaybar;
    [SerializeField]
    private TextMeshProUGUI textCurrentPlayTime;
    [SerializeField]
    private TextMeshProUGUI textMaxPlayTime;

    [Header("Play Audio")]
    [SerializeField]
    private AudioSource audioSource;

    private System.IO.FileInfo currentFile;


    public void OnLoad(System.IO.FileInfo file)
    {
        currentFile = file;
        Debug.Log(currentFile);
        panelMP3Player.SetActive(true);
        textFileName.text = file.Name;
        ResetPlayTimeUI();
        StartCoroutine(LoadAudio(file.FullName));
    }

    private IEnumerator LoadAudio(string fileName)
    {
        AudioClip clip = null;
        fileName = "file://" + fileName;
        UnityWebRequest request = UnityWebRequestMultimedia.GetAudioClip(fileName, AudioType.MPEG);
        yield return request.SendWebRequest();
        if (request.result == UnityWebRequest.Result.Success)
        {
            Debug.Log($"Load Success : {fileName}");
            //#if UNITY_2021_1_OR_NEWER
            clip = DownloadHandlerAudioClip.GetContent(request);
            audioSource.clip = clip;
            Play();
        }
    }

    public void OffLoad()
    {
        Stop();
        panelMP3Player.SetActive(false);
    }

    public void Play()
    {
        audioSource.Play();
        StartCoroutine("OnPlaytimeUI");
    }

    public void Pause()
    {
        audioSource.Pause();
    }

    public void Stop()
    {
        audioSource.Stop();
        StopCoroutine("OnPlaytimeUI");
        ResetPlayTimeUI();
    }

    private void ResetPlayTimeUI()
    {
        silderPlaybar.value = 0;
        textCurrentPlayTime.text = "00:00:00";
        textMaxPlayTime.text = "00:00:00";
    }

    private IEnumerator OnPlaytimeUI()
    {
        int hour = 0;
        int minutes = 0;
        int seconds = 0;

        while (true)
        {
            hour = (int)audioSource.time / 3600;
            minutes = (int)(audioSource.time % 3600) / 60;
            seconds = (int)(audioSource.time % 3600) % 60;
            textCurrentPlayTime.text = $"{hour:D2}:{minutes:D2}:{seconds:D2}";

            hour = (int)audioSource.clip.length / 3600;
            minutes = (int)(audioSource.clip.length % 3600) / 60;
            seconds = (int)(audioSource.clip.length % 3600) % 60;
            textMaxPlayTime.text = $"{hour:D2}:{minutes:D2}:{seconds:D2}";

            silderPlaybar.value = audioSource.time / audioSource.clip.length;

            yield return new WaitForSeconds(1);
        }
    }

    public string GetFileName()
    {
        return currentFile != null ? currentFile.FullName : null;
    }
}
