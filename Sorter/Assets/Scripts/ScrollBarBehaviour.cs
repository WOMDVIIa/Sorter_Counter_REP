using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBarBehaviour : MonoBehaviour
{
    private Scrollbar scrollBar;

    // Start is called before the first frame update
    void Start()
    {
        scrollBar = GetComponent<Scrollbar>();
        scrollBar.value = (float)MainManager.instance.numberScrollBar / 3;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BarSlided()
    {
        MainManager.instance.numberScrollBar = Mathf.RoundToInt(scrollBar.value * 3);
    }

}
