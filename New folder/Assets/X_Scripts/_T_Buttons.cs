using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace VahidClash
{

    public class _T_Buttons : MonoBehaviour
    {
        public static Sprite V_sprite;

        public static Vector3 V_Pos;

        public static Vector2 V_size;

        public static GameObject V_canvas;

        public static UnityEngine.Events.UnityAction V_method;




        public static Button UiTexturedButton(Sprite sprite, Vector2 size, Vector3 pos, GameObject canvas, UnityEngine.Events.UnityAction method)
        {
            GameObject go = new GameObject("Textured button (" + sprite.name + ")");
            Image image = go.AddComponent<Image>();
            image.sprite = sprite;
            Button button = go.AddComponent<Button>();
            go.transform.SetParent(canvas.transform, false);
            go.transform.position = pos;
            image.rectTransform.sizeDelta = size;
            image.rectTransform.transform.position = pos;
            button.GetComponent<Button>().onClick.AddListener(method);
            return button;
        }
    }
}