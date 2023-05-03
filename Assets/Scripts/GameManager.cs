using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] public AudioSource pickupSound;
    [SerializeField] public AudioSource dropSound;
    [SerializeField] public AudioSource buttonSound;

    public static GameManager gameManager;
    private void Awake()
    {
        gameManager= this;
        DontDestroyOnLoad(gameObject);
    }

    public static void PlayPickupSound()
    {
        gameManager.pickupSound.Play();
    }
    public static void PlayDropSound()
    {
        gameManager.dropSound.Play();
    }
    public void PlayButtonSound()
    {
        buttonSound.Play();
    }

    public void ChangeSceneToEnd()
    {
        Debug.Log("recieved");
        SceneManager.LoadScene(1);
    }
    
    
    private String name;
    private int age;

    public static String GetName()
    {
        return gameManager.name;
    }
    public void SetName(String name)
    {
        Debug.Log(name);
        gameManager.name = name;
        
    }
    
    public static int GetAge()
    {
        return gameManager.age;
    }
    public void SetAge(int age)
    {
        Debug.Log(age);
        gameManager.age = age;
    }
    public void SetAge(String age)
    {
        Debug.Log(age);
        gameManager.age = int.Parse(age);
    }
    
}
