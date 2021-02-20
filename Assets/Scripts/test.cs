using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class test : MonoBehaviour
{
    public GameObject Sun, Mercury, Venus, Earth, Moon, Mars, Sun1, Mercury1, Venus1, Earth1, Moon1, Mars1, videoplane;
    VirtualButtonBehaviour[] awa;
    // Start is called before the first frame update
    void Start()
    {
        awa = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < awa.Length; ++i)
        {
            awa[i].RegisterOnButtonPressed(OnButtonPressed);
            awa[i].RegisterOnButtonReleased(OnButtonReleased);
        }
        Sun.SetActive(false);
        Mercury.SetActive(false);
        Venus.SetActive(false);
        Earth.SetActive(false);
        Moon.SetActive(false);
        Mars.SetActive(false);
        Sun1.SetActive(false);
        Mercury1.SetActive(false);
        Venus1.SetActive(false);
        Earth1.SetActive(false);
        Moon1.SetActive(false);
        Mars1.SetActive(false);
        videoplane.SetActive(false);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "previewvb")
        {
            Sun.SetActive(false);
            Mercury.SetActive(false);
            Venus.SetActive(false);
            Earth.SetActive(false);
            Moon.SetActive(false);
            Mars.SetActive(false);
            Sun1.SetActive(true);
            Mercury1.SetActive(true);
            Venus1.SetActive(true);
            Earth1.SetActive(true);
            Moon1.SetActive(true);
            Mars1.SetActive(true);
            videoplane.SetActive(false);
        }
        else if (vb.VirtualButtonName == "animationvb")
        {
            UnityEngine.Debug.Log("animationvb Button pressed");
            Sun.SetActive(true);
            Mercury.SetActive(true);
            Venus.SetActive(true);
            Earth.SetActive(true);
            Moon.SetActive(true);
            Mars.SetActive(true);
            Sun1.SetActive(false);
            Mercury1.SetActive(false);
            Venus1.SetActive(false);
            Earth1.SetActive(false);
            Moon1.SetActive(false);
            Mars1.SetActive(false);
            videoplane.SetActive(false);
           
        }
        else if (vb.VirtualButtonName == "videovb")
        {
            UnityEngine.Debug.Log("Traveller Button pressed");
            Sun.SetActive(false);
            Mercury.SetActive(false);
            Venus.SetActive(false);
            Earth.SetActive(false);
            Moon.SetActive(false);
            Mars.SetActive(false);
            Sun1.SetActive(false);
            Mercury1.SetActive(false);
            Venus1.SetActive(false);
            Earth1.SetActive(false);
            Moon1.SetActive(false);
            Mars1.SetActive(false);
            videoplane.SetActive(true);
        }
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button not supported");
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        UnityEngine.Debug.Log(vb.VirtualButtonName + " released");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
