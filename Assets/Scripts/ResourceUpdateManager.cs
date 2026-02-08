using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class ResourceUpdateManager : MonoBehaviour
{
    [SerializeField]
    public List<Image> resourceBars = new List<Image>();

    public void Start()
    {
        foreach (Image i in resourceBars) 
        {
            i.fillAmount = Random.Range(0.25f, 1f);
        }
    }

    public void UpdateResource(int resource, float amount) 
    {
        resourceBars[resource].fillAmount += amount;
    }

    public void Update() 
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            UpdateResource(Random.Range(0, 5), Random.Range(-0.5f, 0.5f));
        }
    }

}
