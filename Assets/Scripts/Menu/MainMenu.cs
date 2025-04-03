using Ami.BroAudio;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Time.timeScale = 1f;
        StartCoroutine(StartCutscene());
    }

    private IEnumerator StartCutscene()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadSceneAsync(1);

    }

    public void SetMasterVolume(float volume)
    {
        BroAudio.SetVolume(volume);
    }

    public void SetUIVolume(float volume)
    {
        BroAudio.SetVolume(BroAudioType.UI, volume);
    }
    public void SetSFXVolume(float volume)
    {
        BroAudio.SetVolume(BroAudioType.SFX, volume);
    }
    public void SetMusicVolume(float volume)
    {
        BroAudio.SetVolume(BroAudioType.Music, volume);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}

