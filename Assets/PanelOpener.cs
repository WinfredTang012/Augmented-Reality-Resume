using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PanelOpener : MonoBehaviour
{
    public GameObject panel;
    public GameObject model;
    public VideoPlayer video;
    // Start is called before the first frame update
    public void OpenPanel()
    {
        if (panel.activeInHierarchy == true)
        {
            panel.SetActive(false);
            model.SetActive(false);
            video.Pause();

        }
        else
        {
            panel.SetActive(true);
            model.SetActive(true);
            video.Play();
        }
    }
}
