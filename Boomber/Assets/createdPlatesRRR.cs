using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createdPlatesRRR : MonoBehaviour {

    public int SizeOfArea = 10;
    public GameObject wall;
    public GameObject plate;
    void Start () {

        GenerateArea();
		
	}

	void Update () {
		
	}

    void GenerateArea ()
    {
        for (int x = 0; x < SizeOfArea; x++)
        {
            for (int y = 0; y < SizeOfArea; y++)
            {
                if (x == 0 || y == 0 || x == SizeOfArea - 1 || y == SizeOfArea - 1)
                {
                    GameObject Wall = Instantiate(wall, new Vector2(x, y), transform.rotation);
                } else
                {
                    GameObject Plate = Instantiate(plate, new Vector2(x, y), transform.rotation);
                }
            }
        }

    }
}
