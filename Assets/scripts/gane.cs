using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gane : MonoBehaviour
{
    [SerializeField] Text screen;
    [SerializeField] Parts initial;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        screen.text = initial.written_text();
    }

    // Update is called once per frame
    void Update()
    {
        quitting();
        manage_state();
    }

    private void manage_state()
    {
        Parts[] next = initial.next_parts();
        for(int t = 0; t < next.Length; t++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + t) || Input.GetKeyDown(KeyCode.Keypad1 + t))
            {
                initial = next[t];
                screen.text = initial.written_text();
            }
        }
    }

    private void quitting()
    {
        if (Input.GetKeyDown(KeyCode.Q)) { Application.Quit(); }
    }
}
