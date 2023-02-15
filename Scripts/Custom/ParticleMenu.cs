using UnityEngine;
using UnityEngine.UI;

public class ParticleMenu : MonoBehaviour {
    public GameObject particleMenu;
    public Toggle toggleParticleMenu;

    public void particlemenu() {
        if(toggleParticleMenu.isOn) {
            particleMenu.SetActive(true);
        } else {
            particleMenu.SetActive(false);
        }
    }

    public void setting() {
        
    }
}