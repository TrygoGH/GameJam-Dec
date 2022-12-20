using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour 
{

    private void Awake()
    {
        ButtonOBJ a = new ButtonOBJ("Start", new Vector3(300,100,5) );
    }

    public class ButtonOBJ
    {

        public GameObject Object;
        public Button Button { get; private set; }
        public Image SourceImg { get; private set; }
        public Color Color { get; private set; }
        public Material Material { get; private set; }
        public string Name { get; private set; }
      
        #region constructors
        public ButtonOBJ(Image Source, Color col, Material mat, string name, Vector3 pos)
        {
            Object = Instantiate(GameObject.FindGameObjectWithTag("DefaultButton"));
            Button = Object.GetComponent<Button>();
            Name = name;
            if (Name == "Start")
            {
                Button.onClick.AddListener(StartButton);
            }
            else if (Name == "Options")
            {
                Button.onClick.AddListener(OptionButton);
            }
            else if (Name == "Exit")
            {
                Button.onClick.AddListener(ExitButton);
            }
        }

        public ButtonOBJ(string name, Vector3 pos)
        {
            Object = Instantiate(GameObject.FindGameObjectWithTag("DefaultButton"), GameObject.FindGameObjectWithTag("ButtonHolder").transform);
            Object.transform.position = pos;
            Button = Object.GetComponent<Button>();
            Name = name;
            if (Name == "Start")
            {
                Button.onClick.AddListener(StartButton);
            }
            else if (Name == "Options")
            {
                Button.onClick.AddListener(OptionButton);
            }
            else if (Name == "Exit")
            {
                Button.onClick.AddListener(ExitButton);
            }
        }

        #endregion


        public void StartButton()
        {
            Debug.Log("Play the game!");
        }

        public void OptionButton()
        {
            Debug.Log("Options");
        }

        public void ExitButton()
        {
            Debug.Log("Exit");
        }


    }

}

