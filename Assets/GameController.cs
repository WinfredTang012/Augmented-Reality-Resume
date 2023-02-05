using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject PanelInfo;
    public AudioSource PlaySound;


    public bool show = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SHowHideInfo()
    {

        if (!show)
        {
            PanelInfo.SetActive(true);
            show = true;
        }
        else
        {
            PanelInfo.SetActive(false);
            show = false;
        }
    }

    public void PlaySoundInfo()
    {
        PlaySound.Play();
       
    }

    public void PauseSoundInfo()
    {
        PlaySound.Pause();

    }
}
