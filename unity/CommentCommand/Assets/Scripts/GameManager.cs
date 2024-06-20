using UnityEngine;

public class GameManager : MonoBehaviour
{
    private DisplayScript m_displayScript;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var displayScript = GameObject.Find("SubCameras");
        m_displayScript = DisplayScript.AddComponent(displayScript, this);
        Initialize();
    }

    private void Initialize()
    {
        m_displayScript.Initialize();
        m_displayScript.AddScreen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
