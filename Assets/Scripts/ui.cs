using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui : MonoBehaviour
{
    public GameObject kata;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        kata.SetActive(true);
    }


}
