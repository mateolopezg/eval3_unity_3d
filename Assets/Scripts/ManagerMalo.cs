using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerMalo : MonoBehaviour
{
    public GameObject sonidoMuere;

    private void OnTriggerEnter(Collider col)
    {
        Instantiate(sonidoMuere);
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PLayer" || collision.gameObject.name == "Piso")
        {
            ResetScene();
        }
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
