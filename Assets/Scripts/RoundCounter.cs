using TMPro;
using UnityEngine;

public class RoundCounter : MonoBehaviour
{
   private TextMeshProUGUI roundText; 
   public int round = 1;
    void Start()
    {
        roundText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        roundText.text = "Round " + round.ToString("#");
    }

    public void roundIncrement(){
        round += 1;
    }
}
