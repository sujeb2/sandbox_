using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideBlockListMenu : MonoBehaviour
{
    public GameObject itemlist;
    public GameObject blocklist;
    public GameObject gamesettinglist;
    public GameObject customlist;
    public Animator ani;

    public void listactive(){
        blocklist.SetActive(true);
        itemlist.SetActive(false);
        gamesettinglist.SetActive(false);
        customlist.SetActive(false);
        ani.SetBool("isBlock", true);
        Invoke("stop", 0.5f);
    }

    void stop() {
        ani.SetBool("isBlock", false);
    }
}
