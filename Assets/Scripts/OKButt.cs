using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OKButt : MonoBehaviour 
{
    public SuperGuy OurMaster;
    public RawImage DisplayButt;

    void Awake()
    {
        DisplayButt.texture = OurMaster.GetButt();
    }
}
