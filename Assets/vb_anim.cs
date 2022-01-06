using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class vb_anim : MonoBehaviour
{

	public VirtualButtonBehaviour[] vbBtnObj;
    public AudioClip[] aClips;
    public AudioSource[] myAudioSource;
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
			
			Debug.Log("parents est: "+vb.transform.parent.name);
			Vector3 posNote = vb.transform.parent.transform.position;
			vb.transform.parent.transform.position = new Vector3(posNote.x,posNote.y-0.01f,posNote.z);
        
        }
        public void OnButtonReleased(VirtualButtonBehaviour vb)
        {
            Debug.Log("bouton relaché "+ vb.name);
			stopSound(vb);
			
			Vector3 posNote = vb.transform.parent.transform.position;
			vb.transform.parent.transform.position = new Vector3(posNote.x,posNote.y+0.01f,posNote.z);
			
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
							//myAudioSource.PlayOneShot(aClips[0],1f);
                            myAudioSource[0].clip = aClips[0];
                            myAudioSource[0].Play();
                            break;
                        case "ReBtn":
						//myAudioSource.PlayOneShot(aClips[1],1f);
                            myAudioSource[1].clip = aClips[1];
                            myAudioSource[1].Play();
                            break;
                        case "MiBtn":
                            myAudioSource[2].clip = aClips[2];
                            myAudioSource[2].Play();
                            break;
                        case "FaBtn":
                            myAudioSource[3].clip = aClips[3];
                            myAudioSource[3].Play();
                            break;
                        case "SolBtn":
                            myAudioSource[4].clip = aClips[4];
                            myAudioSource[4].Play();
                            break;
                        case "LaBtn":
                            myAudioSource[5].clip = aClips[5];
                            myAudioSource[5].Play();
                            break;
                        case "SiBtn":
                            myAudioSource[6].clip = aClips[6];
                            myAudioSource[6].Play();
                            break;
                        default:
                            break;

                    }
	}
	}
	void stopSound(VirtualButtonBehaviour vb){
		 
                
                    string btnName = vb.name;//Hit.transform.name;
                    switch (btnName)
                    {
                        case "DoBtn":
							//myAudioSource.PlayOneShot(aClips[0],1f);
                          //  myAudioSource[0].clip = aClips[0];
                            myAudioSource[0].Stop();
                            break;
                        case "ReBtn":
						//myAudioSource.PlayOneShot(aClips[1],1f);
                            //myAudioSource[1].clip = aClips[1];
                            myAudioSource[1].Stop();
                            break;
                        case "MiBtn":
                
                            myAudioSource[2].Stop();
                            break;
                        case "FaBtn":
                   
                            myAudioSource[3].Stop();
                            break;
                        case "SolBtn":
                       
                            myAudioSource[4].Stop();
                            break;
                        case "LaBtn":
             
                            myAudioSource[5].Stop();
                            break;
                        case "SiBtn":
                    
                            myAudioSource[6].Stop();
                            break;
                        default:
                            break;

                    }
	}
	
}
