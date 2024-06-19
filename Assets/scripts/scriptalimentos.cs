using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptalimentos : MonoBehaviour
{
    public GameObject[] alimentos;
    int currentindex = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentindex < alimentos.Length)
            {
                currentindex++;
            }
            else
            {
                currentindex = alimentos.Length - 1;
            }
            DesactivateAll();
            alimentos[currentindex].SetActive(true);

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentindex > 0)
            {
                currentindex--;
            }
            else
            {
                currentindex = 0;
            }
            DesactivateAll();
            alimentos[currentindex].SetActive(true);

        }

    }
    void DesactivateAll()
    {
        for (int i = 0; i < alimentos.Length; i++)
        {
            alimentos[i].SetActive(false);
        }
    }
}

