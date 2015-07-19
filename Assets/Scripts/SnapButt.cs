using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SnapButt : MonoBehaviour 
{
    WebCamTexture CameraTexture;
    public RawImage Display;
    public SuperGuy OurMaster;
	
    void Start() 
    {
        CameraTexture = new WebCamTexture("Remote Front Camera");
        CameraTexture.Stop();
        CameraTexture.Play();
        Display.texture = CameraTexture;
        Display.material.mainTexture = CameraTexture;
	}
	
	void Snap() 
    {
        OurMaster.StoreButt(CameraTexture);
        CameraTexture.Stop();
	}
}
