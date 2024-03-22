using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerKey : MonoBehaviour
{

    [SerializeField] GameObject keyG;

    private void OnTriggerEnter(Collider other)
    {
        keyG.SetActive(true);
    }
}
