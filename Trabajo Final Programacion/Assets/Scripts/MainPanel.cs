using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainPanel : MonoBehaviour
{
    [Header("Options")]
    public Slider volumeFX;
    public Slider volumeMaster;
    public Toggle mute;
    public AudioMixer mixer;
    public AudioSource fxsound;
    public AudioClip clipSound;
    public float lastVolume;
    [Header("Panels")]
    public GameObject mainPanel;
    public GameObject optionsPanel;
    public GameObject levelSelectPanel;
    private void Awake()
    {
        volumeFX.onValueChanged.AddListener(ChangeVolumeFX);
        volumeMaster.onValueChanged.AddListener(ChangeVolumeMaster);
    }
    public void PlayLevel(string LevelName)
    {
        SceneManager.LoadScene(LevelName);
    }
    public void setMute()
    {
        if (mute.isOn)
        {
            mixer.GetFloat("volMaster", out lastVolume);
            mixer.SetFloat("volMaster", -80);
        }
        else
            mixer.SetFloat("volMaster", lastVolume);
    }

    public void OpenPanel(GameObject panel)
    {
        mainPanel.SetActive(false);
        optionsPanel.SetActive(false);
       // levelSelectPanel.SetActive(false);
        //activa un panel
        panel.SetActive(true);
        PlaySoundButton();
    }
    public void ChangeVolumeMaster(float v) 
    {
        mixer.SetFloat("volMaster", v);
    }
    public void ChangeVolumeFX(float v)
    {
        mixer.SetFloat("volFX", v);
    }
    public void PlaySoundButton()
    {
        fxsound.PlayOneShot(clipSound);
    }

}
