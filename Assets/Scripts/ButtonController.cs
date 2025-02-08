using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject button;
    public GameObject text;
    void Start() {
        button.SetActive(false);
        text.SetActive(false);
    }

    public void activate(){
        button.SetActive(true);
        text.SetActive(true);
    }
}
