using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject button;
    void Start() {
        button.SetActive(false);
    }

    public void activate(){
        button.SetActive(true);
    }
}
