using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeScript : MonoBehaviour
{
    public double[] values;
    double[] privateValues;
    double cost;
    double cost_inc;
    double upgrade;
    double upgrade_inc;

    void Start()
    {
        privateValues = new double[] { cost, cost_inc, upgrade, upgrade_inc };

        for(int i = 0; i < values.Length; i++)
        {
            privateValues.SetValue(values[i], i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Buy()
    {
        print(privateValues.ToString());
    }
}
