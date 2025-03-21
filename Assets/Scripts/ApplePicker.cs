using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ApplePicker : MonoBehaviour {
    [Header("Inscribed")]
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;
    public ButtonController buttonScript;
    public AppleTree ATS;

    void Start()
    {
        basketList = new List<GameObject>();
        for (int i = 0; i < numBaskets; i++) {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
    }

    public void AppleMissed() {
        removeItems();
        DestroyBasket();
    }

    public void DestroyBasket() {
        int basketIndex = basketList.Count -1;
        GameObject basketGO = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(basketGO);

        if (basketList.Count == 0) {
            buttonScript.activate();
            ATS.drop = false;
            removeItems();
        }
    }  

    public void removeItems(){
        GameObject[] appleArray = GameObject.FindGameObjectsWithTag("Apple");
        GameObject[] stickArray = GameObject.FindGameObjectsWithTag("Stick");
        foreach (GameObject tempGO in appleArray) {
            Destroy(tempGO);
        }
        foreach (GameObject tempGO in stickArray) {
            Destroy(tempGO);
        }
    }
}
