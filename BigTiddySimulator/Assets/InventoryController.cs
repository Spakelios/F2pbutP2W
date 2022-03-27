using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
public TextMeshProUGUI one, two, three, four;

private void Update()
{
    one.text = ShowCurrency.pucks.ToString();
    two.text = ShowCurrency.screws.ToString();
    three.text = ShowCurrency.stings.ToString();
    four.text = ShowCurrency.brokenKey.ToString();
}
}
