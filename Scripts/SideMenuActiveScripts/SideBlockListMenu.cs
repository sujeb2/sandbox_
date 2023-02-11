using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideBlockListMenu : MonoBehaviour
{
    public GameObject itemlist;
    public GameObject blocklist;
    public GameObject gamesettinglist;
    public GameObject customlist;

    public void listactive(){
        blocklist.SetActive(true);
        itemlist.SetActive(false);
        gamesettinglist.SetActive(false);
        customlist.SetActive(false);
    }
}
