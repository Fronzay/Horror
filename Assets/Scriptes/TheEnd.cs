using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnd : MonoBehaviour
{
    [SerializeField] GameObject panelTheEnd;

    private void OnTriggerEnter(Collider other)
    {
        panelTheEnd.SetActive(true);
        Time.timeScale = 0;
    }
}
