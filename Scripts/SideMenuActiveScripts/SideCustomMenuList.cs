using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideCustomMenuList : MonoBehaviour
{
    public GameObject itemlist;
    public GameObject blocklist;
    public GameObject customlist;
    public GameObject gamesettinglist;

    public void listactive(){
        blocklist.SetActive(false);
        itemlist.SetActive(false);
        gamesettinglist.SetActive(false);
        customlist.SetActive(true);
    }
}
