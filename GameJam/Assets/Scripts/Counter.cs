using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counterText;

    public int counter;
    public int costAmount;
    

    // Update is called once per frame
    void Update()
    {
        counterText.text = counter.ToString();
    }

    public void IncreaseCounter()
    {
        counter++; 
    }

    public void DecreaseCounter()
    {
        costAmount = GetComponent<AdoptionCardDisplay>().adoptionCard.cost;
        
        if (costAmount > counter)
        {
            Debug.Log(costAmount);
            return;
            
        }

        else
        {
            counter -= costAmount;
        }
    }
}
