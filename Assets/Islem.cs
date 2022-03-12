using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Islem : MonoBehaviour
{

    public TMP_Text islemText;

    public TMP_InputField cevapText;

    public TMP_Text dogruSayısı;
    public TMP_Text yanlısSayısı;

    public TMP_Text kontrolText;

    public int dogru1Sayısı;
    public int yanlıs1Sayısı;

    public int islem = 1;

    // Start is called before the first frame update
    void Start()
    {
        ilkSayı();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Debug.Log("x" + x);
        Debug.Log("y" + y);
        */
    }

    public void Toplama()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            int x = Random.Range(1, 10);
            int y = Random.Range(1, 10);

            islemText.text = x + "+" + y + "= ";
            int cevap = int.Parse(cevapText.text);

            if (cevap == x + y)
            {
                Debug.Log("Doğru");
                dogru1Sayısı++;
                dogruSayısı.text = dogru1Sayısı.ToString();
            }
            else
            {
                Debug.Log("Yanlış");
                yanlıs1Sayısı++;
                yanlısSayısı.text = yanlıs1Sayısı.ToString();
            }
        }
    }
    public void Cıkarma()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            int x = Random.Range(1, 10);
            int y = Random.Range(1, 10);

            islemText.text = x + "-" + y + "= ";
            int cevap = int.Parse(cevapText.text);

            if (cevap == x - y)
            {
                Debug.Log("Doğru");
                dogru1Sayısı++;
                dogruSayısı.text = dogru1Sayısı.ToString();
            }
            else
            {
                Debug.Log("Yanlış");
                yanlıs1Sayısı++;
                yanlısSayısı.text = yanlıs1Sayısı.ToString();
            }
        }

    }
    public void Carpma()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            int x = Random.Range(1, 10);
            int y = Random.Range(1, 10);

            islemText.text = x + "*" + y + "= ";
            int cevap = int.Parse(cevapText.text);

            if (cevap == x * y)
            {
                Debug.Log("Doğru");
                dogru1Sayısı++;
                dogruSayısı.text = dogru1Sayısı.ToString();
            }
            else
            {
                Debug.Log("Yanlış");
                yanlıs1Sayısı++;
                yanlısSayısı.text = yanlıs1Sayısı.ToString();
            }
        }

    }
    public void Bolme()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            int x = Random.Range(1, 10);
            int y = Random.Range(1, 10);

            islemText.text = x + "/" + y + "= ";
            int cevap = int.Parse(cevapText.text);

            if (cevap == x / y)
            {
                Debug.Log("Doğru");
                dogru1Sayısı++;
                dogruSayısı.text = dogru1Sayısı.ToString();
            }
            else
            {
                Debug.Log("Yanlış");
                yanlıs1Sayısı++;
                yanlısSayısı.text = yanlıs1Sayısı.ToString();
            }
        }
    }

    public void IslemSecme()
    {
        switch (islem)
        {
            case (1):
                Debug.Log("Toplama");
                Toplama();
                break;
            case (2):
                Debug.Log("Çıkarma");
                Cıkarma();
                break;
            case (3):
                Debug.Log("Çarpma");
                Carpma();
                break;
            case (4):
                Debug.Log("Bölme");
                Bolme();
                break;
            default:
                Debug.Log("Lütfen işlem seçiniz.");
                break;

        }
    }
    public void ilkSayı()
    {
        int x = Random.Range(1, 10);
        int y = Random.Range(1, 10);

        islemText.text = x + "+" + y + "= ";
       
        if(Input.GetKeyDown(KeyCode.Return))
        {
            int cevap = int.Parse(cevapText.text);
            if (cevap == x + y)
            {
                Debug.Log("Doğru");
                dogru1Sayısı++;
                dogruSayısı.text = dogru1Sayısı.ToString();
            }
            else
            {
                Debug.Log("Yanlış");
                yanlıs1Sayısı++;
                yanlısSayısı.text = yanlıs1Sayısı.ToString();
            }
        }
    }
}


