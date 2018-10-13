using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[System.Serializable]
public class Control : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    bool pressed;
    public GameObject thisgo;
    int aroow;

    private void Start()
    {

       

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
        if (thisgo.tag == "RArrow")
        {
            aroow = 0;
        }
        else
        {
            aroow = 1;
        }
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
    }

    // Update is called once per frame
    void Update () {
        if (!pressed)
            return;

        if (aroow == 0)
        {
            Debug.Log("Pressed Right");
        }
        else
        {
            Debug.Log("Pressed Left");
        }

        
        

    }
}
