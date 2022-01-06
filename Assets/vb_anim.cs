using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class vb_anim : MonoBehaviour
{

	public VirtualButtonBehaviour[] vbBtnObj;
    public AudioClip[] aClips;
    public AudioSource myAudioSource;
    // public Animator cubeAni;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("init btn");
  //      Debug.Log(vbBtnObj.name);
  foreach(VirtualButtonBehaviour btn in vbBtnObj){
	  btn.RegisterOnButtonPressed(OnButtonPressed);
      btn.RegisterOnButtonReleased(OnButtonReleased);
	  Debug.Log(btn.name);
  }
        //vbBtnObj = GameObject.Find("DoBtn");
   //     vbBtnObj.RegisterOnButtonPressed(OnButtonPressed);
     //     vbBtnObj.RegisterOnButtonReleased(OnButtonReleased);
    }
    
        public void OnButtonPressed(VirtualButtonBehaviour vb)
        {
            Debug.Log("bouton appuyé "+vb.name);
		sound(vb);
        
        }
        public void OnButtonReleased(VirtualButtonBehaviour vb)
        {
            Debug.Log("bouton relaché "+ vb.name);
			
        }
    
    // Update is called once per frame
  /*  void Update()
    {
        
    }*/
	
	void sound(VirtualButtonBehaviour vb){
		 if (true)//Physics.Raycast(ray, out Hit))
                {
                    string btnName = vb.name;//Hit.transform.name;
                    switch (btnName)
                    {
                        case "DoBtn":
                            myAudioSource.clip = aClips[0];
                            myAudioSource.Play();
                            break;
                        case "ReBtn":
                            myAudioSource.clip = aClips[1];
                            myAudioSource.Play();
                            break;
                        case "MiBtn":
                            myAudioSource.clip = aClips[2];
                            myAudioSource.Play();
                            break;
                        case "FaBtn":
                            myAudioSource.clip = aClips[3];
                            myAudioSource.Play();
                            break;
                        case "SolBtn":
                            myAudioSource.clip = aClips[4];
                            myAudioSource.Play();
                            break;
                        case "LaBtn":
                            myAudioSource.clip = aClips[5];
                            myAudioSource.Play();
                            break;
                        case "SiBtn":
                            myAudioSource.clip = aClips[6];
                            myAudioSource.Play();
                            break;
                        default:
                            break;

                    }
	}
	}
}
