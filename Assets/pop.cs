using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pop : MonoBehaviour
{
    public GameObject res;
   
    // Start is called before the first frame update


    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

    public void Res_Pop()
    {
        if(res.activeInHierarchy==true)
        {
            res.SetActive(false);

        }
        else
        {
            res.SetActive(true);
        }
    }


}
