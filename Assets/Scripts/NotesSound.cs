﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesSound : MonoBehaviour { 
public AudioClip[] aClips;
public AudioSource myAudioSource;
string btnName;

    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                switch (btnName)
                {
                    case "do":
                        myAudioSource.clip = aClips[0];
                        myAudioSource.Play();
                        break;
                    case "ré":
                        myAudioSource.clip = aClips[1];
                        myAudioSource.Play();
                        break;
                    case "mi":
                        myAudioSource.clip = aClips[2];
                        myAudioSource.Play();
                        break;
                    case "fa":
                        myAudioSource.clip = aClips[3];
                        myAudioSource.Play();
                        break;
                    case "sol":
                        myAudioSource.clip = aClips[4];
                        myAudioSource.Play();
                        break;
                    case "la":
                        myAudioSource.clip = aClips[5];
                        myAudioSource.Play();
                        break;
                    case "si":
                        myAudioSource.clip = aClips[5];
                        myAudioSource.Play();
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
