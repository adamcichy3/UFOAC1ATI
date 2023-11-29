using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min, max,shoot;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Witaj w grze Number Wizard");
        Debug.Log("Wymyœl liczbe w glowie w przedziale od 1 do 1000");
        Debug.Log("Czy twoja liczba jest wieksza lub mniejsza od 500?");
        Debug.Log("Aby odpowiedziec nacisnij gorna strzalke jesli wieksza" +
            "jesli mniejsza to dolna strzalke a jesli trafiles");
        min = 1; max = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {   
            min = shoot;
            shoot = (min + max) / 2;
            Debug.Log("Czy twoja liczba jest wieksza lub mniejsza od ?"+shoot);

        if (Input.GetKeyDown(KeyCode.DownArrow))
          {
             max = shoot;
             shoot = (min + max) / 2;
             Debug.Log("Czy twoja liczba jest wieksza lub mniejsza od ?" + shoot);
          }
        if (Input.GetKeyDown(KeyCode.Return))
        {
                
                Debug.Log("Trafilem moja liczbe");
        }


        }
}
