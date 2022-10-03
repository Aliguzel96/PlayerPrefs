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
        //PlayerPrefs.SetString("UserName", "Lucifer"); //Set iþlemi sýfýrdan bir tanýmlama yapar
        //PlayerPrefs.SetInt("Coins", 92); //örnek olarak coins isimli ve 92 deðerine sahip bir veriyi set ettik
        //PlayerPrefs.SetFloat("Health", 100);
        
        //PlayerPrefs.Save();// Yukarýda kaç tane iþlem yapýldýðý fark edilmeksizin kaydetme iþlemini yapar 

        text1.text = PlayerPrefs.GetString("UserName"); //Kaydettiðimiz veriyi text içerisine aktardýk
        text2.text = PlayerPrefs.GetInt("Coins").ToString();
        text3.text = PlayerPrefs.GetFloat("Health").ToString();

        slider.value = PlayerPrefs.GetFloat("Health"); //Slider çubuðunu health ile senkronize hale getirdik

        PlayerPrefs.DeleteKey("Silinecek Anahtar"); //Vermiþ olduðumuz anahtarý siler
        //PlayerPrefs.DeleteAll(); -> Bütün anahtarlarý siler

        PlayerPrefs.Equals("Coins", "Health"); //anahtarlarýn deðerleri birbirine eþit mi (Equals(veri1,veri2) þeklinde de yazabiliriz)

        //if (PlayerPrefs.HasKey("Coins")) //sistemde Coins isminde bir anahtar varsa = true
        //    {
        //    Debug.Log("Evet sistemde böyle bir anahtar mevcut");

        //    }

        //Ornek olarak oyunun her çalýþtýðýnda artan bir sistem yapalým
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 5); //Coins deðerininin mevcut deðerine 5 ekleyerek set et
        text2.text = PlayerPrefs.GetInt("Coins").ToString();

        //PlayerPrefs.SetInt("Coins", 125); //bu iþlem güncelleme olur çünkü mevcut anahtar sistemde yok
        //PlayerPrefs.SetInt("Stamina", 120); //bu iþlem yeni ekleme olur çünkü sistemde bu anahtar mevcut deðil
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

        //if ler yardýmýyla yalnýzca deðer gelirse set yaptýrma iþlemini uyguladýk yani diðer inputlar girilmese de teker teker veri eklenebilir duruma geldi

        if(value1.text != "")//tüm inputlarý kontrol etmeliyiz, aksi durumda hata verir
            PlayerPrefs.SetString("UserName", value1.text);
        if (value2.text != "")
            PlayerPrefs.SetInt("Coins", int.Parse(value2.text)); //int içerisine string yazdýrmaya çalýþtýðýmýz için parse etmeliyiz
        if (value3.text != "")
            PlayerPrefs.SetFloat("Health", float.Parse(value3.text));


        verileriGuncelle();
    }


    public void hepsiniSil()
    {

        PlayerPrefs.DeleteAll();//herseyi silecek, dolayýsýyla aþaðýda yeniden oluþturmamýz lazým
        verileriGuncelle();
        

    }

    public void AnlikDegerGuncellemesi(float deger)//Sahnedeki slider'a bu fonks üzerinden ulaþtýk
    {
        PlayerPrefs.SetFloat("Health", deger);
        // Debug.Log(deger);//Slider degerini consola yazdýrdýk
        verileriGuncelle();
    }








}
