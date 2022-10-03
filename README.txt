PlayerPrefabs, oyundaki bilgileri tutmamızı sağlayan bir sistemdir.
Veriler ön bellekte işlenir ve yine burada tutulur

Oyun geliştiriyor ve oturumlar/sessions ya da bölümler/levels arasında geçiş yaparken verilerin kaybolmasını istemiyorsanız PlayerPrefs kullanabilirsiniz.

PlayerPrefs, oyuncu için özelleştirilmiş/oyuncuya ait verileri saklamanıza ve daha sonra bu verilere erişmenize olanak tanır.

Tüm Veri Tipleri İçin Kullanabilir Miyim  ?
Hayır. PlayerPrefs ile String, Float ve Integer tiplerinde veriler saklanabilir.

PlayerPrefs Fonksiyonları
DeleteAll   : Kayıtlı tüm anahtar ve verileri siler
DeleteKey : Belirtilen anahtar ve onunla ilgili veriyi siler
GetFloat    : Belirtilen anahtar ile kaydedilmiş float tipindeki veriyi getirir
GetInt         : Belirtilen anahtar ile kaydedilmiş integer tipindeki veriyi getirir
GetString  : Belirtilen anahtar ile kaydedilmiş string tipindeki veriyi getirir
HasKey      : Belirtilen anahtar kayıtlı ise true döndürür
Save            : Düzenlenen tüm tercihleri diske yazar
SetFloat     : Float tipindeki veriyi belirtilen anahtar ile birlikte saklar
SetInt         : Integer tipindeki veriyi belirtilen anahtar ile birlikte saklar
SetString  : String tipindeki veriyi belirtilen anahtar ile birlikte saklar



referans - > http://www.cerenavci.com/unity-playerprefs-kullanimi/
