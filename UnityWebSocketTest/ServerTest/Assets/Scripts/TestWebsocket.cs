using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestWebsocket : MonoBehaviour
{
    public Text TextServer;
    public Button ButtonServer;
    // Start is called before the first frame update
    void Start()
    {
        ButtonServer.onClick.AddListener(setText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setText(){
        TextServer.text = "Button pressed";
    }   
}
