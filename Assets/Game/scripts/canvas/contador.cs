using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class contador : MonoBehaviour
{
    public TextMeshProUGUI MisionCount;
    public string MisionTag = "Misiones";
    private void Start()
    {
        GetTotalTotems();
    }
    void Update()
    {
        UpdateTotemCountText();
    }

    void UpdateTotemCountText()
    {
        GameObject[] mision = GameObject.FindGameObjectsWithTag(MisionTag);
        int TotalMisiones = mision.Length;
        if (TotalMisiones > 0)
        {
            MisionCount.text = "Misions Remains: " + TotalMisiones;
        }
        else { MisionCount.text = "All Misions completed!"; }
    }
    public int GetTotalTotems()
    {
        GameObject[] mision = GameObject.FindGameObjectsWithTag(MisionTag);
        return mision.Length;
    }

}
