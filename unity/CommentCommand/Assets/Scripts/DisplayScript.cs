using System.Collections.Generic;
using UnityEngine;

public class DisplayScript : MonoBehaviour
{
    private const int MAX_SCREEN_COUNT = 8 - 1;
    private GameManager m_gameManager;
    private GameObject m_root;
    private List<Camera> m_cameras;
    private GameObject m_prefabCamera;
    
    

    public DisplayScript(GameObject gameObject, GameManager gameManager)
    {
        CreateCore(this, gameObject, gameManager);
    }

    public void Initialize()
    {
        m_prefabCamera = (GameObject)Resources.Load ("Prefabs/Main Camera");
    }

    public bool AddScreen()
    {
        if (m_cameras.Count >= MAX_SCREEN_COUNT)
        {
            return false;
        }

        var camera = Instantiate(m_prefabCamera, parent:m_root.transform);
        m_cameras.Add(camera.GetComponent<Camera>());
        return true;
    }

    public static DisplayScript AddComponent(GameObject gameObject, GameManager gameManager)
    {
        var displayScript = gameObject.AddComponent<DisplayScript>();
        CreateCore(displayScript, gameObject, gameManager);
        return displayScript;
    }

    public static void CreateCore(DisplayScript displayScript, GameObject gameObject, GameManager gameManager)
    {
        displayScript.m_root = gameObject;
        displayScript.m_gameManager = gameManager;
        displayScript.m_cameras = new List<Camera>();
    }

}
