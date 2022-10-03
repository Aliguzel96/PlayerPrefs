using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class playerPrefs : MonoBehaviour
{
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;

    public TMP_InputField value1;
    public TMP_InputField value2;
    public TMP_InputField value3;

    public Slider slider;
    void Start()
    {
        //PlayerPrefs.SetString("UserName", "Lucifer"); //Set i�lemi s�f�rdan bir tan�mlama yapar
        //PlayerPrefs.SetInt("Coins", 92); //�rnek olarak coins isimli ve 92 de�erine sahip bir veriyi set ettik
        //PlayerPrefs.SetFloat("Health", 100);
        
        //PlayerPrefs.Save();// Yukar�da ka� tane i�lem yap�ld��� fark edilmeksizin kaydetme i�lemini yapar 

        text1.text = PlayerPrefs.GetString("UserName"); //Kaydetti�imiz veriyi text i�erisine aktard�k
        text2.text = PlayerPrefs.GetInt("Coins").ToString();
        text3.text = PlayerPrefs.GetFloat("Health").ToString();

        slider.value = PlayerPrefs.GetFloat("Health"); //Slider �ubu�unu health ile senkronize hale getirdik

        PlayerPrefs.DeleteKey("Silinecek Anahtar"); //Vermi� oldu�umuz anahtar� siler
        //PlayerPrefs.DeleteAll(); -> B�t�n anahtarlar� siler

        PlayerPrefs.Equals("Coins", "Health"); //anahtarlar�n de�erleri birbirine e�it mi (Equals(veri1,veri2) �eklinde de yazabiliriz)

        //if (PlayerPrefs.HasKey("Coins")) //sistemde Coins isminde bir anahtar varsa = true
        //    {
        //    Debug.Log("Evet sistemde b�yle bir anahtar mevcut");

        //    }

        //Ornek olarak oyunun her �al��t���nda artan bir sistem yapal�m
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 5); //Coins de�erininin mevcut de�erine 5 ekleyerek set et
        text2.text = PlayerPrefs.GetInt("Coins").ToString();

        //PlayerPrefs.SetInt("Coins", 125); //bu i�lem g�ncelleme olur ��nk� mevcut anahtar sistemde yok
        //PlayerPrefs.SetInt("Stamina", 120); //bu i�lem yeni ekleme olur ��nk� sistemde bu anahtar mevcut de�il
    }

    
    public void verileriYaz()
    {
        PlayerPrefs.SetString("UserName", "Lucifer"); 
        PlayerPrefs.SetInt("Coins", 92);
        PlayerPrefs.SetFloat("Health", 100);
        verileriGuncelle();

    }

    void verileriGuncelle()
    {
        text1.text = PlayerPrefs.GetString("UserName");
        text2.text = PlayerPrefs.GetInt("Coins").ToString();
        text3.text = PlayerPrefs.GetFloat("Health").ToString();

    }

    public void yeniVerileriYaz()
    {

        //if ler yard�m�yla yaln�zca de�er gelirse set yapt�rma i�lemini uygulad�k yani di�er inputlar girilmese de teker teker veri eklenebilir duruma geldi

        if(value1.text != "")//t�m inputlar� kontrol etmeliyiz, aksi durumda hata verir
            PlayerPrefs.SetString("UserName", value1.text);
        if (value2.text != "")
            PlayerPrefs.SetInt("Coins", int.Parse(value2.text)); //int i�erisine string yazd�rmaya �al��t���m�z i�in parse etmeliyiz
        if (value3.text != "")
            PlayerPrefs.SetFloat("Health", float.Parse(value3.text));


        verileriGuncelle();
    }


    public void hepsiniSil()
    {

        PlayerPrefs.DeleteAll();//herseyi silecek, dolay�s�yla a�a��da yeniden olu�turmam�z laz�m
        verileriGuncelle();
        

    }

    public void AnlikDegerGuncellemesi(float deger)//Sahnedeki slider'a bu fonks �zerinden ula�t�k
    {
        PlayerPrefs.SetFloat("Health", deger);
        // Debug.Log(deger);//Slider degerini consola yazd�rd�k
        verileriGuncelle();
    }








}
