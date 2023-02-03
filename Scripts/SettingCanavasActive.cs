using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingCanavasActive : MonoBehaviour
{
    public GameObject blockListMenu;
    public GameObject itemListMenu;
    public GameObject normalMenu;
    public GameObject SettingMenu;
    public GameObject gamesettingMenu;

    public void ActiveSet(){
        blockListMenu.SetActive(true);
        itemListMenu.SetActive(false);
        normalMenu.SetActive(false);
        gamesettingMenu.SetActive(false);
        SettingMenu.SetActive(true);
    }

    public void DeActiveSetting(){
        SettingMenu.SetActive(false);
        blockListMenu.SetActive(true);
        itemListMenu.SetActive(false);
        gamesettingMenu.SetActive(false);
        normalMenu.SetActive(true);
    }
}
