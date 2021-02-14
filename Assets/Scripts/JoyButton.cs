using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JoyButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public bool Pressed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = true;
        Debug.Log("Was Pressed!");
        gameObject.GetComponent<Image>().color = Color.gray;
        gameObject.GetComponent<Image>().color = Color.white;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = false;
        gameObject.GetComponent<Image>().color = Color.gray;
    }
}
