using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private Text coinScoreText;
    private AudioSource audioManager;
    private int scoreCount = 0;

    private void Awake()
    {
        audioManager = GetComponent<AudioSource>();
    }


    void Start()
    {
        coinScoreText = GameObject.Find("CoinText").GetComponent<Text>();
        
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == MyTags.COIN_TAG)
        {
            target.gameObject.SetActive(false);

            scoreCount++;

            coinScoreText.text = "x" + scoreCount;

            audioManager.Play();
        }
        
    }

} // class
