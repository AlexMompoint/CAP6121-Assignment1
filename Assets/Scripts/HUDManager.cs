using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public TextMeshProUGUI HealthUI;
    public TextMeshProUGUI ScoreUI;
    private int _scr;
    private int _health;

    public int score
    {
        get { return _scr; }
        set
        {
            _scr = value;
            ScoreUI.text = "Score:" + score.ToString();
        }
    }
    public int health
    {
        get { return _health; }
        set
        {
            _health = value;
            HealthUI.text = "Health:" + health.ToString();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 1;
        health = 99;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
