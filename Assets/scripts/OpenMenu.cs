using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject menuPannel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OpenTheMenu()
    {
        menuPannel.SetActive(menuPannel);
    }
}
