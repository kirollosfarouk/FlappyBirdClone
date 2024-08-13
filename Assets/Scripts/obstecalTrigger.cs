using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstecalTrigger : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("GAME OVER");
    }
}
