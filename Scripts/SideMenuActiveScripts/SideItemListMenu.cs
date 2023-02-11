using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideItemListMenu : MonoBehaviour
{
    public GameObject itemlist;
    public GameObject blocklist;
    public GameObject gamesettinglist;
    public GameObject customlist;

    public void listactive(){
        blocklist.SetActive(false);
        itemlist.SetActive(true);
        gamesettinglist.SetActive(false);
        customlist.SetActive(false);
    }
}
