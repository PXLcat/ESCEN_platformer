using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("+1 pi�ce");
        //On envoie l'�v�nement
        GameManager.Instance.AddACoin();

        Destroy(this.gameObject); //Attention � bien pr�ciser 
    }
}
