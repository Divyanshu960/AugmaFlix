using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class Cinema2 : MonoBehaviour
{

    public GameObject VideoCube2;
    private VideoPlayer Video2;
    public GameObject VirtualButton2;
    private VirtualButtonBehaviour VB_Behaviour2;
    public GameObject ButtonCube2;


    private void Start()
    {
        Video2 = VideoCube2.GetComponent<VideoPlayer>();
        VB_Behaviour2 = VirtualButton2.GetComponent<VirtualButtonBehaviour>();
        VB_Behaviour2.RegisterOnButtonPressed(playVideo2);
    }

    public void playVideo2(VirtualButtonBehaviour vp)
    {
        if (!Video2.isPlaying)
        {
            Video2.Play();
            ButtonCube2.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            Video2.Pause();
            ButtonCube2.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
