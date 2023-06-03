using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public void Awake(){
    Text gt = this.GetComponent<Text>();
        gt.text = HighScore.score.ToString();
        
    }
}
