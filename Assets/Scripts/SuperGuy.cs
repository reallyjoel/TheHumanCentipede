using UnityEngine;
using UnityEditor.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SuperGuy : MonoBehaviour 
{
    [System.Serializable]
    public struct NamedScreen
    {
        public string name;
        public Canvas screen;
    }

    public NamedScreen[] Screens;
    Dictionary<string, Canvas> ScreensDictionary = new Dictionary<string,Canvas>();

    Texture StoredButt;


	void Awake () 
    {
        foreach(NamedScreen scr in Screens)
        {
            ScreensDictionary.Add(scr.name, scr.screen);
        }
	}

    void JoinCentipede()
    {
        SwitchScreen("SnapButt");
    }

    void OKButt()
    {
        SwitchScreen("OKButt");
    }

    void NoseOnButt()
    {
        SwitchScreen("NoseOnButt");
    }

    void Thanks()
    {
        SwitchScreen("Thanks");
    }

    void SwitchScreen(string name)
    {
        foreach(Canvas c in ScreensDictionary.Values)
        {
            c.gameObject.SetActive(false);
        }
        ScreensDictionary[name].gameObject.SetActive(true);
    }

    public void StoreButt(Texture butt)
    {
        StoredButt = butt;
    }

    public Texture GetButt()
    {
        return StoredButt;
    }
}
