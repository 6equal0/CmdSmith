using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
    private new AudioSource audio;
    [SerializeField] GameObject button;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public void MouseEnter()
    {
        button.transform.localScale = new Vector3(0.9f, 0.9f, 1);
    }
    public void MouseExit()
    {
        button.transform.localScale = new Vector3(1, 1, 1);
    }
}
