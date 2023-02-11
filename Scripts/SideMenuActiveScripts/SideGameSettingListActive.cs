using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideGameSettingListActive : MonoBehaviour
{
    public GameObject itemlist;
    public GameObject blocklist;
    public GameObject gamesettinglist;
    public GameObject customlist;

    public void listactive(){
        blocklist.SetActive(false);
        itemlist.SetActive(false);
        gamesettinglist.SetActive(true);
        customlist.SetActive(false);
    }
}
