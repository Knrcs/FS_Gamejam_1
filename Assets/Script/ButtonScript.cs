using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject Element;
    public GameObject Self;
    // Update is called once per frame
    void OnMouseDown()
    {
        Element.SetActive(true);
        Self.SetActive(false);
        }
}
