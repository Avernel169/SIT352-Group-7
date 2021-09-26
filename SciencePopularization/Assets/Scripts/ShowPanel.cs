using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShowPanel : MonoBehaviour
{

    public Button[] Btn;
    public GameObject MenuPanel;

    public Slider Slider;
    public List<GameObject> ModelListS;

    public string[] Names;

    private int NUMModel;

    public GameObject ARPanelBtnText3;

    public GameObject ARPanelNames;

    public string[] TextStr;

    private float TimeTOUCH;


    private Vector3 V1;
    private Vector3 V2;
    private 
    void Start()
    {
        NUMModel = 0;
        
        Btn[0].onClick.AddListener(QuitGame);
        Btn[1].onClick.AddListener(OnClickMenuBtn);
        Btn[2].onClick.AddListener(CloseMenu);
        Btn[3].onClick.AddListener(OnClickLBtn);
        Btn[4].onClick.AddListener(OnClickRBtn);
        Btn[5].onClick.AddListener(OnClickUSEBtn);
        Btn[6].onClick.AddListener(OnClickReturnGame);
        Slider.onValueChanged.AddListener(MusicManager.Instance.SetAudioSourceVOLUME1);
        V1 = Camera.transform.position;
        V2 = Camera.transform.eulerAngles;
    }

    private void OnClickReturnGame()
    {
        SceneManager.LoadScene("Start");
    }

    private void OnClickUSEBtn()
    {
        ARPanelBtnText3.gameObject.SetActive(!ARPanelBtnText3.activeSelf);
    }

    private void OnClickLBtn()
    {
        NUMModel--;
        if (NUMModel < 0)
        {
            NUMModel = ModelListS.Count-1;
        }
        for (int i = 0; i < ModelListS.Count; i++)
        {
            ModelListS[i].gameObject.SetActive(false);
        }
        ModelListS[NUMModel].gameObject.SetActive(true);
        ARPanelBtnText3.gameObject.GetComponent<Text>().text = TextStr[NUMModel];
        ARPanelNames.gameObject.GetComponent<Text>().text = Names[NUMModel];
        Camera.transform.eulerAngles = V2;
        Camera.transform.position = V1;
    }

    private void OnClickRBtn()
    {
        NUMModel++;
        if (NUMModel >= ModelListS.Count)
        {
            NUMModel =0;
        }
        for (int i = 0; i < ModelListS.Count; i++)
        {
            ModelListS[i].gameObject.SetActive(false);
        }
        ModelListS[NUMModel].gameObject.SetActive(true);
        ARPanelBtnText3.gameObject.GetComponent<Text>().text = TextStr[NUMModel];
        ARPanelNames.gameObject.GetComponent<Text>().text = Names[NUMModel];
        Camera.transform.eulerAngles = V2;
        Camera.transform.position = V1;
    }

    private void CloseMenu()
    {
        MenuPanel.gameObject.SetActive(false);
    }

    private void OnClickMenuBtn()
    {
        MenuPanel.gameObject.SetActive(true);
    }

    private void QuitGame()
    {
        Application.Quit();
    }

    public Transform ModelList;
    public Transform Camera;
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {

            TimeTOUCH += Time.deltaTime;
            if (TimeTOUCH >0.1f)
            {
                float x = Input.GetAxis("Mouse X");
                Camera.transform.RotateAround(ModelList.position, Vector3.up, x * 5);

            }
        }

        if (!Input.anyKey)
        {
            TimeTOUCH = 0;
        }
    }
}
