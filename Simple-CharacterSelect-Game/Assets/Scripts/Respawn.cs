using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject black;
    public GameObject red;
    public GameObject green;
    public GameObject blue;
    public GameObject selectPlayer;

    Dictionary<string, GameObject> charP;
    // Start is called before the first frame update
    void Start()
    {
        charP.Add("Black", black);
        charP.Add("Blue", blue);
        charP.Add("Green", green);
        charP.Add("Red", red);
        selectPlayer = Instantiate(charP[GetCharName(DataManager.instance.currentCharacter)]);

        selectPlayer.transform.position = transform.position;
    }


    string GetCharName(Character player)
    {
        string name = System.Enum.GetName(typeof(Character), player);
        return name;
    }

}
