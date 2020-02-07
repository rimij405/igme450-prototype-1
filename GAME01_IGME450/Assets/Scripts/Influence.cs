﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Influence : MonoBehaviour
{

    //varaibles

    private float sizeDecrease;
    /*private float influencePercentage; //float to hold the current multiplier value
    public float reputationScoreMultiplier;    //float to decide how fast the bar will fill and multiplier will increase
    */

    // Start is called before the first frame update
    void Start()
    {
        sizeDecrease = .5f;
        /*reputationScoreMultiplier = .02f;
        influencePercentage = 0;*/
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.localScale.x < .5)
        {
            //call a function to end the night when the player is out of infulence
        }
    }

    //fixed update to run the timer for the influence bar and the mulitplier
    /*private void FixedUpdate()
    {
        influencePercentage += .1f;

        if (this.transform.localScale.x < 18f)
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x + reputationScoreMultiplier, this.transform.localScale.y);
        }
    }

    //function to return the current multiplier that will effect popularity
    public float GetMulitplier()
    {
        if (influencePercentage < 5)
        {
            return 0;
        }
        else if (influencePercentage < 10)
        {
            return 1;
        }
        else if (influencePercentage < 20)
        {
            return 2;
        }
        else if (influencePercentage < 50)
        {
            return 4;
        }
        else if (influencePercentage < 85)
        {
            return 6;
        }
        else
        {
            return 8;
        }

    }
    */
    //function to reset the influence
    public void ResetInfluence()
    {
        this.transform.localScale = new Vector3(18f, this.transform.localScale.y);

    }


    //function to subtract from the influence bar when the player likes or dislikes a painting
    public void DecreaseInfluence()
    {
        if (this.transform.localScale.x >= .5)
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x - sizeDecrease, this.transform.localScale.y);
        }
    }


}