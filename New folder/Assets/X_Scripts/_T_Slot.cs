using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using VahidClash;


public class _T_Slot : MonoBehaviour 
{




    private UnityAction v_method;
    public UnityAction V_method
    {
        get
        {
            return v_method;
        }
        set
        {
            v_method = Onclick;
            v_method = value;
            value = Onclick;
        }
    }

    public Vector2 V_size = new Vector2(100, 100);

    public GameObject V_canvas;

    public Vector3 V_Pos;

    public Sprite V_sprite;
    void Start()
    { }

        void Update()
    {




        if (Input.GetButton("Fire1"))
        {
            _T_Buttons.UiTexturedButton(sprite: V_sprite, size: V_size,pos:V_Pos, canvas: V_canvas, method: V_method);

            Debug.LogFormat(V_sprite.ToString());
          
        }
    }
    void Onclick()
    {
        if (GUILayout.Button("Build Object"))
        {
                   Debug.Log("Test");

        }
    }
}
