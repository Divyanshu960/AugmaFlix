using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class Cinema1 : MonoBehaviour
{
    
    public GameObject VideoCube1;
    private VideoPlayer Video1;
    public GameObject VirtualButton1;
    private VirtualButtonBehaviour VB_Behaviour1;
    public GameObject ButtonCube1;


    private void Start()
    {
        Video1 = VideoCube1.GetComponent<VideoPlayer>();
        VB_Behaviour1 = VirtualButton1.GetComponent<VirtualButtonBehaviour>();
        VB_Behaviour1.RegisterOnButtonPressed(playVideo1);
    }

    public void playVideo1(VirtualButtonBehaviour vp)
    {
        if (!Video1.isPlaying)
        {
            Video1.Play();
            ButtonCube1.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            Video1.Pause();
            ButtonCube1.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
    