using UnityEngine;
using System.Collections;

public class GlobalStateManager : MonoBehaviour
{
    public int deadPlayers = 0;
    public int deadPlayerNumber = -1;

    public void PlayerDied (int playerNumber)
    {
        deadPlayers++;

        if(deadPlayers == 1) 
        {
            deadPlayerNumber = playerNumber;
            Invoke("CheckPlayersDeath", .3f);
        }
    }

    void CheckPlayersDeath() 
    {
        if(deadPlayers == 1) 
        {
            if(deadPlayerNumber == 1) 
            {
                Debug.Log("Player 2 Won!");
            }
            else 
            {
                Debug.Log("Player 1 Won!");
            }
        }
        else 
        {
            Debug.Log("The Game Ended In A Draw!");
        }
    }
}
