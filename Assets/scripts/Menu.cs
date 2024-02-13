using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Menu : MonoBehaviour
{
    public GameObject menuPannel;
    public GameObject pauseButton;
    public GameObject exitButton;
    public GameObject claire;
    public GameObject thumbStickLeft;

    //tick icon
    public GameObject tickPointAndClick;
    public GameObject tickThirdPerson;
    public GameObject tickThumbStickLeft;

    private void Start()
    {
        gameObject.GetComponent<PontAndClick>();
        gameObject.GetComponent<thirdPersonController>();
        gameObject.GetComponent<ThumbStickContoller>();
    }
    public void ActivateMenu()
    {
        menuPannel.SetActive(true);
        pauseButton.SetActive(false);
        exitButton.SetActive(true);
        claire.SetActive(false);
        
    }

    public void DeactivateMenu()
    {
        menuPannel.SetActive(false);
        pauseButton.SetActive(true);
        exitButton.SetActive(false);
        claire.SetActive(true);
    }

    public void ActivatePointAndClick()
    {
        //gameObject.GetComponent<PontAndClick>().enabled = true;
        tickPointAndClick.SetActive(true);
    }
    public void ActivateThirdPerson()
    {
        //gameObject.GetComponent<thirdPersonController>().enabled = true;
        tickThirdPerson.SetActive(true);
    }
    public void ActivateThumbStickLeft()
    {
        thumbStickLeft.SetActive(true);
        tickThumbStickLeft.SetActive(true);
    }

    public void DeactivatePointAndClick()
    {
        //gameObject.GetComponent<PontAndClick>().enabled = false;
        tickPointAndClick.SetActive(false);
    }
    public void DeactivateThirdPerson()
    {
        //gameObject.GetComponent<thirdPersonController>().enabled = false;
        tickThirdPerson.SetActive(false);
    }
    public void DeactivateThumbStickLeft()
    {
        thumbStickLeft.SetActive(false);
        tickThumbStickLeft.SetActive(false);
    }


}
