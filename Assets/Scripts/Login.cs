using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;
using System.IO;

public class Login : MonoBehaviour
{
    [SerializeField] private GameObject _selectLog;
    [SerializeField] private GameObject _personL;
    [SerializeField] private GameObject _companyL;
    [SerializeField] private GameObject _personalName;
    [SerializeField] private GameObject _personalPassword;
    [SerializeField] private GameObject _companyName;
    [SerializeField] private GameObject _companyPassword;
    [SerializeField] private GameObject _accetpButton;
    [SerializeField] private GameObject _worringText;

    public string _personalNameT;
    public string _personalPasswordT;
    public string _companyNameT;
    public string _companyPasswordT;

    public string data; 

    private void CollsectInfo()
    {
        _personalNameT = _personalName.GetComponent<Text>().text;
        _personalPasswordT = _personalPassword.GetComponent<Text>().text;
        _companyNameT = _companyName.GetComponent<Text>().text;
        _companyPasswordT = _companyPassword.GetComponent<Text>().text;
    }
    

    void Start()
    {
        Time.timeScale = 1f;
        _selectLog.SetActive(true);
        _personL.SetActive(false);
        _companyL.SetActive(false);
        _accetpButton.SetActive(false);
    }

    private void PersonalBtn()
    {
        _personL.SetActive(true);
        _selectLog.SetActive(false);
    }

    private void CompanyBtn()
    {
        _selectLog.SetActive(false);
        _companyL.SetActive(true);
    }

    private bool TextAvailabilityP()
    {
        bool n = false;
        string _text = _personalName.GetComponent<Text>().text;
        string _text2 = _personalPassword.GetComponent<Text>().text;
        string _text3 = _companyName.GetComponent<Text>().text;
        string _text4 = _companyPassword.GetComponent<Text>().text;
        if(_text != "" && _text2 != "" || _text3 != "" && _text4 != "")
            n = true;
        return n;
    }

    private bool InfoChecking()
    {
        bool indicator = false; 
        data = File.ReadAllText("C:/save.txt");
        JsonUtility.FromJsonOverwrite(data, this);
        return indicator;
    }

    public void SaveBtn()
    {
        CollsectInfo();
        data = JsonUtility.ToJson(this);
        File.WriteAllText("C:/save.txt", data);
        if(_personalNameT != "")
            SceneManager.LoadScene(4);
        else
            SceneManager.LoadScene(3);
    }

    void Update()
    {
        if(TextAvailabilityP())
            _accetpButton.SetActive(true);
        else
            _accetpButton.SetActive(false);
    }   
}
