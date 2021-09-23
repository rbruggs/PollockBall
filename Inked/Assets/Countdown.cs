using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    [SerializeField]
    Text timeText;
    [SerializeField]
    GameObject playerObj;
    float timeLeft;
    [SerializeField]
    Text gameText;
    [SerializeField]
    Text overText;
    [SerializeField]
    Text remainingText;
    GameObject lastCap;
    [SerializeField]
    Button restartButton;
    [SerializeField]
    Button quitButton;
    [SerializeField]
    Text scoreText;
    int capScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 25.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft > 0)
        {
            timeText.text = Mathf.Round(timeLeft).ToString();
        }
        else
        {
            lastCap = GameObject.FindGameObjectWithTag("Cap");
            remainingText.gameObject.SetActive(false);
            timeText.gameObject.SetActive(false);
            overText.gameObject.SetActive(true);
            gameText.gameObject.SetActive(true);

            scoreText.text = "FINAL SCORE: " + capScore.ToString();
            scoreText.gameObject.SetActive(true);
            this.GetComponent<ChangeCamera>().Togglecam();
            playerObj.GetComponent<PlayerMove>().endGame();
            quitButton.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            lastCap.gameObject.SetActive(false);
            playerObj.gameObject.SetActive(false);
        }
    }

    public void addTime()
    {
        if (timeLeft > 0) {
            capScore += 1;
            timeLeft += 3.3f;
                }
    }
}
