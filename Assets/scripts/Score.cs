using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour

{
    public Transform player;
    public Text scoreText;
    int convertPositionZ = 0;
    int score=0;
    public void scoreupd()
    {
         score++;
         scoreText.text = score.ToString();
         UnityEngine.Debug.Log(score);
    }

}