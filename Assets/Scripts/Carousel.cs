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
        hoverButton.onButtonIsPressed.AddListener(OnButtonPressed);
    }

    private void OnButtonPressed(Hand hand)
    {
        // Rotate the carousel 72 degrees
        transform.Rotate(0f, 72f, 0f);
        transform.Translate(-transform.right, Space.World);
        Debug.Log("SPINNNNN!!!!!");
        Debug.Log(carousel.transform.position);
    }
}
