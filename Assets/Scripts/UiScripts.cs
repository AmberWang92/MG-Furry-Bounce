using UnityEngine;
using UnityEngine.Events;
public class UiScripts : MonoBehaviour
{
    public UnityEvent resetPlayerEvent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void ResetButton()
    {
        resetPlayerEvent.Invoke();
    }
}
