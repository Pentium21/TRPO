using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesChanger:MonoBehaviour
{
    public void HomeBtn()
   {
      SceneManager.LoadScene(0);
   }

    public void LoginBtn()
    {
      SceneManager.LoadScene(1);
    }
        
    public void SignInBtn()
    {
      SceneManager.LoadScene(2);
    }

    public void CompanyAreaBtn()
    {
      SceneManager.LoadScene(3);
    }

    public void PersonalAreaBtn()
    {
      SceneManager.LoadScene(4);
    }

    public void Test1Btn()
    {
      SceneManager.LoadScene(5);
    }

    public void Test2Btn()
    {
      SceneManager.LoadScene(6);
    }

    public void Test3Btn()
    {
      SceneManager.LoadScene(7);
    }

    public void Test4Btn()
    {
      SceneManager.LoadScene(8);
    }

    public void Test5Btn()
    {
      SceneManager.LoadScene(9);
    }

    public void TestResulat()
    {
      SceneManager.LoadScene(10);
    }
}