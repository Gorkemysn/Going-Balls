using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerCoin playerCoin = other.GetComponent<PlayerCoin>();

        if(playerCoin != null)
        {
            playerCoin.CoinCollected();
            gameObject.SetActive(false);
        }
    }

}
