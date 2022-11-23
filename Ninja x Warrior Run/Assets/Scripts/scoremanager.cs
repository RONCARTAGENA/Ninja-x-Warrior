using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour
{

    public float scoreCount;
    public float pointsPerSecond;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    // Update is called once per frame
    void Update()
    {
        scoreCount += pointsPerSecond + Time.deltaTime;
        scoreText.text = Mathf.Round(scoreCount).ToString();
       
        

    }

    
}