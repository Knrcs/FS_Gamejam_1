using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerScore : MonoBehaviour
{
    // Start is called before the first frame update\
    [Header("Drinks")]
    public bool Mocha;
    public bool Espresso;
    public bool Latte_Macchiato;
    public bool Cappuchino;
    public bool White_Chocolate;
    public bool Hot_Chocolate;
    
    [Header("Food")]
    public bool BlueberryMuffin;
    public bool Brownies;
    public bool Cheesecake;
    public bool Cinnamon_rolls;
    public bool Cookies;
    public bool Crossiant;
    public bool Macaroons;

    [Header("Customer Morning")]
    public bool I_Mr_Browns;
    public bool I_Sparkle;

    [Header("Customer Noon")]
    public bool II_Quaso;
    public bool II_Sparkle;
    public bool II_Chino;

    [Header("Customer Evening")]
    public bool III_Mr_Browns;
    public bool III_Chino;

    
    void Start()
    {
        // Hot Drink
        
        Mocha = false;
        Espresso = false;
        Latte_Macchiato = false;
        Cappuchino = false;
        White_Chocolate = false;
        Hot_Chocolate = false;

        // Foof
        
        BlueberryMuffin = false;
        Brownies = false;
        Cheesecake = false;
        Cinnamon_rolls = false;
        Cookies = false;
        Crossiant = false;
        Macaroons = false;

//Morning

        if(I_Mr_Browns == true)
            {
                Espresso = true;
                Debug.Log("Variables set for Mr.Browns!");
            }
        else
        if(I_Sparkle == true)
            {
                Latte_Macchiato = true;
                BlueberryMuffin = true;
                Debug.Log("Variables set for Sparkle!");
            }
        else   

// Noon

        if(II_Quaso == true)
            {
                Crossiant = true;
                Debug.Log("Variables set for Quaso!");
            }
        else
        if(II_Sparkle == true)
            {
                White_Chocolate = true;
                Hot_Chocolate = true;
                Cinnamon_rolls = true;
                Debug.Log("Variables set for Sparkle!");
            }
        else
        if(II_Chino == true)
            {
                Cappuchino = true;
                Cheesecake = true;
                Debug.Log("Variables set for Chino!");
            } 

//Evening

        if(III_Mr_Browns == true)
            {
                Brownies = true;
                Espresso = true;
                Debug.Log("Variables set for Mr.Browns!");
            }
        else
        if(III_Chino == true)
            {
                Cappuchino = true;
                Cheesecake = true;
                Debug.Log("Variables set for Chino!");
            } 

    }

    // Update is called once per frame
    void Update()
    {
    
            
    }
}
