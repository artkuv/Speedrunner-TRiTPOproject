using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject BtnStart;//переменные для кнопок
    public GameObject BtnSettings;
    public GameObject BtnExit;
    public GameObject BtnMusicOn;
    public GameObject BtnMusicOff;
    public GameObject BtnSoundOn;
    public GameObject BtnSoundOff;
    public GameObject Panel;
    public GameObject Back;
    public AudioSource myAudio;
    public static float MusicActive;
    public static float SoundActive;

    private void Start()
    {
       Time.timeScale=1f;
       MusicActive=PlayerPrefs.GetFloat("Music");
       gameObject.GetComponent<AudioSource>().volume = MusicActive;
        if (MusicActive == 0f)
        {
            BtnMusicOn.SetActive(false);
            BtnMusicOff.SetActive(true);
        }

        SoundActive = PlayerPrefs.GetFloat("Sound");
       
        if (SoundActive == 0f)
        {
            BtnSoundOn.SetActive(false);
            BtnSoundOff.SetActive(true);
        }
    }

    public void ButtonStart()
    {   
       
        SceneManager.LoadScene("SampleScene");
    }

    public void ButtonSettings()
    {
        BtnStart.SetActive(false);
        BtnExit.SetActive(false);
        BtnSettings.SetActive(false);
        Panel.SetActive(true);
    }

    public void ButtonMusicOn()
    {

        BtnMusicOn.SetActive(false);
        BtnMusicOff.SetActive(true);
        MusicActive = 0f;
        gameObject.GetComponent<AudioSource>().volume = MusicActive;
    }

    public void ButtonMusicOff()
    {
        BtnMusicOff.SetActive(false);
        BtnMusicOn.SetActive(true);
        MusicActive = 0.28f;
        gameObject.GetComponent<AudioSource>().volume = MusicActive;
    }

    public void ButtonSoundOn()
    {
        BtnSoundOn.SetActive(false);
        BtnSoundOff.SetActive(true);
        SoundActive = 0f;
    }

    public void ButtonSoundOff()
    {
        BtnSoundOff.SetActive(false);
        BtnSoundOn.SetActive(true);
        SoundActive = 0.28f;
    }

    public void ButtonExit()
    {
        Application.Quit();
    }

    public void ButtonBack()
    {
        PlayerPrefs.SetFloat("Music", MusicActive);
        PlayerPrefs.SetFloat("Sound", SoundActive);
        Panel.SetActive(false);
        BtnStart.SetActive(true);
        BtnSettings.SetActive(true);
        BtnExit.SetActive(true);

    }
}
