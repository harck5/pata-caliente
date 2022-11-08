using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameControler : MonoBehaviour
{
    private int randomNumber;
    public int clickCounter;

    private void Start()
    {
        randomNumber = Random.Range(1, 11);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AddOneToCounter();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
           if (HaveIWon())
            {
                Debug.Log(message: "Eres un maquina, un fiera, un mastodonte, un idolo...");
            }
        }

    }
    private void AddOneToCounter()
    {
        clickCounter++;
        transform.localScale += Vector3.one;
    }

    private bool HaveIWon()
    {
        if (clickCounter < randomNumber)
        {
            Debug.Log(message: $"Te has quedado corto , has hecho {clickCounter} Clicks. Son {randomNumber} Clicks");
            Destroy(gameObject);
            return false;
        } 
            else if (clickCounter == randomNumber)
            {
                Debug.Log(message: "¡¡¡HAS GANADO!!!");
            return true;
            }
        Debug.Log(message: "Te has pasado");
        Destroy(gameObject);
        return false;
    }
}
