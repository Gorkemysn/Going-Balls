using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCoin : MonoBehaviour
{
    public int NumberOfCoins { get; private set; }

    public UnityEvent<PlayerCoin> OnCoinCollected;

    public void CoinCollected()
    {
        NumberOfCoins++;
        OnCoinCollected.Invoke(this);
    }

}
