using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideGameSettingListActive : MonoBehaviour
{
    public GameObject itemlist;
    public GameObject blocklist;
    public GameObject gamesettinglist;
    public GameObject customlist;
    public Animator ani;

    public void listactive(){
        blocklist.SetActive(false);
        itemlist.SetActive(false);
        gamesettinglist.SetActive(true);
        customlist.SetActive(false);
        ani.SetBool("isError", true);
        Invoke("stop", 0.5f);
    }
    
    void stop() {
        ani.SetBool("isBlock", false);
    }
}
