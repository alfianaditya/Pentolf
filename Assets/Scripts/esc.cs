using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esc : MonoBehaviour
{
    public GameObject pause;

    public void Update()
    {
        if (Input.GetKeyDown("escape") && pause.activeSelf == false)
        {
            pause.SetActive(true);
        }
        else if (Input.GetKeyDown("escape") && pause.activeSelf == true)
        {
            pause.SetActive(false);
        }
    }
}
