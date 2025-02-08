using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;

public class ScoreCounter : MonoBehaviour {
    [Header("Dynamic")]
    public int score = 0;

    public ApplePicker RoundControl;

    private TextMeshProUGUI uiText;

    private int SafeLock = 0;
    public RoundCounter roundCounter;
    public AppleTree ATS;

    void Start() {
        uiText = GetComponent<TextMeshProUGUI>();
    }

    void Update() {
        uiText.text = "Score: " + score.ToString("#,0");
        switch(score){
            case 2000:
            case 4000:
            case 6000:
                roundUpdate();
                break;
            default:
                SafeLock = 0;
                break;
        }
    }

    void roundUpdate(){
        if (SafeLock == 0){
            SafeLock = 1;
            roundCounter.roundIncrement();
            ATS.speedIncrease();
        }
    }
}
