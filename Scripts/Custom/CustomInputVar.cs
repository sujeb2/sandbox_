using UnityEngine;
using UnityEngine.UI;

public class CustomInputVar : MonoBehaviour
{
    // tag, name
    public string blockName = null;
    public string itemName = null;
    public string blockTag = null;
    public string itemTag = null;

    // input
    public InputField blockNameInput;
    public InputField itemNameInput;
    public InputField blockTagInput;
    public InputField itemTagInput;

    // text
    public Text blockTagText;
    public Text itemTagText;

    private void Awake() {
        blockName = blockNameInput.GetComponent<InputField>().text;
        blockTag = blockTagInput.GetComponent<InputField>().text;
        itemName = itemNameInput.GetComponent<InputField>().text;
        itemTag = itemTagInput.GetComponent<InputField>().text;
    }

    private void Update() {
        if (blockName.Length > 0 && Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Set custom block name to: " + blockName);
        }

        if (itemName.Length > 0 && Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Set custom item name to: " + itemName);
        }

        if (blockTag.Length > 0 && Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Set custom block tag to: " + blockTag);
        }

        if (itemTag.Length > 0 && Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Set custom item tag to: " + itemTag);
        }

        blockTagText.text = blockTag;
        itemTagText.text = itemTag;
    }
 
    //public void BlockNameInput() {
    //    blockName = blockNameInput.text;
    //    PlayerPrefs.SetString("CurrentPlayerName", playerName);
    //}
}
