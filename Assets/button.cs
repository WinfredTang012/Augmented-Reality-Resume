using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void youtube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCcl3fBMeLGZ108gdZCI14qw");
    }

    public void whatsap()
    {
        Application.OpenURL("https://wa.me/601110873824");
    }

    public void twitter()
    {
        Application.OpenURL("https://twitter.com/XinZhe28669976");
    }
    public void github()
    {
        Application.OpenURL("https://github.com/WinfredTang012");
    }


}
