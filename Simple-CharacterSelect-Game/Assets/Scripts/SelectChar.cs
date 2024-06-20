using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectChar : MonoBehaviour
{
    public Character character;
    Animator anim;
    SpriteRenderer sr;

    public SelectChar[] chars;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

        if (DataManager.instance.currentCharacter == character)
        {
            OnSelect();
        }
        else
        {
            OnDeselect();
        }
    }

    // Update is called once per frame

    private void OnMouseUpAsButton()
    {
        DataManager.instance.currentCharacter = character;
        OnSelect();

        for(int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != this)
            {
                chars[i].OnDeselect();
            }
        }
    }

    void OnDeselect()
    {
        anim.SetBool("run", false);
        sr.color = new Color(0.5f, 0.5f, 0.5f);
    }

    void OnSelect()
    {
        anim.SetBool("run", true);
        sr.color = new Color(1f, 1f, 1f);
    }
}
