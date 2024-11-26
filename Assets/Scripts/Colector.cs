using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colector : MonoBehaviour
{
    int CONTADOR = 10 ;

    public GameObject itemFinal;
    public GameObject caja;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        itemFinal.SetActive(false);
        caja.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnTriggerEnter(Collider other){

        if (other.CompareTag("Item")){

            Destroy(other.gameObject);

            CONTADOR --;

            if (CONTADOR == 0){

                itemFinal.SetActive(true);
                caja.SetActive(false);

            }

        }

        if (other.CompareTag("Finish")){

            Destroy(other.gameObject);

            SceneManager.LoadScene("Level_2");

        }

        

    }
}
