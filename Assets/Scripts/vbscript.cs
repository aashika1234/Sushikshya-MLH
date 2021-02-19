using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class vbscript : MonoBehaviour
{
    public GameObject idleheart, animatedheart, videoplane;
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
        idleheart.SetActive(false);
        animatedheart.SetActive(false);
        videoplane.SetActive(false);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "previewvb")
        {
            UnityEngine.Debug.Log("previewvb Button pressed");
            idleheart.SetActive(true);
            animatedheart.SetActive(false);
            videoplane.SetActive(false);
        }
        else if (vb.VirtualButtonName == "animationvb")
        {
            UnityEngine.Debug.Log("animationvb Button pressed");
            idleheart.SetActive(false);
            animatedheart.SetActive(true);
            videoplane.SetActive(false);
        }
        else if (vb.VirtualButtonName == "videovb")
        {
            UnityEngine.Debug.Log("Traveller Button pressed");
            idleheart.SetActive(false);
            animatedheart.SetActive(false);
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
