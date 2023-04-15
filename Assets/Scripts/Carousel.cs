using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Carousel : MonoBehaviour
{

    public GameObject carousel;
    public HoverButton hoverButton;

    public void Start()
    {
        hoverButton.onButtonDown.AddListener(OnButtonDown);
    }

    private void OnButtonDown(Hand hand)
    {
        // Rotate the carousel 72 degrees
        carousel.transform.Rotate(0f, 72f, 0f);
        Debug.Log("SPIIINNNNNN!!!!!");
    }
}
