using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public static string nameOfPlayer;
    public string saveName;

    public Text playerName;
    public Text loadedName;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nameOfPlayer = PlayerPrefs.GetString("name", "none");
        loadedName.text = nameOfPlayer;
    }

    public void SetName()
    {
        saveName = playerName.text;
        PlayerPrefs.SetString("name", saveName);
    }

    
}
