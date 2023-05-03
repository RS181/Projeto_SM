using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager_Turn : MonoBehaviour
{
    public List<player> players = new List<player>();
    void Start()
    {

    }

    void Update()
    {

    }
    int idPlayering;


    public void runTurn(int numberBox)
    {
        switch (idPlayering)
        {
            case 0:
                players[idPlayering].enter_numberBox(numberBox);
                idPlayering = 1;

                break;
            case 1:
                players[idPlayering].enter_numberBox(numberBox);
                idPlayering = 2;

                break;
            case 2:
                players[idPlayering].enter_numberBox(numberBox);
                idPlayering = 3;
                break;
            case 3:
                players[idPlayering].enter_numberBox(numberBox);
                idPlayering = 0;
                break;

        }

    }
}
