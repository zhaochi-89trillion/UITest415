﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomePage : MonoBehaviour
{
    [SerializeField] private Transform rootTS;
    [SerializeField] private GameObject dsPrefab;

    public void RootButtonOnClick() //生成daily selection 页面
    {

            var ds = Instantiate(dsPrefab, rootTS, false);
            ds.name = "Daily Selection"; //赋予预制体在场景中的名字
            ds.transform.localScale = Vector3.one;
            ds.transform.localPosition = Vector3.zero;
    }
}