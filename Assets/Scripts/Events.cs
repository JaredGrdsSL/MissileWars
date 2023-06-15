using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour {
    private TextMeshProUGUI scoreL;
    private TextMeshProUGUI scoreR;

    // Start is called before the first frame update
    void Start()
    {
        scoreL = GameObject.Find("ScoreL").GetComponent<TextMeshProUGUI>();
        scoreR = GameObject.Find("ScoreR").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreL.text = DataHandler.score.ToString();
        scoreR.text = DataHandler.score.ToString();

        if(DataHandler.score < 0) { // red score

        } else if(DataHandler.score > 0) { // blue score

        }

        switch(DataHandler.score) {
            case 5:
                SceneManager.LoadScene(1);
                break;
            case -5:
                SceneManager.LoadScene(2);
                break;
        }
    }
}
