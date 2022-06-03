using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Meta : MonoBehaviour
{
    public Text txtTime;
    bool firewin = false;
    bool waterwin = false;
    public Text txtwins;
    bool finished = false;
    public GameObject pelota;
    GameObject clon;

    void Start()
    {



    }

    void Update()
    {

        if (finished == false)
        {
            txtTime.text = Time.time.ToString();
        }


    }
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "Watergirl")
        {

            Debug.Log("WaterGirl Wins");
            waterwin = true;
            txtwins.text = "WaterGirl Wins";
            finished = true;
     
            for (int i = 0; i < 5; i++)
            {
                clon = Instantiate(pelota);
                Instantiate(pelota);
                Destroy(clon, 5);
            }
        }

        if (col.gameObject.name == "Fireboy")
        {


            Debug.Log("Fireboy Wins");
            firewin = true;
            txtwins.text = "Fireboy Wins";
            finished = true;

            for (int i = 0; i < 5; i++)
            {
                clon = Instantiate(pelota);
                Instantiate(pelota);
                Destroy(clon, 5);
            }
        }

    }
}