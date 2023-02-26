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
    public bool Mr_Browns;
    public bool Quaso;
    public bool Sparkle;
    public bool Chino;

    
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
        
        if(Mr_Browns == true)
        {
            Brownies = true;
            Espresso = true;
            Debug.Log("Variables set for Mr.Browns!");
        }
        else
        if(Quaso == true)
        {
            Crossiant = true;
            Debug.Log("Variables set for Quaso!");
        }
        else
        if(Sparkle == true)
        {
            White_Chocolate = true;
            Hot_Chocolate = true;
            Cinnamon_rolls = true;
            Debug.Log("Variables set for Sparkle!");
        }
        else
        if(Chino == true)
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
