using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// کلاسی برای بربر
/// </summary>
public class TestCamp : MonoBehaviour
{
    ///classbarbar;

    #region متغییرها

    public Text txtnumAllArmy;
    public GameObject txtnumbarbar;
    public int numAllArmy = 20;
    public int Numbarbar = 0;


    public GameObject Bala;

    #endregion

    void Start()
    {
        Numbarbar = 0;
    }
    void Update()
    {

    }

    /// <summary>
    /// متد برای استوک بربر که با کیک کردن بر روی استوک بربر این دستورات اعمال خواهد شد
    /// </summary>
    public void MakeNewArmy()
    {
        ++Numbarbar;
        if (Numbarbar <= numAllArmy)
        {
            if (!GameObject.Find("EmptyBarbarSlot(Clone)"))
            {
                _makePrefab();
            }
            _SetKardanha();
            Debug.Log(Numbarbar);
        }
    }





    public void _RemoveArmy()
    {

        --Numbarbar;
        Debug.Log(Numbarbar);

    }






    #region متدهای کوچک دیگر
    /// <summary>
    ///ساختن پرفب
    /// </summary>
    private void _makePrefab()
    {
        //ساختن پرفب
        _InstanceLoadPrefabs(path: "EmptyBarbarSlot", parent: Bala, _name: "EmptyBarbarSlot"); _SetKardanha();
    }
    void _SetKardanha()
    {
        txtnumAllArmy.text = (Numbarbar + " / " + numAllArmy).ToString();
        GameObject inst = GameObject.Find("EmptyBarbarSlot(Clone)");

        txtnumbarbar = GameObject.Find("EmptyBarbarSlot(Clone)/txtnumbarbar");

        txtnumbarbar.GetComponent<Text>().text = Numbarbar.ToString();

    }

    #endregion

    #region کلاس های ریشه
    /// <summary>
    ///  کلاس اینستنس از طریق گیم آبجکت
    /// </summary>
    /// <param name="parent">نام آبجکتی که اینیستنس جایلد آن خواهد شد</param>
    //public void _Instance(GameObject instance, GameObject parent)
    //{
    //    instance = Instantiate(instance, parent.transform) as GameObject;
    //}

    /// <summary>
    /// ساخت اینستنشید از طریق پرفب 
    /// </summary>
    /// <param name="parent">نام آبجکتی که اینیستنس جایلد آن خواهد شد</param>
    /// <param name="path">نام مسیر پرفب که باید در پوشه ریسورس باشد</param>
    /// <param name="_name">نام اینسنتشید</param>
    public void _InstanceLoadPrefabs(GameObject parent, string path, string _name)
    {
        Button Instance = Instantiate(Resources.Load(path), parent.transform.parent) as Button;
        //Instance.name = _name; 
        // mytext.GetComponent<Text>().font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font; 

        Debug.Log(_name);
    }
    #endregion

}
