using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class regresar1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D colli)
    {

        if (colli.gameObject.tag == "Player")
        {
            
            SceneManager.LoadScene(0);
        }
       
    }
}
