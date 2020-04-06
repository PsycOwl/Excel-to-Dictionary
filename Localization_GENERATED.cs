using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class Localization
{

    static bool SafeMode = true; //IF TRANSLATE ERROR, WON'T ATTEMPT TO TRANSLATE THE FAILED STRING.

    public static Dictionary<string, string> TR = new Dictionary<string, string>()
    {
		{"EN", "TR" },
		//GENERAL UI ELEMENTS
		{"7.99USD", "39.99TL" },
		{"Don't show again.", "Bir daha gösterme." },
		{"You have to turn the phone's rotating feature on.", "Telefonunun döndürme özelliğini açık hale getirmelisin." },
		{"RESTORE", "YUKLE" },
		{"Restore Purchases", "Satın Alımları Yükle" },
		{"COMING SOON...", "ÇOK YAKINDA..." },
		{"COME AGAIN TOMORROW!", "YARIN YİNE GEL!" },
		{"3 days free", "3 gün ücretsiz" },
		{"AND...", "Ve..." },
		{"BECOME VIP!", "VIP OLUN!" },
		{"CONGRATULATIONS!!!", "TEBRİKLER!!!" },
		{"Daily Bonus", "Günlük Bonus" },
		{"Double daily bonus", "Çift günlük bonus" },
		//ANDROID EXPLANATION
		//Weekly Premium automatically renews. Payment will be charged to your Google account at the end of the trial period of purchase. The subscription automatically renews unless auto-renews unless auto-renew is turned off at least 24 hours before the end of the current period. You can manage and turn off auto-renewal of the subscription by going to your account settings on the Google Play after purchase.
		//IOS EXPLANATION
		//Weekly Premium automatically renews. Payment will be charged to your iTunes account at the end of the trial period of purchase The subscription automatically renews unless auto-renews unless auto-renew is turned off at least 24 hours before the end of the current period. You can manage and turn off auto-renewal of the subscription by going to your account settings on the iTunes after purchase.
		{"Feedback", "Geri Bildirim" },
		{"Free", "Ücretsiz" },
		{"Game Reset", "Oyunun Verilerini Sil" },
		{"Hint discounts", "İpucu indirimleri" },
		{"INSTANTLY", "ANINDA" },
		{"All Levels", "Tüm Seviyeler" },
		{"Music", "Müzik" },
		{"Next", "Sonraki" },
		{"Nice start...", "Güzel başlangıç..." },
		{"Privacy Policy", "Gizlilik Politikası" },
		{"PRIVACY POLICY", "GİZLİLİK POLİTİKASI" },
		{"Rate", "Değerlendir" },
		{"remove ads", "reklamları kaldır" },
		{"Remove ads", "Reklamları kaldır" },
		{"Remove Ads", "Reklamları Kaldır" },
		{"Share", "Paylaş" },
		{"Skip discounts", "Atlama indirimleri" },
		{"Skip", "Atla" },
		{"Skipping costs 2 keys. Would you like to skip?", "Atlamak 2 anahtar harcar. Atlamak ister misin?" },
		{"Sounds", "Sesler" },
		{"Store", "Mağaza" },
		{"TERMS OF USE", "KULLANIM ŞARTLARI" },
		{"Terms of Use", "Kullanım Şartları" },
		{"TRY FOR FREE!", "ÜCRETSİZ DENE!" },
		{"Vibration", "Titreşim" },
		{"Watch", "İzle" },
		{"Weekly", "Haftalık" },
		//PREFABS
		{"Exit", "Çıkış" },
		{"OK", "TAMAM" },
		{"Fire", "Ateş" },
		{"FINISH", "TAMAMLA" },
		{"RUN", "KAÇ" },
		{"CLEAR", "TEMİZLE" },
		{"START", "BAŞLA" },
		{"JUMP", "ZIPLA" },
		{"Write your answer", "Cevabınızı girin" },
		//LEVELS
		//1
		{"Which one is red?", "Hangisi kırmızı?" },
		{"Or you didn't click on the red text?", "Yoksa sen kırmızı yazısına tıklamadın mı?" },
		{"Good start.", "Güzel başladın." },
		{"Green", "Yeşil" },
		{"Yellow", "Sarı" },
		{"Blue", "Mavi" },
		{"Red", "Kırmızı" },
		//2
		{"Shoot the basketball into the hoop", "Potaya basket at" },
		{"You need to press the shoot button when it reaches green in order to shoot.", "Basket atmak için yeşil yere geldiğinde at tuşuna basmalısın..." },
		{"Nice shot.", "Güzel basket." },
		{"Shoot", "At" },
		//3
		{"Throw everything away", "Her şeyi çöpe at" },
		{"You should drag-and-drop pizza, cheese, ice-cream and cactus to the trash.", "Pizza, peynir, dondurma ve kaktüsü çöp kutusuna sürükleyip bırakmalısınız." },
		{"Cleaning is important, of course...", "Temizlik önemli tabi ki..." },
		//4
		{"Find the different one", "Farklı olanı bul" },
		{"Could it be under the ice-cream? Look at it.", "Dondurmanın altında olabilir mi ? Hemen bak." },
		{"I guess someone likes a different kind of ice-cream :)", "Sanırım biri farklı bir dondurma seviyor :)" },
		//5
		{"Which one is the biggest drop?", "En büyük damla hangisi?" },
		{"Put the drops on top of each other and create the largest one.", "Damlaları üst üste koyup birleştir ve en büyük damlayı ortaya çıkar." },
		{"Many a mickle makes a muckle...", "Damlaya damlaya göl olur..." },
		//6
		{"Did you try covering the lamp with your hand?", "Lambanın üzerini parmağınla kapatmayı denedin mi?" },
		{"You managed to help the baby sleep again. Zzz...", "Yine uyutmayı başardın. Zzz." },
		//7
		{"How many points do you give to this game?", "Bu oyuna kaç puan verirsiniz?" },
		{"I think you liked it very much.", "Bence çok beğendin." },
		{"Since you loved it so much, let’s continue!", "Madem çok beğendin, o zaman devam!" },
		{"Waste of time", "Vakit kaybı" },
		{"I couldn't figured it out", "Çözemedim" },
		{"It's OK", "İdare eder" },
		{"It's nice", "Güzel gibi" },
		{"I liked it very much!", "Çok beğendim!" },
		//8
		{"Make the baby sleep", "Bebeği uyut" },
		{"Firstly, you should give the bottle and then try to put the baby to sleep in his/her car.", "Ona önce biberonu verip bebek arabasında uyutmayı denemelisin." },
		{"Rub-a-dub-dub... Zzz...", "Uyusunda büyüsün ninni...Zzz" },
		//9
		{"Balance the scale", "Teraziyi dengele" },
		{"If you take everything off, the scale would be even.", "Bütün cisimleri kaldırırsan terazi eşit olur." },
		{"I know you are a balanced person.", "Dengeli bin insan olduğunu biliyordum." },
		//10
		{"One of the girls looking at the West, the other is to the East. But both of them can see each other, how can you do that?", "Kızlardan biri batıya diğeri doğuya bakıyor... İkiside birbirlerini görebiliyor, bunu nasıl yaparsın?" },
		{"You should move the girls’ head as to be turned as face-to-face.", "Kızların kafaları yüz yüze gelecek şekile oynatmalısın." },
		{"I see you’re getting used to it.", "Bakıyorumda alıştın." },
		//11
		{"Open the door", "Kapıyı aç" },
		{"You need to use the key in the child's pocket in order to open the door.", "Kapıyı açmak için çocuğun cebindeki anahtarı kullanmalısın." },
		{"Yeah, that’s it ;)", "İşte bu kadaaaar..." },
		//12
		{"Stop the fight..!!", "Kavgayı durdur!" },
		{"You can stop the fight when you split the bone in two and give it to the dogs.", "Kemiği ikiye ayırıp köpeklere verdiğinde kavgayı durdurabilirsin." },
		{"Fifty-fifty ;)", "Kardeş payı :)" },
		//13
		{"Help the tree shed its leaves", "Yaprakların dökülmesine yardım et" },
		{"Paint the tree yellow with the paint bucket.", "Ağacı boya kutusunu kullanarak sarıya boya." },
		{"You’re doing great!", "İyi gidiyorsun!" },
		//14
		{"Catch the fish!", "Balığı tut!" },
		{"The fish is hidden between the waves. Move the waves.", "Balık dalgaların arasında gizli..." },
		{"That move seems familiar...", "Bu hareket bir yerden tanıdık geldi bana..." },
		//15
		{"Fill the bucket with water", "Kovayı su ile doldur" },
		{"Try to turn the phone. You will see that the direction of water will change.", "Telefonu döndürmeyi dene, suyun yönünün değiştiğini göreceksin." },
		{"Nature will take its course.", "Su akaar...Yolunu bulur" },
		//16
		{"Help the man lose weight", "Adamı zayıflat" },
		{"Hold the man with your finger, drag him to the left and right 4 times and make him lose weight.", "Adamı parmağınla tutup sağ sola 4 kere salla ve adamı zayıflat." },
		{"He’s skin and bones.", "Bir deri bir kemik kaldı." },
		//17
		{"Feed the hay to the cow", "Samanı ineğe yedir" },
		{"Didn't you see the shovel behind the hay? You can open a way with it.", "Samanın arkasındaki küreği görmedin mi? Onunla yolu açabilirsin." },
		{"Now it’s time to eat.", "Şimdi yemek zamanı." },
		//18
		{"Find the 10 differences", "Aradaki 10 farkı bul" },
		{"What’s important is making a difference :)", "Önemli olan fark yaratmaktır." },
		//19
		{"Clean the page!", "Sayfayı temizle" },
		{"You can clean it by hovering over it with your finger.", "Parmağını yazının üzerinde gezdirerek temizleyebilirsin." },
		{"Did you try to use a rubber? Hahaha", "Silgiyi kullanmayı mı denedin? Hahaha" },
		//20
		{"Which one is soda?", "Hangisi soda" },
		{"Shake the phone, sparkle it and find the soda!", "Telefonu sallayıp köpürt ve sodayı bul!" },
		{"You will fizz like blup blup blup xD", "Köpürürsün blup blup blup xD" },
		//21
		{"Find the gamer", "Gamer'ı bul" },
		{"A true gamer never sleeps.", "Gerçek bir gamer asla uyumaz." },
		{"Gamers don’t sleep. You can find the gamer by clicking on the only window in the apartment where the light is on.", "Gamer'lar uyumaz. Apartmandaki ışığı açık olan tek pencereye tıklayarak onu bulabilisin." },
		//22
		{"How many hairs does the child have?", "Çocuğun kaç tane saçı var?" },
		{"If you lift the child’s wig, you will see how many of the real hair is.", "Çocuğun peruğunu kaldırırsan gerçek saçının kaç tane olduğunu görürsün." },
		{"If you could count all the hair, please contact us. :)", "Eğer bütün saçları saydıysan bizel ulaş. :)" },
		//23
		{"Please charge the phone", "Lütfen telefonu şarja tak" },
		{"Have you ever tried touching the cables at the same time with your two fingers?", "iki parmağınla kablolara aynı anda dokunmayı denedin mi?" },
		{"I'm taking a shine from you.", "Senden elektrik almaya başladım." },
		//24
		{"If the hunter shots 2 of the birds, how many birds left at the branch?", "Avcı bu kuşlardan 2 tanesini vurursa, dalda kaç tane kuş kalır?" },
		{"'0' There would not be any birds left, all of them scared and flew away.", "'0' Hiç kuş kalmaz, diğer kuşlarda korkudan kaçarlar." },
		{"Well done the hunter, he shot 2 birds at the same time.", "Avcıyada helal olsun, aynı anda iki kuş vurmuş." },
		//25
		{"Pop the balloons!", "Balonları patlat!" },
		{"Scare the hedgehog and pop the balloons with its spines!", "Kirpiye dokunarak korkut ve çıkan dikenleriyle balonları patlat!" },
		{"Boooooommmmm!", "Boooooommmmm!" },
		//26
		{"Reach the animal to the exit by using arrows", "Okları kullanarak hayvanı çıkışa ulaştır" },
		{"You should wander around before entering the maze.", "Labirente girmeden etrafından dolaşmalısın." },
		{"All great minds think alike.", "Aklın yolu bir." },
		//27
		{"How many letters left in alphabet if you take the letters of “a” and “b” out?", "Alfabeden 'a' ve 'b' harflerini çıkartırsak kaç harf kalır?" },
		{"There will be 6 letters left if you take a and b out from alphabet word.", "'Alfabeden' kelimesinden a ve b yi çıkartırsak 7 harf kalır." },
		{"Do you think that your friends can solve this question?", "Sence bu soruyu arkadaşların da geçebilir mi?" },
		//28
		{"How many flies are there?", "Kaç sinek var?" },
		{"Enlarge the poop in the back and count the flies over it.", "Arkadaki kakaları büyüt ve üzerindeki sinekleri say." },
		{"Flies resides in the details.", "Sinek ayrıntıda gizli ;)" },
		//29 DON'T FORGET TO CHANGE PREFAB
		{"Try to drag the “sleep” word over the baby...", "Uyut kelimesini bebeğin üzerine sürüklemeyi dene..." },
		{"It would be perfect if it was that easy to put babies in sleep in real life.", "Keşke geçekte de bebekleri uyutmak bu kadar basit olsa." },
		//30
		{"Try to close the cow's nose. Look at it, will it wake up?", "İneğin burnunu kapatmayı dene. Bak bakalım uyanacak mı?" },
		{"Almost drowning.", "Az daha boğuluyordu." },
		//31
		{"Save the ship from crashing into the iceberg", "Geminin buzdağına çarpmasına engel ol" },
		{"Try melting the iceberg by rubbing it with your finger.", "Buzdağını parmağınla sürterek erit." },
		{"The Titanic would have sunk.", "Titanik olsa batardı." },
		//32
		{"Cross the truck across the bridge", "Kamyonu köprüden karşıya geçir" },
		{"Try to lift the bridge from the top with your finger.", "Köprüyü ucundan parmağınla kaldırmayı dene." },
		{"Honk honk!", "Düt Düüütt..." },
		//33
		{"Which one is edible?", "Hangisi yenilebilir?" },
		{"What you think of as diamond and poop is actually cone and ice cream. Drag the cone under the ice cream.", "Elmas ve kaka sandığın şey aslında külah ve dondurma. Külahı dondurmanın altına sürükle." },
		{"I wish they were here.", "Olsa da yesek.." },
		//34
		{"What would the result be if we multiply all the numbers with each other?", "Tüm sayıları birbiri ile çarparsak sonuç ne olur?" },
		{"What would the result be if you multiply a number with zero?", "Bir rakamı sıfırla çarparsan sonuç sence ne olur?" },
		{"You cannot ignore the zero...", "Sıfırı görmezden gelemezsin." },
		//35
		{"Do the right move to win the game!", "Oyunu kazanmak için doğru hamleyi yap!" },
		{"Touch the sides of 'O' in the middle, at the same time with 2 fingers!", "2 parmağınla aynı anda ortadaki 'O' nun yanlarına dokun!" },
		{"Good strategy.", "İyi strateji." },
		//36
		{"How would you empty the bathtub fastly?", "Küveti en hızlı şekilde nasıl boşaltırsın?" },
		{"Didn't you try to remove the stopper from the tub? You should try it right now.", "Küvetten tıpayı çıkarmayı denedin mi?" },
		{"Your friends will have difficulty in solving this question!", "Arkadaşların bu soruyu çözmekte zorlanacak." },
		//37
		{"Turn the child over by using two fingers and shake. The key will fall out of the child’s pocket.", "Çocuğu ayağından çevirip sallamayı denemelisin." },
		{"Successful!", "Başarılı!" },
		//38
		{"Find the real shadow of the bird", "Kuşun gerçek gölgesini bul" },
		{"If you drag the sun over the bird, the bird will have a shadow.", "Güneşi kuşun üzerine getirirsen kuşun gerçek gölgesi ortaya çıkacaktır." },
		{"You are great.", "Harikasın!" },
		//39
		{"Some months take 30, some take 31; how many months have 28 days?", "Bazı aylar 30, bazı aylar 31 çeker; kaç ayda 28 gün vardır?" },
		{"Each month has 28 days.", "Her ayda 28 gün vardır." },
		{"It’s that simple.", "İşte bu kadar basit." },
		//40
		{"Do not explode the bomb!", "Bombayı patlatmayın!" },
		{"The bomb will not explode already, just wait for 30 seconds.", "Bomba zaten patlamayacak, 30 saniye bekleyiver..." },
		{"How impatient you are.", "Ne kadar sabırsızsın." },
		//41 DON'T FORGET TO CHANGE PREFAB
		{"You should hang the word of “Man” in the question.", "Sorudaki 'Adam' kelimesini asmalısın." },
		{"Rest in peace.", "Allah rahmet eylesin..." },
		//42
		{"Wake up the cow", "İneği uyandır" },
		{"If you take the moon off the screen, the sun rises and the cow wakes up.", "Ayı ekrandan çıkartırsan güneş doğar ve inek uyanır." },
		{"How can you sleep that much?", "Bu saate kadar uyunur mu?" },
		//43
		{"Press the orange circle 10 times, then press the blue circle once", "10 kere turuncu daireye sonra mavi daireye bas" },
		{"Are you sure that you pressed 10 times? Because the number starts from 1.", "10 kere bastığına emin misin? Çünkü sayı birden başlıyor" },
		{"Or did you press 9 times? We said 10...", "Yoksa 9 kere mi basmıştın? 10 demiştik..." },
		//44
		{"Find the couples and win the game", "Çiftleri bul ve oyunu kazan" },
		{"Shrink your screen, you will see your other mate.", "Ekranı küçült diğer eşini göreceksin." },
		{"You did a good job.", "İyi iş çıkardın." },
		//45
		{"How this equation becomes correct?", "Bu eşitlik nasıl doğru hale gelir?" },
		{"Use the number of 45 in the Lv.45 to create 4550 number.", "Lvl.45'deki 45'i kullanarak 4550 sayısını oluştur." },
		{"You are a true genius.", "Gerçek bir dahisin." },
		//46
		{"Confirm evenness by moving the single matchstick!", "Tek kibrit çöpünü hareket ettirerek eşitliği doğrula!" },
		{"Move the number of 4's matchstick and get 2 pieces of 1! 311+89=400", "4'ün kibrit çöpünü hareket ettir ve 2 tane 1 elde et! 311+89=400" },
		{"Did you know that the match was invented after the lighter?", "Kibritin, çakmaktan sonra icat edildiğini biliyor muydun?" },
		//47
		{"Make all of it green!", "Her şeyi yeşil yap" },
		{"First of all, shake the phone, then put the chameleon on the grass, and then paint the question with the paint bucket. Don't forget to remove the clouds from the screen.", "Önce telefonu salla, sonra bukalemunu ota koy, sonra boya kovasıyla soruyu boya en sonda bulutları çıkart!" },
		{"How the greens will smile if the clouds do not cry?", "Bulutlar ağlamasa, yeşillikler nasıl güler?" },
		//48
		{"If 5 squirrels eat 5 walnuts in 5 minutes, in how many minutes does 15 squirrels eat 15 walnuts?", "5 sincap 5 cevizi 5 dakikada yiyorsa, 15 sincap 15 cevizi kaç dakikada yer?" },
		{"In 5 minutes.", "5 dakikada" },
		{"Aren’t those squirrels so sweet?", "Sincaplar çok tatlı değil mi?" },
		//49 DON'T FORGET TO CHANGE PREFAB
		{"Drag the word 'Protect' on to the rocket.", "'Koruyun' yazısını roketin üzerine sürükle." },
		{"Power shields are now activated.", "Güc kalkanları devrede." },
		//50
		{"You should win the game again", "Oyunu tekrar kazanmalısın!" },
		{"Use 0 in the 50 words. Hold and drag it to the middle of O and press the other side.", "50 yazısındaki 0'ı kazanmak içi kullan. Tutup O'nun yanındaki boşluklardan birine sürükle." },
		{"You know it.", "Sen bu işi biliyorsun." },
		//51
		{"Pizza, ice-cream, cheese, cactus, 'Throw everything away' text and you should throw away the cap of the trash.", "Pizza, peynir, dondurma, kaktüs, 'Her şeyi çöpe at' yazısı ve çöp kapağını çöpe at" },
		//52
		{"How many rings are there on the screen?", "Burada kaç tane yüzük var?" },
		{"We hid 4 of them under the Clean button. '22'", "Temizle butonunun altına da 4 tane sakladık. '22'" },
		{"Nothing can escape from you.", "Senden bir şey kaçmıyor." },
		//53
		{"Collect 5 mice like in the picture", "Resimdeki gibi olan 5 fareyi topla" },
		{"Just click to the mouse in the left direction and do not forget the mouse in the example.", "Sadece sola giden farelere tıkla ve örnekteki fareyi unutma." },
		{"You are a good hunter!", "İyi bir avcısın!" },
		//54
		{"How can the kangaroo jump higher than the building?", "Kanguru binadan yükseğe nasıl zıplayabilir?" },
		{"Make the trampoline bigger!", "Trambolini büyüt!" },
		{"Bounce bounce bounce...!", "Zıp zıp zıp...!" },
		//55
		{"Bring the magnifier to the child's arm on the lower left. You will see the replica.", "Büyüteci sol alttaki çocuğun koluna götür kopyayı göreceksin." },
		{"You’ve got him.", "Yakaladın onu." },
		//56
		{"Which one is the prettiest?", "En güzeli hangisi?" },
		{"Drag the boy in front of the girl, whichever one he smiles at is the prettiest.", "Çocuğu kızın önüne götür hangisine gülerse o en güzelidir." },
		{"Love at first sight.", "Şıpsevdi!" },
		//57
		{"You should rub the baby’s belly and let the gas out.", "Bebeğin karnını okşayıp gazını çıkartmalısın." },
		{"Ops the baby has gas.", "Aa, bebeğin gazı varmış" },
		//58 DON'T FORGET TO CHANGE PREFAB
		{"You should clean it by using the word 'Clean' in the question.", "Sorudaki 'Temizle' yazısını temizlemek için kullan." },
		{"I accept it was bad.", "Kabul ediyorum kötüydü." },
		//59
		{"Get the number of 100 twice by using a single line from the number of 188", "Şimdi elinizde 188 sayısı var. Sadece 1 çizgi kullanarak bu sayıdan iki 100 çıkarabilir misiniz?" },
		{"Divide the number of 188 horizontally. You will have 2 of 1, 4 of 0.", "188 sayısını yatay bir şekilde ortadan ikiye böl. 2 tane 1, 4 tane 0 elde edeceksin." },
		{"Wooww, you are super.", "Wooww, süpersin!" },
		//60
		{"To drop an apple from the tree, you must shake the tree very much. Shake the phone.", "Ağaçtan elma düşürmek için ağacı epey bir sallamalısın. Telefonu salla." },
		{"Did this cow discover gravity?", "Yer çekimini bu inek mi keşfetti?" },
		//61
		{"Turn the light off", "Işığı kapat" },
		{"Turn off the screen towards the table. The light will go off.", "Ekranı yüz üstü masanın üzerine kapat. Işık sönecektir." },
		{"Where were we?", "Nerede kalmıştık?" },
		//62
		{"Bring the pen into the empty space", "Boş alana doğru kalemi getir." },
		{"One of the objects below can be rotated. Find the rotating pen and put it back correctly.", "Aşağıdaki kalemlerin bir tanesi döndürülebilir. Dönebilen kalemi bul ve doğru şekilde yerine koy." },
		{"The pen is mightier than the sword.", "Kalem kılıçtan keskindir." },
		//63
		{"Feed the dog with the food under the box and wait for it to poop. Take the key that comes with the poop to the door.", "Kutunun altındaki mamayı köpeğe yedir ve kakasını yapmasını bekle." },
		{"Sweet little doggie.", "Sevimli kuçu kuçu." },
		//64
		{"Solve the problem!", "Problemi çöz!" },
		{"Be careful about seeds of blackberry, 2 of them are missing. '18'", "Böğürtlen tanelerini saymayı denedin mi? 2 tanesi eksik '18'" },
		{"You understand the math...", "Matematikten anlıyorsun..." },
		//65
		{"Try to get rain from the cloud.", "Buluttan yağmur yağdırmayı dene." },
		{"It's raining, floods are flowing...", "Yağmur yağıyor, seller akıyor..." },
		//66
		{"Do you guess the three letters upcoming in the order?", "Sıralamanın devamında gelecek 3 harfi tahmin edebilir misin?" },
		{"Look carefully at the first letters of words in the question? Use the first letters of last two words", "Sorudaki kelimelerin baş harflerine dikaktli bak. Son 3 kelimenin baş harflerini kullan!" },
		{"Did you guess?", "Tahmin ettin mi?" },
		//67
		{"Find objects!", "Objeleri bul!" },
		{"You have a sharp sight!", "Keskin gözlere sahipsin." },
		//68
		{"How many numbers are there?", "Kaç tane rakam var?" },
		{"You are super!", "Süpersin!" },
		//69
		{"Please write down the right answer?", "Lütfen doğru cevabı yazınız" },
		{"You should think simple. Add up the 8 and 5.", "Basit düşünmelisin. 8 ile 5'i topla." },
		{"Sometimes you need to think simple ;)", "Bazen basit düşünmek lazım ;)" },
		//70
		{"I go to bed at 8 o'clock at night and I set my cuckoo clock at 9 in the morning. How many hours will I sleep?", "Gece saat 8 de yatıyorum ve guguklu saatimi sabah 9'a kuruyorum. Kaç saat uyurum?" },
		{"The cuckoo clock won’t differentiate night and day, hence you will sleep for one hour.", "Guguklu saatler gece gündüz ayrımı yapmadığı için 1 saat uyursun" },
		{"Is the alarm a little bit early?", "Alarm biraz erken mi çaldı?" },
		//71
		{"With two fingers, swipe to the left on the screen and plug the phone into a socket. Then touch the cables at the same time.", "İki parmağınla ekranı sola kaydır ve telefonu prize tak. Sonrasında kablolara aynı anda dokun." },
		{"Be careful, don’t be shocked!", "Dikkat et sakın çarpılma!" },
		//72
		{"The wheel of the car is in one of the clouds. Put the cloud with your finger and shake it. Mount the wheel on the truck. Tilt the screen to the right. The truck will move across the street.", "Arabanın tekerleği bulutlardan birinin içinde. Bulutları parmağınla tut ve salla." },
		{"Do not ask why the rubber tire is over there.", "O lastik neden orda diye sorma. :)" },
		//73
		{"You should try to turn off the light with your finger.", "Işığın üstünü parmağınla kapatmayı denemelisin." },
		{"There would not be a more creative way.", "Daha yaratıcı bir çözüm olamazdı." },
		//74
		{"Choose 3 balls, verify the evenness!", "3 tane top seç ve eşitliği doğrula!" },
		{"Turn the 9 upside down and make it 6! 11+13+6: 30! That much easy!", "9'u ters çevirip 6 yap! 11+13+6 = 30! Bu kadar kolaydı." },
		{"We put the ball upside down, sorry.", "O topu ters koymuşuz pardon." },
		//75
		{"Which one is the heaviest?", "En Ağırı Hangisi?" },
		{"Lift both hammers and drop them at the same time to find out which one is the heaviest.", "İki çekicide kaldır, aynı anda bırak, hangisinin ağır olduğunu gör." },
		{"I congratulate your physics teacher.", "Fizik öğretmenini tebrik ediyorum." },
		//76 DON'T FORGET TO CHANGE PREFAB
		{"Drag the “fish” text over to the edge of the fishing hook.", "Balık yazısını oltanın ucuna götür." },
		{"Delicious.", "Denizden ne çıksa yerim." },
		//77
		{"Shake the drink and help the child drink it", "İçeceği karıştırıp çocuğa içir" },
		{"Hold the bottle shut with your finger, shake your phone, and give the bottle to the child.", "Şişenin ağzını parmağınla kapatarak telefonu salla ve çocuğa ver." },
		{"Shake before drinking!", "Çalkalamadan içmeyiniz." },
		//78
		{"Help the child to open the safe", "Çocuğun kasayı açmasına yardım et" },
		{"Turn the phone over and shake it. The key will fall out of the child’s pocket.", "Telefonu ters çevirip salla. Anahtar çocuğun cebinden düşecek." },
		{"What do you think inside of it?", "Acaba kasada ne var?" },
		//79
		{"Find the numbers on the balls", "Toplardaki sayıları bul" },
		{"148", "148" },
		{"Are you a math professor or something?", "Sen matematik profesörü müsün yoksa?" },
		//80
		{"Drag the screen towards the left and you will see the bird’s real shadow. (Use two fingers at the same time)", "Ekranı sola doğru sürükle, kuşun gerçek gölgesini göreceksin. (İki parmağını aynı anda kullan)" },
		{"I’m impressed… You’re fast.", "Etkilendim! çok hızlısın." },
		//81
		{"Clean the car", "Arabayı temizle" },
		{"You need to clean over the car with your finger.", "Arabayı parmağınla temizlemen lazım." },
		{"Sparkling clean.", "Tertemiz oldu." },
		//82
		{"Find the strongest balloon!", "En güçlü balonu bul!" },
		{"Drag the balloons over to the skip forward sign, 4 of them will pop! The strongest balloon won’t pop.", "İleri geç simgesine balonları sürükle, 4 tanesi patlayacak! Sağlam olan patlamayacak!" },
		{"You’re doing great.", "Çok iyi gidiyorsun!" },
		//83
		{"How many orange cubes do you need to cover the blue cube?", "Mavi küpü kapatmak için kaç tane turuncu küpe ihtiyaç var?" },
		{"22", "22" },
		{"That was a good one.", "Bak bu iyidi." },
		//84
		{"Flip the text with two fingers. Put it between the tap and the bucket.", "'Kovayı su ile doldur cümlesini' musluk ile kova arasına koy. İki parmağınla yazıyı çevir. Musluk ile kovanın arasına koy." },
		{"Bet you didn’t think of that one, did you?", "Bu hiç aklına gelmemişti değil mi?" },
		//85
		{"The baby will sleep if you put your phone down on the table face down.", "Telefonu masanın üstüne kapatarak koyarsan bebek uyur." },
		{"You’re the best at putting babies to sleep.", "bebeği uyutmada üstüne yok." },
		//86  DON'T FORGET TO CHANGE PREFAB
		{"What’s the size of the table?", "Masanın boyu nedir?" },
		{"You’re on a roll.", "Sanada soru dayanmıyor." },
		//87
		{"Try dispersing the soil by shaking your phone", "Telefonu sallayarak toprağı dağıtmayı denemelisin." },
		{"We’re covered in dirt.", "Toz toprak içinde kaldık." },
		//88
		{"Please help me find my dog in this mess", "Lütfen kargaşanın içinde köpeğimi bulmama yardım et" },
		{"You need to make the screen smaller. The dog is somewhere outside of the screen.", "Köpek ekranın dışında bir yerde. Ekranı küçültmelisin." },
		{"Thank you!", "Teşekkür ederim!" },
		//89
		{"Lift Thor’s hammer", "Thor'un çekicini kaldır" },
		{"The hammer is so heavy you will need to lift it with three fingers.", "Çekiç çok ağır olduğundan üç parmağın ile kaldırmalısın." },
		{"You’re even stronger than I thought!", "Tahmin ettiğimden güçlüymüşsün!" },
		//90
		{"Find the pairs and win the game", "Oyunu kazanmak için çiftleri bul" },
		{"Divide the last one remaining in half by drawing a line through the middle of it.", "Son kalan kutucuğun ortasından çizgi çekerek ikiye böl." },
		{"We make a good pair.", "İyi bir çift olduk." },
		//91
		{"Touch the cow’s head 10 times.", "İneğin kafasına 10 kere dokun." },
		{"The cow is a heavy sleeper.", "İneğin uykusu bayağı ağırmış." },
		//92
		{"Hey..!! What day of the month is it?", "Hey..!! Bugün ayın kaçı?" },
		{"Seriously, what day of the month is it? What number is the calendar on your phone showing?", "Cidden, bugün ayın kaçı? telefonunun takviminde hangi sayı gözüküyor?" },
		{"Sometimes I forget the date, too.", "Bazen bende ayın kaçı olduğunu unutuyorum." },
		//93
		{"You need to shake the tree a lot. The key will fall from it.", "Ağacı epey bir sallaman lazım. Anahtar düşecektir." },
		{"Whose idea was it to hide the key in a tree?", "Anahtarı ağacın içine koymak kimin fikriydi?" },
		//94  DON'T FORGET TO CHANGE PREFAB
		{"You can use the word “Balance” in the text to balance the scale.", "'Dengele' yazısını kullanarak teraziyi dengeleyebilirsin." },
		{"Are you balanced?", "Denge siz misiniz?" },
		//95
		{"If the bridge is falling apart, you need to support the middle of the bridge with your hand.", "Köprü yıkılıyorsa, köprünün ortasına parmağınla destek yapman lazım." },
		{"You’re the king of the road.", "Yolların kralısın." },
		//96
		{"It’s snowing! Catch the snow...", "Kar yağıyor! Yakala..." },
		{"Place your phone on a flat surface with the screen facing up and wait.", "Telefonunu ters çevirip, düz bir yüzeye koy ve bekle." },
		{"Become one with the snow.", "Bir kar tanesi ol." },
		//97
		{"Help him escape prison", "Hapisten kaçmasına yardım et" },
		{"You can escape by pressing the escape button after you unscrew the lightbulb.", "Ampulü söktükten sonra kaç butonuna basarak kaçabilirsin." },
		{"Smells like freedom!", "Özgürlük gibisi yok" },
		//98
		{"Park the car", "Arabayı park et" },
		{"There might be space further down the road.", "Biraz daha ileride boş yer olabilir." },
		{"Slowly… Slowly… Now park the car!", "Gel gel gel.... Hoop!" },
		//99
		{"You will catch the cheater if you move the front row.", "Eğer ön sırayı oynatırsan kopyacıyı yakalarsın." },
		{"Caught red-handed.", "Yine yakaladın kopyacıyı." },
		//100
		{"Help the child see!", "Çocuğun görmesine yardım et!" },
		{"Drag the two zeros in '100' to make glasses for the kid.", "'100' sayısındaki iki sıfırı tutup sürükleyip, çocuğa gözlük yap" },
		{"That’ll show you!", "Sen şimdi görürsün." },
		//101
		{"Which one would you save?", "Hangisini kurtarırsın?" },
		{"You need to press all three at the same time. Don’t try doing it one by one.", "Üçüne aynı anda basman lazım. teker teker deneme." },
		{"You are so single.", "Senin sevgilin yok ki hahaha." },
		{"Family", "Aile" },
		{"Love", "Sevgili" },
		{"Money", "Para" },
		//102
		{"The animals are racing. The cow, the rabbit, and the turtle. Help the turtle win", "İnek, tavşan ve kaplumbağ yarışıyor. Kaplumbağanın kazanmasına yardım et" },
		{"Drag the start button and hit the Turbo button underneath.", "'Başla' butonunu kaydır ve altında ki 'Turbo' butonuna bas." },
		{"Fast and furious.", "Hızlı ve öfkeli." },
		{"Start", "Başla" },
		//103
		{"The baby will sleep if you turn the volume down on your phone.", "Oyunun sesini kapatırsan bebek uykuya dalar." },
		{"Hush...", "Şşşş..." },
		//104
		{"What should be the next number in the sequence?", "Dizinin sonraki sayısı ne olmalıdır?" },
		{"Read the numbers you see out loud! The numbers are how the previous numbers sound when you read them together… '13112221'", "Gördüğün rakamları sesli bir şekilde oku! Rakamlar bir önceki sıradaki rakamların sesli okunuşu... '13112221'" },
		{"We’ll admit it was a hard question.", "Kabul ediyoruz bu zordu." },
		//105
		{"Help the truck pass through the tunnel", "Kamyonun tünelden geçmesine yardım et" },
		{"Shrink the truck with two fingers.", "Kamyonu iki parmağınla küçült." },
		{"Well done!", "Tebrikler!!" },
		//106
		{"If Mary gathers 2 bananas in 1 minute, how many bananas can she gather from this tree in 10 minutes?", "Ebru 1 dakikada 2 muz topluyorsa, 10 dakikada ağaçtan kaç muz toplar?" },
		{"Does it look like bananas grow on this tree? The answer is '0'", "Sizce muz bu ağaçta mı yetişir? Cevap '0'" },
		{"You’re quite smart.", "Baya zekisin." },
		//107 DON'T FORGET TO CHANGE PREFAB
		{"The match will be lit if you drag it and rub it over the word 'Light'.", "Kibriti 'Yak' kelimesinin üzerine getirip sürtersen yanar." },
		{"Don’t play with fire.", "Ateşle oynama." },
		//108
		{"List the numbers you see on the screen in order", "Ekranda gördüğün sayıları sırasıyla sırala" },
		{"At first, it started with 3, 2, 1, didn’t you see? 3, 2, 1, 32, 67, 21, 5, 14, 8", "İlk önce 3, 2, 1 ile başladı görmedin mi?" },
		{"I’m in awe of your visual memory!", "Görsel zekana hayran kaldım!" },
		//109
		{"Who is pregnant?", "Hangisi hamile?" },
		{"Turn your phone upside down and shake it. Drag the pregnancy test over to the woman on the right.", "Telefonunu baş aşağı tut ve salla. Düşen hamilelik testini sağdaki kadına sürükle." },
		{"Congratulations!", "Allah analı babalı büyütsün." },
		//110
		{"How many squares are there?", "Kaç tane kare var?" },
		{"Would it be 40?", "40 olabilir mi?" },
		{"It is 40!", "40 yapar!" },
		//111
		{"Make the man happy!", "Adamı mutlu et!" },
		{"Drag the man up over the clouds.", "Adamı bulutlara sürükle." },
		{"Being happy is that simple!", "Mutlu olmak aslında bu kadar basit!" },
		//112
		{"Sally is 21 years older than her son. 2 years ago, Sally was 4 times her son’s age. How old is Sally?", "Sevim oğlundan 21 yaş daha büyüktür. 2 yıl önce, Sevim'in yaşı oğlunun yaşının 4 katı idi. Sevim kaç yaşındadır?" },
		{"She is 31.", "31 yaşında." },
		{"What did you study in school?", "Sen ne mezunusun?" },
		//113
		{"Park the car in the right spot", "Arabayı doğru yere park et" },
		{"Drag the skirt off of the female symbol in the middle to make it appropriate for the driver.", "Ortadaki park yerindeki kadın sembolündeki eteği kaldır ve orayı adam için uygun bir park noktasına dönüştür." },
		{"Thought you’d never figure it out.", "Bir an hiç bulamayacaksın sandım." },
		//114
		{"That counts as a three-pointer.", "Bunu üçlükten sayıyoruz." },
		//115
		{"Did you try taking the light that won’t turn off out of the screen?", "Sönmeyen ışığı ekrandan çıkarmayı denedin mi?" },
		{"I love your sharp wit!", "Parlak zekana bayıldım!" },
		//116
		{"Save the gorilla :(", "Gorili kurtar :(" },
		{"You can use the hint key to unlock the lock.", "ipucu anahtarını kullanarak kilidini açabilirsin" },
		{"#FreedomForAnimals", "#HayvanlaraÖzgürlük" },
		//117
		{"What’s the fastest route from A to I?", "A'dan I'ya en hızlı yolu nedir?" },
		{"You need to swap B and I’s places.", "B ile I'nın yerini değiştirmelisin." },
		{"You’re so fast!", "Çok hızlısın!" },
		//118
		{"Burn everything", "Herşeyi yak" },
		{"Drag the magnifying glass between the sun and the wood to spark a fire. Then use the wood on the fire to burn everything. You can pass the level by burning everything including the 'Burn everything' text and the sun.", "Büyüteci güneş ile odun arasına getirerek odunu tutuştur, Yanan odun ile güneşi, büyüteci 'Her şeyi yak' yazısını, havluyu yak." },
		{"Time to call the fire station!", "Şimdi de iyfaiyeyi çağır." },
		//119
		{"2 of them are drowned, 4 of them are swimming, and 3 of them are dead. How many fish left in the aquarium?", "2 tanesi boğuldu, 4 tanesi yüzüyor, ve 3 tanesi öldü. Akvarumda kaç balık kaldı?" },
		{"Fish don’t drown in water. But even if they did, none of them would go out of aquarium hence, 10 fish will be left.", "Balıklar suda boğulmaz. Boğulsa bile akvarvumda durmaya devam ederler. Akvaryumda 10 balık kalır." },
		{"You are a real genius.", "Gerçekten zekisin." },
		//120
		{"You should try charging your own phone while the game is on.", "Oyun açık iken kendi telefonunu şarj et" },
		{"We gave you an excuse to charge your phone :)", "Telefonunu şarj etmen için sana fırsat verdik :)" },
		//121
		{"Put the fire out", "Ateşi söndür" },
		{"Squeeze the cloud with two fingers and make water spill to put out the fire.", "Bulutu iki parmağın ile sık ve suyun ateşin üzerine dökülmesini sağla." },
		{"It’s raining cats and dogs!", "Taşı sıksan suyunu çıkartırsın." },
		//122
		{"Find the pirate", "Korsanı bul" },
		{"Pirates have wooden legs. Try lifting their pant legs to see.", "Korsanları tahta bacağı vardır. Pantolonlarını kaldır ve bak." },
		{"Nice, the next question awaits.", "Güzel, bir sonraki soru seni bekliyor." },
		//123
		{"Complete the equation", "Denklemi tamamla" },
		{"Take the 1, 2, and 3 from “Lv. 123” and put them in the places of A, B, and C. That will complete the equation.", "'Lv.123'de ki 1, 2 ve 3'ü alıp A, B ve C nin yerlerine koy. Bu denklemi tamamlayacaktır." },
		{"You really surprised me.", "Beni gerçekten şaşırttın" },
		//124
		{"Defeat your competitor in Rock-Paper-Scissors game!", "Taş-Kağıt-Makas oynunda rakibini yen!" },
		{"You have to move to the winning side by relocating the players!", "Oyuncuların yerini değiştirerek kazanan tarafa geçmen lazım." },
		{"Or did you cheat?", "Yoksa hile mi yaptın?" },
		//125
		{"It’s 3:35. What time would it be if the clock moved counter-clockwise 90 degrees?", "Saat 3:35. Saat 90 derece saat yönünün tersine dönseydi kaç gösterirdi?" },
		{"Could it be 12:20?", "12:20 olabilir mi?" },
		{"Did you ask your friends what level they’re on?", "Arkadaşların hangi bölümdeler? Sordun mu?" },
		//126 DON'T FORGET TO CHANGE PREFAB
		{"Did you try to click on Europe text?", "Avrupa yazısına tıklamayı denedin mi?" },
		{"Bravo!", "Bravo!" },
		//127
		{"Make the bulbs explode by clicking on the lights 5 times", "Işıkların üzerine 5'er kere tıklayarak ışıkları patlat." },
		{"The lights are off alright...", "Kırdın kırdın..." },
		//128
		{"He broke the vase 10 minutes ago. Help him fix it", "10 dakika önce vazo kırıldı. Tamir etmesine yardım et" },
		{"The vase wasn’t broken 10 minutes ago. Try rewinding the clock.", "10 dakika önce vazo kırık değildi. Saati geriye almayı dene." },
		{"You just traveled through time.", "Biraz önce zamanda yolculuk yaptın." },
		//129
		{"Which tank would be filled first?", "Önce hangi tank dolar?" },
		{"Draw a line to A's drain. Thus, 'A' will be filled first.", "A'nın giderine bir çizgi çek. Böylece ilk 'A' dolacak." },
		{"Hmm, smart...", "Hmm, zekice..." },
		//130
		{"Shrink the building.", "Binayı küçült." },
		{"Kangaroo-lations!", "Kanguruculeyşıns." },
		//131 DON'T FORGET TO CHANGE PREFAB
		{"You should try turning the 9 in the question into a 6. Then you will have the right number of bananas.", "Sorudaki 9 rakamını 6'ya döndürmeyi denemelisin. O zaman muzların sayısı doğru olur." },
		{"Something’s not right about this.", "Bu işte bir terslik var." },
		//132
		{"What should fill the blank?", "Boşluğa ne gelmeli?" },
		{"Did you ever drive? This was car gear. Reverse gear 'R'...", "Anlamadın mı? Bu bir araba vitesiydi. Geri vites 'R'..." },
		{"Ok understood, you don’t have an 'R'.", "Anladık sende 'R' yok!" },
		//133
		{"How many 3's are there?", "Kaç tane üç var?" },
		{"There are five 3's including the ones in 'Lv.133' and the question.", "Lv.133'tekiler ve sorudakiyle birilikte 5 tane 3 var." },
		{"Good catch!", "İyi yakaladın!" },
		//134
		{"Shake the clouds and catch the fish with the worm under the tree.", "Bulutlari salla ve ağacın altındaki solucanla balığı tut..." },
		{"Hook, line, and sinker!", "Haydi rastgele!" },
		//135
		{"Help the truck pass through the tunnel!", "Kamyonun tünelden geçmesine yardım et!" },
		{"Deflate the truck’s wheels! You can use the 'Forward' symbol.", "Kamyonun tekerleklerini patlat! 'İleri' simgesini kullanabilirsin." },
		{"Wish we could give you a reward.", "Keşke sana ödül verebilseydik." },
		//136
		{"Make a square by moving 2 balls", "İki topu hareket ettirerek kare oluştur" },
		{"Wow!", "Wow!" },
		//137
		{"Turn off the lights", "Işıkları söndür" },
		{"You should try putting your phone upside down on the table, with the screen facing down. Then the light will go off.", "Ekranı masanın üzerine ters koymayı denemelisin. O zaman ışık söner." },
		{"That’s what we’re talking about.", "İşte istediğimiz hareket." },
		//138
		{"Turn the cow in the other direction before it reaches the soil.", "İneği toprağa gelmeden ters çevir." },
		{"Where there’s a will, there’s a way.", "Her zaman bir yol vardır." },
		//139
		{"Speed up the clock and reveal the pregnant woman.", "Saati hızlandır ve hamile kadını ortaya çıkar." },
		{"Time flies...", "Zaman su gibi geçti..." },
		//140
		{"Take the key on the upper right corner of the screen and drag it onto the door to pass the level.", "Ekranın sağ üstündeki anahtarı alıp, sürükleyip kapının kilidine bırakınca kapı açılacaktır." },
		{"We couldn’t trick you...", "Seni kandıramadık..." },
		//141
		{"Leave me alone for a bit...", "Beni bir süre yalnız bırak..." },
		{"Leave the game, wait a couple of seconds, and re-enter the game.", "Oyundan çık, 1-2 saniye bekle ve tekrar oyuna gir..." },
		{"Thank you for understanding.", "Anlayışın için teşekkür ederim." },
		//142
		{"Hold the basketball with your finger and slam dunk!", "Parmağınla topu tut ve potaya smaç bas." },
		{"A great slam dunk.", "Harika bir smaç!" },
		//143
		{"Catch person who is cheating!", "Kopya çekeni yakala" },
		{"Try lifting the child’s hat who is at the right.", "Sağ üstteki çocuğun şapkasnı kaldırmayı dene." },
		{"You are not missing a thing.", "Gözünden bir şey kaçmıyor." },
		//144
		{"Help an old lady cross the road", "Yaşlı kadının karşıya geçmesine yardım et" },
		{"One of the trucks has a green light in its truck bed. You need to put it in the right spot.", "Kamyonun birinin kasasında yeşil ışık var. Onu doğru yere koymalısın." },
		{"Thank you for your help!", "Yardımın için teşekkürler!" },
		//145
		{"What is the result of the calculation?", "İşlemin sonucu nedir?" },
		{"The result of the calculation is '-62'.", "İşlemin sonucu -62 dir." },
		{"The social science people are now crying.", "Sözelcilerin gözü yaşlı" },
		//146
		{"Gather the stones upstream and stop the water. Drag the net over the fish.", "Taşları yukarı doğru topla balığın geçmesini engelle ve ağ ile balığı yakala." },
		{"The fish jumps once jumps twice...", "Balık bir sıçrar, iki sıçrar..." },
		//147
		{"Shrink down the fire!", "Ateşi küçült" },
		{"Shake the phone, let the fire disperse and choose the smaller one!", "Telefonu salla, ateş dağılsın, küçüğünü seç!" },
		{"Did you try to snuff it out?", "Söndürmeye mi çalıştın yoksa?" },
		//148
		{"Find the password!", "Şifreyi bul!" },
		{"'042' Think again... You can also ask a friend.", "042 yazmayı denedin mi?" },
		{"If you found this as well, you should be proud of yourself!", "Bunu da bulduysan, kendinle gurur duyabilirsin." },
		{"A number and it's place are correct", "Bir rakam ve yeri doğru" },
		{"A number is correct but it's place is wrong", "Bir rakam doğru ama yeri yanlış" },
		{"Two numbers are correct but the places are wrong", "İki rakam doğru ama yerleri yanlış" },
		{"Nothing is correct", "Hiç bir şey doğru değil" },
		{"ENTER", "GİR" },
		//149
		{"Weigh the chicken", "Tavuğu tart" },
		{"Shake the chicken to make its eggs fall out and make it lighter.", "Tavuğu sallayarak yumurtalarını düşür ve tavuğu zayıflat." },
		{"I’m light as a feather.", "Kuş gibi hafifledim." },
		//150
		{"Is it too quiet here?", "Buralar çok sessiz değil mi sence de?" },
		{"A little music wouldn't be bad.", "Biraz müzik fena olmazdı sanki." },
		{"Music is the essence of the soul ;)", "Müzik ruhun gıdasıdır ;)" },
		//151
		{"Take the ball outside!", "Topu dışarı çıkar." },
		{"Pour water from the dispenser size bottle to the glass and pour it into the pipe. Let the ball go up.", "Damacanadan bardağa su doldur, onu boruya dök su dolsun ve top yukarı çıksın." },
		{"You discovered the buoyant force of the water.", "Suyun kaldırma kuvvetini keşfettin!" },
		//152
		{"Score a goal.", "Gol at." },
		{"Try to press two arrows at the same time.", "İki ok'a aynı anda basmaya çalış." },
		{"Gooaal!..!!", "Goooooool!..!!" },
		//153
		{"Make the baby laugh.", "Bebeği güldür." },
		{"Take off the baby's socks and tickle the baby's feet with a feather.", "Bebeğin çorabını çıkart ve tüy'le bebeğin ayağını gıdıkla." },
		{"The world is better when babies laugh.", "Bebekler gülünce dünya daha güzel." },
		//154
		{"Bring the child to the exit", "Çocuğu çıkışa ulaştır" },
		{"Turn your phone over and watch the child.", "Telefonunu ters çevir ve çocuğu izle." },
		{"Did you send the game to your friends? Now, send it from the share button below.", "Oyunu arkadaşlarına gönderdin mi? O zaman hemen alttaki paylaş butonundan gönder." },
		//155
		{"The child is so lonely", "Çocuk çok yalnız" },
		{"Hold on the child with your finger for 5 seconds and then, copy the child.", "Çocuğun üzerine parmağınla 5 saniye basılı tut ve çocuğu kopyala." },
		{"Now, they are twins.", "İkiz kardeş oldular." },
		{"Copy", "Kopyala" },
		{"Rate the game", "Oyunu değerlendirin" },
		//156
		{"Please click in the following order", "Doğru sıraya göre tıkla" },
		{"Are you sure you did the right thing? Watch out for the last finger.", "Doğru tıkladığına emin misin? En sondaki parmağa dikkat et." },
		{"That's it!", "İşte bu kadar!." },
		//157
		{"Silence the child", "Çocuğu sustur" },
		{"The toy is hidden under the button. Give it to the child.", "Butonun altında oyuncak gizli. Oyuncağı çocuğa ver." },
		{"It's really awesome.", "Müthiş oldu gerçekten." },
		{"Watch video", "Video izle" },
		//158 DON'T FORGET TO CHANGE PREFAB
		{"Unlock the case.", "Kasanın kilidini kaldır." },
		{"Take the word ‘password’ to the correct place.", "Şifreyi gir yazısındaki 'şifre'yi doğru yere götür." },
		{"Is it difficult?", "Zor muydu?" },
		//159
		{"Grab the gift box on the daily bonus button and give it to the man. The man will be happy to receive a gift.", "Günlük bonus'taki hediye kutusunu tut ve adama ver. Adam hediye aldığına mutlu olacaktır." },
		{"Who recently bought you a gift?", "Sana en son kim hediye aldı?" },
		//160
		{"What does the child see?", "Çocuk ne görüyor." },
		{"Try to look at from the perspective of the child.", "Birde çocuğun açısından bakmaya çalış." },
		{"It's all about perspective!", "Perspektifin mükemmel." },
		//161 DON'T FORGET TO CHANGE PREFAB
		{"One of the X's can be moved. Remove X and replace it with the dot in the question.", "X'lerden biri yerinden oynatılabiliyor. X'i kaldır ve yerine sorudaki noktayı koy." },
		{"You are true genius!", "Sana da bulmaca dayanmıyor." },
		//162
		{"Make the girl fall in love with the boy", "Kızı çocuğa aşık et" },
		{"Shake the child quite a while. Maybe he is hiding a surprise gift.", "Çocuğu uzunca salla. Belki sürpriz bir hediye saklıyordur." },
		{"You're the last single person in the world.", "Bir sevgilisi olmayan sen kaldın." },
		//163 DON'T FORGET TO CHANGE PREFAB
		{"Try to use the word 'Truck'.", "Kamyonu' kelimesini kullanmayı dene." },
		{"Poor truck.", "Kamyonun başına gelmeyen kalmadı." },
		//164
		{"Find the water for kids to make a water fight.", "Çocukların su savaşı yapması için onlara su bul." },
		{"Hold both clouds with your fingers at the same time shake your phone.", "İki bulutuda aynı anda parmaklarınla tut ve telefonunu salla." },
		{"May the best man win!", "Dostluk kazansın." },
		//165
		{"Shout and Say 'MOM'", "Anne' diye bağır" },
		{"The level will be passed when you click the start button 4 times and fill the bar. You must allow microphone access, or enable Phone Settings > Apps > Trick Me > Permissions > Microphone option.", "4 kere başlaya basıp ortadaki barı doldurduğunda bölüm geçilecek. 'Anne'. Mikrofon erişimine izin vermeli veya Telefon Ayarları > Uygulamalar > Trick Me > İzinler > Mikrofon seçeneğini etkinleştirmelisiniz." },
		{"What did you mom say?", "Annen ne dedi?" },
		//166
		{"Find a frame for these colored objects.", "Renkli objeleri her birini sadece bir çerçeveye yerleştir" },
		{"I said find 'a frame' for these colored objects. :)", "Sadece bir tane çerçeve içine yerleştir diyorum :)" },
		{"You are amazing!", "Bu kadar hızlı geçeceğini düşünmemiştim." },
		//167
		{"Do something to end the war.", "Bu savaşı bitirmek için bir şey yap." },
		{"If you shoot at the right place, the war is over.", "Doğru yere ateş edersen savaş biter." },
		{"#worldpeace", "#dünyabarışı" },
		//168
		{"Find the ball?", "Topu bul?" },
		{"To make 'x10' 'x1', delete '0' using your finger.", "x10'un x1 Olmasını sağla, '0'ı Parmağını kullanarak sil." },
		{"A++++++", "A++++++" },
		//169
		{"After the game has started, you must turn the child left using your finger.", "Oyun başladıktan sonra parmağını kullanarak çocuğu sola çevirmelisin." },
		{"Nobody could pass this level except you.", "Bu bölümü senden başka geçen olabilir mi?" },
		//170
		{"Hit the man's head and knock the man out. Then, shoot the ball.", "Adamın kafasına vurarak adamı bayılt ve şut çek." },
		{"Incredible goal!", "İnanılmaz bir şut." },
		//171
		{"Grasp the first car with two fingers and remove it draggingly. Then, park your car in its place.", "En baştaki arabayı iki parmağınla tutup sürükleyerek yerinden kaldır ve arabanı onun yerine park et." },
		{"Nice job!", "Bölüm Sonu: Güzel park ettin." },
		//172
		{"One of the L's in Lvl is big and the other small.", "Lvl'deki L'ler biri büyük biri küçük. O'da bir fark..." },
		{"You can think differently...", "Çok farklı düşünebiliyorsun..." },
		//173 DON'T FORGET TO CHANGE PREFAB
		{"Enter password", "Şifreyi gir." },
		{"Try zooming your screen a few times.", "Ekranını bir kaç kere yakınlaştırmayı dene." },
		{"You're very good!", "Çok iyiydin." },
		//174
		{"Behind one of the windows.", "Pencerelerden birinin arkasında." },
		{"Don't lie, you're a gamer, too.", "Sende mi gamer'sın." },
		//175
		{"Grab the small key on watch video button and drag it to the door.", "Video izleme butonunun üzerindeki küçük anahtarı tutup kapıya sürükle." },
		{"Amazing!", "Fevkalade." },
		//176
		{"Hi, we’re still working on new levels. Stay tuned for the next update.", "Selam, yeni bölümlerin yapımına başladık bile. Bir sonraki güncellemeye kadar takipte kalın :)" },
		{"", "" }
    };
    public static Dictionary<string, string> ESP = new Dictionary<string, string>()
    {
		{"EN", "ESP" },
		//GENERAL UI ELEMENTS
		{"7.99USD", "7.99EUR" },
		{"Don't show again.", "No mostrar de nuevo." },
		{"You have to turn the phone's rotating feature on.", "Tienes que activar la función giratoria del teléfono." },
		{"RESTORE", "RESTAURAR" },
		{"Restore Purchases", "Restaurar compras" },
		{"COMING SOON...", "PRÓXIMAMENTE..." },
		{"COME AGAIN TOMORROW!", "¡VUELVA A MAÑANA!" },
		{"3 days free", "3 días gratis" },
		{"AND...", "Y..." },
		{"BECOME VIP!", "HAZTE VIP!" },
		{"CONGRATULATIONS!!!", "FELICIDADES!!!" },
		{"Daily Bonus", "Bonus Diario" },
		{"Double daily bonus", "Doble bono diario" },
		//ANDROID EXPLANATION
		//Weekly Premium automatically renews. Payment will be charged to your Google account at the end of the trial period of purchase. The subscription automatically renews unless auto-renews unless auto-renew is turned off at least 24 hours before the end of the current period. You can manage and turn off auto-renewal of the subscription by going to your account settings on the Google Play after purchase.
		//IOS EXPLANATION
		//Weekly Premium automatically renews. Payment will be charged to your iTunes account at the end of the trial period of purchase The subscription automatically renews unless auto-renews unless auto-renew is turned off at least 24 hours before the end of the current period. You can manage and turn off auto-renewal of the subscription by going to your account settings on the iTunes after purchase.
		{"Feedback", "Realimentación" },
		{"Free", "Gratis" },
		{"Game Reset", "Restablecer Juego" },
		{"Hint discounts", "Pista de descuentos" },
		{"INSTANTLY", "INSTANTÁNEAMENTE" },
		{"All Levels", "Todos los Niveles" },
		{"Music", "Música" },
		{"Next", "Próximo" },
		{"Nice start...", "Buen comienzo..." },
		{"Privacy Policy", "Política de privacidad" },
		{"PRIVACY POLICY", "POLÍTICA DE PRIVACIDAD" },
		{"Rate", "Velocidad" },
		{"remove ads", "quitar anuncios" },
		{"Remove ads", "Quitar anuncios" },
		{"Remove Ads", "Quitar Anuncios" },
		{"Share", "Compartir" },
		{"Skip discounts", "Omitir descuentos" },
		{"Skip", "Omitir" },
		{"Skipping costs 2 keys. Would you like to skip?", "Saltar cuesta 2 llaves. ¿Te gustaría saltar?" },
		{"Sounds", "Suena" },
		{"Store", "Tienda" },
		{"TERMS OF USE", "TÉRMINOS DE USO" },
		{"Terms of Use", "Términos de Uso" },
		{"TRY FOR FREE!", "¡PRUEBA GRATIS!" },
		{"Vibration", "Vibraciòn" },
		{"Watch", "Reloj" },
		{"Weekly", "Semanal" },
		//PREFABS
		{"Exit", "Salida" },
		{"OK", "OKAY" },
		{"Fire", "Fuego" },
		{"FINISH", "TERMINAR" },
		{"RUN", "CORRER" },
		{"CLEAR", "CLARO" },
		{"START", "COMIENZO" },
		{"JUMP", "SALTAR" },
		{"Write your answer", "Escribe tu respuesta" },
		//LEVELS
		//1
		{"Which one is red?", "¿Cuál es el rojo?" },
		{"Or you didn't click on the red text?", "¿O no has hecho clic en el texto rojo?" },
		{"Good start.", "Buen comienzo." },
		{"Green", "Verde" },
		{"Yellow", "Amarilla" },
		{"Blue", "Azul" },
		{"Red", "Rojo" },
		//2
		{"Shoot the basketball into the hoop", "Lanza la pelota de baloncesto al aro" },
		{"You need to press the shoot button when it reaches green in order to shoot.", "Tienes que apretar el botón de lanzar cuando llegue a verde para poder lanzar..." },
		{"Nice shot.", "Buen tiro." },
		{"Shoot", "Disparar" },
		//3
		{"Throw everything away", "Tira todo a la basura" },
		{"You should drag-and-drop pizza, cheese, ice-cream and cactus to the trash.", "Arrastre la pizza, el queso, el helado y el cactus a la basura y tírelo a la basura." },
		{"Cleaning is important, of course...", "La limpieza es importante, por supuesto..." },
		//4
		{"Find the different one", "Encuentra otra diferente" },
		{"Could it be under the ice-cream? Look at it.", "¿Podría estar debajo del helado? Míralo." },
		{"I guess someone likes a different kind of ice-cream :)", "Supongo que a alguien le gusta un tipo diferente de helado :)" },
		//5
		{"Which one is the biggest drop?", "¿Cuál es la gota más grande?" },
		{"Put the drops on top of each other and create the largest one.", "Pon las gotas una encima de otra y crea una más grande." },
		{"Many a mickle makes a muckle...", "Muchos pocos hacen un mucho..." },
		//6
		{"Did you try covering the lamp with your hand?", "¿Intentaste cubrir la lámpara con tu mano?" },
		{"You managed to help the baby sleep again. Zzz...", "Te las arreglaste para ayudar al bebé a dormir otra vez. Zzz..." },
		//7
		{"How many points do you give to this game?", "¿Cuántos puntos le das a este juego?" },
		{"I think you liked it very much.", "Creo que te gusto mucho." },
		{"Since you loved it so much, let’s continue!", "Como te ha gustado tanto, ¡continuemos!" },
		{"Waste of time", "Pérdida de tiempo" },
		{"I couldn't figured it out", "No pude entenderlo" },
		{"It's OK", "Está bien" },
		{"It's nice", "Es agradable" },
		{"I liked it very much!", "¡Me gusto mucho!" },
		//8
		{"Make the baby sleep", "Haz que el bebé se duerma" },
		{"Firstly, you should give the bottle and then try to put the baby to sleep in his/her car.", "Primero, deberías darle el biberón y luego intentar dormir al bebé en su coche." },
		{"Rub-a-dub-dub... Zzz...", "Rub-a-dub-dub... Zzz..." },
		//9
		{"Balance the scale", "Equilibra la balanza." },
		{"If you take everything off, the scale would be even.", "Si quitas todo, la balanza estaría equilibrada." },
		{"I know you are a balanced person.", "Sé que eres una persona equilibrada." },
		//10
		{"One of the girls looking at the West, the other is to the East. But both of them can see each other, how can you do that?", "Una de las chicas está mirando al Oeste, la otra está mirando al Este. Pero ambas pueden verse, ¿cómo se puede hacer eso?" },
		{"You should move the girls’ head as to be turned as face-to-face.", "Deberías mover la cabeza de las chicas para que se giren para que estén cara a cara." },
		{"I see you’re getting used to it.", "Veo que te estás acostumbrando." },
		//11
		{"Open the door", "Abre la puerta" },
		{"You need to use the key in the child's pocket in order to open the door.", "Tienes que usar la llave que está en el bolsillo del niño para abrir la puerta." },
		{"Yeah, that’s it ;)", "Sí, eso es todo ;)" },
		//12
		{"Stop the fight..!!", "¡¡Detén la pelea!!" },
		{"You can stop the fight when you split the bone in two and give it to the dogs.", "Puedes detener la pelea cuando partas el hueso en dos y se lo des." },
		{"Fifty-fifty ;)", "Cincuenta-cincuenta ;)" },
		//13
		{"Help the tree shed its leaves", "Ayuda al árbol a deshacerse de sus hojas." },
		{"Paint the tree yellow with the paint bucket.", "Pinta el árbol de amarillo con el balde de pintura." },
		{"You’re doing great!", "¡Lo estás haciendo muy bien!" },
		//14
		{"Catch the fish!", "¡Atrapa el pez!" },
		{"The fish is hidden between the waves. Move the waves.", "El pez está escondido entre las olas. Mueve las olas..." },
		{"That move seems familiar...", "Ese movimiento me parece familiar..." },
		//15
		{"Fill the bucket with water", "Llena el balde con agua" },
		{"Try to turn the phone. You will see that the direction of water will change.", "Intenta girar el teléfono. Verás que la dirección del agua cambiará." },
		{"Nature will take its course.", "La naturaleza seguirá su curso." },
		//16
		{"Help the man lose weight", "Ayuda al hombre a perder peso" },
		{"Hold the man with your finger, drag him to the left and right 4 times and make him lose weight.", "Sostén al hombre con el dedo, arrástralo a la izquierda y a la derecha 4 veces y hazle perder peso." },
		{"He’s skin and bones.", "Es piel y huesos." },
		//17
		{"Feed the hay to the cow", "Alimenta a la vaca con el heno" },
		{"Didn't you see the shovel behind the hay? You can open a way with it.", "¿No viste la pala detrás del heno? Puedes abrir un camino con ella." },
		{"Now it’s time to eat.", "Ahora es hora de comer." },
		//18
		{"Find the 10 differences", "Encuentra las 10 diferencias." },
		{"What’s important is making a difference :)", "Lo importante es hacer la diferencia :)" },
		//19
		{"Clean the page!", "¡Limpia la página!" },
		{"You can clean it by hovering over it with your finger.", "Puedes limpiarla pasando el dedo por encima de ella." },
		{"Did you try to use a rubber? Hahaha", "¿Intentaste usar una goma? Jajaja" },
		//20
		{"Which one is soda?", "¿Cuál es la gaseosa?" },
		{"Shake the phone, sparkle it and find the soda!", "¡Agita el teléfono, hazla burbujear y encuentra la gaseosa!" },
		{"You will fizz like blup blup blup xD", "Vas a burbujear blup blup blup xD" },
		//21
		{"Find the gamer", "Encuentra al gamer" },
		{"A true gamer never sleeps.", "Un verdadero gamer nunca duerme." },
		{"Gamers don’t sleep. You can find the gamer by clicking on the only window in the apartment where the light is on.", "Los gamers no duermen. Puedes encontrar al jugador haciendo clic en la única ventana del apartamento donde está la luz encendida." },
		//22
		{"How many hairs does the child have?", "¿Cuántos pelos tiene el niño?" },
		{"If you lift the child’s wig, you will see how many of the real hair is.", "Si levantas el peluquín del niño, verás cuánto pelo realmente es." },
		{"If you could count all the hair, please contact us. :)", "Si pudiste contar todo el pelo, por favor contáctanos :)" },
		//23
		{"Please charge the phone", "Por favor, carga tu teléfono." },
		{"Have you ever tried touching the cables at the same time with your two fingers?", "¿Alguna vez has intentado tocar los cables al mismo tiempo con tus dos dedos?" },
		{"I'm taking a shine from you.", "Bien hecho, está mejor." },
		//24
		{"If the hunter shots 2 of the birds, how many birds left at the branch?", "Si el cazador le dispara a 2 de los pájaros, ¿cuántos quedan en la rama?" },
		{"'0' There would not be any birds left, all of them scared and flew away.", "'0' No quedaría ningún pájaro, todos se asustaron y se fueron volando." },
		{"Well done the hunter, he shot 2 birds at the same time.", "Bien hecho, el cazador les disparó a 2 pájaros al mismo tiempo." },
		//25
		{"Pop the balloons!", "¡Revienta los globos!" },
		{"Scare the hedgehog and pop the balloons with its spines!", "¡Asusta al erizo y revienta los globos con sus espinas!" },
		{"Boooooommmmm!", "Boooooommmmm!" },
		//26
		{"Reach the animal to the exit by using arrows", "Lleva al animal a la salida con las flechas" },
		{"You should wander around before entering the maze.", "Deberías dar una vuelta antes de entrar en el laberinto." },
		{"All great minds think alike.", "Todas las grandes mentes piensan igual." },
		//27
		{"How many letters left in alphabet if you take the letters of “a” and “b” out?", "¿Cuántas letras quedan en el alfabeto si sacas las letras “a” y “b”?" },
		{"There will be 6 letters left if you take a and b out from alphabet word.", "Quedarían 6 letras si sacas la “a” y la “b” de la palabra 'alfabeto'." },
		{"Do you think that your friends can solve this question?", "¿Crees que tus amigos puedan resolver esta pregunta?" },
		//28
		{"How many flies are there?", "¿Cuántas moscas hay?" },
		{"Enlarge the poop in the back and count the flies over it.", "Agranda la caca de atrás y cuenta las moscas que hay sobre ella." },
		{"Flies resides in the details.", "Las moscas se encuentran en los detalles." },
		//29 DON'T FORGET TO CHANGE PREFAB
		{"Try to drag the “sleep” word over the baby...", "Intenta arrastrar la palabra “duerme” hacia el bebé..." },
		{"It would be perfect if it was that easy to put babies in sleep in real life.", "Sería perfecto si fuera tan fácil dormir a los bebés en la vida real." },
		//30
		{"Try to close the cow's nose. Look at it, will it wake up?", "Intenta tapar la nariz de la vaca. Mírala, ¿se despertará?" },
		{"Almost drowning.", "Casi se ahoga." },
		//31
		{"Save the ship from crashing into the iceberg", "Salva al barco de estrellarse contra el iceberg" },
		{"Try melting the iceberg by rubbing it with your finger.", "Intenta derretir el iceberg frotándolo con el dedo." },
		{"The Titanic would have sunk.", "El Titanic se habría hundido." },
		//32
		{"Cross the truck across the bridge", "Cruza el camión por el puente" },
		{"Try to lift the bridge from the top with your finger.", "Intenta levantar el puente desde arriba con el dedo." },
		{"Honk honk!", "Honk honk!" },
		//33
		{"Which one is edible?", "¿Cuál es comestible?" },
		{"What you think of as diamond and poop is actually cone and ice cream. Drag the cone under the ice cream.", "Lo que piensas que es un diamante y caca es en realidad un cono y un helado. Arrastra el cono debajo del helado." },
		{"I wish they were here.", "Ojalá estuvieran aquí..." },
		//34
		{"What would the result be if we multiply all the numbers with each other?", "¿Cuál sería el resultado si multiplicamos todos los números entre sí?" },
		{"What would the result be if you multiply a number with zero?", "¿Cuál sería el resultado si se multiplica un número por cero?" },
		{"You cannot ignore the zero...", "No puedes ignorar el cero." },
		//35
		{"Do the right move to win the game!", "¡Haz el movimiento correcto para ganar el juego!" },
		{"Touch the sides of 'O' in the middle, at the same time with 2 fingers!", "Toca los lados de la “O” en el medio, ¡al mismo tiempo con 2 dedos!" },
		{"Good strategy.", "Buena estrategia." },
		//36
		{"How would you empty the bathtub fastly?", "¿Cómo vaciarías la bañera rápidamente?" },
		{"Didn't you try to remove the stopper from the tub? You should try it right now.", "¿No intentaste quitar el tapón de la bañera? Deberías intentarlo ahora mismo." },
		{"Your friends will have difficulty in solving this question!", "¡Tus amigos tendrán dificultades para resolver esta pregunta!" },
		//37
		{"Turn the child over by using two fingers and shake. The key will fall out of the child’s pocket.", "Dale la vuelta al niño con dos dedos y sacúdelo. La llave se caerá su bolsillo." },
		{"Successful!", "¡Exitoso!" },
		//38
		{"Find the real shadow of the bird", "Encuentra la verdadera sombra del pájaro" },
		{"If you drag the sun over the bird, the bird will have a shadow.", "Si arrastras el sol sobre el pájaro, el pájaro tendrá una sombra." },
		{"You are great.", "Eres genial." },
		//39
		{"Some months take 30, some take 31; how many months have 28 days?", "Algunos meses tienen 30, otros 31; ¿cuantos meses tienen 28 días?" },
		{"Each month has 28 days.", "Cada mes tiene 28 días." },
		{"It’s that simple.", "Es así de sencillo." },
		//40
		{"Do not explode the bomb!", "¡No explotes la bomba!" },
		{"The bomb will not explode already, just wait for 30 seconds.", "La bomba no va a explotar aún, sólo espera 30 segundos..." },
		{"How impatient you are.", "Qué impaciente eres." },
		//41 DON'T FORGET TO CHANGE PREFAB
		{"You should hang the word of “Man” in the question.", "Deberías colgar la palabra 'hombre' en la pregunta." },
		{"Rest in peace.", "Descanse en paz." },
		//42
		{"Wake up the cow", "Despierta a la vaca" },
		{"If you take the moon off the screen, the sun rises and the cow wakes up.", "Si quitas la luna de la pantalla, el sol sale y la vaca se despierta." },
		{"How can you sleep that much?", "¿Cómo puedes dormir tanto?" },
		//43
		{"Press the orange circle 10 times, then press the blue circle once", "Presiona el círculo naranja 10 veces, luego presiona el círculo azul una vez." },
		{"Are you sure that you pressed 10 times? Because the number starts from 1.", "¿Estás seguro de haberlo presionado 10 veces? Porque los números comienzan desde el 1." },
		{"Or did you press 9 times? We said 10...", "¿Presionaste 9 veces? Dijimos 10 veces..." },
		//44
		{"Find the couples and win the game", "Encuentra las parejas y gana el juego" },
		{"Shrink your screen, you will see your other mate.", "Si reduces la pantalla, verás a tu otra pareja." },
		{"You did a good job.", "Hiciste un buen trabajo." },
		//45
		{"How this equation becomes correct?", "¿Cómo esta ecuación se hace correcta?" },
		{"Use the number of 45 in the Lv.45 to create 4550 number.", "Utiliza el número 45 del Nivel 45 para crear el número 4550." },
		{"You are a true genius.", "Eres un verdadero genio." },
		//46
		{"Confirm evenness by moving the single matchstick!", "¡Confirmen la uniformidad moviendo un único fósforo!" },
		{"Move the number of 4's matchstick and get 2 pieces of 1! 311+89=400", "¡Mueve el número de fósforos del 4 y consigue 2 piezas de 1! 311+89=400" },
		{"Did you know that the match was invented after the lighter?", "¿Sabías que el fósforo fue inventado después del encendedor?" },
		//47
		{"Make all of it green!", "¡Haz que todo sea verde!" },
		{"First of all, shake the phone, then put the chameleon on the grass, and then paint the question with the paint bucket. Don't forget to remove the clouds from the screen.", "Primero que nada, agita el teléfono, luego pon el camaleón en el césped, y luego pinta la pregunta con el balde de pintura. No olvides sacar las nubes de la pantalla." },
		{"How the greens will smile if the clouds do not cry?", "¡Excelente idea!" },
		//48
		{"If 5 squirrels eat 5 walnuts in 5 minutes, in how many minutes does 15 squirrels eat 15 walnuts?", "Si 5 ardillas se comen 5 nueves en 5 minutos, ¿en cuántos minutos 15 ardillas se comen 15 nueces?" },
		{"In 5 minutes.", "En 5 minutos." },
		{"Aren’t those squirrels so sweet?", "¿No son tiernas esas ardillas?" },
		//49 DON'T FORGET TO CHANGE PREFAB
		{"Drag the word 'Protect' on to the rocket.", "Arrastra la palabra 'Protege' al cohete." },
		{"Power shields are now activated.", "Los escudos de energía están activados ahora." },
		//50
		{"You should win the game again", "Deberías ganar el juego de nuevo." },
		{"Use 0 in the 50 words. Hold and drag it to the middle of O and press the other side.", "Usa el 0 en las 50 palabras. Sostenlo y arrástralo hasta el centro de la O y presiona el otro lado." },
		{"You know it.", "Lo sabes." },
		//51
		{"Pizza, ice-cream, cheese, cactus, 'Throw everything away' text and you should throw away the cap of the trash.", "La pizza, el queso, el helado, el cactus, el texto 'Tira todo a la basura' y deberías tirar la tapa de la basura." },
		//52
		{"How many rings are there on the screen?", "¿Cuántos anillos hay en la pantalla?" },
		{"We hid 4 of them under the Clean button. '22'", "Escondimos 4 de ellos bajo el botón de Limpiar. '22'" },
		{"Nothing can escape from you.", "Nada se te puede escapar." },
		//53
		{"Collect 5 mice like in the picture", "Recoge 5 ratones como en la foto." },
		{"Just click to the mouse in the left direction and do not forget the mouse in the example.", "Sólo tienes que hacer clic con el ratón en la dirección de la izquierda y no te olvides del ratón en el ejemplo." },
		{"You are a good hunter!", "¡Eres un buen cazador!" },
		//54
		{"How can the kangaroo jump higher than the building?", "¿Cómo puede el canguro saltar más alto que el edificio?" },
		{"Make the trampoline bigger!", "¡Haz el trampolín más grande!" },
		{"Bounce bounce bounce...!", "¡Rebota, rebota, rebota...!" },
		//55
		{"Bring the magnifier to the child's arm on the lower left. You will see the replica.", "Lleva la lupa al brazo del niño en la parte inferior izquierda. Verás la réplica." },
		{"You’ve got him.", "Lo tienes." },
		//56
		{"Which one is the prettiest?", "¿Cuál es la más bonita?" },
		{"Drag the boy in front of the girl, whichever one he smiles at is the prettiest.", "Arrastra al chico delante de la chica, a la que le sonría es la más bonita." },
		{"Love at first sight.", "Amor a primera vista!" },
		//57
		{"You should rub the baby’s belly and let the gas out.", "Deberías frotar la barriga del bebé y dejar salir el gas." },
		{"Ops the baby has gas.", "Ups, el bebé tiene gases." },
		//58 DON'T FORGET TO CHANGE PREFAB
		{"You should clean it by using the word 'Clean' in the question.", "Deberías limpiarla usando la palabra “Limpia” en la pregunta." },
		{"I accept it was bad.", "Acepto que fue malo." },
		//59
		{"Get the number of 100 twice by using a single line from the number of 188", "Consigue el número 100 dos veces usando una sola línea del número 188." },
		{"Divide the number of 188 horizontally. You will have 2 of 1, 4 of 0.", "Divide el número 188 horizontalmente. Tendrás dos 1 y cuatro 0." },
		{"Wooww, you are super.", "Vaya, eres genial." },
		//60
		{"To drop an apple from the tree, you must shake the tree very much. Shake the phone.", "Para dejar caer una manzana del árbol, debes sacudir mucho el árbol. Agita el teléfono." },
		{"Did this cow discover gravity?", "¿Esta vaca descubrió la gravedad?" },
		//61
		{"Turn the light off", "Apaga la luz." },
		{"Turn off the screen towards the table. The light will go off.", "Apaga la pantalla hacia la mesa. La luz se apagará." },
		{"Where were we?", "¿En qué estábamos?" },
		//62
		{"Bring the pen into the empty space", "Lleva el bolígrafo hacia el espacio vacío." },
		{"One of the objects below can be rotated. Find the rotating pen and put it back correctly.", "Uno de los objetos de abajo se puede girar. Encuentra el bolígrafo giratorio y devuélvelo correctamente." },
		{"The pen is mightier than the sword.", "El bolígrafo es más poderoso que la espada." },
		//63
		{"Feed the dog with the food under the box and wait for it to poop. Take the key that comes with the poop to the door.", "Alimenta al perro con la comida debajo de la caja y espera que haga caca. Lleva la llave que viene con la caca a la puerta." },
		{"Sweet little doggie.", "Dulce perrito." },
		//64
		{"Solve the problem!", "¡Soluciona el problema!" },
		{"Be careful about seeds of blackberry, 2 of them are missing. '18'", "Ten cuidado con las semillas de mora, están faltando 2 de ellas. '18'" },
		{"You understand the math...", "Entiendes las matemáticas..." },
		//65
		{"Try to get rain from the cloud.", "Intenta que llueva desde la nube." },
		{"It's raining, floods are flowing...", "Está lloviendo, las aguas están corriendo..." },
		//66
		{"Do you guess the three letters upcoming in the order?", "¿Adivinas las tres letras que aparecerán en el orden?" },
		{"Look carefully at the first letters of words in the question? Use the first letters of last two words", "Mira cuidadosamente las primeras letras de las palabras de la pregunta. Usa las primeras letras de las últimas tres palabras." },
		{"Did you guess?", "¿Adivinaste?" },
		//67
		{"Find objects!", "¡Encuentra los objetos!" },
		{"You have a sharp sight!", "¡Tienes una visión aguda!" },
		//68
		{"How many numbers are there?", "¿Cuántos números hay?" },
		{"You are super!", "¡Eres genial!" },
		//69
		{"Please write down the right answer?", "Por favor, escribe la respuesta correcta." },
		{"You should think simple. Add up the 8 and 5.", "Deberías pensar en algo sencillo. Suma el 8 y el 5." },
		{"Sometimes you need to think simple ;)", "A veces necesitas pensar en algo simple ;)" },
		//70
		{"I go to bed at 8 o'clock at night and I set my cuckoo clock at 9 in the morning. How many hours will I sleep?", "Si me acuesto a las 8 en punto de la noche y pongo mi reloj cucú a las 9 de la mañana. ¿Cuántas horas voy a dormir?" },
		{"The cuckoo clock won’t differentiate night and day, hence you will sleep for one hour.", "El reloj cucú no diferencia entre el día y la noche, por lo tanto, dormiré una hora." },
		{"Is the alarm a little bit early?", "¿La alarma está un poco temprano?" },
		//71
		{"With two fingers, swipe to the left on the screen and plug the phone into a socket. Then touch the cables at the same time.", "Con dos dedos, desliza la pantalla hacia la izquierda y conecta el teléfono a un enchufe. Luego toca los cables al mismo tiempo." },
		{"Be careful, don’t be shocked!", "Atención, ¡presta atención a la electricidad!" },
		//72
		{"The wheel of the car is in one of the clouds. Put the cloud with your finger and shake it. Mount the wheel on the truck. Tilt the screen to the right. The truck will move across the street.", "La rueda del auto está en una de las nubes. Pon la nube con tu dedo y agítala. Monta la rueda en el camión. Inclina la pantalla hacia la derecha. El camión cruzará la calle." },
		{"Do not ask why the rubber tire is over there.", "No preguntes porque el neumático está ahí." },
		//73
		{"You should try to turn off the light with your finger.", "Deberías intentar apagar la luz con tu dedo." },
		{"There would not be a more creative way.", "No habría una forma más creativa." },
		//74
		{"Choose 3 balls, verify the evenness!", "Escoge 3 bolas, ¡comprueba la uniformidad!" },
		{"Turn the 9 upside down and make it 6! 11+13+6: 30! That much easy!", "¡Gira el 9 al revés y hazlo un 6! 11+13+6=30! ¡Así de fácil!" },
		{"We put the ball upside down, sorry.", "Pusimos la bola al revés, lo sentimos." },
		//75
		{"Which one is the heaviest?", "¿Cuál es el más pesado?" },
		{"Lift both hammers and drop them at the same time to find out which one is the heaviest.", "Levanta ambos martillos y déjalos caer al mismo tiempo para saber cuál es el más pesado." },
		{"I congratulate your physics teacher.", "Felicito a tu profesor de física." },
		//76 DON'T FORGET TO CHANGE PREFAB
		{"Drag the “fish” text over to the edge of the fishing hook.", "Arrastra la palabra “pez” hacia el extremo del anzuelo." },
		{"Delicious.", "Delicioso." },
		//77
		{"Shake the drink and help the child drink it", "Agita la bebida y ayuda al niño a beberla." },
		{"Hold the bottle shut with your finger, shake your phone, and give the bottle to the child.", "Tapa la botella con tu dedo, agita tu teléfono, y dale la botella al niño." },
		{"Shake before drinking!", "¡Agita antes de beber!" },
		//78
		{"Help the child to open the safe", "Ayuda al niño a abrir la caja fuerte" },
		{"Turn the phone over and shake it. The key will fall out of the child’s pocket.", "Dale la vuelta al teléfono y agítalo. La llave se caerá del bolsillo del niño." },
		{"What do you think inside of it?", "¿Qué piensas de su interior?" },
		//79
		{"Find the numbers on the balls", "Encuentra el número en las bolas." },
		{"148", "148" },
		{"Are you a math professor or something?", "¿Eres un profesor de matemática o algo así?" },
		//80
		{"Drag the screen towards the left and you will see the bird’s real shadow. (Use two fingers at the same time)", "Arrastra la pantalla hacia la izquierda y verás la verdadera sombra del pájaro.(Usa dos dedos al mismo tiempo)" },
		{"I’m impressed… You’re fast.", "Encuentra la verdadera sombra del pájaro." },
		//81
		{"Clean the car", "Limpia el auto." },
		{"You need to clean over the car with your finger.", "Tienes que limpiar el auto con tu dedo." },
		{"Sparkling clean.", "Limpio como el agua." },
		//82
		{"Find the strongest balloon!", "¡Encuentra el globo más fuerte!" },
		{"Drag the balloons over to the skip forward sign, 4 of them will pop! The strongest balloon won’t pop.", "¡Arrastra los globos hacia la señal de saltar hacia adelante, 4 de ellos explotarán! El globo más fuerte no explotará." },
		{"You’re doing great.", "Lo estás haciendo muy bien." },
		//83
		{"How many orange cubes do you need to cover the blue cube?", "¿Cuántos cubos naranjas necesitas para cubrir el cubo azul?" },
		{"22", "22" },
		{"That was a good one.", "Esa fue una buena." },
		//84
		{"Flip the text with two fingers. Put it between the tap and the bucket.", "Voltea el texto con dos dedos. Ponlo entre el grifo y el cubo." },
		{"Bet you didn’t think of that one, did you?", "Apuesto que no pensaste en eso, ¿cierto?" },
		//85
		{"The baby will sleep if you put your phone down on the table face down.", "El bebé se dormirá si pones tu teléfono en la mesa boca abajo." },
		{"You’re the best at putting babies to sleep.", "Eres el mejor en dormir a los bebés." },
		//86  DON'T FORGET TO CHANGE PREFAB
		{"What’s the size of the table?", "¿De qué tamaño es la mesa?" },
		{"You’re on a roll.", "Estás en racha." },
		//87
		{"Try dispersing the soil by shaking your phone", "Intenta dispersar la tierra sacudiendo el teléfono." },
		{"We’re covered in dirt.", "Estamos cubiertos de tierra." },
		//88
		{"Please help me find my dog in this mess", "Por favor, ayúdame a encontrar a mi perro en este desorden." },
		{"You need to make the screen smaller. The dog is somewhere outside of the screen.", "Necesitas reducir la pantalla. El perro está en algún lugar fuera de la pantalla." },
		{"Thank you!", "¡Gracias!" },
		//89
		{"Lift Thor’s hammer", "Levanta el martillo de Thor." },
		{"The hammer is so heavy you will need to lift it with three fingers.", "El martillo es tan pesado que tendrás que levantarlo con tres dedos." },
		{"You’re even stronger than I thought!", "¡Eres más fuerte de lo que pensaba!" },
		//90
		{"Find the pairs and win the game", "Encuentra los pares y gana el juego" },
		{"Divide the last one remaining in half by drawing a line through the middle of it.", "Divide la última que queda en la mitad dibujando una línea en el medio de ella." },
		{"We make a good pair.", "Hacemos una buena pareja." },
		//91
		{"Touch the cow’s head 10 times.", "Toca la cabeza de la vaca 10 veces." },
		{"The cow is a heavy sleeper.", "La vaca tiene el sueño pesado." },
		//92
		{"Hey..!! What day of the month is it?", "¡Oye! ¿Qué día del mes es?" },
		{"Seriously, what day of the month is it? What number is the calendar on your phone showing?", "En serio, ¿qué día del mes es? ¿Qué número muestra el calendario de tu teléfono?" },
		{"Sometimes I forget the date, too.", "A veces también olvido la fecha." },
		//93
		{"You need to shake the tree a lot. The key will fall from it.", "Necesitas sacudir mucho el árbol. La llave se caerá de él." },
		{"Whose idea was it to hide the key in a tree?", "¿De quién fue la idea de ocultar la llave en un árbol?" },
		//94  DON'T FORGET TO CHANGE PREFAB
		{"You can use the word “Balance” in the text to balance the scale.", "Puedes utilizar la palabra 'Equilibra' del texto para equilibrar la balanza." },
		{"Are you balanced?", "¿Estás equilibrado?" },
		//95
		{"If the bridge is falling apart, you need to support the middle of the bridge with your hand.", "Si el puente se está cayendo, necesitas sostener el medio del puente con tu mano." },
		{"You’re the king of the road.", "Eres el rey de la carretera." },
		//96
		{"It’s snowing! Catch the snow...", "¡Está nevando! Atrapa la nieve..." },
		{"Place your phone on a flat surface with the screen facing up and wait.", "Coloca tu teléfono en una superficie plana con la pantalla hacia arriba y espera." },
		{"Become one with the snow.", "Conviértete en uno con la nieve." },
		//97
		{"Help him escape prison", "Ayúdalo a escapar de la cárcel." },
		{"You can escape by pressing the escape button after you unscrew the lightbulb.", "Puedes escapar presionando el botón de escape después que desenroscar el bombillo." },
		{"Smells like freedom!", "¡Huele a libertad!" },
		//98
		{"Park the car", "Estaciona el auto." },
		{"There might be space further down the road.", "Puede haber espacio más adelante en la carretera." },
		{"Slowly… Slowly… Now park the car!", "Despacio... Despacio... ¡Ahora estaciona el auto!" },
		//99
		{"You will catch the cheater if you move the front row.", "Atraparás al tramposo si mueves la primera fila." },
		{"Caught red-handed.", "Atrapado con las manos en la masa." },
		//100
		{"Help the child see!", "¡Ayuda al niño a ver!" },
		{"Drag the two zeros in '100' to make glasses for the kid.", "Arrastra los dos ceros en '100' para hacer las gafas para el niño." },
		{"That’ll show you!", "¡Eso te enseñará!" },
		//101
		{"Which one would you save?", "¿A cuál salvarías?" },
		{"You need to press all three at the same time. Don’t try doing it one by one.", "Necesitas presionar los tres al mismo tiempo. No intentes hacerlo uno por uno." },
		{"You are so single.", "Eres tan simple." },
		{"Family", "Familia" },
		{"Love", "Amor" },
		{"Money", "Dinero" },
		//102
		{"The animals are racing. The cow, the rabbit, and the turtle. Help the turtle win", "Los animales están corriendo. La vaca, el conejo, y la tortuga. Ayuda a la tortuga a ganar.c" },
		{"Drag the start button and hit the Turbo button underneath.", "Arrastra el botón de inicio y presiona el botón de turbo que está debajo." },
		{"Fast and furious.", "Rápido y furioso." },
		{"Start", "Comienzo" },
		//103
		{"The baby will sleep if you turn the volume down on your phone.", "El bebé dormirá si baja el volumen de su teléfono." },
		{"Hush...", "Silencio..." },
		//104
		{"What should be the next number in the sequence?", "¿Cuál debería ser el próximo número en la secuencia?" },
		{"Read the numbers you see out loud! The numbers are how the previous numbers sound when you read them together… '13112221'", "¡Lee los números que ves en voz alta! Los números son como suenan los números anteriores cuando los lees juntos… '13112221'" },
		{"We’ll admit it was a hard question.", "Admitiremos que fue una pregunta difícil." },
		//105
		{"Help the truck pass through the tunnel", "Ayuda al camión a pasar por el túnel" },
		{"Shrink the truck with two fingers.", "Encoge el camión con los dedos." },
		{"Well done!", "¡Bien hecho!" },
		//106
		{"If Mary gathers 2 bananas in 1 minute, how many bananas can she gather from this tree in 10 minutes?", "Si María recoge 2 bananas en 1 minuto, ¿cuántas bananas puede recoger en 10 minutos?" },
		{"Does it look like bananas grow on this tree? The answer is '0'", "¿Parece que las bananas crecen en este árbol? La respuesta es '0'" },
		{"You’re quite smart.", "Eres muy inteligente." },
		//107 DON'T FORGET TO CHANGE PREFAB
		{"The match will be lit if you drag it and rub it over the word 'Light'.", "El fósforo se encenderá si lo arrastras y lo frotas sobre la palabra 'Enciende'" },
		{"Don’t play with fire.", "No juegues con fuego." },
		//108
		{"List the numbers you see on the screen in order", "Enumera los números que ves en la pantalla en orden" },
		{"At first, it started with 3, 2, 1, didn’t you see? 3, 2, 1, 32, 67, 21, 5, 14, 8", "Al principio, empezaba con 3, 2, 1, ¿no lo viste? 3, 2, 1, 32, 67, 21, 5, 14, 8" },
		{"I’m in awe of your visual memory!", "¡Me impresiona tu memoria visual!" },
		//109
		{"Who is pregnant?", "¿Quién está embarazada?" },
		{"Turn your phone upside down and shake it. Drag the pregnancy test over to the woman on the right.", "Ponga el teléfono boca abajo y agítelo. Arrastra la prueba de embarazo hacia la mujer de la derecha." },
		{"Congratulations!", "¡Felicitaciones!" },
		//110
		{"How many squares are there?", "¿Cuántos cuadrados hay?" },
		{"Would it be 40?", "¿Serán 40?" },
		{"It is 40!", "¡Son 40!" },
		//111
		{"Make the man happy!", "¡Haz feliz al hombre!" },
		{"Drag the man up over the clouds.", "Arrastra al hombre sobre las nubes." },
		{"Being happy is that simple!", "¡Ser feliz es así de simple!" },
		//112
		{"Sally is 21 years older than her son. 2 years ago, Sally was 4 times her son’s age. How old is Sally?", "Sally es 21 años mayor que su hijo. Hace 2 años, Sally tenía 4 veces la edad de su hijo. ¿Qué edad tiene Sally?" },
		{"She is 31.", "Tiene 31 años." },
		{"What did you study in school?", "¿Qué estudiaste en la escuela?" },
		//113
		{"Park the car in the right spot", "Aparque el coche en el lugar correcto" },
		{"Drag the skirt off of the female symbol in the middle to make it appropriate for the driver.", "Arrastra la falda del icono femenino en el medio para que sea apropiado para el conductor." },
		{"Thought you’d never figure it out.", "Pensé que nunca lo resolverías." },
		//114
		{"That counts as a three-pointer.", "Eso cuenta como un triple." },
		//115
		{"Did you try taking the light that won’t turn off out of the screen?", "¿Intentaste quitar la luz que no se apaga fuera de la pantalla?" },
		{"I love your sharp wit!", "¡Me encanta tu agudo ingenio!" },
		//116
		{"Save the gorilla :(", "Salva al gorila :(" },
		{"You can use the hint key to unlock the lock.", "Puedes usar la llave de pistas para abrir la cerradura." },
		{"#FreedomForAnimals", "#LibertadParaLosAnimales" },
		//117
		{"What’s the fastest route from A to I?", "¿Cuál es la ruta más rápida de la A a la I?" },
		{"You need to swap B and I’s places.", "Necesitas intercambiar los lugares de la B y de la I." },
		{"You’re so fast!", "¡Eres tan rápido!" },
		//118
		{"Burn everything", "Quémalo todo" },
		{"Drag the magnifying glass between the sun and the wood to spark a fire. Then use the wood on the fire to burn everything. You can pass the level by burning everything including the 'Burn everything' text and the sun.", "Arrastra la lupa entre el sol y la madera para encender el fuego. Luego usa la madera del fuego para quemar todo. Puedes pasar el nivel quemando todo, incluyendo el texto “Quémalo todo” y el sol." },
		{"Time to call the fire station!", "¡Hora de llamar a la estación de bomberos!" },
		//119
		{"2 of them are drowned, 4 of them are swimming, and 3 of them are dead. How many fish left in the aquarium?", "2 de ellos se ahogaron, 4 de ellos están nadando, y 3 de ellos están muertos. ¿Cuántos peces quedan en el acuario?" },
		{"Fish don’t drown in water. But even if they did, none of them would go out of aquarium hence, 10 fish will be left.", "Los peces no se ahogan en el agua. Pero incluso si lo hicieran, ninguno de ellos saldría del acuario, por lo cual quedan 10 peces." },
		{"You are a real genius.", "Eres un genio." },
		//120
		{"You should try charging your own phone while the game is on.", "Deberías intentar cargar tu propio teléfono mientras el juego está encendido" },
		{"We gave you an excuse to charge your phone :)", "Te dimos una excusa para cargar tu teléfono :)" },
		//121
		{"Put the fire out", "Apaga el fuego" },
		{"Squeeze the cloud with two fingers and make water spill to put out the fire.", "Aprieta la nube con dos dedos y haz que el agua caiga para apagar el fuego." },
		{"It’s raining cats and dogs!", "¡Está lloviendo a cántaros!" },
		//122
		{"Find the pirate", "Encuentra al pirata." },
		{"Pirates have wooden legs. Try lifting their pant legs to see.", "Los piratas tienen patas de madera. Intenta levantar sus pantalones para ver." },
		{"Nice, the next question awaits.", "Bien, la siguiente pregunta espera." },
		//123
		{"Complete the equation", "Completa la ecuación" },
		{"Take the 1, 2, and 3 from “Lv. 123” and put them in the places of A, B, and C. That will complete the equation.", "Toma el 1, 2 y 3 de 'Lv. 123' y ponlos en los lugares de A, B y C. Eso completará la ecuación." },
		{"You really surprised me.", "Realmente me sorprendes." },
		//124
		{"Defeat your competitor in Rock-Paper-Scissors game!", "¡Derrota a tu competidor en el juego Piedra, Papel o Tijeras!" },
		{"You have to move to the winning side by relocating the players!", "¡Tienes que moverte al lado ganador reubicando a los jugadores!" },
		{"Or did you cheat?", "¿Has hecho trampa?" },
		//125
		{"It’s 3:35. What time would it be if the clock moved counter-clockwise 90 degrees?", "Son las 3:35. ¿Qué hora sería si el reloj se moviera 90 grados en sentido contrario a las agujas del reloj?" },
		{"Could it be 12:20?", "¿Podrían ser las 12:20?" },
		{"Did you ask your friends what level they’re on?", "¿Le preguntaste a tus amigos en qué nivel están?" },
		//126 DON'T FORGET TO CHANGE PREFAB
		{"Did you try to click on Europe text?", "¿Intentaste hacer clic en el texto de Europa?" },
		{"Bravo!", "¡Bravo!" },
		//127
		{"Make the bulbs explode by clicking on the lights 5 times", "Haz que las bombillas exploten haciendo clic en las luces 5 veces." },
		{"The lights are off alright...", "Las luces están apagadas..." },
		//128
		{"He broke the vase 10 minutes ago. Help him fix it", "Rompió el jarrón hace 10 minutos. Ayúdalo a arreglarlo." },
		{"The vase wasn’t broken 10 minutes ago. Try rewinding the clock.", "El jarrón no se rompió hace 10 minutos. Intenta rebobinar el reloj." },
		{"You just traveled through time.", "Acabas de viajar a través del tiempo." },
		//129
		{"Which tank would be filled first?", "¿Qué tanque se llenará primero?" },
		{"Draw a line to A's drain. Thus, 'A' will be filled first.", "Dibuja una línea hasta el desagüe del tanque A. Así, el tanque “A” se llenará primero." },
		{"Hmm, smart...", "Hmm, inteligente..." },
		//130
		{"Shrink the building.", "Encoge el edificio" },
		{"Kangaroo-lations!", "¡Canguro-laciones!" },
		//131 DON'T FORGET TO CHANGE PREFAB
		{"You should try turning the 9 in the question into a 6. Then you will have the right number of bananas.", "Deberías intentar convertir el 9 de la pregunta en un 6. Entonces tendrás el número correcto de bananas." },
		{"Something’s not right about this.", "Algo no está bien en esto." },
		//132
		{"What should fill the blank?", "¿Qué debería llenar el espacio en blanco?" },
		{"Did you ever drive? This was car gear. Reverse gear 'R'...", "¿Alguna vez has conducido? Esto era una marcha de un auto. Reversa “R”..." },
		{"Ok understood, you don’t have an 'R'.", "Ok entendido, no tienes una “R”." },
		//133
		{"How many 3's are there?", "¿Cuántos 3 hay?" },
		{"There are five 3's including the ones in 'Lv.133' and the question.", "Hay cinco 3 incluyendo los de 'Lv.133' y la pregunta." },
		{"Good catch!", "¡Buena jugada!" },
		//134
		{"Shake the clouds and catch the fish with the worm under the tree.", "Agita las nubes y atrapa el pescado con el gusano bajo el árbol..." },
		{"Hook, line, and sinker!", "¡Anzuelo, línea y plomo!" },
		//135
		{"Help the truck pass through the tunnel!", "¡Ayuda al camión a pasar por el túnel!" },
		{"Deflate the truck’s wheels! You can use the 'Forward' symbol.", "¡Desinfla las ruedas del camión! Puedes usar el símbolo “Adelante”." },
		{"Wish we could give you a reward.", "Desearía que pudiéramos darte una recompensa." },
		//136
		{"Make a square by moving 2 balls", "Haz un cuadrado moviendo 2 bolas" },
		{"Wow!", "¡Vaya!" },
		//137
		{"Turn off the lights", "Apaga las luces." },
		{"You should try putting your phone upside down on the table, with the screen facing down. Then the light will go off.", "Deberías intentar poner el teléfono con la pantalla hacia abajo sobre la mesa. Luego la luz se apagará." },
		{"That’s what we’re talking about.", "De eso es lo que estamos hablando." },
		//138
		{"Turn the cow in the other direction before it reaches the soil.", "Da vuelta a la vaca en la otra dirección antes de que llegue al suelo." },
		{"Where there’s a will, there’s a way.", "Donde hay voluntad, hay un camino." },
		//139
		{"Speed up the clock and reveal the pregnant woman.", "Adelanta el reloj y revela a la mujer embarazada." },
		{"Time flies...", "El tiempo vuela..." },
		//140
		{"Take the key on the upper right corner of the screen and drag it onto the door to pass the level.", "Toma la llave de la esquina superior derecha de la pantalla y arrástrala hasta la puerta para pasar el nivel." },
		{"We couldn’t trick you...", "No podríamos engañarte..." },
		//141
		{"Leave me alone for a bit...", "Déjame en paz por un rato..." },
		{"Leave the game, wait a couple of seconds, and re-enter the game.", "Sal del juego, espera un par de segundos y vuelva a entrar en el juego." },
		{"Thank you for understanding.", "Gracias por entenderlo." },
		//142
		{"Hold the basketball with your finger and slam dunk!", "¡Sostén la pelota de baloncesto con el dedo y haz una clavada!" },
		{"A great slam dunk.", "Una gran clavada!" },
		//143
		{"Catch person who is cheating!", "¡Atrapa a la persona que está haciendo trampa!" },
		{"Try lifting the child’s hat who is at the right.", "Intenta levantar el sombrero del niño que está a la derecha." },
		{"You are not missing a thing.", "No se te escapa nada." },
		//144
		{"Help an old lady cross the road", "Ayuda a una anciana a cruzar la calle" },
		{"One of the trucks has a green light in its truck bed. You need to put it in the right spot.", "Uno de los camiones tiene luz verde en su plataforma. Necesitas ponerla en el lugar correcto." },
		{"Thank you for your help!", "¡Gracias por tu ayuda!" },
		//145
		{"What is the result of the calculation?", "¿Cuál es el resultado del cálculo?" },
		{"The result of the calculation is '-62'.", "El resultado del cálculo es '-62'." },
		{"The social science people are now crying.", "La gente de ciencias sociales ahora está llorando." },
		//146
		{"Gather the stones upstream and stop the water. Drag the net over the fish.", "Reúne las piedras río arriba y detén el agua. Arrastra la red sobre los peces." },
		{"The fish jumps once jumps twice...", "El pez salta una vez, salta dos veces..." },
		//147
		{"Shrink down the fire!", "¡Reduce el fuego!" },
		{"Shake the phone, let the fire disperse and choose the smaller one!", "¡Agita el teléfono, deja que el fuego de disperse y elige el más pequeño!" },
		{"Did you try to snuff it out?", "¿Intentaste apagarlo?" },
		//148
		{"Find the password!", "¡Encuentra la contraseña!" },
		{"'042' Think again... You can also ask a friend.", "“042” Piénsalo de nuevo… También puedes preguntarle a un amigo." },
		{"If you found this as well, you should be proud of yourself!", "Si también encontraste esto, ¡deberías estar orgulloso de tí!" },
		{"A number and it's place are correct", "Un número y su lugar son correctos" },
		{"A number is correct but it's place is wrong", "Un número es correcto pero su lugar está mal" },
		{"Two numbers are correct but the places are wrong", "Dos números son correctos pero los lugares están equivocados" },
		{"Nothing is correct", "Nada es correcto" },
		{"ENTER", "ENTRAR" },
		//149
		{"Weigh the chicken", "Pesa la gallina" },
		{"Shake the chicken to make its eggs fall out and make it lighter.", "Agita la gallina para que se le caigan los huevos y se haga más liviana." },
		{"I’m light as a feather.", "Soy ligero como una pluma." },
		//150
		{"Is it too quiet here?", "¿Es demasiado tranquilo aquí?" },
		{"A little music wouldn't be bad.", "Un poco de música no sería malo." },
		{"Music is the essence of the soul ;)", "La música es la esencia del alma ;)" },
		//151
		{"Take the ball outside!", "¡Lleva la pelota afuera!" },
		{"Pour water from the dispenser size bottle to the glass and pour it into the pipe. Let the ball go up.", "Vierte el agua de la botella del tamaño de un dispensador al vaso y viértela en el tubo. Deja que la pelota suba." },
		{"You discovered the buoyant force of the water.", "Has descubierto la fuerza de flotación del agua." },
		//152
		{"Score a goal.", "Marca un gol." },
		{"Try to press two arrows at the same time.", "Intenta hacer clic en dos flechas al mismo tiempo." },
		{"Gooaal!..!!", "¡Gooooool...!" },
		//153
		{"Make the baby laugh.", "Haz reir al bebé." },
		{"Take off the baby's socks and tickle the baby's feet with a feather.", "Quítale los calcetines al bebé y hazle cosquillas en los pies con una pluma." },
		{"The world is better when babies laugh.", "El mundo es mejor cuando los bebés ríen." },
		//154
		{"Bring the child to the exit", "Lleva al niño a la salida" },
		{"Turn your phone over and watch the child.", "Voltea el teléfono y observa al niño." },
		{"Did you send the game to your friends? Now, send it from the share button below.", "¿Le enviaste el juego a tus amigos? Ahora, envíalo desde el botón de compartir que se encuentra abajo." },
		//155
		{"The child is so lonely", "El niño está muy solo" },
		{"Hold on the child with your finger for 5 seconds and then, copy the child.", "Sujeta al niño con el dedo durante 5 segundos y luego, copia al niño." },
		{"Now, they are twins.", "Ahora, son gemelos." },
		{"Copy", "Copiar" },
		{"Rate the game", "Evalua el juego" },
		//156
		{"Please click in the following order", "Por favor, haz clic en el siguiente orden." },
		{"Are you sure you did the right thing? Watch out for the last finger.", "¿Estás seguro de que hiciste lo correcto? Cuidado con el último dedo." },
		{"That's it!", "¡Eso es todo!" },
		//157
		{"Silence the child", "Haz que el niño se calle." },
		{"The toy is hidden under the button. Give it to the child.", "El juego está escondido debajo del botón. Dáselo al niño." },
		{"It's really awesome.", "Es realmente impresionante." },
		{"Watch video", "Ver video" },
		//158 DON'T FORGET TO CHANGE PREFAB
		{"Unlock the case.", "Abre el maletín." },
		{"Take the word ‘password’ to the correct place.", "Lleva la palabra ‘contraseña’ al lugar correcto." },
		{"Is it difficult?", "¿Es difícil?" },
		//159
		{"Grab the gift box on the daily bonus button and give it to the man. The man will be happy to receive a gift.", "Agarra la caja de regalo del botón de la bonificación diaria y dásela al hombre. El hombre estará feliz de recibir un regalo." },
		{"Who recently bought you a gift?", "¿Quién te compró un regalo recientemente?" },
		//160
		{"What does the child see?", "¿Qué ve el niño?" },
		{"Try to look at from the perspective of the child.", "Trata de mirar desde la perspectiva del niño." },
		{"It's all about perspective!", "¡Todo es cuestión de perspectiva!" },
		//161 DON'T FORGET TO CHANGE PREFAB
		{"One of the X's can be moved. Remove X and replace it with the dot in the question.", "Una de las X se puede mover. Quite X y reemplácelo con el punto en la pregunta." },
		{"You are true genius!", "¡Eres un verdadero genio!" },
		//162
		{"Make the girl fall in love with the boy", "Haz que la chica se enamore del chico." },
		{"Shake the child quite a while. Maybe he is hiding a surprise gift.", "Sacude al niño un rato. Tal vez esté escondiendo un regalo sorpresa." },
		{"You're the last single person in the world.", "Eres la última persona soltera del mundo." },
		//163 DON'T FORGET TO CHANGE PREFAB
		{"Try to use the word 'Truck'.", "Intenta usar la palabra 'Camión'." },
		{"Poor truck.", "Pobre camión." },
		//164
		{"Find the water for kids to make a water fight.", "Encuentra el agua para los niños para hacer una guerra de agua." },
		{"Hold both clouds with your fingers at the same time shake your phone.", "Sujeta las dos nubes con los dedos y agita el teléfono al mismo tiempo." },
		{"May the best man win!", "¡Que gane el mejor!" },
		//165
		{"Shout and Say 'MOM'", "Grita y di ‘MAMÁ’" },
		{"The level will be passed when you click the start button 4 times and fill the bar. You must allow microphone access, or enable Phone Settings > Apps > Trick Me > Permissions > Microphone option.", "El nivel será superado cuando hagas clic en el botón de inicio 4 veces y llenes la barra. Debe permitir el acceso al micrófono o habilitar la Configuración del Teléfono > Aplicaciones > Truco > Permisos > Opción de micrófono." },
		{"What did you mom say?", "¿Qué dijo tu mamá?" },
		//166
		{"Find a frame for these colored objects.", "Encuentra un marco para estos objetos de color." },
		{"I said find 'a frame' for these colored objects. :)", "He dicho que busques ‘un marco’ para estos objetos de color. :)" },
		{"You are amazing!", "¡Eres increíble!" },
		//167
		{"Do something to end the war.", "Haz algo para detener la guerra." },
		{"If you shoot at the right place, the war is over.", "Si disparas en el lugar correcto, la guerra se termina." },
		{"#worldpeace", "#pazmundial" },
		//168
		{"Find the ball?", "Encuentra la pelota" },
		{"To make 'x10' 'x1', delete '0' using your finger.", "Para hacer ‘x10’ ‘x1’, borra el ‘0’ con el dedo." },
		{"A++++++", "A++++++" },
		//169
		{"After the game has started, you must turn the child left using your finger.", "Después de que el juego ha comenzado, debes girar al niño hacia la izquierda usando tu dedo." },
		{"Nobody could pass this level except you.", "Nadie puede pasar este nivel excepto tú." },
		//170
		{"Hit the man's head and knock the man out. Then, shoot the ball.", "Golpea al hombre en la cabeza y noquéalo. Luego, tira la pelota." },
		{"Incredible goal!", "¡Increíble gol!" },
		//171
		{"Grasp the first car with two fingers and remove it draggingly. Then, park your car in its place.", "Agarra el primer coche con dos dedos y sácalo arrastrando. Luego, aparca el coche en su sitio." },
		{"Nice job!", "¡Buen trabajo!" },
		//172
		{"One of the L's in Lvl is big and the other small.", "Una de las L de Lvl es grande y la otra pequeña." },
		{"You can think differently...", "Puedes pensar de forma diferente..." },
		//173 DON'T FORGET TO CHANGE PREFAB
		{"Enter password", "Ingresa la contraseña" },
		{"Try zooming your screen a few times.", "Intenta hacer zoom en la pantalla varias veces." },
		{"You're very good!", "¡Eres muy bueno!" },
		//174
		{"Behind one of the windows.", "Detrás de una de las ventanas." },
		{"Don't lie, you're a gamer, too.", "No mientas, tú también eres un gamer." },
		//175
		{"Grab the small key on watch video button and drag it to the door.", "Agarra la pequeña llave del botón de ver video y arrástrala hasta la puerta." },
		{"Amazing!", "¡Increíble!" },
		//176
		{"Hi, we’re still working on new levels. Stay tuned for the next update.", "Hola, todavía estamos trabajando en nuevos niveles. Mantente en sintonía para la próxima actualización. :)" },
		{"", "" }
    };
    public static Dictionary<string, string> DE = new Dictionary<string, string>()
    {
		{"EN", "DE" },
		//GENERAL UI ELEMENTS
		{"7.99USD", "7.99EUR" },
		{"Don't show again.", "Nicht mehr zeigen." },
		{"You have to turn the phone's rotating feature on.", "Sie müssen die Drehfunktion des Telefons aktivieren." },
		{"RESTORE", "WIEDERHERSTELLEN" },
		{"Restore Purchases", "Einkäufe wiederherstellen" },
		{"COMING SOON...", "KOMMT BALD..." },
		{"COME AGAIN TOMORROW!", "KOMMEN SIE MORGEN WIEDER!" },
		{"3 days free", "3 Tage frei" },
		{"AND...", "UND..." },
		{"BECOME VIP!", "WERDE VIP!" },
		{"CONGRATULATIONS!!!", "HERZLICHE GLÜCKWÜNSCHE!!!" },
		{"Daily Bonus", "Täglicher Bonus" },
		{"Double daily bonus", "Doppel Täglicher Bonus" },
		//ANDROID EXPLANATION
		//Weekly Premium automatically renews. Payment will be charged to your Google account at the end of the trial period of purchase. The subscription automatically renews unless auto-renews unless auto-renew is turned off at least 24 hours before the end of the current period. You can manage and turn off auto-renewal of the subscription by going to your account settings on the Google Play after purchase.
		//IOS EXPLANATION
		//Weekly Premium automatically renews. Payment will be charged to your iTunes account at the end of the trial period of purchase The subscription automatically renews unless auto-renews unless auto-renew is turned off at least 24 hours before the end of the current period. You can manage and turn off auto-renewal of the subscription by going to your account settings on the iTunes after purchase.
		{"Feedback", "Feedback" },
		{"Free", "Kostenlos" },
		{"Game Reset", "Spiel zurücksetzen" },
		{"Hint discounts", "Tipp Rabatte" },
		{"INSTANTLY", "SOFORT" },
		{"All Levels", "Alle Ebenen" },
		{"Music", "Musik" },
		{"Next", "Nächster" },
		{"Nice start...", "Schöner Start..." },
		{"Privacy Policy", "Datenschutz-Bestimmungen" },
		{"PRIVACY POLICY", "DATENSCHUTZ-BESTIMMUNGEN" },
		{"Rate", "Bewertung" },
		{"remove ads", "anzeigen entfernen" },
		{"Remove ads", "Anzeigen entfernen" },
		{"Remove Ads", "Anzeigen Entfernen" },
		{"Share", "Teilen" },
		{"Skip discounts", "Rabatte überspringen" },
		{"Skip", "Überspringen" },
		{"Skipping costs 2 keys. Would you like to skip?", "Überspringen Sie die Herausforderung verbraucht 2 Schlüssel, überspringen oder nicht?" },
		{"Sounds", "Soundeffekte" },
		{"Store", "Geschäft" },
		{"TERMS OF USE", "NUTZUNGSBEDINGUNGEN" },
		{"Terms of Use", "Nutzungsbedingungen" },
		{"TRY FOR FREE!", "VERSUCHEN SIE ES KOSTENLOS!" },
		{"Vibration", "Vibration" },
		{"Watch", "Beobachten" },
		{"Weekly", "Wöchentlich" },
		//PREFABS
		{"Exit", "Verlassen" },
		{"OK", "OK" },
		{"Fire", "Feuer" },
		{"FINISH", "FERTIG" },
		{"RUN", "LAUF" },
		{"CLEAR", "LÖSCHEN" },
		{"START", "STARTEN" },
		{"JUMP", "SPRINGEN" },
		{"Write your answer", "Schreibe deine Antwort" },
		//LEVELS
		//1
		{"Which one is red?", "Welches ist rot?" },
		{"Or you didn't click on the red text?", "Oder hast du nicht auf den roten Text geklickt?" },
		{"Good start.", "Guter Start." },
		{"Green", "Grün" },
		{"Yellow", "Gelb" },
		{"Blue", "Blau" },
		{"Red", "Rot" },
		//2
		{"Shoot the basketball into the hoop", "Schieße den Basketball in den Reifen." },
		{"You need to press the shoot button when it reaches green in order to shoot.", "Sie müssen die Aufnahmetaste drücken, wenn sie grün ist, um zu schießen." },
		{"Nice shot.", "Schönes Foto." },
		{"Shoot", "Schieße" },
		//3
		{"Throw everything away", "Wirf alles weg." },
		{"You should drag-and-drop pizza, cheese, ice-cream and cactus to the trash.", "Sie sollten Pizza, Käse, Eis und Kakteen per Drag & Drop in den Müll werfen." },
		{"Cleaning is important, of course...", "Reinigung ist natürlich wichtig..." },
		//4
		{"Find the different one", "Finde einen anderen." },
		{"Could it be under the ice-cream? Look at it.", "Könnte es unter dem Eis sein? Schau es dir an." },
		{"I guess someone likes a different kind of ice-cream :)", "Ich denke, jemand mag eine andere Art von Eis :)" },
		//5
		{"Which one is the biggest drop?", "Welches ist der größte Tropfen?" },
		{"Put the drops on top of each other and create the largest one.", "Legen Sie die Tropfen übereinander und erstellen Sie den größten" },
		{"Many a mickle makes a muckle...", "Manch ein Mickle macht ein Muckle ..." },
		//6
		{"Did you try covering the lamp with your hand?", "Haben Sie versucht, die Lampe mit Ihrer Hand abzudecken?" },
		{"You managed to help the baby sleep again. Zzz...", "Sie haben es geschafft, dem Baby wieder beim Schlafen zu helfen. Zzz..." },
		//7
		{"How many points do you give to this game?", "Wie viele Punkte gibst du für dieses Spiel?" },
		{"I think you liked it very much.", "Ich denke es hat dir sehr gut gefallen." },
		{"Since you loved it so much, let’s continue!", "Da es Ihnen so gut gefallen hat, machen wir weiter!" },
		{"Waste of time", "Zeitverschwendung" },
		{"I couldn't figured it out", "Ich konnte es nicht herausfinden" },
		{"It's OK", "Es gehts" },
		{"It's nice", "Es ist schön" },
		{"I liked it very much!", "Ich mochte es sehr!" },
		//8
		{"Make the baby sleep", "Lass das Baby schlafen." },
		{"Firstly, you should give the bottle and then try to put the baby to sleep in his/her car.", "Zuerst sollten Sie die Flasche geben und dann versuchen, das Baby in seinem Auto einzuschlafen." },
		{"Rub-a-dub-dub... Zzz...", "Rub-a-Dub-Dub ... Zzz ..." },
		//9
		{"Balance the scale", "Waage ausbalancieren." },
		{"If you take everything off, the scale would be even.", "Wenn Sie alles abnehmen, wäre die Skala gleichmäßig." },
		{"I know you are a balanced person.", "Ich weiß, dass du eine ausgeglichene Person bist." },
		//10
		{"One of the girls looking at the West, the other is to the East. But both of them can see each other, how can you do that?", "Eines der Mädchen schaut nach Westen, das andere nach Osten. Aber beide können sich sehen, wie kannst du das machen?" },
		{"You should move the girls’ head as to be turned as face-to-face.", "Sie sollten den Kopf der Mädchen bewegen, um ihn von Angesicht zu Angesicht zu drehen." },
		{"I see you’re getting used to it.", "Ich sehe, dass Sie sich daran gewöhnen." },
		//11
		{"Open the door", "Öffne die Tür." },
		{"You need to use the key in the child's pocket in order to open the door.", "Sie müssen den Schlüssel in der Tasche des Kindes verwenden, um die Tür zu öffnen." },
		{"Yeah, that’s it ;)", "Ja, das ist es ;)" },
		//12
		{"Stop the fight..!!", "Stoppen Sie den Kampf .. !!" },
		{"You can stop the fight when you split the bone in two and give it to the dogs.", "Sie können den Kampf beenden, wenn Sie den Knochen in zwei Teile teilen und ihn den Hunden geben." },
		{"Fifty-fifty ;)", "Fünfzig-Fünfzig ;)" },
		//13
		{"Help the tree shed its leaves", "Hilf dem Baum, seine Blätter abzuwerfen." },
		{"Paint the tree yellow with the paint bucket.", "Malen Sie den Baum gelb mit dem Farbeimer." },
		{"You’re doing great!", "Du machst das großartig!" },
		//14
		{"Catch the fish!", "Fang den Fisch!" },
		{"The fish is hidden between the waves. Move the waves.", "Der Fisch ist zwischen den Wellen versteckt. Bewege die Wellen." },
		{"That move seems familiar...", "Dieser Schritt kommt mir bekannt vor..." },
		//15
		{"Fill the bucket with water", "Füllen Sie den Eimer mit Wasser." },
		{"Try to turn the phone. You will see that the direction of water will change.", "Versuchen Sie, das Telefon einzuschalten. Sie werden sehen, dass sich die Richtung des Wassers ändert." },
		{"Nature will take its course.", "Die Natur wird ihren Lauf nehmen." },
		//16
		{"Help the man lose weight", "Helfen Sie dem Mann, Gewicht zu verlieren." },
		{"Hold the man with your finger, drag him to the left and right 4 times and make him lose weight.", "Halten Sie den Mann mit Ihrem Finger, ziehen Sie ihn viermal nach links und rechts und lassen Sie ihn abnehmen." },
		{"He’s skin and bones.", "Er ist Haut und Knochen." },
		//17
		{"Feed the hay to the cow", "Füttere die Kuh mit dem Heu." },
		{"Didn't you see the shovel behind the hay? You can open a way with it.", "Hast du die Schaufel hinter dem Heu nicht gesehen? Sie können damit einen Weg eröffnen." },
		{"Now it’s time to eat.", "Jetzt ist es Zeit zu essen." },
		//18
		{"Find the 10 differences", "Finde die 10 Unterschiede." },
		{"What’s important is making a difference :)", "Was wichtig ist, ist einen Unterschied zu machen :)" },
		//19
		{"Clean the page!", "Bereinige die Seite!" },
		{"You can clean it by hovering over it with your finger.", "Sie können es reinigen, indem Sie mit dem Finger darüber schweben." },
		{"Did you try to use a rubber? Hahaha", "Haben Sie versucht, einen Gummi zu verwenden? hahaha" },
		//20
		{"Which one is soda?", "Welches ist Soda?" },
		{"Shake the phone, sparkle it and find the soda!", "Schütteln Sie das Telefon, funkeln Sie es und finden Sie das Soda!" },
		{"You will fizz like blup blup blup xD", "Sie werden wie Blup Blup Blup xD sprudeln" },
		//21
		{"Find the gamer", "Finde den Spieler." },
		{"A true gamer never sleeps.", "Ein wahrer Spieler schläft nie." },
		{"Gamers don’t sleep. You can find the gamer by clicking on the only window in the apartment where the light is on.", "Spieler schlafen nicht. Sie finden den Spieler, indem Sie auf das einzige Fenster in der Wohnung klicken, in dem das Licht an ist." },
		//22
		{"How many hairs does the child have?", "Wie viele Haare hat das Kind?" },
		{"If you lift the child’s wig, you will see how many of the real hair is.", "Wenn Sie die Perücke des Kindes anheben, sehen Sie, wie viele echte Haare vorhanden sind." },
		{"If you could count all the hair, please contact us. :)", "Wenn Sie alle Haare zählen könnten, kontaktieren Sie uns bitte. :)" },
		//23
		{"Please charge the phone", "Bitte laden Sie Ihr Telefon auf." },
		{"Have you ever tried touching the cables at the same time with your two fingers?", "Haben Sie jemals versucht, die Kabel gleichzeitig mit Ihren beiden Fingern zu berühren?" },
		{"I'm taking a shine from you.", "Ich nehme einen Glanz von dir." },
		//24
		{"If the hunter shots 2 of the birds, how many birds left at the branch?", "Wenn der Jäger 2 der Vögel schießt, wie viele Vögel sind dann noch am Ast?" },
		{"'0' There would not be any birds left, all of them scared and flew away.", "'0' Es würden keine Vögel mehr übrig sein, alle hatten Angst und flogen davon." },
		{"Well done the hunter, he shot 2 birds at the same time.", "Gut gemacht, der Jäger, er hat 2 Vögel gleichzeitig geschossen." },
		//25
		{"Pop the balloons!", "Pop die Luftballons!" },
		{"Scare the hedgehog and pop the balloons with its spines!", "Erschrecken Sie den Igel und platzen Sie die Luftballons mit den Stacheln!" },
		{"Boooooommmmm!", "Boooooommmmm!" },
		//26
		{"Reach the animal to the exit by using arrows", "Erreichen Sie das Tier mit Pfeilen bis zum Ausgang." },
		{"You should wander around before entering the maze.", "Sie sollten herumlaufen, bevor Sie das Labyrinth betreten." },
		{"All great minds think alike.", "Alle großen Köpfe denken gleich." },
		//27
		{"How many letters left in alphabet if you take the letters of “a” and “b” out?", "Wie viele Buchstaben sind noch im Alphabet, wenn Sie die Buchstaben 'a' und 'b' herausnehmen?" },
		{"There will be 6 letters left if you take a and b out from alphabet word.", "Es bleiben 6 Buchstaben übrig, wenn Sie a und b aus dem Alphabet herausnehmen." },
		{"Do you think that your friends can solve this question?", "Denken Sie, dass Ihre Freunde diese Frage lösen können?" },
		//28
		{"How many flies are there?", "Wie viele Fliegen gibt es?" },
		{"Enlarge the poop in the back and count the flies over it.", "Vergrößern Sie die Kacke im Rücken und zählen Sie die Fliegen darüber." },
		{"Flies resides in the details.", "Fliegen liegt im Detail." },
		//29 DON'T FORGET TO CHANGE PREFAB
		{"Try to drag the “sleep” word over the baby...", "Versuchen Sie, das Wort 'Schlaf' über das Baby zu ziehen ..." },
		{"It would be perfect if it was that easy to put babies in sleep in real life.", "Es wäre perfekt, wenn es so einfach wäre, Babys im wirklichen Leben in den Schlaf zu versetzen." },
		//30
		{"Try to close the cow's nose. Look at it, will it wake up?", "Versuchen Sie, die Nase der Kuh zu schließen. Schau es dir an, wird es aufwachen?" },
		{"Almost drowning.", "Fast ertrinken." },
		//31
		{"Save the ship from crashing into the iceberg", "Rette das Schiff vor dem Absturz in den Eisberg." },
		{"Try melting the iceberg by rubbing it with your finger.", "Versuchen Sie, den Eisberg zu schmelzen, indem Sie ihn mit Ihrem Finger reiben." },
		{"The Titanic would have sunk.", "Die Titanic wäre gesunken." },
		//32
		{"Cross the truck across the bridge", "Überqueren Sie den LKW über die Brücke." },
		{"Try to lift the bridge from the top with your finger.", "Versuchen Sie, die Brücke mit Ihrem Finger von oben anzuheben." },
		{"Honk honk!", "Hupen Hupen!" },
		//33
		{"Which one is edible?", "Welches ist essbar?" },
		{"What you think of as diamond and poop is actually cone and ice cream. Drag the cone under the ice cream.", "Was Sie als Diamant und Kot betrachten, ist eigentlich Kegel und Eis. Ziehen Sie den Kegel unter das Eis." },
		{"I wish they were here.", "Ich wünschte, sie wären hier." },
		//34
		{"What would the result be if we multiply all the numbers with each other?", "Was wäre das Ergebnis, wenn wir alle Zahlen miteinander multiplizieren würden?" },
		{"What would the result be if you multiply a number with zero?", "Was wäre das Ergebnis, wenn Sie eine Zahl mit Null multiplizieren würden?" },
		{"You cannot ignore the zero...", "Sie können die Null nicht ignorieren..." },
		//35
		{"Do the right move to win the game!", "Mach den richtigen Zug, um das Spiel zu gewinnen!" },
		{"Touch the sides of 'O' in the middle, at the same time with 2 fingers!", "Berühren Sie die Seiten von 'O' in der Mitte gleichzeitig mit 2 Fingern!" },
		{"Good strategy.", "Gute Strategie." },
		//36
		{"How would you empty the bathtub fastly?", "Wie würden Sie die Badewanne schnell leeren?" },
		{"Didn't you try to remove the stopper from the tub? You should try it right now.", "Haben Sie nicht versucht, den Stopfen aus der Wanne zu entfernen? Sie sollten es jetzt versuchen." },
		{"Your friends will have difficulty in solving this question!", "Ihre Freunde werden Schwierigkeiten haben, diese Frage zu lösen!" },
		//37
		{"Turn the child over by using two fingers and shake. The key will fall out of the child’s pocket.", "Drehen Sie das Kind mit zwei Fingern um und schütteln Sie es. Der Schlüssel fällt aus der Tasche des Kindes." },
		{"Successful!", "Erfolgreich!" },
		//38
		{"Find the real shadow of the bird", "Finde den wahren Schatten des Vogels." },
		{"If you drag the sun over the bird, the bird will have a shadow.", "Wenn Sie die Sonne über den Vogel ziehen, hat der Vogel einen Schatten." },
		{"You are great.", "Du bist großartig." },
		//39
		{"Some months take 30, some take 31; how many months have 28 days?", "Einige Monate dauern 30, andere 31; Wie viele Monate haben 28 Tage?" },
		{"Each month has 28 days.", "Jeder Monat hat 28 Tage." },
		{"It’s that simple.", "So einfach ist das." },
		//40
		{"Do not explode the bomb!", "Explodiere die Bombe nicht!" },
		{"The bomb will not explode already, just wait for 30 seconds.", "Die Bombe wird nicht schon explodieren, warten Sie einfach 30 Sekunden." },
		{"How impatient you are.", "Wie ungeduldig du bist." },
		//41 DON'T FORGET TO CHANGE PREFAB
		{"You should hang the word of “Man” in the question.", "Sie sollten das Wort 'Mann' in die Frage hängen." },
		{"Rest in peace.", "Ruhe in Frieden." },
		//42
		{"Wake up the cow", "Weck die Kuh auf." },
		{"If you take the moon off the screen, the sun rises and the cow wakes up.", "Wenn Sie den Mond vom Bildschirm nehmen, geht die Sonne auf und die Kuh wacht auf." },
		{"How can you sleep that much?", "Wie kannst du so viel schlafen?" },
		//43
		{"Press the orange circle 10 times, then press the blue circle once", "Drücken Sie 10 Mal auf den orangefarbenen Kreis und dann einmal auf den blauen Kreis." },
		{"Are you sure that you pressed 10 times? Because the number starts from 1.", "Bist du sicher, dass du 10 Mal gedrückt hast? Weil die Nummer bei 1 beginnt." },
		{"Or did you press 9 times? We said 10...", "Oder hast du 9 mal gedrückt? Wir sagten 10..." },
		//44
		{"Find the couples and win the game", "Finde die Paare und gewinne das Spiel" },
		{"Shrink your screen, you will see your other mate.", "Verkleinern Sie Ihren Bildschirm, Sie werden Ihren anderen Partner sehen." },
		{"You did a good job.", "Du hast gute Arbeit geleistet." },
		//45
		{"How this equation becomes correct?", "Wie wird diese Gleichung richtig?" },
		{"Use the number of 45 in the Lv.45 to create 4550 number.", "Verwenden Sie die Nummer 45 in Lv.45, um eine 4550-Nummer zu erstellen." },
		{"You are a true genius.", "Du bist ein wahres Genie." },
		//46
		{"Confirm evenness by moving the single matchstick!", "Bestätigen Sie die Gleichmäßigkeit, indem Sie das einzelne Streichholz bewegen!" },
		{"Move the number of 4's matchstick and get 2 pieces of 1! 311+89=400", "Bewegen Sie die Nummer 4 des Streichholzes und erhalten Sie 2 Stück von 1! 311 + 89 = 400" },
		{"Did you know that the match was invented after the lighter?", "Wussten Sie, dass das Match nach dem Feuerzeug erfunden wurde?" },
		//47
		{"Make all of it green!", "Mach alles grün!" },
		{"First of all, shake the phone, then put the chameleon on the grass, and then paint the question with the paint bucket. Don't forget to remove the clouds from the screen.", "Schütteln Sie zuerst das Telefon, legen Sie dann das Chamäleon ins Gras und malen Sie die Frage mit dem Farbeimer. Vergessen Sie nicht, die Wolken vom Bildschirm zu entfernen." },
		{"How the greens will smile if the clouds do not cry?", "Wie werden die Grüns lächeln, wenn die Wolken nicht weinen?" },
		//48
		{"If 5 squirrels eat 5 walnuts in 5 minutes, in how many minutes does 15 squirrels eat 15 walnuts?", "Wenn 5 Eichhörnchen in 5 Minuten 5 Walnüsse essen, in wie vielen Minuten essen 15 Eichhörnchen 15 Walnüsse?" },
		{"In 5 minutes.", "In 5 Minuten." },
		{"Aren’t those squirrels so sweet?", "Sind diese Eichhörnchen nicht so süß?" },
		//49 DON'T FORGET TO CHANGE PREFAB
		{"Drag the word 'Protect' on to the rocket.", "Ziehen Sie das Wort 'Schützen' auf die Rakete." },
		{"Power shields are now activated.", "Power Shields sind jetzt aktiviert." },
		//50
		{"You should win the game again", "Sie sollten das Spiel erneut gewinnen." },
		{"Use 0 in the 50 words. Hold and drag it to the middle of O and press the other side.", "Verwenden Sie 0 in den 50 Wörtern. Halten Sie es gedrückt und ziehen Sie es in die Mitte von O und drücken Sie die andere Seite." },
		{"You know it.", "Du weißt es." },
		//51
		{"Pizza, ice-cream, cheese, cactus, 'Throw everything away' text and you should throw away the cap of the trash.", "Pizza, Eis, Käse, Kaktus, 'Wirf alles weg' - Text und du solltest die Kappe des Mülls wegwerfen." },
		//52
		{"How many rings are there on the screen?", "Wie viele Ringe gibt es auf dem Bildschirm?" },
		{"We hid 4 of them under the Clean button. '22'", "Wir haben 4 davon unter dem Clean-Button versteckt. '22'" },
		{"Nothing can escape from you.", "Nichts kann dir entkommen." },
		//53
		{"Collect 5 mice like in the picture", "Sammle 5 Mäuse wie auf dem Bild." },
		{"Just click to the mouse in the left direction and do not forget the mouse in the example.", "Klicken Sie einfach mit der Maus in die linke Richtung und vergessen Sie die Maus im Beispiel nicht." },
		{"You are a good hunter!", "Du bist ein guter Jäger!" },
		//54
		{"How can the kangaroo jump higher than the building?", "Wie kann das Känguru höher springen als das Gebäude?" },
		{"Make the trampoline bigger!", "Mach das Trampolin größer!" },
		{"Bounce bounce bounce...!", "Bounce Bounce Bounce...!" },
		//55
		{"Bring the magnifier to the child's arm on the lower left. You will see the replica.", "Bringen Sie die Lupe unten links zum Arm des Kindes. Sie sehen die Replik." },
		{"You’ve got him.", "Du hast ihn." },
		//56
		{"Which one is the prettiest?", "Welches ist das schönste?" },
		{"Drag the boy in front of the girl, whichever one he smiles at is the prettiest.", "Ziehen Sie den Jungen vor das Mädchen, welcher auch immer er anlächelt, ist der Schönste." },
		{"Love at first sight.", "Liebe auf den ersten Blick." },
		//57
		{"You should rub the baby’s belly and let the gas out.", "Sie sollten den Bauch des Babys reiben und das Gas herauslassen." },
		{"Ops the baby has gas.", "Ops das Baby hat Benzin." },
		//58 DON'T FORGET TO CHANGE PREFAB
		{"You should clean it by using the word 'Clean' in the question.", "Sie sollten es reinigen, indem Sie das Wort 'Bereinige' in der Frage verwenden." },
		{"I accept it was bad.", "Ich akzeptiere, dass es schlecht war." },
		//59
		{"Get the number of 100 twice by using a single line from the number of 188", "Ermitteln Sie die Zahl 100 zweimal, indem Sie eine einzelne Zeile aus der Zahl 188 verwenden." },
		{"Divide the number of 188 horizontally. You will have 2 of 1, 4 of 0.", "Teilen Sie die Zahl 188 horizontal. Sie haben 2 von 1, 4 von 0." },
		{"Wooww, you are super.", "Wooww, du bist super." },
		//60
		{"To drop an apple from the tree, you must shake the tree very much. Shake the phone.", "Um einen Apfel vom Baum fallen zu lassen, müssen Sie den Baum sehr stark schütteln. Schütteln Sie das Telefon." },
		{"Did this cow discover gravity?", "Hat diese Kuh die Schwerkraft entdeckt?" },
		//61
		{"Turn the light off", "Schalte das Licht aus." },
		{"Turn off the screen towards the table. The light will go off.", "Schalten Sie den Bildschirm in Richtung Tisch aus. Das Licht geht aus." },
		{"Where were we?", "Wo waren wir?" },
		//62
		{"Bring the pen into the empty space", "Bringen Sie den Stift in den leeren Raum." },
		{"One of the objects below can be rotated. Find the rotating pen and put it back correctly.", "Eines der folgenden Objekte kann gedreht werden. Suchen Sie den rotierenden Stift und setzen Sie ihn wieder richtig ein." },
		{"The pen is mightier than the sword.", "Die Feder ist mächtiger als das Schwert." },
		//63
		{"Feed the dog with the food under the box and wait for it to poop. Take the key that comes with the poop to the door.", "Füttere den Hund mit dem Futter unter der Kiste und warte, bis es kackt. Nimm den Schlüssel, der mit der Kacke kommt, zur Tür." },
		{"Sweet little doggie.", "Süßes kleines Hündchen." },
		//64
		{"Solve the problem!", "Das Problem lösen!" },
		{"Be careful about seeds of blackberry, 2 of them are missing. '18'", "Seien Sie vorsichtig mit Brombeersamen, 2 davon fehlen. '18'" },
		{"You understand the math...", "Du verstehst die Mathematik..." },
		//65
		{"Try to get rain from the cloud.", "Versuche Regen aus der Wolke zu bekommen." },
		{"It's raining, floods are flowing...", "Es regnet, Überschwemmungen fließen..." },
		//66
		{"Do you guess the three letters upcoming in the order?", "Erraten Sie die drei Buchstaben, die in der Reihenfolge erscheinen?" },
		{"Look carefully at the first letters of words in the question? Use the first letters of last two words", "Schauen Sie sich die ersten Buchstaben der Wörter in der Frage genau an? Verwenden Sie die ersten Buchstaben der letzten beiden Wörter." },
		{"Did you guess?", "Hast du geraten?" },
		//67
		{"Find objects!", "Objekte finden!" },
		{"You have a sharp sight!", "Du hast einen scharfen Anblick!" },
		//68
		{"How many numbers are there?", "Wie viele Nummern gibt es?" },
		{"You are super!", "Du bist super!" },
		//69
		{"Please write down the right answer?", "Bitte schreiben Sie die richtige Antwort auf." },
		{"You should think simple. Add up the 8 and 5.", "Sie sollten einfach denken. Addiere die 8 und 5." },
		{"Sometimes you need to think simple ;)", "Manchmal muss man einfach denken ;)" },
		//70
		{"I go to bed at 8 o'clock at night and I set my cuckoo clock at 9 in the morning. How many hours will I sleep?", "Ich gehe abends um 8 Uhr ins Bett und stelle meine Kuckucksuhr um 9 Uhr morgens ein. Wie viele Stunden werde ich schlafen?" },
		{"The cuckoo clock won’t differentiate night and day, hence you will sleep for one hour.", "Die Kuckucksuhr unterscheidet Tag und Nacht nicht, daher schlafen Sie eine Stunde lang." },
		{"Is the alarm a little bit early?", "Ist der Alarm etwas früh?" },
		//71
		{"With two fingers, swipe to the left on the screen and plug the phone into a socket. Then touch the cables at the same time.", "Wischen Sie mit zwei Fingern auf dem Bildschirm nach links und stecken Sie das Telefon in eine Steckdose. Berühren Sie dann gleichzeitig die Kabel." },
		{"Be careful, don’t be shocked!", "Sei vorsichtig, sei nicht schockiert!" },
		//72
		{"The wheel of the car is in one of the clouds. Put the cloud with your finger and shake it. Mount the wheel on the truck. Tilt the screen to the right. The truck will move across the street.", "Das Rad des Autos befindet sich in einer der Wolken. Legen Sie die Wolke mit Ihrem Finger und schütteln Sie sie. Montieren Sie das Rad am LKW. Kippen Sie den Bildschirm nach rechts. Der LKW fährt über die Straße." },
		{"Do not ask why the rubber tire is over there.", "Fragen Sie nicht, warum der Gummireifen dort drüben ist." },
		//73
		{"You should try to turn off the light with your finger.", "Sie sollten versuchen, das Licht mit Ihrem Finger auszuschalten." },
		{"There would not be a more creative way.", "Kreativer geht es nicht." },
		//74
		{"Choose 3 balls, verify the evenness!", "Wähle 3 Bälle, überprüfe die Gleichmäßigkeit!" },
		{"Turn the 9 upside down and make it 6! 11+13+6: 30! That much easy!", "Drehen Sie die 9 um und machen Sie es 6! 11 + 13 + 6: 30! So einfach!" },
		{"We put the ball upside down, sorry.", "Wir haben den Ball auf den Kopf gestellt, sorry." },
		//75
		{"Which one is the heaviest?", "Welches ist das schwerste?" },
		{"Lift both hammers and drop them at the same time to find out which one is the heaviest.", "Heben Sie beide Hämmer an und lassen Sie sie gleichzeitig fallen, um herauszufinden, welcher der schwersten ist." },
		{"I congratulate your physics teacher.", "Ich gratuliere Ihrem Physiklehrer." },
		//76 DON'T FORGET TO CHANGE PREFAB
		{"Drag the “fish” text over to the edge of the fishing hook.", "Ziehen Sie den Text „Fisch“ an den Rand des Angelhakens." },
		{"Delicious.", "Köstlich." },
		//77
		{"Shake the drink and help the child drink it", "Schütteln Sie das Getränk und helfen Sie dem Kind, es zu trinken." },
		{"Hold the bottle shut with your finger, shake your phone, and give the bottle to the child.", "Halten Sie die Flasche mit Ihrem Finger zu, schütteln Sie Ihr Telefon und geben Sie die Flasche dem Kind." },
		{"Shake before drinking!", "Vor dem Trinken schütteln!" },
		//78
		{"Help the child to open the safe", "Helfen Sie dem Kind, den Safe zu öffnen." },
		{"Turn the phone over and shake it. The key will fall out of the child’s pocket.", "Drehen Sie das Telefon um und schütteln Sie es. Der Schlüssel fällt aus der Tasche des Kindes." },
		{"What do you think inside of it?", "Was denkst du drin?" },
		//79
		{"Find the numbers on the balls", "Finde die Zahlen auf den Bällen." },
		{"148", "148" },
		{"Are you a math professor or something?", "Bist du ein Mathematikprofessor?" },
		//80
		{"Drag the screen towards the left and you will see the bird’s real shadow. (Use two fingers at the same time)", "Ziehen Sie den Bildschirm nach links und Sie sehen den echten Schatten des Vogels.(Verwenden Sie zwei Finger gleichzeitig)" },
		{"I’m impressed… You’re fast.", "Ich bin beeindruckt ... Du bist schnell." },
		//81
		{"Clean the car", "Putz das Auto." },
		{"You need to clean over the car with your finger.", "Sie müssen das Auto mit Ihrem Finger reinigen." },
		{"Sparkling clean.", "Funkelnd sauber." },
		//82
		{"Find the strongest balloon!", "Finde den stärksten Ballon!" },
		{"Drag the balloons over to the skip forward sign, 4 of them will pop! The strongest balloon won’t pop.", "Ziehen Sie die Luftballons zum Vorwärtssprungzeichen, 3 davon werden platzen! Der stärkste Ballon wird nicht platzen." },
		{"You’re doing great.", "Du machst das großartig." },
		//83
		{"How many orange cubes do you need to cover the blue cube?", "Wie viele orangefarbene Würfel benötigen Sie, um den blauen Würfel zu bedecken?" },
		{"22", "22" },
		{"That was a good one.", "Der war gut." },
		//84
		{"Flip the text with two fingers. Put it between the tap and the bucket.", "Drehen Sie den Text mit zwei Fingern um. Stellen Sie es zwischen den Wasserhahn und den Eimer." },
		{"Bet you didn’t think of that one, did you?", "Ich wette, du hast nicht daran gedacht, oder?" },
		//85
		{"The baby will sleep if you put your phone down on the table face down.", "Das Baby schläft, wenn Sie Ihr Telefon verdeckt auf den Tisch legen." },
		{"You’re the best at putting babies to sleep.", "Sie können Babys am besten einschläfern." },
		//86  DON'T FORGET TO CHANGE PREFAB
		{"What’s the size of the table?", "Wie groß ist der Tisch?" },
		{"You’re on a roll.", "Du bist auf einer Rolle." },
		//87
		{"Try dispersing the soil by shaking your phone", "Versuchen Sie, den Boden zu verteilen, indem Sie Ihr Telefon schütteln." },
		{"We’re covered in dirt.", "Wir sind voller Schmutz." },
		//88
		{"Please help me find my dog in this mess", "Bitte helfen Sie mir, meinen Hund in diesem Chaos zu finden." },
		{"You need to make the screen smaller. The dog is somewhere outside of the screen.", "Sie müssen den Bildschirm verkleinern. Der Hund ist irgendwo außerhalb des Bildschirms." },
		{"Thank you!", "Vielen Dank!" },
		//89
		{"Lift Thor’s hammer", "Hebe Thors Hammer." },
		{"The hammer is so heavy you will need to lift it with three fingers.", "Der Hammer ist so schwer, dass Sie ihn mit drei Fingern anheben müssen." },
		{"You’re even stronger than I thought!", "Du bist noch stärker als ich dachte!" },
		//90
		{"Find the pairs and win the game", "Finde die Paare und gewinne das Spiel." },
		{"Divide the last one remaining in half by drawing a line through the middle of it.", "Teilen Sie den letzten verbleibenden in zwei Hälften, indem Sie eine Linie durch die Mitte ziehen." },
		{"We make a good pair.", "Wir machen ein gutes Paar." },
		//91
		{"Touch the cow’s head 10 times.", "Berühren Sie den Kopf der Kuh 10 Mal." },
		{"The cow is a heavy sleeper.", "Die Kuh schläft schwer." },
		//92
		{"Hey..!! What day of the month is it?", "Hallo..!! Welcher Tag des Monats ist es?" },
		{"Seriously, what day of the month is it? What number is the calendar on your phone showing?", "Ernsthaft, welcher Tag des Monats ist es? Welche Nummer zeigt der Kalender auf Ihrem Telefon?" },
		{"Sometimes I forget the date, too.", "Manchmal vergesse ich auch das Datum." },
		//93
		{"You need to shake the tree a lot. The key will fall from it.", "Sie müssen den Baum viel schütteln. Der Schlüssel wird davon fallen." },
		{"Whose idea was it to hide the key in a tree?", "Wessen Idee war es, den Schlüssel in einem Baum zu verstecken?" },
		//94  DON'T FORGET TO CHANGE PREFAB
		{"You can use the word “Balance” in the text to balance the scale.", "Sie können das Wort 'ausbalancieren' im Text verwenden, um die Skala auszugleichen." },
		{"Are you balanced?", "Bist du ausgeglichen?" },
		//95
		{"If the bridge is falling apart, you need to support the middle of the bridge with your hand.", "Wenn die Brücke auseinander fällt, müssen Sie die Mitte der Brücke mit Ihrer Hand stützen." },
		{"You’re the king of the road.", "Du bist der König der Straße." },
		//96
		{"It’s snowing! Catch the snow...", "Es schneit! Fang den Schnee…" },
		{"Place your phone on a flat surface with the screen facing up and wait.", "Stellen Sie Ihr Telefon mit dem Bildschirm nach oben auf eine ebene Fläche und warten Sie." },
		{"Become one with the snow.", "Werde eins mit dem Schnee." },
		//97
		{"Help him escape prison", "Hilf ihm, aus dem Gefängnis zu fliehen." },
		{"You can escape by pressing the escape button after you unscrew the lightbulb.", "Sie können entkommen, indem Sie die Fluchttaste drücken, nachdem Sie die Glühbirne abgeschraubt haben." },
		{"Smells like freedom!", "Riecht nach Freiheit!" },
		//98
		{"Park the car", "Parke das Auto." },
		{"There might be space further down the road.", "Weiter unten könnte Platz sein." },
		{"Slowly… Slowly… Now park the car!", "Langsam ... Langsam ... Jetzt parken Sie das Auto!" },
		//99
		{"You will catch the cheater if you move the front row.", "Sie werden den Betrüger fangen, wenn Sie die erste Reihe bewegen." },
		{"Caught red-handed.", "Auf frischer Tat ertappt." },
		//100
		{"Help the child see!", "Hilf dem Kind zu sehen!" },
		{"Drag the two zeros in '100' to make glasses for the kid.", "Ziehen Sie die beiden Nullen in '100', um eine Brille für das Kind herzustellen." },
		{"That’ll show you!", "Das wird es dir zeigen!" },
		//101
		{"Which one would you save?", "Welches würdest du sparen?" },
		{"You need to press all three at the same time. Don’t try doing it one by one.", "Sie müssen alle drei gleichzeitig drücken. Versuchen Sie nicht, es einzeln zu tun." },
		{"You are so single.", "Du bist so Single." },
		{"Family", "Familie" },
		{"Love", "Liebe" },
		{"Money", "Geld" },
		//102
		{"The animals are racing. The cow, the rabbit, and the turtle. Help the turtle win", "Die Tiere rennen. Die Kuh, das Kaninchen und die Schildkröte. Hilf der Schildkröte zu gewinnen." },
		{"Drag the start button and hit the Turbo button underneath.", "Ziehen Sie die Starttaste und drücken Sie die Turbo-Taste darunter." },
		{"Fast and furious.", "Schnell und wütend." },
		{"Start", "Start" },
		//103
		{"The baby will sleep if you turn the volume down on your phone.", "Das Baby schläft, wenn Sie die Lautstärke Ihres Telefons verringern." },
		{"Hush...", "Stille..." },
		//104
		{"What should be the next number in the sequence?", "Was sollte die nächste Nummer in der Sequenz sein?" },
		{"Read the numbers you see out loud! The numbers are how the previous numbers sound when you read them together… '13112221'", "Lesen Sie die Zahlen, die Sie laut sehen! Die Zahlen sind so, wie die vorherigen Zahlen klingen, wenn Sie sie zusammen lesen… '13112221'" },
		{"We’ll admit it was a hard question.", "Wir werden zugeben, dass es eine schwierige Frage war." },
		//105
		{"Help the truck pass through the tunnel", "Helfen Sie dem LKW, durch den Tunnel zu fahren." },
		{"Shrink the truck with two fingers.", "Schrumpfen Sie den LKW mit zwei Fingern." },
		{"Well done!", "Gut gemacht!" },
		//106
		{"If Mary gathers 2 bananas in 1 minute, how many bananas can she gather from this tree in 10 minutes?", "Wenn Mary in 1 Minute 2 Bananen sammelt, wie viele Bananen kann sie in 10 Minuten von diesem Baum sammeln?" },
		{"Does it look like bananas grow on this tree? The answer is '0'", "Sieht es so aus, als ob Bananen auf diesem Baum wachsen? Die Antwort lautet '0'" },
		{"You’re quite smart.", "Du bist ziemlich schlau." },
		//107 DON'T FORGET TO CHANGE PREFAB
		{"The match will be lit if you drag it and rub it over the word 'Light'.", "Das Streichholz wird beleuchtet, wenn Sie es ziehen und über das Wort 'Zünde' reiben." },
		{"Don’t play with fire.", "Spiel nicht mit dem Feuer." },
		//108
		{"List the numbers you see on the screen in order", "Listen Sie die Zahlen, die Sie auf dem Bildschirm sehen, der Reihe nach auf." },
		{"At first, it started with 3, 2, 1, didn’t you see? 3, 2, 1, 32, 67, 21, 5, 14, 8", "Zuerst begann es mit 3, 2, 1, hast du nicht gesehen? 3, 2, 1, 32, 67, 21, 5, 14, 8" },
		{"I’m in awe of your visual memory!", "Ich habe Ehrfurcht vor Ihrem visuellen Gedächtnis!" },
		//109
		{"Who is pregnant?", "Wer ist schwanger?" },
		{"Turn your phone upside down and shake it. Drag the pregnancy test over to the woman on the right.", "Drehen Sie Ihr Telefon um und schütteln Sie es. Ziehen Sie den Schwangerschaftstest auf die Frau rechts." },
		{"Congratulations!", "Herzliche Glückwünsche!" },
		//110
		{"How many squares are there?", "Wie viele Quadrate sind da?" },
		{"Would it be 40?", "Wäre es 40?" },
		{"It is 40!", "Es ist 40!" },
		//111
		{"Make the man happy!", "Mach den Mann glücklich!" },
		{"Drag the man up over the clouds.", "Ziehe den Mann über die Wolken." },
		{"Being happy is that simple!", "Glücklich zu sein ist so einfach!" },
		//112
		{"Sally is 21 years older than her son. 2 years ago, Sally was 4 times her son’s age. How old is Sally?", "Sally ist 21 Jahre älter als ihr Sohn. Vor 2 Jahren war Sally viermal so alt wie ihr Sohn. Wie alt ist Sally?" },
		{"She is 31.", "Sie ist 31." },
		{"What did you study in school?", "Was hast du in der Schule gelernt?" },
		//113
		{"Park the car in the right spot", "Parken Sie das Auto an der richtigen Stelle." },
		{"Drag the skirt off of the female symbol in the middle to make it appropriate for the driver.", "Ziehen Sie den Rock vom weiblichen Symbol in der Mitte ab, damit er für den Fahrer geeignet ist." },
		{"Thought you’d never figure it out.", "Ich dachte, du würdest es nie herausfinden." },
		//114
		{"That counts as a three-pointer.", "Das zählt als Drei-Zeiger." },
		//115
		{"Did you try taking the light that won’t turn off out of the screen?", "Haben Sie versucht, das Licht, das sich nicht ausschaltet, vom Bildschirm zu entfernen?" },
		{"I love your sharp wit!", "Ich liebe deinen scharfen Witz!" },
		//116
		{"Save the gorilla :(", "Rette den Gorilla :(" },
		{"You can use the hint key to unlock the lock.", "Sie können die Hinweistaste verwenden, um das Schloss zu entsperren." },
		{"#FreedomForAnimals", "#FreedomForAnimals" },
		//117
		{"What’s the fastest route from A to I?", "Was ist der schnellste Weg von A nach I?" },
		{"You need to swap B and I’s places.", "Sie müssen die Plätze von B und mir tauschen." },
		{"You’re so fast!", "Du bist so schnell!" },
		//118
		{"Burn everything", "Verbrenne alles." },
		{"Drag the magnifying glass between the sun and the wood to spark a fire. Then use the wood on the fire to burn everything. You can pass the level by burning everything including the 'Burn everything' text and the sun.", "Ziehen Sie die Lupe zwischen Sonne und Holz, um ein Feuer zu entfachen. Verwenden Sie dann das Holz auf dem Feuer, um alles zu verbrennen. Sie können das Level bestehen, indem Sie alles brennen, einschließlich 'Alles brennen'. Text und die Sonne." },
		{"Time to call the fire station!", "Zeit, die Feuerwache anzurufen!" },
		//119
		{"2 of them are drowned, 4 of them are swimming, and 3 of them are dead. How many fish left in the aquarium?", "2 von ihnen ertrinken, 4 schwimmen und 3 sind tot. Wie viele Fische sind noch im Aquarium?" },
		{"Fish don’t drown in water. But even if they did, none of them would go out of aquarium hence, 10 fish will be left.", "Fische ertrinken nicht im Wasser. Aber selbst wenn sie es tun würden, würde keiner von ihnen das Aquarium verlassen, daher bleiben 10 Fische übrig." },
		{"You are a real genius.", "Du bist ein echtes Genie." },
		//120
		{"You should try charging your own phone while the game is on.", "Sie sollten versuchen, Ihr eigenes Telefon aufzuladen, während das Spiel läuft." },
		{"We gave you an excuse to charge your phone :)", "Wir haben dir eine Ausrede gegeben, dein Handy aufzuladen :)" },
		//121
		{"Put the fire out", "Das Feuer löschen." },
		{"Squeeze the cloud with two fingers and make water spill to put out the fire.", "Drücken Sie die Wolke mit zwei Fingern zusammen und lassen Sie Wasser verschütten, um das Feuer zu löschen." },
		{"It’s raining cats and dogs!", "Es schüttet wie aus Eimern!" },
		//122
		{"Find the pirate", "Finde den Piraten." },
		{"Pirates have wooden legs. Try lifting their pant legs to see.", "Piraten haben Holzbeine. Versuchen Sie, die Hosenbeine anzuheben, um zu sehen" },
		{"Nice, the next question awaits.", "Schön, die nächste Frage wartet." },
		//123
		{"Complete the equation", "Vervollständige die Gleichung." },
		{"Take the 1, 2, and 3 from “Lv. 123” and put them in the places of A, B, and C. That will complete the equation.", "Nimm die 1, 2 und 3 aus 'Lv. 123' und setzen Sie sie an die Stellen von A, B und C. Damit wird die Gleichung vervollständigt." },
		{"You really surprised me.", "Du hast mich wirklich überrascht." },
		//124
		{"Defeat your competitor in Rock-Paper-Scissors game!", "Besiege deinen Konkurrenten im Rock-Paper-Scissors-Spiel!" },
		{"You have to move to the winning side by relocating the players!", "Sie müssen auf die Gewinnerseite wechseln, indem Sie die Spieler verschieben!" },
		{"Or did you cheat?", "Oder hast du geschummelt?" },
		//125
		{"It’s 3:35. What time would it be if the clock moved counter-clockwise 90 degrees?", "Es ist 3:35 Uhr. Wie spät wäre es, wenn sich die Uhr um 90 Grad gegen den Uhrzeigersinn bewegen würde?" },
		{"Could it be 12:20?", "Könnte es 12:20 sein?" },
		{"Did you ask your friends what level they’re on?", "Hast du deine Freunde gefragt, auf welchem Level sie sind?" },
		//126 DON'T FORGET TO CHANGE PREFAB
		{"Did you try to click on Europe text?", "Haben Sie versucht, auf Europa-Text zu klicken?" },
		{"Bravo!", "Bravo!" },
		//127
		{"Make the bulbs explode by clicking on the lights 5 times", "Lassen Sie die Glühbirnen explodieren, indem Sie fünfmal auf die Lichter klicken." },
		{"The lights are off alright...", "Die Lichter sind in Ordnung aus ..." },
		//128
		{"He broke the vase 10 minutes ago. Help him fix it", "Er hat die Vase vor 10 Minuten zerbrochen. Hilf ihm, das Problem zu beheben." },
		{"The vase wasn’t broken 10 minutes ago. Try rewinding the clock.", "Die Vase wurde vor 10 Minuten nicht zerbrochen. Versuchen Sie, die Uhr zurückzuspulen." },
		{"You just traveled through time.", "Du bist gerade durch die Zeit gereist." },
		//129
		{"Which tank would be filled first?", "Welcher Tank würde zuerst gefüllt werden?" },
		{"Draw a line to A's drain. Thus, 'A' will be filled first.", "Zeichnen Sie eine Linie zu A's Abfluss. Somit wird zuerst 'A' gefüllt." },
		{"Hmm, smart...", "Hmm, klug …" },
		//130
		{"Shrink the building.", "Schrumpfe das Gebäude." },
		{"Kangaroo-lations!", "Känguru-Lationen!" },
		//131 DON'T FORGET TO CHANGE PREFAB
		{"You should try turning the 9 in the question into a 6. Then you will have the right number of bananas.", "Sie sollten versuchen, die 9 in der Frage in eine 6 zu verwandeln. Dann haben Sie die richtige Anzahl von Bananen." },
		{"Something’s not right about this.", "Daran stimmt etwas nicht." },
		//132
		{"What should fill the blank?", "Was soll die Lücke füllen?" },
		{"Did you ever drive? This was car gear. Reverse gear 'R'...", "Bist du jemals gefahren? Das war Autoausrüstung. Rückwärtsgang 'R' ..." },
		{"Ok understood, you don’t have an 'R'.", "Ok, verstanden, du hast kein 'R'." },
		//133
		{"How many 3's are there?", "Wie viele 3er gibt es?" },
		{"There are five 3's including the ones in 'Lv.133' and the question.", "Es gibt fünf 3er, einschließlich der in 'Lv.133' und der Frage." },
		{"Good catch!", "Guter Fang!" },
		//134
		{"Shake the clouds and catch the fish with the worm under the tree.", "Schütteln Sie die Wolken und fangen Sie den Fisch mit dem Wurm unter dem Baum." },
		{"Hook, line, and sinker!", "Haken, Leine und Platine!" },
		//135
		{"Help the truck pass through the tunnel!", "Hilf dem LKW durch den Tunnel zu fahren!" },
		{"Deflate the truck’s wheels! You can use the 'Forward' symbol.", "Entleeren Sie die Räder des LKW! Sie können das Symbol 'Weiterleiten' verwenden." },
		{"Wish we could give you a reward.", "Ich wünschte, wir könnten Ihnen eine Belohnung geben." },
		//136
		{"Make a square by moving 2 balls", "Bilden Sie ein Quadrat, indem Sie 2 Kugeln bewegen." },
		{"Wow!", "Beeindruckend!" },
		//137
		{"Turn off the lights", "Schalte das Licht aus" },
		{"You should try putting your phone upside down on the table, with the screen facing down. Then the light will go off.", "Sie sollten versuchen, Ihr Telefon mit dem Bildschirm nach unten auf den Tisch zu legen. Dann geht das Licht aus." },
		{"That’s what we’re talking about.", "Darüber sprechen wir." },
		//138
		{"Turn the cow in the other direction before it reaches the soil.", "Drehen Sie die Kuh in die andere Richtung, bevor sie den Boden erreicht." },
		{"Where there’s a will, there’s a way.", "Wo ein Wille ist, ist auch ein Weg." },
		//139
		{"Speed up the clock and reveal the pregnant woman.", "Beschleunigen Sie die Uhr und enthüllen Sie die schwangere Frau." },
		{"Time flies...", "Zeit vergeht..." },
		//140
		{"Take the key on the upper right corner of the screen and drag it onto the door to pass the level.", "Nimm den Schlüssel in der oberen rechten Ecke des Bildschirms und ziehe ihn auf die Tür, um das Level zu passieren." },
		{"We couldn’t trick you...", "Wir konnten dich nicht austricksen ..." },
		//141
		{"Leave me alone for a bit...", "Lass mich ein bisschen in Ruhe." },
		{"Leave the game, wait a couple of seconds, and re-enter the game.", "Verlasse das Spiel, warte ein paar Sekunden und betrete das Spiel erneut." },
		{"Thank you for understanding.", "Danke für dein Verständnis." },
		//142
		{"Hold the basketball with your finger and slam dunk!", "Halten Sie den Basketball mit Ihrem Finger und knallen Sie ein!" },
		{"A great slam dunk.", "Ein großartiger Slam Dunk." },
		//143
		{"Catch person who is cheating!", "Fang eine Person, die betrügt!" },
		{"Try lifting the child’s hat who is at the right.", "Versuchen Sie, den Hut des Kindes rechts anzuheben." },
		{"You are not missing a thing.", "Ihnen fehlt nichts." },
		//144
		{"Help an old lady cross the road", "Hilf einer alten Dame, die Straße zu überqueren." },
		{"One of the trucks has a green light in its truck bed. You need to put it in the right spot.", "Einer der Lastwagen hat grünes Licht in seiner Ladefläche. Sie müssen es an der richtigen Stelle platzieren." },
		{"Thank you for your help!", "Danke für deine Hilfe!" },
		//145
		{"What is the result of the calculation?", "Was ist das Ergebnis der Berechnung?" },
		{"The result of the calculation is '-62'.", "Das Ergebnis der Berechnung ist '-62'." },
		{"The social science people are now crying.", "Die Sozialwissenschaftler weinen jetzt." },
		//146
		{"Gather the stones upstream and stop the water. Drag the net over the fish.", "Sammeln Sie die Steine stromaufwärts und stoppen Sie das Wasser. Ziehen Sie das Netz über den Fisch" },
		{"The fish jumps once jumps twice...", "Der Fisch springt einmal springt zweimal ..." },
		//147
		{"Shrink down the fire!", "Schrumpfe das Feuer!" },
		{"Shake the phone, let the fire disperse and choose the smaller one!", "Schütteln Sie das Telefon, lassen Sie das Feuer zerstreuen und wählen Sie das kleinere!" },
		{"Did you try to snuff it out?", "Hast du versucht, es auszulöschen?" },
		//148
		{"Find the password!", "Finde das Passwort!" },
		{"'042' Think again... You can also ask a friend.", "042' Denken Sie noch einmal nach ... Sie können auch einen Freund fragen." },
		{"If you found this as well, you should be proud of yourself!", "Wenn Sie dies auch gefunden haben, sollten Sie stolz auf sich sein!" },
		{"A number and it's place are correct", "Eine Nummer und ihr Platz sind korrekt" },
		{"A number is correct but it's place is wrong", "Eine Zahl ist korrekt, aber der Ort ist falsch" },
		{"Two numbers are correct but the places are wrong", "Zwei Zahlen sind richtig, aber die Stellen sind falsch" },
		{"Nothing is correct", "Nichts ist richtig" },
		{"ENTER", "EINGEBEN" },
		//149
		{"Weigh the chicken", "Wiegen Sie das Huhn." },
		{"Shake the chicken to make its eggs fall out and make it lighter.", "Schütteln Sie das Huhn, damit seine Eier herausfallen und es leichter wird." },
		{"I’m light as a feather.", "Ich bin federleicht." },
		//150
		{"Is it too quiet here?", "Ist es hier zu leise?" },
		{"A little music wouldn't be bad.", "Ein bisschen Musik wäre nicht schlecht." },
		{"Music is the essence of the soul ;)", "Musik ist die Essenz der Seele;)" },
		//151
		{"Take the ball outside!", "Bring den Ball nach draußen!" },
		{"Pour water from the dispenser size bottle to the glass and pour it into the pipe. Let the ball go up.", "Gießen Sie Wasser aus der Flasche in Spendergröße in das Glas und gießen Sie es in das Rohr. Lass den Ball hoch gehen." },
		{"You discovered the buoyant force of the water.", "Sie haben die Auftriebskraft des Wassers entdeckt." },
		//152
		{"Score a goal.", "Ein Tor schießen." },
		{"Try to press two arrows at the same time.", "Versuchen Sie, gleichzeitig auf zwei Pfeile zu klicken." },
		{"Gooaal!..!!", "Toooooooor ...!" },
		//153
		{"Make the baby laugh.", "Bringen Sie das Baby zum Lachen." },
		{"Take off the baby's socks and tickle the baby's feet with a feather.", "Ziehen Sie die Socken des Babys aus und kitzeln Sie seine Füße mit einer Feder." },
		{"The world is better when babies laugh.", "Die Welt ist besser, wenn Babys lachen." },
		//154
		{"Bring the child to the exit", "Bringen Sie das Kind zum Ausgang" },
		{"Turn your phone over and watch the child.", "Drehen Sie Ihr Telefon um und beobachten Sie das Kind." },
		{"Did you send the game to your friends? Now, send it from the share button below.", "Haben Sie das Spiel an Ihre Freunde geschickt? Senden Sie es jetzt über die Schaltfläche ‘Teilen’ unten." },
		//155
		{"The child is so lonely", "Das Kind ist so einsam" },
		{"Hold on the child with your finger for 5 seconds and then, copy the child.", "Halten Sie das Kind 5 Sekunden lang mit Ihrem Finger fest und kopieren Sie es dann." },
		{"Now, they are twins.", "Jetzt sind sie Zwillinge." },
		{"Copy", "Kopieren" },
		{"Rate the game", "Bewerte das Spiel" },
		//156
		{"Please click in the following order", "Bitte klicken Sie in der folgenden Reihenfolge" },
		{"Are you sure you did the right thing? Watch out for the last finger.", "Sind Sie sicher, dass Sie das Richtige getan haben? Achten Sie auf den letzten Finger." },
		{"That's it!", "Das ist es!" },
		//157
		{"Silence the child", "Bring das Kind zum Schweigen" },
		{"The toy is hidden under the button. Give it to the child.", "Das Spielzeug ist unter dem Knopf versteckt. Geben Sie es dem Kind." },
		{"It's really awesome.", "Es ist wirklich super." },
		{"Watch video", "Schau Video" },
		//158 DON'T FORGET TO CHANGE PREFAB
		{"Unlock the case.", "Entsperren Sie den Koffer." },
		{"Take the word ‘password’ to the correct place.", "Bringen Sie das Wort ‘Passwort’ an die richtige Stelle." },
		{"Is it difficult?", "Ist es schwer?" },
		//159
		{"Grab the gift box on the daily bonus button and give it to the man. The man will be happy to receive a gift.", "Nehmen Sie die Geschenkbox auf dem täglichen Bonusknopf und geben Sie sie dem Mann. Der Mann freut sich über ein Geschenk." },
		{"Who recently bought you a gift?", "Wer hat Ihnen kürzlich ein Geschenk gekauft?" },
		//160
		{"What does the child see?", "Was sieht das Kind?" },
		{"Try to look at from the perspective of the child.", "Versuchen Sie, aus der Perspektive des Kindes zu betrachten." },
		{"It's all about perspective!", "Es geht nur um Perspektive!" },
		//161 DON'T FORGET TO CHANGE PREFAB
		{"One of the X's can be moved. Remove X and replace it with the dot in the question.", "Eines der X kann verschoben werden. Entfernen Sie X und ersetzen Sie es durch den Punkt in der Frage." },
		{"You are true genius!", "Sie sind ein wahres Genie!" },
		//162
		{"Make the girl fall in love with the boy", "Lassen Sie das Mädchen sich in den Jungen verlieben" },
		{"Shake the child quite a while. Maybe he is hiding a surprise gift.", "Schütteln Sie das Kind eine ganze Weile. Vielleicht versteckt er ein Überraschungsgeschenk." },
		{"You're the last single person in the world.", "Sie sind der letzte Einzelne auf der Welt." },
		//163 DON'T FORGET TO CHANGE PREFAB
		{"Try to use the word 'Truck'.", "Versuchen Sie, das Wort ‘LKW’ zu verwenden." },
		{"Poor truck.", "Armer LKW." },
		//164
		{"Find the water for kids to make a water fight.", "Finden Sie das Wasser für Kinder, um einen Wasserschlacht zu führen." },
		{"Hold both clouds with your fingers at the same time shake your phone.", "Halten Sie beide Wolken gleichzeitig mit Ihren Fingern und schütteln Sie Ihr Telefon." },
		{"May the best man win!", "Möge der beste Mann gewinnen!" },
		//165
		{"Shout and Say 'MOM'", "Schreien Sie und sagen Sie 'MOM'" },
		{"The level will be passed when you click the start button 4 times and fill the bar. You must allow microphone access, or enable Phone Settings > Apps > Trick Me > Permissions > Microphone option.", "Das Level wird bestanden, wenn Sie viermal auf die Startschaltfläche klicken und die Leiste füllen. Sie müssen den Mikrofonzugriff zulassen oder die Option Telefoneinstellungen > Apps > Trick Me > Berechtigungen > Mikrofon aktivieren." },
		{"What did you mom say?", "Was hast du Mama gesagt?" },
		//166
		{"Find a frame for these colored objects.", "Finden Sie einen Rahmen für diese farbigen Objekte." },
		{"I said find 'a frame' for these colored objects. :)", "Ich sagte, finden Sie 'einen Rahmen' für diese farbigen Objekte. :) :)" },
		{"You are amazing!", "Sie sind unglaublich!" },
		//167
		{"Do something to end the war.", "Tuen Sie etwas, um den Krieg zu beenden." },
		{"If you shoot at the right place, the war is over.", "Wenn Sie am richtigen Ort schießen, ist der Krieg vorbei." },
		{"#worldpeace", "#Weltfrieden" },
		//168
		{"Find the ball?", "Den Ball finden?" },
		{"To make 'x10' 'x1', delete '0' using your finger.", "Um 'x10' 'x1' zu machen, löschen Sie '0' mit Ihrem Finger." },
		{"A++++++", "A ++++++" },
		//169
		{"After the game has started, you must turn the child left using your finger.", "Nach dem Start des Spiels müssen Sie das Kind mit dem Finger nach links drehen." },
		{"Nobody could pass this level except you.", "Niemand außer Ihnen konnte dieses Level bestehen." },
		//170
		{"Hit the man's head and knock the man out. Then, shoot the ball.", "Schlagen Sie den Kopf des Mannes und schlagen Sie den Mann aus. Dann schießen Sie den Ball." },
		{"Incredible goal!", "Unglaubliches Ziel!" },
		//171
		{"Grasp the first car with two fingers and remove it draggingly. Then, park your car in its place.", "Fassen Sie das erste Auto mit zwei Fingern und entfernen Sie es schleppend. Dann parken Sie Ihr Auto an seinem Platz." },
		{"Nice job!", "Gut gemacht!!" },
		//172
		{"One of the L's in Lvl is big and the other small.", "Eines der Ls in Lvl ist groß und das andere klein." },
		{"You can think differently...", "Sie können anders denken ..." },
		//173 DON'T FORGET TO CHANGE PREFAB
		{"Enter password", "Passwort eingeben" },
		{"Try zooming your screen a few times.", "Versuchen Sie, den Bildschirm einige Male zu zoomen." },
		{"You're very good!", "Sie haben das sehr gut gemacht!" },
		//174
		{"Behind one of the windows.", "Hinter einem der Fenster." },
		{"Don't lie, you're a gamer, too.", "Lügen Sie nicht, Sie sind auch ein Spieler." },
		//175
		{"Grab the small key on watch video button and drag it to the door.", "Nehmen Sie den kleinen Schlüssel auf der Schaltfläche ‘Video ansehen’ und ziehen Sie ihn zur Tür." },
		{"Amazing!", "Toll!" },
		//176
		{"Hi, we’re still working on new levels. Stay tuned for the next update.", "Hallo, wir arbeiten immer noch an neuen Levels. Seien Sie gespannt auf das nächste Update." },
		{"", "" }
    };
    public static Dictionary<string, string> RU = new Dictionary<string, string>()
    {
		{"EN", "RU" },
		//GENERAL UI ELEMENTS
		{"7.99USD", "320RUB" },
		{"Don't show again.", "Больше не появляйся." },
		{"You have to turn the phone's rotating feature on.", "Вы должны включить вращающуюся функцию телефона." },
		{"RESTORE", "Восстановить" },
		{"Restore Purchases", "Восстановление закупок" },
		{"COMING SOON...", "СКОРО..." },
		{"COME AGAIN TOMORROW!", "ПРИХОДИТЕ ЗАВТРА!" },
		{"3 days free", "3 дня бесплатно" },
		{"AND...", "И..." },
		{"BECOME VIP!", "СТАНЬТЕ VIP!" },
		{"CONGRATULATIONS!!!", "ПОЗДРАВЛЯЮ!!!" },
		{"Daily Bonus", "Ежедневный бонус" },
		{"Double daily bonus", "Двойной ежедневный бонус" },
		//ANDROID EXPLANATION
		//Weekly Premium automatically renews. Payment will be charged to your Google account at the end of the trial period of purchase. The subscription automatically renews unless auto-renews unless auto-renew is turned off at least 24 hours before the end of the current period. You can manage and turn off auto-renewal of the subscription by going to your account settings on the Google Play after purchase.
		//IOS EXPLANATION
		//Weekly Premium automatically renews. Payment will be charged to your iTunes account at the end of the trial period of purchase The subscription automatically renews unless auto-renews unless auto-renew is turned off at least 24 hours before the end of the current period. You can manage and turn off auto-renewal of the subscription by going to your account settings on the iTunes after purchase.
		{"Feedback", "Обратная связь" },
		{"Free", "Бесплатный" },
		{"Game Reset", "Перезагрузка игры" },
		{"Hint discounts", "Скидки на подсказку" },
		{"INSTANTLY", "МГНОВЕННО" },
		{"All Levels", "Все уровни" },
		{"Music", "Музыка" },
		{"Next", "Следующий" },
		{"Nice start...", "Хорошее начало..." },
		{"Privacy Policy", "Политика конфиденциальности" },
		{"PRIVACY POLICY", "ПОЛИТИКА КОНФИДЕНЦИАЛЬНОСТИ" },
		{"Rate", "Ставка" },
		{"remove ads", "удалить объявления" },
		{"Remove ads", "Удалить объявления" },
		{"Remove Ads", "Удалить Объявления" },
		{"Share", "Поделиться" },
		{"Skip discounts", "Пропускайте скидки" },
		{"Skip", "Пропустить" },
		{"Skipping costs 2 keys. Would you like to skip?", "Пропуск стоит 2 ключа. Хочешь пропустить?" },
		{"Sounds", "Звуки" },
		{"Store", "Магазин" },
		{"TERMS OF USE", "УСЛОВИЯ ИСПОЛЬЗОВАНИЯ" },
		{"Terms of Use", "Условия использования" },
		{"TRY FOR FREE!", "ПОПРОБУЙТЕ БЕСПЛАТНО!" },
		{"Vibration", "Вибрация" },
		{"Watch", "Часы" },
		{"Weekly", "Еженедельно" },
		//PREFABS
		{"Exit", "Выход" },
		{"OK", "ХОРОШО" },
		{"Fire", "Пожар" },
		{"FINISH", "ЗАКОНЧИТЬ" },
		{"RUN", "ЗАПУСТИТЬ" },
		{"CLEAR", "ЯСНО" },
		{"START", "НАЧАТЬ" },
		{"JUMP", "ПРЫГАТЬ" },
		{"Write your answer", "Напишите свой ответ" },
		//LEVELS
		//1
		{"Which one is red?", "Который из них красный?" },
		{"Or you didn't click on the red text?", "Или вы еще не нажали на красный текст?" },
		{"Good start.", "Хорошее начало." },
		{"Green", "Грюн" },
		{"Yellow", "Желтый" },
		{"Blue", "Синий" },
		{"Red", "Красного" },
		//2
		{"Shoot the basketball into the hoop", "Попадите баскетбольным мячом в кольцо." },
		{"You need to press the shoot button when it reaches green in order to shoot.", "Вам нужно нажать кнопку броска, когда она станет зеленого цвета, чтобы сделать бросок." },
		{"Nice shot.", "Отличный бросок." },
		{"Shoot", "Стрелять" },
		//3
		{"Throw everything away", "Выбросьте все, что видите." },
		{"You should drag-and-drop pizza, cheese, ice-cream and cactus to the trash.", "Вы должны перетащить пиццу, сыр, мороженое и кактус в мусорное ведро." },
		{"Cleaning is important, of course...", "Чистота, конечно, важна, нооо." },
		//4
		{"Find the different one", "Найдите то, что отличается." },
		{"Could it be under the ice-cream? Look at it.", "Попробуйте заглянуть под мороженое." },
		{"I guess someone likes a different kind of ice-cream :)", "Наверное, кто-то любит другое мороженое :)" },
		//5
		{"Which one is the biggest drop?", "Какая капля самая большая?" },
		{"Put the drops on top of each other and create the largest one.", "Положите капли друг на друга и создайте самую большую" },
		{"Many a mickle makes a muckle...", "Иногда не стоит недооценивать малый размер вещей..." },
		//6
		{"Did you try covering the lamp with your hand?", "Вы пробовали прикрыть лампу рукой?" },
		{"You managed to help the baby sleep again. Zzz...", "Вам удалось помочь ребенку... и он снова заснул. Хрррр..." },
		//7
		{"How many points do you give to this game?", "Сколько очков вы дадите этой игре?" },
		{"I think you liked it very much.", "Я думаю, что она вам очень понравилась." },
		{"Since you loved it so much, let’s continue!", "Раз так, то давайте продолжим!" },
		{"Waste of time", "Пустая трата времени" },
		{"I couldn't figured it out", "Я не мог понять это" },
		{"It's OK", "Это нормально" },
		{"It's nice", "Прекрасно" },
		{"I liked it very much!", "Мне очень понравилось!" },
		//8
		{"Make the baby sleep", "Заставьте ребенка спать." },
		{"Firstly, you should give the bottle and then try to put the baby to sleep in his/her car.", "Во-первых, вы должны дать ему бутылочку, а затем попытаться уложить ребенка спать в его или ее коляске." },
		{"Rub-a-dub-dub... Zzz...", "Бам-бам-бам... Хрррр..." },
		//9
		{"Balance the scale", "Уравновесьте весы." },
		{"If you take everything off, the scale would be even.", "Если снять все предметы, то весы будут уравновешены." },
		{"I know you are a balanced person.", "Я знаю, что вы - уравновешенный человек." },
		//10
		{"One of the girls looking at the West, the other is to the East. But both of them can see each other, how can you do that?", "Одна из девушек смотрит на запад, другая - на восток. Но они обе могут видеть друг друга... Как это возможно?" },
		{"You should move the girls’ head as to be turned as face-to-face.", "Вы должны повернуть головы девушек так, чтобы они оказались лицом к лицу." },
		{"I see you’re getting used to it.", "Мне кажется, что вы привыкаете к нашей игре." },
		//11
		{"Open the door", "Откройте дверь." },
		{"You need to use the key in the child's pocket in order to open the door.", "Вам нужно использовать ключ в кармане ребенка, чтобы открыть дверь." },
		{"Yeah, that’s it ;)", "Да, именно так ;)" },
		//12
		{"Stop the fight..!!", "Остановите драку!" },
		{"You can stop the fight when you split the bone in two and give it to the dogs.", "Вы можете остановить драку, когда сломаете кость пополам и отдадите ее собакам." },
		{"Fifty-fifty ;)", "Пополам ;)" },
		//13
		{"Help the tree shed its leaves", "Помогите дереву сбросить листья." },
		{"Paint the tree yellow with the paint bucket.", "Покрасьте дерево в желтый цвет с помощью ведра для краски." },
		{"You’re doing great!", "Вы отлично справляетесь!" },
		//14
		{"Catch the fish!", "Поймайте рыбу!" },
		{"The fish is hidden between the waves. Move the waves.", "Рыба спрятана между волнами. Двигайте волны." },
		{"That move seems familiar...", "Это движение кажется мне знакомым..." },
		//15
		{"Fill the bucket with water", "Наполните ведро водой." },
		{"Try to turn the phone. You will see that the direction of water will change.", "Попробуйте повернуть телефон. Вы увидите, что направление движения воды изменится." },
		{"Nature will take its course.", "Природа возьмет свое." },
		//16
		{"Help the man lose weight", "Помогите мужчине похудеть." },
		{"Hold the man with your finger, drag him to the left and right 4 times and make him lose weight.", "Держите мужчину пальцем, потяните его влево и вправо 4 раза и заставьте его похудеть." },
		{"He’s skin and bones.", "Кожа да кости." },
		//17
		{"Feed the hay to the cow", "Скормите сено корове." },
		{"Didn't you see the shovel behind the hay? You can open a way with it.", "Разве вы не видели лопату за сеном? Вы можете использовать ее, чтобы проложить себе путь." },
		{"Now it’s time to eat.", "Теперь пришло время поесть." },
		//18
		{"Find the 10 differences", "Найдите 10 отличий." },
		{"What’s important is making a difference :)", "Выбирайте то, что действительно важно :)" },
		//19
		{"Clean the page!", "Очистите страницу!" },
		{"You can clean it by hovering over it with your finger.", "Вы можете очистить ее своим пальцем." },
		{"Did you try to use a rubber? Hahaha", "Вы пробовали использовать резинку? Ха-ха-ха" },
		//20
		{"Which one is soda?", "Где газировка?" },
		{"Shake the phone, sparkle it and find the soda!", "Встряхните телефон и найдите содовую!" },
		{"You will fizz like blup blup blup xD", "Обожаю это шипение... буль-буль-буль... xD" },
		//21
		{"Find the gamer", "Найдите геймера." },
		{"A true gamer never sleeps.", "Настоящий геймер никогда не спит." },
		{"Gamers don’t sleep. You can find the gamer by clicking on the only window in the apartment where the light is on.", "Геймеры не спят. Вы можете найти геймера, нажав на единственное окно в квартире, где горит свет." },
		//22
		{"How many hairs does the child have?", "Сколько волос у ребенка?" },
		{"If you lift the child’s wig, you will see how many of the real hair is.", "Если вы поднимете парик ребенка, вы увидите, сколько у него настоящих волос." },
		{"If you could count all the hair, please contact us. :)", "Если вы смогли пересчитать все волосы, пожалуйста, свяжитесь с нами. :)" },
		//23
		{"Please charge the phone", "Пожалуйста, зарядите свой телефон." },
		{"Have you ever tried touching the cables at the same time with your two fingers?", "Вы когда-нибудь пробовали прикоснуться одновременно двумя пальцами?" },
		{"I'm taking a shine from you.", "Я забираю всю твою славу." },
		//24
		{"If the hunter shots 2 of the birds, how many birds left at the branch?", "Если охотник застрелит 2 птиц, сколько птиц останется на ветке?" },
		{"'0' There would not be any birds left, all of them scared and flew away.", "'0'... Там не осталось бы ни одной птицы... все они испугались и улетели." },
		{"Well done the hunter, he shot 2 birds at the same time.", "Какой меткий охотник! Он подстрелил 2 птицы одновременно." },
		//25
		{"Pop the balloons!", "Лопните воздушные шары!" },
		{"Scare the hedgehog and pop the balloons with its spines!", "Напугайте ежа и лопните шары его иглами!" },
		{"Boooooommmmm!", "Бу-у-у-м!" },
		//26
		{"Reach the animal to the exit by using arrows", "Доведите животного до выхода с помощью стрелок." },
		{"You should wander around before entering the maze.", "Вы должны побродить вокруг, прежде чем войти в лабиринт." },
		{"All great minds think alike.", "Все великие умы мыслят одинаково." },
		//27
		{"How many letters left in alphabet if you take the letters of “a” and “b” out?", "Сколько букв останется в алфавите, если убрать буквы 'a' и 'b'?" },
		{"There will be 6 letters left if you take a and b out from alphabet word.", "Если вы уберете А и В из слова алфавит, то останется 6 букв." },
		{"Do you think that your friends can solve this question?", "Вы думаете, что ваши друзья смогут ответить на этот вопрос?" },
		//28
		{"How many flies are there?", "Сколько там мух?" },
		{"Enlarge the poop in the back and count the flies over it.", "Увеличьте фекалии и сосчитайте мух над ними." },
		{"Flies resides in the details.", "Мухи кроются в деталях." },
		//29 DON'T FORGET TO CHANGE PREFAB
		{"Try to drag the “sleep” word over the baby...", "Попробуйте перетащить слово 'спать' на ребенка..." },
		{"It would be perfect if it was that easy to put babies in sleep in real life.", "Было бы замечательно, если бы в реальной жизни было так легко заставлять младенцев спать." },
		//30
		{"Try to close the cow's nose. Look at it, will it wake up?", "Попробуйте закрыть корове нос. Посмотри на нее... она проснулась?" },
		{"Almost drowning.", "Чуть все не испортил..." },
		//31
		{"Save the ship from crashing into the iceberg", "Спасите корабль от столкновения с айсбергом." },
		{"Try melting the iceberg by rubbing it with your finger.", "Попробуйте растопить айсберг, потерев его пальцем." },
		{"The Titanic would have sunk.", "Титаник бы не затонул." },
		//32
		{"Cross the truck across the bridge", "Помогите грузовику пересечь мост." },
		{"Try to lift the bridge from the top with your finger.", "Попробуйте поднять мост сверху пальцем." },
		{"Honk honk!", "Бип-бип!" },
		//33
		{"Which one is edible?", "Какая из них съедобна?" },
		{"What you think of as diamond and poop is actually cone and ice cream. Drag the cone under the ice cream.", "То, что вы приняли за бриллиант и какашку... на самом деле рожок и мороженое. Перетащите рожок под мороженое." },
		{"I wish they were here.", "Жаль, что их здесь нет." },
		//34
		{"What would the result be if we multiply all the numbers with each other?", "Какой получится результат, если мы перемножим все числа?" },
		{"What would the result be if you multiply a number with zero?", "Каким будет результат, если умножить число на ноль?" },
		{"You cannot ignore the zero...", "Вы не можете игнорировать ноль…" },
		//35
		{"Do the right move to win the game!", "Сделайте правильный ход, чтобы выиграть игру!" },
		{"Touch the sides of 'O' in the middle, at the same time with 2 fingers!", "Прикоснитесь к бокам 'О' в центре одновременно двумя пальцами!" },
		{"Good strategy.", "Правильная стратегия." },
		//36
		{"How would you empty the bathtub fastly?", "Как бы вы быстро опорожнили ванну?" },
		{"Didn't you try to remove the stopper from the tub? You should try it right now.", "Вы не пытались вытащить пробку из ванны? Вы должны попробовать это прямо сейчас." },
		{"Your friends will have difficulty in solving this question!", "Вашим друзьям будет трудно решить эту задачу!" },
		//37
		{"Turn the child over by using two fingers and shake. The key will fall out of the child’s pocket.", "Переверните ребенка двумя пальцами и встряхните. Ключ выпадет из кармана ребенка." },
		{"Successful!", "Отлично!" },
		//38
		{"Find the real shadow of the bird", "Найдите настоящую тень птицы." },
		{"If you drag the sun over the bird, the bird will have a shadow.", "Если вы перетащите солнце на птицу, то у птицы будет тень." },
		{"You are great.", "Вы великолепны." },
		//39
		{"Some months take 30, some take 31; how many months have 28 days?", "В некоторых месяцах есть 30, а в других - 31 день... Сколько месяцев имеет по 28 дней," },
		{"Each month has 28 days.", "В каждом месяце есть 28 дней." },
		{"It’s that simple.", "Все очень просто." },
		//40
		{"Do not explode the bomb!", "Не взрывайте бомбу!" },
		{"The bomb will not explode already, just wait for 30 seconds.", "Бомба не взорвется, просто подождите 30 секунд." },
		{"How impatient you are.", "Как же вы нетерпеливы." },
		//41 DON'T FORGET TO CHANGE PREFAB
		{"You should hang the word of “Man” in the question.", "Вы должны повесить слово 'человек' в вопросе." },
		{"Rest in peace.", "Покойся с миром." },
		//42
		{"Wake up the cow", "Разбудите корову." },
		{"If you take the moon off the screen, the sun rises and the cow wakes up.", "Если убрать Луну с экрана, встанет солнце и корова проснется." },
		{"How can you sleep that much?", "Как ты можешь столько спать?" },
		//43
		{"Press the orange circle 10 times, then press the blue circle once", "Нажмите на оранжевый круг 10 раз, затем нажмите на синий круг один раз." },
		{"Are you sure that you pressed 10 times? Because the number starts from 1.", "Вы уверены, что нажали 10 раз? Числа начинаются с 1..." },
		{"Or did you press 9 times? We said 10...", "Может быть, вы нажали 9 раз? Мы сказали 10..." },
		//44
		{"Find the couples and win the game", "Найдите пары и выиграйте игру." },
		{"Shrink your screen, you will see your other mate.", "Уменьшите масштаб экрана, и вы увидите вторую картинку." },
		{"You did a good job.", "Вы хорошо поработали." },
		//45
		{"How this equation becomes correct?", "Как сделать это уравнение правильным?" },
		{"Use the number of 45 in the Lv.45 to create 4550 number.", "Использовать число 45 из названия уровня, чтобы получить 4550." },
		{"You are a true genius.", "Вы настоящий гений!" },
		//46
		{"Confirm evenness by moving the single matchstick!", "Подтвердите равенство, переместив одну спичку!" },
		{"Move the number of 4's matchstick and get 2 pieces of 1! 311+89=400", "Переместите спичку в четверке и получите сразу две цифры! 311+89=400" },
		{"Did you know that the match was invented after the lighter?", "Знаете ли вы, что спичка была изобретена после зажигалки?" },
		//47
		{"Make all of it green!", "Сделайте все зеленым!" },
		{"First of all, shake the phone, then put the chameleon on the grass, and then paint the question with the paint bucket. Don't forget to remove the clouds from the screen.", "Встряхните телефон, затем положите хамелеона на траву... После этого окрастьте вопрос, используя ведро краски. Не забудьте убрать облака с экрана." },
		{"How the greens will smile if the clouds do not cry?", "Как же будет расти зелень, если облака не дают воды?" },
		//48
		{"If 5 squirrels eat 5 walnuts in 5 minutes, in how many minutes does 15 squirrels eat 15 walnuts?", "Если 5 белок съедают 5 грецких орехов за 5 минут, то, за сколько минут 15 белок съедают 15 грецких орехов?" },
		{"In 5 minutes.", "За 5 минут." },
		{"Aren’t those squirrels so sweet?", "Разве эти белки не милые?" },
		//49 DON'T FORGET TO CHANGE PREFAB
		{"Drag the word 'Protect' on to the rocket.", "Перетащите слово 'защитите' на ракету." },
		{"Power shields are now activated.", "Силовые щиты активированы." },
		//50
		{"You should win the game again", "Вы должны снова выиграть игру." },
		{"Use 0 in the 50 words. Hold and drag it to the middle of O and press the other side.", "Используйте 0 в числе 50. Удерживайте и перетащите его на середину O и нажмите на другую сторону." },
		{"You know it.", "Уверены, что вы и так все знаете." },
		//51
		{"Pizza, ice-cream, cheese, cactus, 'Throw everything away' text and you should throw away the cap of the trash.", "Пицца, мороженое, сыр, кактус, текст 'Выбросьте все, что видите.', и вы должны выбросить крышку мусора." },
		//52
		{"How many rings are there on the screen?", "Сколько колец на экране?" },
		{"We hid 4 of them under the Clean button. '22'", "Мы спрятали 4 из них под кнопкой 'Очистить'. Всего их 22." },
		{"Nothing can escape from you.", "Ничто не может скрыться от вас." },
		//53
		{"Collect 5 mice like in the picture", "Соберите 5 мышей, как на картинке." },
		{"Just click to the mouse in the left direction and do not forget the mouse in the example.", "Просто кликайте и не забывайте про мышку в примере." },
		{"You are a good hunter!", "Вы хороший охотник!" },
		//54
		{"How can the kangaroo jump higher than the building?", "Как может кенгуру прыгнуть выше здания?" },
		{"Make the trampoline bigger!", "Сделайте батут больше!" },
		{"Bounce bounce bounce...!", "Прыг-прыг-прыг!" },
		//55
		{"Bring the magnifier to the child's arm on the lower left. You will see the replica.", "Поднесите лупу к левой руке ребенка снизу. Вы увидите шпаргалку." },
		{"You’ve got him.", "Он у тебя в руках." },
		//56
		{"Which one is the prettiest?", "Кто самый красивый." },
		{"Drag the boy in front of the girl, whichever one he smiles at is the prettiest.", "Перетащите мальчика к девочке. Кто улыбнется, то и есть самый красивый." },
		{"Love at first sight.", "Любовь с первого взгляда." },
		//57
		{"You should rub the baby’s belly and let the gas out.", "Вы должны потереть живот ребенка и выпустить газы." },
		{"Ops the baby has gas.", "Ой... ребенок страдает от газов..." },
		//58 DON'T FORGET TO CHANGE PREFAB
		{"You should clean it by using the word 'Clean' in the question.", "Вы должны очистить ее, используя слово 'очистить' в вопросе." },
		{"I accept it was bad.", "Я признаю, это было плохо." },
		//59
		{"Get the number of 100 twice by using a single line from the number of 188", "Получите два раза по 100, используя одну линию и число 188." },
		{"Divide the number of 188 horizontally. You will have 2 of 1, 4 of 0.", "Разделите число 188 по горизонтали. У вас будет две единицы и четыре нуля." },
		{"Wooww, you are super.", "Уууу... Вы - просто супер." },
		//60
		{"To drop an apple from the tree, you must shake the tree very much. Shake the phone.", "Чтобы сбросить яблоко с дерева, вы должны очень сильно встряхнуть дерево. Встряхните телефон." },
		{"Did this cow discover gravity?", "Неужели эта корова открыла для себя гравитацию?" },
		//61
		{"Turn the light off", "Выключите свет." },
		{"Turn off the screen towards the table. The light will go off.", "Выключите экран, положив его на стол. Свет погаснет." },
		{"Where were we?", "На чем мы остановились?" },
		//62
		{"Bring the pen into the empty space", "Перенесите ручку в пустое пространство." },
		{"One of the objects below can be rotated. Find the rotating pen and put it back correctly.", "Один из объектов ниже можно повернуть. Найдите ручку, которая повернута и верните ее в правильное положение." },
		{"The pen is mightier than the sword.", "Ручка сильнее меча." },
		//63
		{"Feed the dog with the food under the box and wait for it to poop. Take the key that comes with the poop to the door.", "Покормите собаку кормом из под коробки и подождите, пока она покакает. Возьмите ключ, который окажется в какашках." },
		{"Sweet little doggie.", "Милая маленькая собачка." },
		//64
		{"Solve the problem!", "Решите задачку!" },
		{"Be careful about seeds of blackberry, 2 of them are missing. '18'", "Будьте осторожны с кусочками ежевики... 2 из них пропали, поэтому 18." },
		{"You understand the math...", "Вы понимаете математику..." },
		//65
		{"Try to get rain from the cloud.", "Попробуйте получить дождь из облака." },
		{"It's raining, floods are flowing...", "Идет дождь, льет как из ведра..." },
		//66
		{"Do you guess the three letters upcoming in the order?", "Догадываетесь ли вы, какие три буквы идут дальше?" },
		{"Look carefully at the first letters of words in the question? Use the first letters of last two words", "Внимательно посмотрите на первые буквы слов в вопросе? Используйте первые буквы последних слов. ДЛВКТБИД" },
		{"Did you guess?", "А вы догадались?" },
		//67
		{"Find objects!", "Найдите предметы!" },
		{"You have a sharp sight!", "У вас острое зрение!" },
		//68
		{"How many numbers are there?", "Сколько же здесь чисел?" },
		{"You are super!", "Вы супер!" },
		//69
		{"Please write down the right answer?", "Пожалуйста, запишите правильный ответ." },
		{"You should think simple. Add up the 8 and 5.", "Не стоит искать слишком сложный ответ. Сложите 8 и 5." },
		{"Sometimes you need to think simple ;)", "Иногда не нужно думать слишком долго ;)" },
		//70
		{"I go to bed at 8 o'clock at night and I set my cuckoo clock at 9 in the morning. How many hours will I sleep?", "Я ложусь спать в 8 часов вечера и ставлю часы с кукушкой на 9 утра. Сколько часов я буду спать?" },
		{"The cuckoo clock won’t differentiate night and day, hence you will sleep for one hour.", "Часы с кукушкой не различают ночь и день, поэтому вы будете спать всего час." },
		{"Is the alarm a little bit early?", "Не слишком ли рано сработал будильник?" },
		//71
		{"With two fingers, swipe to the left on the screen and plug the phone into a socket. Then touch the cables at the same time.", "Двумя пальцами проведите влево по экрану и подключите телефон к розетке. После этого одновременно прикоснитесь к кабелям." },
		{"Be careful, don’t be shocked!", "Будьте осторожны и не получите удар током!" },
		//72
		{"The wheel of the car is in one of the clouds. Put the cloud with your finger and shake it. Mount the wheel on the truck. Tilt the screen to the right. The truck will move across the street.", "Колесо автомобиля находится в одном из облаков. Возьмите облако пальцем и встряхните его. Установите колесо на грузовик. Наклоните экран вправо. Грузовик переедет через дорогу." },
		{"Do not ask why the rubber tire is over there.", "Не спрашивайте, почему резиновая шина оказалась именно там..." },
		//73
		{"You should try to turn off the light with your finger.", "Вы должны попытаться выключить свет пальцем." },
		{"There would not be a more creative way.", "У вас просто не было более творческого пути." },
		//74
		{"Choose 3 balls, verify the evenness!", "Выберите 3 шара, чтобы сделать равенство правильным!" },
		{"Turn the 9 upside down and make it 6! 11+13+6: 30! That much easy!", "Переверните 9 вверх дном и сделайте ее шестеркой! 11+13+6: 30! Очень легко!" },
		{"We put the ball upside down, sorry.", "Мы положили мяч вверх ногами, извините" },
		//75
		{"Which one is the heaviest?", "Какой из них самый тяжелый?" },
		{"Lift both hammers and drop them at the same time to find out which one is the heaviest.", "Поднимите оба молотка и опустите их одновременно, чтобы выяснить, какой из них самый тяжелый." },
		{"I congratulate your physics teacher.", "Поздравляю вашего учителя физики." },
		//76 DON'T FORGET TO CHANGE PREFAB
		{"Drag the “fish” text over to the edge of the fishing hook.", "Перетащите слово 'рыба' на край рыболовного крючка." },
		{"Delicious.", "Какая вкуснятина." },
		//77
		{"Shake the drink and help the child drink it", "Встряхните напиток и помогите ребенку выпить его." },
		{"Hold the bottle shut with your finger, shake your phone, and give the bottle to the child.", "Держите бутылку закрытой пальцем, встряхните телефон и дайте бутылку ребенку." },
		{"Shake before drinking!", "Взболтать перед употреблением!" },
		//78
		{"Help the child to open the safe", "Помогите ребенку открыть сейф." },
		{"Turn the phone over and shake it. The key will fall out of the child’s pocket.", "Переверните телефон и встряхните его. Ключ выпадет из кармана ребенка." },
		{"What do you think inside of it?", "Как вы думаете... что скрывается внутри?" },
		//79
		{"Find the numbers on the balls", "Найдите цифры на шарах." },
		{"148", "148" },
		{"Are you a math professor or something?", "Вы профессор математики или что-то в этом роде?" },
		//80
		{"Drag the screen towards the left and you will see the bird’s real shadow. (Use two fingers at the same time)", "Перетащите экран влево, и вы увидите реальную тень птицы.(Используйте два пальца одновременно)" },
		{"I’m impressed… You’re fast.", "Я впечатлен... вы быстро соображаете." },
		//81
		{"Clean the car", "Очистите машину." },
		{"You need to clean over the car with your finger.", "Вам нужно очистить автомобиль с помощью пальца." },
		{"Sparkling clean.", "Он сверкает чистотой." },
		//82
		{"Find the strongest balloon!", "Найдите самый крепкий воздушный шар!" },
		{"Drag the balloons over to the skip forward sign, 4 of them will pop! The strongest balloon won’t pop.", "Перетащите шары к знаку уступи дорогу... три из них лопнут! Самый крепкий шар не лопнет." },
		{"You’re doing great.", "Вы отлично справляетесь." },
		//83
		{"How many orange cubes do you need to cover the blue cube?", "Сколько оранжевых кубиков вам нужно, чтобы закрыть синий куб?" },
		{"22", "22" },
		{"That was a good one.", "Это было очень хорошо." },
		//84
		{"Flip the text with two fingers. Put it between the tap and the bucket.", "Переверните текст двумя пальцами. Поместите это между краном и ведром." },
		{"Bet you didn’t think of that one, did you?", "Бьюсь об заклад, вы об этом не подумали, не так ли?" },
		//85
		{"The baby will sleep if you put your phone down on the table face down.", "Ребенок будет спать, если вы положите телефон на стол экраном вниз." },
		{"You’re the best at putting babies to sleep.", "Вы - настоящий мастер в убаюкивании детей." },
		//86  DON'T FORGET TO CHANGE PREFAB
		{"What’s the size of the table?", "Какой размер стола?" },
		{"You’re on a roll.", "Вы в ударе." },
		//87
		{"Try dispersing the soil by shaking your phone", "Попробуйте раскидать почву, встряхнув телефон." },
		{"We’re covered in dirt.", "Все мы теперь в грязи." },
		//88
		{"Please help me find my dog in this mess", "Пожалуйста, помогите мне найти мою собаку в этом беспорядке." },
		{"You need to make the screen smaller. The dog is somewhere outside of the screen.", "Вам нужно сделать экран меньше. Собака находится где-то за пределами экрана." },
		{"Thank you!", "Спасибо!" },
		//89
		{"Lift Thor’s hammer", "Поднимите молот Тора." },
		{"The hammer is so heavy you will need to lift it with three fingers.", "Молот такой тяжелый, что вам придется поднимать его тремя пальцами." },
		{"You’re even stronger than I thought!", "Вы даже сильнее, чем я думал!" },
		//90
		{"Find the pairs and win the game", "Найдите пары и выиграйте игру" },
		{"Divide the last one remaining in half by drawing a line through the middle of it.", "Разделите последний оставшийся пополам, проведя линию через его середину." },
		{"We make a good pair.", "Из нас получится хорошая пара" },
		//91
		{"Touch the cow’s head 10 times.", "Прикоснитесь к голове коровы 10 раз." },
		{"The cow is a heavy sleeper.", "Корова крепко спит." },
		//92
		{"Hey..!! What day of the month is it?", "Эй..!! Какой сегодня день месяца?" },
		{"Seriously, what day of the month is it? What number is the calendar on your phone showing?", "Серьезно, какой сегодня день месяца? Какое число показывает календарь на вашем телефоне?" },
		{"Sometimes I forget the date, too.", "Иногда я тоже забываю дату." },
		//93
		{"You need to shake the tree a lot. The key will fall from it.", "Вам нужно сильно потрясти дерево. Ключ упадет с него." },
		{"Whose idea was it to hide the key in a tree?", "Чья это была идея... кто мог спрятать ключ на дереве?" },
		//94  DON'T FORGET TO CHANGE PREFAB
		{"You can use the word “Balance” in the text to balance the scale.", "Вы можете использовать слово 'Уравновесьте' в тексте, чтобы выставить одинаковый вес." },
		{"Are you balanced?", "А вы уравновешены?" },
		//95
		{"If the bridge is falling apart, you need to support the middle of the bridge with your hand.", "Если мост разваливается, вам нужно поддерживать середину моста рукой." },
		{"You’re the king of the road.", "Вы - король дороги." },
		//96
		{"It’s snowing! Catch the snow...", "Идет снег! Поймайте снег…" },
		{"Place your phone on a flat surface with the screen facing up and wait.", "Положите телефон на плоскую поверхность экраном вверх и ждите." },
		{"Become one with the snow.", "Я един со снегом." },
		//97
		{"Help him escape prison", "Помогите ему сбежать из тюрьмы." },
		{"You can escape by pressing the escape button after you unscrew the lightbulb.", "Вы можете убежать, нажав кнопку эвакуации после того, как вы выкрутите лампочку." },
		{"Smells like freedom!", "Пахнет свободой!" },
		//98
		{"Park the car", "Припаркуйте машину." },
		{"There might be space further down the road.", "Дальше по дороге может быть свободное место." },
		{"Slowly… Slowly… Now park the car!", "Медленно... медленно... а теперь припаркуйте машину!" },
		//99
		{"You will catch the cheater if you move the front row.", "Вы поймаете мошенника, если переместите первый ряд." },
		{"Caught red-handed.", "Пойман с поличным." },
		//100
		{"Help the child see!", "Помогите ребенку увидеть!" },
		{"Drag the two zeros in '100' to make glasses for the kid.", "Перетащите два нуля из '100', чтобы сделать очки для ребенка." },
		{"That’ll show you!", "Теперь все узнают!" },
		//101
		{"Which one would you save?", "Кого бы вы спасли?" },
		{"You need to press all three at the same time. Don’t try doing it one by one.", "Вам нужно нажать все три варианта одновременно. Не пытайтесь нажимать один за другим." },
		{"You are so single.", "Ты такой одинокий." },
		{"Family", "Семьи" },
		{"Love", "Любовь" },
		{"Money", "Деньги" },
		//102
		{"The animals are racing. The cow, the rabbit, and the turtle. Help the turtle win", "Животные бегут наперегонки. Корова, кролик и черепаха. Помогите черепахе победить." },
		{"Drag the start button and hit the Turbo button underneath.", "Перетащите кнопку старта и нажмите кнопку 'Турбо'." },
		{"Fast and furious.", "Быстрая и яростная." },
		{"Start", "Начать" },
		//103
		{"The baby will sleep if you turn the volume down on your phone.", "Ребенок будет спать, если вы уменьшите громкость на вашем телефоне." },
		{"Hush...", "Тише..." },
		//104
		{"What should be the next number in the sequence?", "Каким должно быть следующее число в последовательности?" },
		{"Read the numbers you see out loud! The numbers are how the previous numbers sound when you read them together… '13112221'", "Читайте цифры, которые вы видите вслух! Ответ - это то, как звучат предыдущие цифры, когда вы читаете их вместе, то есть '13112221’" },
		{"We’ll admit it was a hard question.", "Мы признаем, что это был трудный вопрос." },
		//105
		{"Help the truck pass through the tunnel", "Помогите грузовику проехать через туннель." },
		{"Shrink the truck with two fingers.", "Сожмите грузовик двумя пальцами." },
		{"Well done!", "Молодец!" },
		//106
		{"If Mary gathers 2 bananas in 1 minute, how many bananas can she gather from this tree in 10 minutes?", "Если Мэри собирает 2 банана за 1 минуту, то сколько бананов она может собрать с этого дерева за 10 минут?" },
		{"Does it look like bananas grow on this tree? The answer is '0'", "Вы думаете, что на этом дереве растут бананы? Ответ - ' 0’" },
		{"You’re quite smart.", "Вы очень умны." },
		//107 DON'T FORGET TO CHANGE PREFAB
		{"The match will be lit if you drag it and rub it over the word 'Light'.", "Вы можете зажечь спичку, если вы потянете ее и потрете слово 'Зажгите'." },
		{"Don’t play with fire.", "Не играйте с огнем." },
		//108
		{"List the numbers you see on the screen in order", "Перечислите цифры, которые вы видите на экране, по порядку." },
		{"At first, it started with 3, 2, 1, didn’t you see? 3, 2, 1, 32, 67, 21, 5, 14, 8", "Все начиналось с 3, 2, 1... Разве вы не видели? 3, 2, 1, 32, 67, 21, 5, 14, 8" },
		{"I’m in awe of your visual memory!", "Я в восторге от вашей зрительной памяти!" },
		//109
		{"Who is pregnant?", "Кто из них беременна?" },
		{"Turn your phone upside down and shake it. Drag the pregnancy test over to the woman on the right.", "Переверните телефон и встряхните его. Перетащите тест на беременность к женщине справа." },
		{"Congratulations!", "Поздравляем!" },
		//110
		{"How many squares are there?", "Сколько здесь квадратов?" },
		{"Would it be 40?", "Может быть 40?" },
		{"It is 40!", "40!" },
		//111
		{"Make the man happy!", "Сделайте этого человека счастливым!" },
		{"Drag the man up over the clouds.", "Перетащите этого человека за облака." },
		{"Being happy is that simple!", "Быть счастливым - это так просто!" },
		//112
		{"Sally is 21 years older than her son. 2 years ago, Sally was 4 times her son’s age. How old is Sally?", "Салли на 21 год старше своего сына. 2 года назад Салли была в 4 раза старше своего сына. Сколько лет Салли?" },
		{"She is 31.", "Ей 31 год." },
		{"What did you study in school?", "Что вы изучали в школе?" },
		//113
		{"Park the car in the right spot", "Припаркуйте машину в нужном месте." },
		{"Drag the skirt off of the female symbol in the middle to make it appropriate for the driver.", "Стяните юбку с женского символа посередине, чтобы сделать ее подходящей для водителя." },
		{"Thought you’d never figure it out.", "Думал, вы никогда этого не поймете." },
		//114
		{"That counts as a three-pointer.", "Вы получили трехочковый!" },
		//115
		{"Did you try taking the light that won’t turn off out of the screen?", "Попробуйте сделать так, чтобы экран не погас... Готовы?" },
		{"I love your sharp wit!", "Мне нравится ваш острый ум!" },
		//116
		{"Save the gorilla :(", "Спасите гориллу :(" },
		{"You can use the hint key to unlock the lock.", "Вы можете использовать кнопку подсказки, чтобы отпереть замок." },
		{"#FreedomForAnimals", "#СвободаЖивотным" },
		//117
		{"What’s the fastest route from A to I?", "Какой самый быстрый маршрут от A до I?" },
		{"You need to swap B and I’s places.", "Вам нужно поменять местами с B и I." },
		{"You’re so fast!", "Вы такой быстрый!" },
		//118
		{"Burn everything", "Сожгите все." },
		{"Drag the magnifying glass between the sun and the wood to spark a fire. Then use the wood on the fire to burn everything. You can pass the level by burning everything including the 'Burn everything' text and the sun.", "Перетащите увеличительное стекло между солнцем и деревом, чтобы зажечь огонь. Затем используйте дрова, чтобы сжечь все. Вы можете пройти уровень, сжигая все, включая текст 'сожгите все' и солнце." },
		{"Time to call the fire station!", "Пора звонить в пожарную службу!" },
		//119
		{"2 of them are drowned, 4 of them are swimming, and 3 of them are dead. How many fish left in the aquarium?", "2 из них утонули, 4 плавают и 3 из них мертвы. Сколько рыб осталось в аквариуме?" },
		{"Fish don’t drown in water. But even if they did, none of them would go out of aquarium hence, 10 fish will be left.", "Рыба не тонет в воде. Даже если бы они тонули, то все равно бы остались в аквариуме. Поэтому их 10." },
		{"You are a real genius.", "Вы настоящий гений." },
		//120
		{"You should try charging your own phone while the game is on.", "Вы должны попробовать зарядить свой собственный телефон во время игры." },
		{"We gave you an excuse to charge your phone :)", "Мы дали вам повод зарядить свой телефон :" },
		//121
		{"Put the fire out", "Потушите огонь." },
		{"Squeeze the cloud with two fingers and make water spill to put out the fire.", "Сожмите облако двумя пальцами и заставьте воду политься, чтобы потушить огонь." },
		{"It’s raining cats and dogs!", "Какой страшный ливень!" },
		//122
		{"Find the pirate", "Найдите пирата." },
		{"Pirates have wooden legs. Try lifting their pant legs to see.", "У пиратов деревянные ноги. Попробуйте поднять их штанины, чтобы увидеть ноги." },
		{"Nice, the next question awaits.", "Хорошо, следующий вопрос уже ждет вас." },
		//123
		{"Complete the equation", "Завершите уравнение." },
		{"Take the 1, 2, and 3 from “Lv. 123” and put them in the places of A, B, and C. That will complete the equation.", "Возьмите 1, 2 и 3 из 'Ур. 123' и поместите их в места A, B и C. Именно так вы решите уравнение." },
		{"You really surprised me.", "Вы действительно удивили меня." },
		//124
		{"Defeat your competitor in Rock-Paper-Scissors game!", "Победите своего соперника в игре Камень-Ножницы-Бумага!" },
		{"You have to move to the winning side by relocating the players!", "Вы должны оказаться на стороне победителя, перемещая игроков!" },
		{"Or did you cheat?", "Или вы жульничали?" },
		//125
		{"It’s 3:35. What time would it be if the clock moved counter-clockwise 90 degrees?", "Сейчас 3:35. Сколько было бы времени, если бы часы двигались против часовой стрелки на 90 градусов?" },
		{"Could it be 12:20?", "Может быть 12:20?" },
		{"Did you ask your friends what level they’re on?", "Вы уже спрашивали своих друзей, на каком уровне они застряли?" },
		//126 DON'T FORGET TO CHANGE PREFAB
		{"Did you try to click on Europe text?", "Вы пробовали нажать на слово Европа?" },
		{"Bravo!", "Браво!" },
		//127
		{"Make the bulbs explode by clicking on the lights 5 times", "Сделайте так, чтобы лампочки взорвались, нажав на лампочки 5 раз." },
		{"The lights are off alright...", "Свет выключен... теперь все в порядке..." },
		//128
		{"He broke the vase 10 minutes ago. Help him fix it", "Он разбил вазу 10 минут назад. Помогите ему все исправить." },
		{"The vase wasn’t broken 10 minutes ago. Try rewinding the clock.", "Ваза была целой еще 10 минут назад. Попробуйте перевести часы назад." },
		{"You just traveled through time.", "Вы просто путешествовали во времени." },
		//129
		{"Which tank would be filled first?", "Какой бак будет заполнен первым?" },
		{"Draw a line to A's drain. Thus, 'A' will be filled first.", "Нарисуйте линию к стоку А. Таким образом, бак 'А' будет заполнен первым." },
		{"Hmm, smart...", "Хм, умно..." },
		//130
		{"Shrink the building.", "Уменьшите здание." },
		{"Kangaroo-lations!", "Примите наше кенгурительное поздравление!" },
		//131 DON'T FORGET TO CHANGE PREFAB
		{"You should try turning the 9 in the question into a 6. Then you will have the right number of bananas.", "Вы должны попробовать превратить 9 в 6. Тогда у вас будет нужное количество бананов." },
		{"Something’s not right about this.", "Что-то неправильное есть в этом всем." },
		//132
		{"What should fill the blank?", "Что должно заполнить этот пробел?" },
		{"Did you ever drive? This was car gear. Reverse gear 'R'...", "Вы когда-нибудь водили машину? Это была коробка передач... Задний ход - это 'R'..." },
		{"Ok understood, you don’t have an 'R'.", "Хорошо поняли... у вас нет 'R'." },
		//133
		{"How many 3's are there?", "Сколько здесь 3?" },
		{"There are five 3's including the ones in 'Lv.133' and the question.", "Есть пять 3, включая те, что спрятались в 'Lv. 133' и вопросе." },
		{"Good catch!", "Хороший улов!" },
		//134
		{"Shake the clouds and catch the fish with the worm under the tree.", "Встряхните облака и поймайте рыбу, используя червя под деревом." },
		{"Hook, line, and sinker!", "Крючок, леска и грузило!" },
		//135
		{"Help the truck pass through the tunnel!", "Помогите грузовику проехать через туннель!" },
		{"Deflate the truck’s wheels! You can use the 'Forward' symbol.", "Сдуйте колеса грузовика! Вы можете использовать символ 'Вперед'." },
		{"Wish we could give you a reward.", "Жаль, что мы не можем дать вам награду." },
		//136
		{"Make a square by moving 2 balls", "Сделайте квадрат, перемещая 2 шара." },
		{"Wow!", "Ух ты!" },
		//137
		{"Turn off the lights", "Выключите свет" },
		{"You should try putting your phone upside down on the table, with the screen facing down. Then the light will go off.", "Вы должны попробовать положить телефон вверх ногами на стол, перевернув экран вниз. Тогда свет погаснет." },
		{"That’s what we’re talking about.", "Вот, о чем мы говорим." },
		//138
		{"Turn the cow in the other direction before it reaches the soil.", "Поверните корову в другую сторону, прежде чем она достигнет земли." },
		{"Where there’s a will, there’s a way.", "Где есть воля, там есть и решение." },
		//139
		{"Speed up the clock and reveal the pregnant woman.", "Ускорьте время и покажите беременную женщину." },
		{"Time flies...", "Время летит быстро..." },
		//140
		{"Take the key on the upper right corner of the screen and drag it onto the door to pass the level.", "Возьмите ключ в правом верхнем углу экрана и перетащите его на дверь, чтобы пройти уровень." },
		{"We couldn’t trick you...", "Мы не смогли обмануть вас..." },
		//141
		{"Leave me alone for a bit...", "Оставьте меня в покое... хотя бы ненадолго." },
		{"Leave the game, wait a couple of seconds, and re-enter the game.", "Выйдите из игры, подождите пару секунд и снова войдите в игру." },
		{"Thank you for understanding.", "Спасибо за понимание." },
		//142
		{"Hold the basketball with your finger and slam dunk!", "Держите баскетбольный мяч пальцем и отправляйте его в корзину!" },
		{"A great slam dunk.", "Какой точный удар." },
		//143
		{"Catch person who is cheating!", "Найдите человека, который обманывает!" },
		{"Try lifting the child’s hat who is at the right.", "Попробуйте приподнять шляпу ребенка, который находится справа." },
		{"You are not missing a thing.", "От вас ничего не скроется." },
		//144
		{"Help an old lady cross the road", "Помогите пожилой даме перейти дорогу." },
		{"One of the trucks has a green light in its truck bed. You need to put it in the right spot.", "В кузове одного из грузовиков горит зеленый свет. Вам нужно поставить его в нужное место." },
		{"Thank you for your help!", "Спасибо за вашу помощь!" },
		//145
		{"What is the result of the calculation?", "Сколько получится в итоге?" },
		{"The result of the calculation is '-62'.", "Результат: '-62'." },
		{"The social science people are now crying.", "Социологи сейчас плачут." },
		//146
		{"Gather the stones upstream and stop the water. Drag the net over the fish.", "Соберите камни выше по течению и остановите воду. Натяните сеть на рыбу." },
		{"The fish jumps once jumps twice...", "Первая рыбка... вторая рыбка..." },
		//147
		{"Shrink down the fire!", "Сбейте огонь!" },
		{"Shake the phone, let the fire disperse and choose the smaller one!", "Встряхните телефон, дайте огню разделиться на части и погасите самый маленький!" },
		{"Did you try to snuff it out?", "Вы пытались погасить его?" },
		//148
		{"Find the password!", "Найдите пароль!" },
		{"'042' Think again... You can also ask a friend.", "'042'... подумайте еще раз... Вы можете спросить друга." },
		{"If you found this as well, you should be proud of yourself!", "Если вы нашли и этот ответ, вы должны гордиться собой!" },
		{"A number and it's place are correct", "Номер, и это место правильно" },
		{"A number is correct but it's place is wrong", "Номер правильный, но это место неправильно" },
		{"Two numbers are correct but the places are wrong", "Два числа верны, но места неправильные" },
		{"Nothing is correct", "Ничто не является правильным" },
		{"ENTER", "ВВЕДИТЕ" },
		//149
		{"Weigh the chicken", "Взвесьте курицу." },
		{"Shake the chicken to make its eggs fall out and make it lighter.", "Встряхните курицу, чтобы ее яйца выпали и она стала легче." },
		{"I’m light as a feather.", "Я легок, как перышко." },
		//150
		{"Is it too quiet here?", "Здесь слишком тихо?" },
		{"A little music wouldn't be bad.", "Немного музыки не было бы плохо." },
		{"Music is the essence of the soul ;)", "Музыка – это суть души ;)" },
		//151
		{"Take the ball outside!", "Выведите мяч наружу!" },
		{"Pour water from the dispenser size bottle to the glass and pour it into the pipe. Let the ball go up.", "Налейте воду из бутылки дозатора в стакан и вылейте ее в трубу. Поднимайте мяч на воде." },
		{"You discovered the buoyant force of the water.", "Вы открыли уникальную силу воды." },
		//152
		{"Score a goal.", "Забейте гол" },
		{"Try to press two arrows at the same time.", "Попробуйте нажать на две стрелки одновременно." },
		{"Gooaal!..!!", "Го-о-о-о-л!" },
		//153
		{"Make the baby laugh.", "Заставьте ребенка засмеяться." },
		{"Take off the baby's socks and tickle the baby's feet with a feather.", "Снимите с ребенка носки и пощекочите ему ноги, используя перышко." },
		{"The world is better when babies laugh.", "Мир становится лучше, когда дети смеются." },
		//154
		{"Bring the child to the exit", "Помогите ребенку найти выход" },
		{"Turn your phone over and watch the child.", "Переверните телефон и наблюдайте за ребенком." },
		{"Did you send the game to your friends? Now, send it from the share button below.", "Вы уже рассказали об этой игре своим друзьям? А теперь, сделайте это, используя кнопку поделиться, расположенную ниже." },
		//155
		{"The child is so lonely", "Этот ребенок так одинок" },
		{"Hold on the child with your finger for 5 seconds and then, copy the child.", "Наведите палец на ребенка и удерживайте его в течение 5 секунд. Теперь скопируйте ребенка." },
		{"Now, they are twins.", "Теперь они близнецы." },
		{"Copy", "копия" },
		{"Rate the game", "Оцените игру" },
		//156
		{"Please click in the following order", "Пожалуйста, нажмите на элементы в следующем порядке" },
		{"Are you sure you did the right thing? Watch out for the last finger.", "Вы уверены, что следовали указаниям? Внимательно следите за последним пальцем." },
		{"That's it!", "Так и есть!" },
		//157
		{"Silence the child", "Заставьте ребенка замолчать" },
		{"The toy is hidden under the button. Give it to the child.", "Игрушка спрятана под кнопкой. Отдайте ее ребенку." },
		{"It's really awesome.", "Вот это круто." },
		{"Watch video", "Смотреть видео" },
		//158 DON'T FORGET TO CHANGE PREFAB
		{"Unlock the case.", "Откройте футляр." },
		{"Take the word ‘password’ to the correct place.", "Переместите слово ‘пароль’ в нужное место." },
		{"Is it difficult?", "Разве это трудно?" },
		//159
		{"Grab the gift box on the daily bonus button and give it to the man. The man will be happy to receive a gift.", "Возьмите подарочную коробку в разделе бонус дня и отдайте ее мужчине. Мужчина будет счастлив получить подарок." },
		{"Who recently bought you a gift?", "Кто-то дарил вам подарки в последнее время?" },
		//160
		{"What does the child see?", "Что увидел ребенок?" },
		{"Try to look at from the perspective of the child.", "Попробуйте посмотреть на это с точки зрения ребенка." },
		{"It's all about perspective!", "Все дело в том, как вы смотрите на мир!" },
		//161 DON'T FORGET TO CHANGE PREFAB
		{"One of the X's can be moved. Remove X and replace it with the dot in the question.", "Один из X может быть перемещен. Удалите X и замените его точкой в вопросе." },
		{"You are true genius!", "Вы настоящий гений!!" },
		//162
		{"Make the girl fall in love with the boy", "Заставьте девушку влюбиться в парня." },
		{"Shake the child quite a while. Maybe he is hiding a surprise gift.", "Попробуйте потрясти ребенка в течение продолжительного времени. Может быть, он прячет подарок." },
		{"You're the last single person in the world.", "Вы - последний одинокий человек в мире." },
		//163 DON'T FORGET TO CHANGE PREFAB
		{"Try to use the word 'Truck'.", "Попробуйте использовать слово ‘Грузовик’." },
		{"Poor truck.", "Бедный грузовик." },
		//164
		{"Find the water for kids to make a water fight.", "Найти воду для детей, чтобы начать водяной бой." },
		{"Hold both clouds with your fingers at the same time shake your phone.", "Держите оба облака пальцами, одновременно встряхивая телефон." },
		{"May the best man win!", "Пусть победит сильнейший!" },
		//165
		{"Shout and Say 'MOM'", "Закричите и скажите ‘МАМА’" },
		{"The level will be passed when you click the start button 4 times and fill the bar. You must allow microphone access, or enable Phone Settings > Apps > Trick Me > Permissions > Microphone option.", "Уровень будет пройден, когда вы нажмете кнопку 4 раза и заполните шкалу. Вы должны разрешить доступ к микрофону или включить параметр Настройки телефона > Приложения > Обмани меня > Разрешения > Микрофон." },
		{"What did you mom say?", "А что сказала ваша мама?" },
		//166
		{"Find a frame for these colored objects.", "Найдите рамку для цветных объектов." },
		{"I said find 'a frame' for these colored objects. :)", "Я сказал, что нужно найти ‘рамку’ для цветных объектов. :)" },
		{"You are amazing!", "Вы просто великолепны!" },
		//167
		{"Do something to end the war.", "Сделай что-нибудь, чтобы остановить войну." },
		{"If you shoot at the right place, the war is over.", "Попадание в нужное место поможет закончить войну." },
		{"#worldpeace", "#мирвовсеммире" },
		//168
		{"Find the ball?", "Вы можете найти мяч?" },
		{"To make 'x10' 'x1', delete '0' using your finger.", "Превратите х10 в х1б просто удалив 0 пальцем." },
		{"A++++++", "ОТЛИЧНО!!" },
		//169
		{"After the game has started, you must turn the child left using your finger.", "После того, как игра началась, вы должны повернуть ребенка влево, используя палец." },
		{"Nobody could pass this level except you.", "Никто не сможет пройти этот уровень, кроме вас." },
		//170
		{"Hit the man's head and knock the man out. Then, shoot the ball.", "Попадите человеку в голову, чтобы выбить его. После этого ударьте по мячу." },
		{"Incredible goal!", "Потрясающий гол!" },
		//171
		{"Grasp the first car with two fingers and remove it draggingly. Then, park your car in its place.", "Возьмите первый автомобиль двумя пальцами и медленно перетащите его. Затем припаркуйте свой автомобиль на его месте." },
		{"Nice job!", "Отличная работа!" },
		//172
		{"One of the L's in Lvl is big and the other small.", "Одна из букв L в Lvl большая, а вторая - маленькая." },
		{"You can think differently...", "Попробуйте мыслить иначе..." },
		//173 DON'T FORGET TO CHANGE PREFAB
		{"Enter password", "Введите пароль" },
		{"Try zooming your screen a few times.", "Попробуйте несколько раз увеличить масштаб экрана." },
		{"You're very good!", "Вы просто молодец!" },
		//174
		{"Behind one of the windows.", "Он скрывается за одним из окон." },
		{"Don't lie, you're a gamer, too.", "Не врите! Вы ведь тоже геймер." },
		//175
		{"Grab the small key on watch video button and drag it to the door.", "Возьмите маленький ключ на кнопке просмотра рекламы и перетащите его к двери." },
		{"Amazing!", "Великолепно!" },
		//176
		{"Hi, we’re still working on new levels. Stay tuned for the next update.", "Привет, мы все еще работаем над новыми уровнями. Пожалуйста, дождитесь следующего обновления." },
		{"", "" }
    };
    public static Dictionary<string, string> POR = new Dictionary<string, string>()
    {
		{"EN", "POR" },
		//GENERAL UI ELEMENTS
		{"7.99USD", "7.99EUR" },
		{"Don't show again.", "Não mostre novamente." },
		{"You have to turn the phone's rotating feature on.", "Você precisa ativar o recurso de rotação do telefone." },
		{"RESTORE", "RESTAURAR" },
		{"Restore Purchases", "Restaurar compras" },
		{"COMING SOON...", "EM BREVE..." },
		{"COME AGAIN TOMORROW!", "VENHA NOVAMENTE AMANHÃ!" },
		{"3 days free", "3 dias grátis" },
		{"AND...", "E..." },
		{"BECOME VIP!", "TORNE-SE VIP!" },
		{"CONGRATULATIONS!!!", "PARABÉNS!" },
		{"Daily Bonus", "Bónus Diário" },
		{"Double daily bonus", "Bônus diário duplo" },
		//ANDROID EXPLANATION
		//Weekly Premium automatically renews. Payment will be charged to your Google account at the end of the trial period of purchase. The subscription automatically renews unless auto-renews unless auto-renew is turned off at least 24 hours before the end of the current period. You can manage and turn off auto-renewal of the subscription by going to your account settings on the Google Play after purchase.
		//IOS EXPLANATION
		//Weekly Premium automatically renews. Payment will be charged to your iTunes account at the end of the trial period of purchase The subscription automatically renews unless auto-renews unless auto-renew is turned off at least 24 hours before the end of the current period. You can manage and turn off auto-renewal of the subscription by going to your account settings on the iTunes after purchase.
		{"Feedback", "Feedback" },
		{"Free", "Livre" },
		{"Game Reset", "Reset do jogo" },
		{"Hint discounts", "Sugestões de descontos" },
		{"INSTANTLY", "IMEDIATAMENTE" },
		{"All Levels", "Todos os Níveis" },
		{"Music", "Música" },
		{"Next", "Próximo" },
		{"Nice start...", "Bom começo ..." },
		{"Privacy Policy", "Politica de Privacidade" },
		{"PRIVACY POLICY", "POLITICA DE PRIVACIDADE" },
		{"Rate", "Avalie" },
		{"remove ads", "remover propagandas" },
		{"Remove ads", "Remover propagandas" },
		{"Remove Ads", "Remover Propagandas" },
		{"Share", "Partilhar" },
		{"Skip discounts", "Pular descontos" },
		{"Skip", "Saltar" },
		{"Skipping costs 2 keys. Would you like to skip?", "Saltar o desafio vai custar 2 chaves, saltar ou não?" },
		{"Sounds", "Efeitos Sonoros" },
		{"Store", "Loja" },
		{"TERMS OF USE", "TERMOS DE SERVIÇO" },
		{"Terms of Use", "Termos de Serviço" },
		{"TRY FOR FREE!", "EXPERIMENTAR GRATUITAMENTE!" },
		{"Vibration", "Vibração" },
		{"Watch", "Ver" },
		{"Weekly", "Semanal" },
		//PREFABS
		{"Exit", "Saída" },
		{"OK", "ESTÁ BEM" },
		{"Fire", "Fogo" },
		{"FINISH", "TERMINAR" },
		{"RUN", "CORRE" },
		{"CLEAR", "CLARO" },
		{"START", "COMEÇAR" },
		{"JUMP", "SALTAR" },
		{"Write your answer", "Escreva sua resposta" },
		//LEVELS
		//1
		{"Which one is red?", "Qual deles é vermelho?" },
		{"Or you didn't click on the red text?", "Ou não clicou no texto vermelho?" },
		{"Good start.", "Bom começo." },
		{"Green", "Verde" },
		{"Yellow", "Amarelo" },
		{"Blue", "Azul" },
		{"Red", "Vermelho" },
		//2
		{"Shoot the basketball into the hoop", "Jogue a bola de basquete para o cesto." },
		{"You need to press the shoot button when it reaches green in order to shoot.", "Você precisa pressionar o botão de disparo quando atingir o verde para lançar." },
		{"Nice shot.", "Bom lance." },
		{"Shoot", "Tiro" },
		//3
		{"Throw everything away", "Jogar tudo fora." },
		{"You should drag-and-drop pizza, cheese, ice-cream and cactus to the trash.", "Você deve arrastar e soltar pizza, queijo, sorvete e cacto no lixo." },
		{"Cleaning is important, of course...", "A limpeza é importante, claro..." },
		//4
		{"Find the different one", "Encontrar um diferente." },
		{"Could it be under the ice-cream? Look at it.", "Poderá estar debaixo do gelado? Dê uma vista de olhos." },
		{"I guess someone likes a different kind of ice-cream :)", "Acho que alguém gosta de outro tipo de gelado :)" },
		//5
		{"Which one is the biggest drop?", "Qual delas a maior gota?" },
		{"Put the drops on top of each other and create the largest one.", "Coloque as gotas umas sobre as outras e crie uma maior" },
		{"Many a mickle makes a muckle...", "Muitos barulhos fazem uma barulheira" },
		//6
		{"Did you try covering the lamp with your hand?", "Tentou tapar a lâmpada com a sua mão?" },
		{"You managed to help the baby sleep again. Zzz...", "Conseguiu ajudar o bebé a dormir novamente. Zzz..." },
		//7
		{"How many points do you give to this game?", "Quantos pontos dá a este jogo?" },
		{"I think you liked it very much.", "Acho que você gostou muito dele." },
		{"Since you loved it so much, let’s continue!", "Visto que você gostou tanto, vamos continuar." },
		{"Waste of time", "Perda de tempo" },
		{"I couldn't figured it out", "Eu não conseguia descobrir" },
		{"It's OK", "Está certo" },
		{"It's nice", "É legal" },
		{"I liked it very much!", "Eu gostei muito disso!" },
		//8
		{"Make the baby sleep", "Faça o bebé dormir." },
		{"Firstly, you should give the bottle and then try to put the baby to sleep in his/her car.", "Em primeiro lugar, deve dar o biberão e depois tentar colocar o bebé a dormir no seu carrinho." },
		{"Rub-a-dub-dub... Zzz...", "Rub-a-dub-dub... Zzz..." },
		//9
		{"Balance the scale", "Equilibre a balança." },
		{"If you take everything off, the scale would be even.", "Se você tirasse tudo, a balança ficaria equilibrada." },
		{"I know you are a balanced person.", "Eu sei que você é uma pessoa equilibrada." },
		//10
		{"One of the girls looking at the West, the other is to the East. But both of them can see each other, how can you do that?", "Uma das meninas a olhar para o Oeste, a outra para Leste. Mas as duas conseguem ver-se, como se pode fazer isto?" },
		{"You should move the girls’ head as to be turned as face-to-face.", "Deve mover a cabeça das meninas de modo a que fiquem cara a cara." },
		{"I see you’re getting used to it.", "Vejo que você está se acostumando." },
		//11
		{"Open the door", "Abra a porta." },
		{"You need to use the key in the child's pocket in order to open the door.", "Você precisa usar a chave no bolso da criança para abrir a porta." },
		{"Yeah, that’s it ;)", "Sim, é isso ;)" },
		//12
		{"Stop the fight..!!", "Parar a luta..!!" },
		{"You can stop the fight when you split the bone in two and give it to the dogs.", "Você pode parar a luta quando dividir o osso em dois e o entregar aos cães" },
		{"Fifty-fifty ;)", "Cinquenta-Cinquenta ;)" },
		//13
		{"Help the tree shed its leaves", "Ajude a árvore a perder suas folhas." },
		{"Paint the tree yellow with the paint bucket.", "Pinte a árvore de amarelo com o balde tinta." },
		{"You’re doing great!", "Você está indo lindamente!" },
		//14
		{"Catch the fish!", "Apanhe o peixe!" },
		{"The fish is hidden between the waves. Move the waves.", "O peixe está escondido entre as ondas. Mova as ondas." },
		{"That move seems familiar...", "Esse movimento me parece familiar…" },
		//15
		{"Fill the bucket with water", "Encha o balde com água." },
		{"Try to turn the phone. You will see that the direction of water will change.", "Tente ligar o telefone. Verá que a direção da água irá mudar." },
		{"Nature will take its course.", "A natureza tomará o seu curso." },
		//16
		{"Help the man lose weight", "Ajude o homem a perder peso." },
		{"Hold the man with your finger, drag him to the left and right 4 times and make him lose weight.", "Segure o homem com o dedo, arraste-o para a esquerda e direita 4 vezes e faça-o perder peso." },
		{"He’s skin and bones.", "Ele está magríssimo." },
		//17
		{"Feed the hay to the cow", "Alimente a vaca com o feno." },
		{"Didn't you see the shovel behind the hay? You can open a way with it.", "Você não viu a pá atrás do feno? Pode abrir um caminho com ela." },
		{"Now it’s time to eat.", "Agora é hora de comer." },
		//18
		{"Find the 10 differences", "Encontre 10 diferenças." },
		{"What’s important is making a difference :)", "O importante é fazer a diferença :)" },
		//19
		{"Clean the page!", "Limpe a página!" },
		{"You can clean it by hovering over it with your finger.", "Você pode limpá-la, ao passar o dedo sobre ele." },
		{"Did you try to use a rubber? Hahaha", "Você já tentou usar uma borracha? hahaha" },
		//20
		{"Which one is soda?", "Qual deles é refrigerante?" },
		{"Shake the phone, sparkle it and find the soda!", "Agite o telefone, faça bolhinhas e encontre o refrigerante!" },
		{"You will fizz like blup blup blup xD", "Você vai fracassar como blup blup blup xD" },
		//21
		{"Find the gamer", "Encontre o jogador." },
		{"A true gamer never sleeps.", "Um verdadeiro jogador nunca dorme." },
		{"Gamers don’t sleep. You can find the gamer by clicking on the only window in the apartment where the light is on.", "Os jogadores não dormem. Pode encontrar o jogador a clicar na única janela do apartamento em que a luz está acesa." },
		//22
		{"How many hairs does the child have?", "Quantos cabelos tem a criança?" },
		{"If you lift the child’s wig, you will see how many of the real hair is.", "Se levantar a peruca da criança, você verá quantos cabelos são de verdade." },
		{"If you could count all the hair, please contact us. :)", "Se você conseguiu contar todos os cabelos, por favor contate-nos. :)" },
		//23
		{"Please charge the phone", "Por favor carregue seu telefone." },
		{"Have you ever tried touching the cables at the same time with your two fingers?", "Você já tentou tocar nos cabos ao mesmo tempo com os dois dedos?" },
		{"I'm taking a shine from you.", "Eu estou a tirar o brilho de você." },
		//24
		{"If the hunter shots 2 of the birds, how many birds left at the branch?", "Se o caçador atira em 2 dos pássaros, quantos ainda restam no galho?" },
		{"'0' There would not be any birds left, all of them scared and flew away.", "0' Não havia mais pássaros, todos se assustaram e voaram para longe." },
		{"Well done the hunter, he shot 2 birds at the same time.", "Muito bem ao caçador, atirou em 2 pássaros ao mesmo tempo." },
		//25
		{"Pop the balloons!", "Rebente os balões!" },
		{"Scare the hedgehog and pop the balloons with its spines!", "Assuste o ouriço e este vai estourar os balões com espinhos!" },
		{"Boooooommmmm!", "Boooooommmmm!" },
		//26
		{"Reach the animal to the exit by using arrows", "Ajude o animal a dirigir-se até à saída usando as setas." },
		{"You should wander around before entering the maze.", "Você deve passear antes de entrar no labirinto." },
		{"All great minds think alike.", "Todas as grandes mentes pensam da mesma forma." },
		//27
		{"How many letters left in alphabet if you take the letters of “a” and “b” out?", "Quantas letras restam no alfabeto de tirar o ‘a’ e o ‘b’?" },
		{"There will be 6 letters left if you take a and b out from alphabet word.", "Ficam 6 letras se tirar a e b da palavra alfabeto." },
		{"Do you think that your friends can solve this question?", "Acha que os seus amigos conseguem responder a esta pergunta?" },
		//28
		{"How many flies are there?", "Quantas moscas existem?" },
		{"Enlarge the poop in the back and count the flies over it.", "Amplie o cocô nas costas e conte as moscas sobre ele." },
		{"Flies resides in the details.", "As moscas residem nos detalhes." },
		//29 DON'T FORGET TO CHANGE PREFAB
		{"Try to drag the “sleep” word over the baby...", "Tente arrastar a palavra ‘dormir’ sobre o bebé..." },
		{"It would be perfect if it was that easy to put babies in sleep in real life.", "Seria perfeito se fosse assim tão fácil colocar os bebés a dormir na vida real." },
		//30
		{"Try to close the cow's nose. Look at it, will it wake up?", "Tente fechar o nariz da vaca. Olhe para ela, vai acordar?" },
		{"Almost drowning.", "Quase se afogou." },
		//31
		{"Save the ship from crashing into the iceberg", "Salve o navio de colidir com o iceberg." },
		{"Try melting the iceberg by rubbing it with your finger.", "Tente derreter o iceberg esfregando-o com o dedo." },
		{"The Titanic would have sunk.", "O Titanic teria afundado." },
		//32
		{"Cross the truck across the bridge", "Atravesse o caminhão pela ponte." },
		{"Try to lift the bridge from the top with your finger.", "Tente levantar a ponte do topo com o dedo." },
		{"Honk honk!", "Honk honk!" },
		//33
		{"Which one is edible?", "Qual deles é comestível?" },
		{"What you think of as diamond and poop is actually cone and ice cream. Drag the cone under the ice cream.", "O que pensa como diamante e cocô é na verdade casquinha de gelado. Arraste o cone sob o gelado." },
		{"I wish they were here.", "Era tão bom que estivessem aqui." },
		//34
		{"What would the result be if we multiply all the numbers with each other?", "Qual seria o resultado se multiplicássemos todos os números entre si?" },
		{"What would the result be if you multiply a number with zero?", "Qual seria o resultado se multiplicar um número por zero?" },
		{"You cannot ignore the zero...", "Não se pode ignorar o zero…" },
		//35
		{"Do the right move to win the game!", "Faça o movimento certo para ganhar o jogo!" },
		{"Touch the sides of 'O' in the middle, at the same time with 2 fingers!", "Toque nos lados do 'O' no meio, ao mesmo tempo com 2 dedos!" },
		{"Good strategy.", "Boa estratégia." },
		//36
		{"How would you empty the bathtub fastly?", "Como esvaziaria a banheira rapidamente?" },
		{"Didn't you try to remove the stopper from the tub? You should try it right now.", "Você não tentou remover a tampa da banheira? Deveria tentar agora." },
		{"Your friends will have difficulty in solving this question!", "Os seus amigos terão dificuldade em resolver esta pergunta!" },
		//37
		{"Turn the child over by using two fingers and shake. The key will fall out of the child’s pocket.", "Vire a criança usando os dois dedos e agite. A chave irá cair do bolso da criança." },
		{"Successful!", "Muito bem!" },
		//38
		{"Find the real shadow of the bird", "Encontre a verdadeira sombra do pássaro." },
		{"If you drag the sun over the bird, the bird will have a shadow.", "Se você arrastar o sol sobre o pássaro, o pássaro terá uma sombra." },
		{"You are great.", "Você é ótimo." },
		//39
		{"Some months take 30, some take 31; how many months have 28 days?", "Alguns meses levam 30, outros 31; quantos meses tem 28 dias?" },
		{"Each month has 28 days.", "Todos os meses têm 28 dias." },
		{"It’s that simple.", "É muito simples." },
		//40
		{"Do not explode the bomb!", "Não rebente a bomba!" },
		{"The bomb will not explode already, just wait for 30 seconds.", "A bomba não vai explodir já, é só esperar 30 segundos" },
		{"How impatient you are.", "Quão impaciente você é." },
		//41 DON'T FORGET TO CHANGE PREFAB
		{"You should hang the word of “Man” in the question.", "Você deve pendurar a palavra 'Homem' na pergunta." },
		{"Rest in peace.", "Descanse em paz." },
		//42
		{"Wake up the cow", "Acorde a vaca." },
		{"If you take the moon off the screen, the sun rises and the cow wakes up.", "Se tirar a lua da tela, o sol nasce e a vaca acorda." },
		{"How can you sleep that much?", "Como é que você consegue dormir assim tanto?" },
		//43
		{"Press the orange circle 10 times, then press the blue circle once", "Pressione o círculo laranja 10 vezes e, em seguida, pressione o círculo azul uma vez." },
		{"Are you sure that you pressed 10 times? Because the number starts from 1.", "Você tem a certeza de que pressionou 10 vezes? Porque o número começa em 1." },
		{"Or did you press 9 times? We said 10...", "Ou você pressionou 9 vezes? Dissemos 10…" },
		//44
		{"Find the couples and win the game", "Encontre os casais e ganhe o jogo." },
		{"Shrink your screen, you will see your other mate.", "Ligar o ecrã e verá o outro parceiro." },
		{"You did a good job.", "Bom trabalho!" },
		//45
		{"How this equation becomes correct?", "Como é que esta equação se torna correta?" },
		{"Use the number of 45 in the Lv.45 to create 4550 number.", "Use o número 45 no Nível 45 para criar o número 4550." },
		{"You are a true genius.", "Você é um verdadeiro génio." },
		//46
		{"Confirm evenness by moving the single matchstick!", "Confirme a uniformidade movendo o único palito de fósforo!" },
		{"Move the number of 4's matchstick and get 2 pieces of 1! 311+89=400", "Mova o número do palito de fósforo de 4 e obtenha 2 peças de 1! 311 + 89 = 400." },
		{"Did you know that the match was invented after the lighter?", "Você sabia que o jogo foi inventado após o isqueiro?" },
		//47
		{"Make all of it green!", "Torne tudo verde!" },
		{"First of all, shake the phone, then put the chameleon on the grass, and then paint the question with the paint bucket. Don't forget to remove the clouds from the screen.", "Primeiro, agite o telefone, coloque o camaleão na relva e depois pinte a pergunta com o balde de tinta. Não se esqueça de remover as nuvens da tela." },
		{"How the greens will smile if the clouds do not cry?", "Como é que os campos irão sorrir se as nuvens não chorarem?" },
		//48
		{"If 5 squirrels eat 5 walnuts in 5 minutes, in how many minutes does 15 squirrels eat 15 walnuts?", "Se 5 esquilos comem 5 nozes em 5 minutos, em quantos minutos 15 esquilos comem 15 nozes?" },
		{"In 5 minutes.", "Em 5 minutos." },
		{"Aren’t those squirrels so sweet?", "Os esquilos não são tão fofos?" },
		//49 DON'T FORGET TO CHANGE PREFAB
		{"Drag the word 'Protect' on to the rocket.", "Arraste a palavra ‘Proteger’ para cima do foguetão." },
		{"Power shields are now activated.", "Escudos protetores agora ativados!" },
		//50
		{"You should win the game again", "Deve ganhar o jogo!" },
		{"Use 0 in the 50 words. Hold and drag it to the middle of O and press the other side.", "Use 0 nas 50 palavras. Segure e arraste-o para o meio do O e pressione o outro lado." },
		{"You know it.", "Você sabe." },
		//51
		{"Pizza, ice-cream, cheese, cactus, 'Throw everything away' text and you should throw away the cap of the trash.", "Pizza, sorvete, queijo, cacto, texto 'Jogue tudo for a' e você deve jogar fora a tampa do lixo." },
		//52
		{"How many rings are there on the screen?", "Quantos anéis existem na tela?" },
		{"We hid 4 of them under the Clean button. '22'", "Nós escondemos 4 deles sob o botão Limpar. '22'." },
		{"Nothing can escape from you.", "Nada escapa de você." },
		//53
		{"Collect 5 mice like in the picture", "Recolha 5 ratos como na foto." },
		{"Just click to the mouse in the left direction and do not forget the mouse in the example.", "Basta clicar com o mouse na direção esquerda e não esquecer o mouse no exemplo." },
		{"You are a good hunter!", "Você é um bom caçador!" },
		//54
		{"How can the kangaroo jump higher than the building?", "Como é que o canguru pode saltar mais alto que o prédio?" },
		{"Make the trampoline bigger!", "Faça o trampolim maior!" },
		{"Bounce bounce bounce...!", "Bounce bounce bounce…!" },
		//55
		{"Bring the magnifier to the child's arm on the lower left. You will see the replica.", "Traga a lupa para o braço da criança, no canto inferior esquerdo. Verá a réplica." },
		{"You’ve got him.", "Você o apanhou." },
		//56
		{"Which one is the prettiest?", "Qual o mais bonito?" },
		{"Drag the boy in front of the girl, whichever one he smiles at is the prettiest.", "Arraste o para frente da menina, a que ele sorrir é a mais bonita." },
		{"Love at first sight.", "Amor à primeira vista." },
		//57
		{"You should rub the baby’s belly and let the gas out.", "Deve esfregar a barriga do bebé e deixar o gás sair." },
		{"Ops the baby has gas.", "Ops o bebé tem gás." },
		//58 DON'T FORGET TO CHANGE PREFAB
		{"You should clean it by using the word 'Clean' in the question.", "Deve limpá-la usando a palavra ‘Limpar’ na pergunta." },
		{"I accept it was bad.", "Concordo que foi mau." },
		//59
		{"Get the number of 100 twice by using a single line from the number of 188", "Obtenha o número de 100 duas vezes usando uma única linha do número de 188." },
		{"Divide the number of 188 horizontally. You will have 2 of 1, 4 of 0.", "Divida o número de 188 na horizontal. Terá 2 de 1, 4 de 0." },
		{"Wooww, you are super.", "Wooww, você é demais." },
		//60
		{"To drop an apple from the tree, you must shake the tree very much. Shake the phone.", "Para soltar uma maçã da árvore, deve a sacudir muito. Agite o telefone." },
		{"Did this cow discover gravity?", "A vaca descobriu a gravidade?" },
		//61
		{"Turn the light off", "Desligue a luz." },
		{"Turn off the screen towards the table. The light will go off.", "Desligue a tela em direção à mesa. A luz se apaga." },
		{"Where were we?", "Onde estávamos?" },
		//62
		{"Bring the pen into the empty space", "Traga a caneta para o espaço vazio." },
		{"One of the objects below can be rotated. Find the rotating pen and put it back correctly.", "Um dos objetos abaixo pode ser girado. Encontre a caneta rotativa e recoloque-a corretamente." },
		{"The pen is mightier than the sword.", "A caneta é mais poderosa do que a espada." },
		//63
		{"Feed the dog with the food under the box and wait for it to poop. Take the key that comes with the poop to the door.", "Alimente o cão com a comida a baixo da caixa e espere que ele faça cocô. Pegue na chave que vem com o cocô até à porta" },
		{"Sweet little doggie.", "Cachorro fofo." },
		//64
		{"Solve the problem!", "Resolva o problema!" },
		{"Be careful about seeds of blackberry, 2 of them are missing. '18'", "Tenha cuidado com as sementes de amora, 2 delas estão em falta.’18’" },
		{"You understand the math...", "Você entende a matemática…" },
		//65
		{"Try to get rain from the cloud.", "Tente fazer chover com a nuvem." },
		{"It's raining, floods are flowing...", "Está a chover, estão a fluir inundações..." },
		//66
		{"Do you guess the three letters upcoming in the order?", "Adivinhe as três letras seguintes na ordem?" },
		{"Look carefully at the first letters of words in the question? Use the first letters of last two words", "Observe atentamente as primeiras letras das últimas duas palavras da pergunta? Use as primeiras letras das duas últimas palavras 'AATLSNO'" },
		{"Did you guess?", "Adivinhou?" },
		//67
		{"Find objects!", "Encontre os objetos!" },
		{"You have a sharp sight!", "Você tem uma visão nítida!" },
		//68
		{"How many numbers are there?", "Quantos números existem?" },
		{"You are super!", "Você é um máximo!" },
		//69
		{"Please write down the right answer?", "Por favor aponte as respostas certas." },
		{"You should think simple. Add up the 8 and 5.", "Você deve pensar simples. Adicione os 8 e 5." },
		{"Sometimes you need to think simple ;)", "Ás vezes você precisa pensar simples ;)" },
		//70
		{"I go to bed at 8 o'clock at night and I set my cuckoo clock at 9 in the morning. How many hours will I sleep?", "Vou dormir às 8 horas da noite e acerto o meu relógio de cuco às 9 da manhã. Quantas horas vou dormir?" },
		{"The cuckoo clock won’t differentiate night and day, hence you will sleep for one hour.", "O relógio de cuco não diferencia noite e dia, portanto dormirá uma hora." },
		{"Is the alarm a little bit early?", "Será que o alarme está um pouco cedo?" },
		//71
		{"With two fingers, swipe to the left on the screen and plug the phone into a socket. Then touch the cables at the same time.", "Com os dois dedos, deslize para a esquerda na tela e conecte o telefone a uma tomada. Em seguida, toque nos cabos ao mesmo tempo." },
		{"Be careful, don’t be shocked!", "Cuidado, não leve um choque." },
		//72
		{"The wheel of the car is in one of the clouds. Put the cloud with your finger and shake it. Mount the wheel on the truck. Tilt the screen to the right. The truck will move across the street.", "O volante do carro está numa das nuvens. Coloque a nuvem com o dedo e agite-a. Monte a roda no caminhão. Incline a tela para a direita. O caminhão irá mover-se do outro lado da rua." },
		{"Do not ask why the rubber tire is over there.", "Não pergunte por que é que a borracha do pneu está ali." },
		//73
		{"You should try to turn off the light with your finger.", "Deve tentar desligar a luz com o dedo." },
		{"There would not be a more creative way.", "Não havia uma forma mais criativa." },
		//74
		{"Choose 3 balls, verify the evenness!", "Escolha 3 bolas, verifique a uniformidade!" },
		{"Turn the 9 upside down and make it 6! 11+13+6: 30! That much easy!", "Vire o 9 de cabeça para baixo e faça 6! 11 + 13 + 6:30! Muito fácil!" },
		{"We put the ball upside down, sorry.", "Colocamos a bola de cabeça para baixo, desculpe." },
		//75
		{"Which one is the heaviest?", "Qual é o mais pesado?" },
		{"Lift both hammers and drop them at the same time to find out which one is the heaviest.", "Levante os dois martelos e solte-os ao mesmo tempo para descobrir qual é o mais pesado." },
		{"I congratulate your physics teacher.", "Parabéns ao seu professor de física." },
		//76 DON'T FORGET TO CHANGE PREFAB
		{"Drag the “fish” text over to the edge of the fishing hook.", "Arraste o texto ‘peixe’ até à borda do anzol." },
		{"Delicious.", "Delicioso." },
		//77
		{"Shake the drink and help the child drink it", "Agite a bebida e ajude a criança a beber." },
		{"Hold the bottle shut with your finger, shake your phone, and give the bottle to the child.", "Mantenha o frasco fechado com o dedo, agite o telefone e entregue-o à criança." },
		{"Shake before drinking!", "Agite antes de beber!" },
		//78
		{"Help the child to open the safe", "Ajude a criança a abrir o cofre." },
		{"Turn the phone over and shake it. The key will fall out of the child’s pocket.", "Vire o telefone e agite-o. A chave irá cair do bolso da criança." },
		{"What do you think inside of it?", "O que acha que está lá dentro?" },
		//79
		{"Find the numbers on the balls", "Encontre os números nas bolas." },
		{"148", "148" },
		{"Are you a math professor or something?", "Você é professor de matemática ou quê?" },
		//80
		{"Drag the screen towards the left and you will see the bird’s real shadow. (Use two fingers at the same time)", "Arraste a tela para a esquerda e verá a sombra real do pássaro. (Use dois dedos ao mesmo tempo)" },
		{"I’m impressed… You’re fast.", "Estou impressionado. Você é rápido." },
		//81
		{"Clean the car", "Limpe o carro." },
		{"You need to clean over the car with your finger.", "Tem de limpar o carro com seu dedo." },
		{"Sparkling clean.", "Limpeza brilhante." },
		//82
		{"Find the strongest balloon!", "Encontre o balão mais forte!" },
		{"Drag the balloons over to the skip forward sign, 4 of them will pop! The strongest balloon won’t pop.", "Arraste os balões para o sinal de avançar, 3 deles irão aparecer! O balão mais forte não vai explodir." },
		{"You’re doing great.", "Você está indo muito bem." },
		//83
		{"How many orange cubes do you need to cover the blue cube?", "Quantos cubos laranja precisa para cobrir o cubo azul?" },
		{"22", "22" },
		{"That was a good one.", "Esta foi boa." },
		//84
		{"Flip the text with two fingers. Put it between the tap and the bucket.", "Vire o texto com dois dedos. Coloque-o entre a torneira e o balde." },
		{"Bet you didn’t think of that one, did you?", "Aposto que você não pensou nisso, pensou?" },
		//85
		{"The baby will sleep if you put your phone down on the table face down.", "O bebé adormece se colocar o telefone na mesa com a face para baixo." },
		{"You’re the best at putting babies to sleep.", "Você é o melhor a adormecer bebés." },
		//86  DON'T FORGET TO CHANGE PREFAB
		{"What’s the size of the table?", "Qual o tamanho da mesa?" },
		{"You’re on a roll.", "Você está bombando!" },
		//87
		{"Try dispersing the soil by shaking your phone", "Tente dispersar o solo agitando seu telefone." },
		{"We’re covered in dirt.", "Estamos cobertos de sujidade." },
		//88
		{"Please help me find my dog in this mess", "Por favor, me ajude a encontrar o meu cachorro nesta bagunça." },
		{"You need to make the screen smaller. The dog is somewhere outside of the screen.", "Você precisa diminuir a tela. O cachorro está em algum lugar fora da tela." },
		{"Thank you!", "Obrigado!" },
		//89
		{"Lift Thor’s hammer", "Levante o martelo do Thor." },
		{"The hammer is so heavy you will need to lift it with three fingers.", "O martelo é tão pesado que você irá precisar levantá-lo com três dedos." },
		{"You’re even stronger than I thought!", "Você é ainda mais forte do que eu pensava!" },
		//90
		{"Find the pairs and win the game", "Encontre os pares e ganhe o jogo." },
		{"Divide the last one remaining in half by drawing a line through the middle of it.", "Divida o último restante ao meio, ao desenhar uma linha no meio." },
		{"We make a good pair.", "Fazemos um bom par." },
		//91
		{"Touch the cow’s head 10 times.", "Toque na cabeça da vaca 10 vezes." },
		{"The cow is a heavy sleeper.", "A vaca tem um sono pesado." },
		//92
		{"Hey..!! What day of the month is it?", "Ei..!! Que dia do mês é?" },
		{"Seriously, what day of the month is it? What number is the calendar on your phone showing?", "A sério, que dia do mês é esse? Qual é o número do calendário no seu telefone?" },
		{"Sometimes I forget the date, too.", "Por vezes também me esqueço da data." },
		//93
		{"You need to shake the tree a lot. The key will fall from it.", "Você precisa agitar muito a árvore. A chave irá cair dela." },
		{"Whose idea was it to hide the key in a tree?", "De quem foi a ideia de esconder a chave numa árvore?" },
		//94  DON'T FORGET TO CHANGE PREFAB
		{"You can use the word “Balance” in the text to balance the scale.", "Você pode usar a palavra ‘Equilibre’ no texto para equilibrar a balança." },
		{"Are you balanced?", "Você está equilibrado?" },
		//95
		{"If the bridge is falling apart, you need to support the middle of the bridge with your hand.", "Se a ponte estiver a desmoronar, você precisa apoiar o meio da ponte com a mão." },
		{"You’re the king of the road.", "Você é o rei da estrada." },
		//96
		{"It’s snowing! Catch the snow...", "Está a nevar! Apanhe a neve…" },
		{"Place your phone on a flat surface with the screen facing up and wait.", "Coloque o telefone numa superfície plana com a tela voltada para cima e aguarde." },
		{"Become one with the snow.", "Se torne um com a neve." },
		//97
		{"Help him escape prison", "Ajude-o a escapar da prisão." },
		{"You can escape by pressing the escape button after you unscrew the lightbulb.", "Você pode escapar ao pressionar o botão de escapar depois de desapertar a lâmpada." },
		{"Smells like freedom!", "Cheira a liberdade!" },
		//98
		{"Park the car", "Estacione o carro." },
		{"There might be space further down the road.", "Pode haver espaço mais adiante no caminho." },
		{"Slowly… Slowly… Now park the car!", "Devagar… Devagar… Agora estacione o carro!" },
		//99
		{"You will catch the cheater if you move the front row.", "Apanhará o batoteiro se mover a primeira fila." },
		{"Caught red-handed.", "Pego em flagrante." },
		//100
		{"Help the child see!", "Ajude a criança a ver!" },
		{"Drag the two zeros in '100' to make glasses for the kid.", "Arraste os dois zeros em ‘100’ para fazer óculos para a criança." },
		{"That’ll show you!", "Isto vai lhe mostrar!" },
		//101
		{"Which one would you save?", "Qual deles salvaria?" },
		{"You need to press all three at the same time. Don’t try doing it one by one.", "Você precisa pressionar todos os três ao mesmo tempo. Não tente fazer isto um por um." },
		{"You are so single.", "Você é solteiro." },
		{"Family", "Família" },
		{"Love", "Ame" },
		{"Money", "Dinheiro" },
		//102
		{"The animals are racing. The cow, the rabbit, and the turtle. Help the turtle win", "Os animais estão a correr. A vaca, o coelho e a tartaruga. Ajude a tartaruga a ganhar." },
		{"Drag the start button and hit the Turbo button underneath.", "Arraste o botão Iniciar e pressione o botão Turbo por baixo." },
		{"Fast and furious.", "Rápidos e furiosos." },
		{"Start", "Começar" },
		//103
		{"The baby will sleep if you turn the volume down on your phone.", "O bebé irá dormir se diminuir o volume no telefone." },
		{"Hush...", "Shh…" },
		//104
		{"What should be the next number in the sequence?", "Qual deve ser o próximo número na sequência?" },
		{"Read the numbers you see out loud! The numbers are how the previous numbers sound when you read them together… '13112221'", "Leia os números que você vê em voz alta! Os números são como os números anteriores soam quando os lê juntos ... ‘13112221’" },
		{"We’ll admit it was a hard question.", "Adimitimos que foi uma pergunta difícil." },
		//105
		{"Help the truck pass through the tunnel", "Ajuda o caminhão a passar pelo túnel." },
		{"Shrink the truck with two fingers.", "Encolha o caminhão com os dois dedos." },
		{"Well done!", "Muito bem!!" },
		//106
		{"If Mary gathers 2 bananas in 1 minute, how many bananas can she gather from this tree in 10 minutes?", "Se a Maria colhe 2 bananas num 1 minuto, quantas bananas consegue colher desta árvore em 10 minutos?" },
		{"Does it look like bananas grow on this tree? The answer is '0'", "Lhe parece que as bananas crescem nesta árvore? A resposta é ‘0’." },
		{"You’re quite smart.", "Você é esperto." },
		//107 DON'T FORGET TO CHANGE PREFAB
		{"The match will be lit if you drag it and rub it over the word 'Light'.", "O fósforo irá acender se o arrastar e esfregar sobre a palavra ‘Acender’." },
		{"Don’t play with fire.", "Não brinque com o fogo." },
		//108
		{"List the numbers you see on the screen in order", "Liste os números que vê na tela em ordem." },
		{"At first, it started with 3, 2, 1, didn’t you see? 3, 2, 1, 32, 67, 21, 5, 14, 8", "No começo, começou com 3, 2, 1, não viu? 3, 2, 1, 32, 67, 21, 5, 14, 8" },
		{"I’m in awe of your visual memory!", "Estou admirado com a sua memória visual!" },
		//109
		{"Who is pregnant?", "Quem está grávida?" },
		{"Turn your phone upside down and shake it. Drag the pregnancy test over to the woman on the right.", "Vire o telefone de cabeça para baixo e agite-o. Arraste o teste de gravidez para a mulher à direita." },
		{"Congratulations!", "Parabéns!" },
		//110
		{"How many squares are there?", "Quantos quadrados existem?" },
		{"Would it be 40?", "Serão 40?" },
		{"It is 40!", "São 40!" },
		//111
		{"Make the man happy!", "Faça o homem feliz!" },
		{"Drag the man up over the clouds.", "Arraste o homem sobre as nuvens." },
		{"Being happy is that simple!", "Ser feliz é tão simples assim!" },
		//112
		{"Sally is 21 years older than her son. 2 years ago, Sally was 4 times her son’s age. How old is Sally?", "Sally tem 21 anos a mais que o seu filho. Há dois anos, Sally tinha 4 vezes a idade do seu filho. Quantos anos tem a Sally?" },
		{"She is 31.", "Ela tem 31." },
		{"What did you study in school?", "O que estudou na escola?" },
		//113
		{"Park the car in the right spot", "Estacione o carro no lugar certo." },
		{"Drag the skirt off of the female symbol in the middle to make it appropriate for the driver.", "Arraste a saia para fora do símbolo feminino no meio para torná-lo apropriado para o motorista." },
		{"Thought you’d never figure it out.", "Pensei que você nunca iria descobrir." },
		//114
		{"That counts as a three-pointer.", "Essa conta como três pontos." },
		//115
		{"Did you try taking the light that won’t turn off out of the screen?", "Tentou tirar a luz que não se apaga na tela?" },
		{"I love your sharp wit!", "Eu amo sua inteligência afiada!" },
		//116
		{"Save the gorilla :(", "Salve o gorila :(" },
		{"You can use the hint key to unlock the lock.", "Pode usar a tecla de dica para abrir a fechadura." },
		{"#FreedomForAnimals", "#LiberdadeParaAnimais" },
		//117
		{"What’s the fastest route from A to I?", "Qual é a rota mais rápida de A a I?" },
		{"You need to swap B and I’s places.", "Você precisa trocar os lugares do B e do I." },
		{"You’re so fast!", "Você é tão rápido!" },
		//118
		{"Burn everything", "Queime tudo." },
		{"Drag the magnifying glass between the sun and the wood to spark a fire. Then use the wood on the fire to burn everything. You can pass the level by burning everything including the 'Burn everything' text and the sun.", "Arraste a lupa entre o sol e a madeira para acender o fogo. Em seguida, use a lenha no fogo para queimar tudo. Pode passar de nível ao queimar tudo, incluindo o item ‘Queimar tudo’ o texto e o sol." },
		{"Time to call the fire station!", "Hora de chamar os bombeiros!" },
		//119
		{"2 of them are drowned, 4 of them are swimming, and 3 of them are dead. How many fish left in the aquarium?", "2 deles são afogados, 4 deles estão a nadar e 3 deles estão mortos. Quantos peixes restam no aquário?" },
		{"Fish don’t drown in water. But even if they did, none of them would go out of aquarium hence, 10 fish will be left.", "O peixe não se afoga na água. Mas, mesmo que o fizessem, nenhum deles sairia do aquário, restam 10 peixes." },
		{"You are a real genius.", "Você é um génio." },
		//120
		{"You should try charging your own phone while the game is on.", "Deve tentar carregar o seu próprio telefone enquanto o jogo está a ligar." },
		{"We gave you an excuse to charge your phone :)", "Demos-lhe uma desculpa para carregar o seu telefone :)" },
		//121
		{"Put the fire out", "Apague o fogo." },
		{"Squeeze the cloud with two fingers and make water spill to put out the fire.", "Aperte a nuvem com os dois dedos e faça com que a água derrame para apagar o fogo." },
		{"It’s raining cats and dogs!", "Está a chover a potes." },
		//122
		{"Find the pirate", "Encontre o pirata." },
		{"Pirates have wooden legs. Try lifting their pant legs to see.", "Piratas têm pernas de pau. Tente levantas as calças deles para ver." },
		{"Nice, the next question awaits.", "Boa, a próxima pergunta espera por você." },
		//123
		{"Complete the equation", "Complete a equação." },
		{"Take the 1, 2, and 3 from “Lv. 123” and put them in the places of A, B, and C. That will complete the equation.", "Tire o 1, 2 e 3 da equação ‘Nivel. 123’ e coloque-os nos lugares de A, B e C. Isto vai completar a equação." },
		{"You really surprised me.", "Realmente me surpreendeu." },
		//124
		{"Defeat your competitor in Rock-Paper-Scissors game!", "Derrote o seu oponente no jogo Pedra-Papel-Tesoura!" },
		{"You have to move to the winning side by relocating the players!", "Tem de passar para o lado vencedor, realocando os jogadores!" },
		{"Or did you cheat?", "Ou fez batota?" },
		//125
		{"It’s 3:35. What time would it be if the clock moved counter-clockwise 90 degrees?", "São 3:35. Que horas seriam se o relógio se movesse 90 graus no sentido anti-horário?" },
		{"Could it be 12:20?", "Seria 12:20?" },
		{"Did you ask your friends what level they’re on?", "Já perguntou para seus amigos em que nível estão?" },
		//126 DON'T FORGET TO CHANGE PREFAB
		{"Did you try to click on Europe text?", "Você tentou clicar no texto Europa?" },
		{"Bravo!", "Bravo!" },
		//127
		{"Make the bulbs explode by clicking on the lights 5 times", "Faça as lâmpadas explodirem clicando nas luzes 5 vezes." },
		{"The lights are off alright...", "As luzes estão apagadas..." },
		//128
		{"He broke the vase 10 minutes ago. Help him fix it", "Ele quebrou o vaso há 10 minutos. Ajude-o a consertar." },
		{"The vase wasn’t broken 10 minutes ago. Try rewinding the clock.", "O vaso não foi quebrado há 10 minutos. Tente rebobinar o relógio." },
		{"You just traveled through time.", "Você acabou de viajar no tempo." },
		//129
		{"Which tank would be filled first?", "Qual tanque seria preenchido primeiro?" },
		{"Draw a line to A's drain. Thus, 'A' will be filled first.", "Desenhe uma linha no dreno de A. Assim, ‘A’ será preenchido primeiro." },
		{"Hmm, smart...", "Hmm, inteligente…" },
		//130
		{"Shrink the building.", "Diminua o prédio." },
		{"Kangaroo-lations!", "Parabéns!!!" },
		//131 DON'T FORGET TO CHANGE PREFAB
		{"You should try turning the 9 in the question into a 6. Then you will have the right number of bananas.", "Deve tentar transformar o 9 da pergunta em 6. Então, terá o número certo de bananas." },
		{"Something’s not right about this.", "Algo não está certo nisso." },
		//132
		{"What should fill the blank?", "O que deve preencher o vazio?" },
		{"Did you ever drive? This was car gear. Reverse gear 'R'...", "Já conduziu? Isso era equipamento de carro. Engrenagem reversa ''R’…" },
		{"Ok understood, you don’t have an 'R'.", "Ok entendido, você não tem um ‘R’" },
		//133
		{"How many 3's are there?", "Quantos 3 existem?" },
		{"There are five 3's including the ones in 'Lv.133' and the question.", "Existem cinco 3, incluindo os do ‘Nivel 133’ e a pergunta." },
		{"Good catch!", "Muito bem!!!" },
		//134
		{"Shake the clouds and catch the fish with the worm under the tree.", "Agite as nuvens e pegue os peixes com a minhoca debaixo da árvore." },
		{"Hook, line, and sinker!", "Anzol, linha e chumbada!" },
		//135
		{"Help the truck pass through the tunnel!", "Ajude o caminhão a atravessar o túnel!" },
		{"Deflate the truck’s wheels! You can use the 'Forward' symbol.", "Esvazie as rodas do caminhão! Pode usar o símbolo ‘Avançar’." },
		{"Wish we could give you a reward.", "Desejávamos poder lhe dar uma recompensa." },
		//136
		{"Make a square by moving 2 balls", "Faça um quadrado movendo 2 bolas." },
		{"Wow!", "Wow!" },
		//137
		{"Turn off the lights", "Apague as luzes." },
		{"You should try putting your phone upside down on the table, with the screen facing down. Then the light will go off.", "Você deve tentar colocar o telefone de cabeça para baixo na mesa, com a tela voltada para baixo. Então a luz se apaga." },
		{"That’s what we’re talking about.", "É disso que estamos a falar." },
		//138
		{"Turn the cow in the other direction before it reaches the soil.", "Vire a vaca na outra direção antes que atinja o solo." },
		{"Where there’s a will, there’s a way.", "Onde há vontade, há um caminho." },
		//139
		{"Speed up the clock and reveal the pregnant woman.", "Acelere o relógio e revele a mulher grávida." },
		{"Time flies...", "O tempo voa…" },
		//140
		{"Take the key on the upper right corner of the screen and drag it onto the door to pass the level.", "Pegue a chave no canto superior direito da tela e arraste-a para a porta para passar de nível." },
		{"We couldn’t trick you...", "Não lhe conseguimos enganar…" },
		//141
		{"Leave me alone for a bit...", "Deixe-me em paz por um pouco." },
		{"Leave the game, wait a couple of seconds, and re-enter the game.", "Saia do jogo, aguarde alguns segundos e entre novamente no jogo." },
		{"Thank you for understanding.", "Obrigado por perceber." },
		//142
		{"Hold the basketball with your finger and slam dunk!", "Segure a bola de basquete com o dedo e lance!" },
		{"A great slam dunk.", "Ótimo lance." },
		//143
		{"Catch person who is cheating!", "Apanhe a pessoa que está a fazer batota!" },
		{"Try lifting the child’s hat who is at the right.", "Tente levantar o chapéu da criança que está à direita." },
		{"You are not missing a thing.", "Você não está a perder nada." },
		//144
		{"Help an old lady cross the road", "Ajude uma senhora a atravessar a rua." },
		{"One of the trucks has a green light in its truck bed. You need to put it in the right spot.", "Um dos caminhões tem uma luz verde na sua carroceria. Precisa colocá-lo no lugar certo." },
		{"Thank you for your help!", "Obrigado pela ajuda!" },
		//145
		{"What is the result of the calculation?", "Qual é o resultado do cálculo?" },
		{"The result of the calculation is '-62'.", "O resultado do cálculo é ‘-62’." },
		{"The social science people are now crying.", "As pessoas das ciências sociais estão chorando." },
		//146
		{"Gather the stones upstream and stop the water. Drag the net over the fish.", "Recolha as pedras e pare a água. Arraste a rede sobre o peixe." },
		{"The fish jumps once jumps twice...", "O peixe pula uma vez pula duas vezes…" },
		//147
		{"Shrink down the fire!", "Abrande o fogo!" },
		{"Shake the phone, let the fire disperse and choose the smaller one!", "Agite o telefone, deixe o fogo se dispersar e escolha o mais pequeno!" },
		{"Did you try to snuff it out?", "Tentou acabar com ele?" },
		//148
		{"Find the password!", "Descubra a palavra-passe!" },
		{"'042' Think again... You can also ask a friend.", "‘042’ Pense novamente ... Também pode perguntar a um amigo." },
		{"If you found this as well, you should be proud of yourself!", "Se você também encontrou isso, deve se orgulhar de si mesmo!" },
		{"A number and it's place are correct", "Um número e seu lugar estão corretos" },
		{"A number is correct but it's place is wrong", "Um número está correto, mas seu lugar está errado" },
		{"Two numbers are correct but the places are wrong", "Dois números estão corretos, mas os lugares estão errados" },
		{"Nothing is correct", "Nada está correto" },
		{"ENTER", "ENTRAR" },
		//149
		{"Weigh the chicken", "Pesar o frango." },
		{"Shake the chicken to make its eggs fall out and make it lighter.", "Agite o frango para que os seus ovos caiam e fique mais leve." },
		{"I’m light as a feather.", "Sou leve como uma pena." },
		//150
		{"Is it too quiet here?", "Está muito quieto aqui?" },
		{"A little music wouldn't be bad.", "Um pouco de música não seria ruim." },
		{"Music is the essence of the soul ;)", "A música é a essência da alma ;)" },
		//151
		{"Take the ball outside!", "Leve a bola para fora!" },
		{"Pour water from the dispenser size bottle to the glass and pour it into the pipe. Let the ball go up.", "Despeje a água do frasco do tamanho do distribuidor no copo e despeje-o no tubo. Deixe a bola subir." },
		{"You discovered the buoyant force of the water.", "Descobriu a força flutuante da água." },
		//152
		{"Score a goal.", "Marque um golo." },
		{"Try to press two arrows at the same time.", "Tente clicar nas duas setas ao mesmo tempo." },
		{"Gooaal!..!!", "Goloooooooo...!" },
		//153
		{"Make the baby laugh.", "Faça o bebê rir." },
		{"Take off the baby's socks and tickle the baby's feet with a feather.", "Tire as meias ao bebê e faça cócegas nos pés com uma pena." },
		{"The world is better when babies laugh.", "O mundo melhora quando um bebê ri." },
		//154
		{"Bring the child to the exit", "Leve a criança à saída" },
		{"Turn your phone over and watch the child.", "Vire o telefone e observe a criança." },
		{"Did you send the game to your friends? Now, send it from the share button below.", "Você enviou o jogo para os seus amigos? Agora, envie-o pelo botão de compartilhamento abaixo." },
		//155
		{"The child is so lonely", "A criança está tão sosinha" },
		{"Hold on the child with your finger for 5 seconds and then, copy the child.", "Segure a criança com o dedo por 5 segundos e depois copie-a." },
		{"Now, they are twins.", "Agora são gêmeos." },
		{"Copy", "cópia de" },
		{"Rate the game", "Avalie o jogo" },
		//156
		{"Please click in the following order", "Clique na seguinte ordem" },
		{"Are you sure you did the right thing? Watch out for the last finger.", "Tem certeza de que fez a coisa certa? Cuidado com o último dedo." },
		{"That's it!", "Isso mesmo!" },
		//157
		{"Silence the child", "Cale a criança" },
		{"The toy is hidden under the button. Give it to the child.", "O brinquedo está escondido sob o botão. Dê para a criança." },
		{"It's really awesome.", "É realmente incrível." },
		{"Watch video", "Assista vídeo" },
		//158 DON'T FORGET TO CHANGE PREFAB
		{"Unlock the case.", "Desbloqueie a capa." },
		{"Take the word ‘password’ to the correct place.", "Leve a palavra 'senha' para o local correto." },
		{"Is it difficult?", "É dificil?" },
		//159
		{"Grab the gift box on the daily bonus button and give it to the man. The man will be happy to receive a gift.", "Pegue a caixa de presente no botão de bônus diário e entregue ao homem. O homem ficará feliz em receber um presente." },
		{"Who recently bought you a gift?", "Quem recentemente lhe ofereceu um presente?" },
		//160
		{"What does the child see?", "O que vê a criança?" },
		{"Try to look at from the perspective of the child.", "Tente olhar da perspectiva da criança." },
		{"It's all about perspective!", "É tudo sobre a prespetiva!" },
		//161 DON'T FORGET TO CHANGE PREFAB
		{"One of the X's can be moved. Remove X and replace it with the dot in the question.", "Um dos X pode ser movido. Remova o X e substitua-o pelo ponto da pergunta." },
		{"You are true genius!", "Você é um verdadeiro gênio!" },
		//162
		{"Make the girl fall in love with the boy", "Faça a garota se apaixonar pelo garoto" },
		{"Shake the child quite a while. Maybe he is hiding a surprise gift.", "Agite a criança por algum tempo. Talvez ele esconda um presente surpresa." },
		{"You're the last single person in the world.", "Você é a última pessoa solteira do mundo." },
		//163 DON'T FORGET TO CHANGE PREFAB
		{"Try to use the word 'Truck'.", "Tente usar a palavra 'Caminhão'." },
		{"Poor truck.", "Pobre caminhão." },
		//164
		{"Find the water for kids to make a water fight.", "Encontre a água para as crianças fazerem uma guerra de água." },
		{"Hold both clouds with your fingers at the same time shake your phone.", "Segure as duas nuvens com os dedos ao mesmo tempo e agite seu telefone ao mesmo tempo." },
		{"May the best man win!", "Que ganhe o melhor homem!" },
		//165
		{"Shout and Say 'MOM'", "Grite e diga 'MAMÃ'" },
		{"The level will be passed when you click the start button 4 times and fill the bar. You must allow microphone access, or enable Phone Settings > Apps > Trick Me > Permissions > Microphone option.", "O nível será passado quando você clicar no botão Iniciar 4 vezes e preencher a barra. Você deve permitir o acesso ao microfone ou ativar a opção Configurações do Telefone > Aplicativos > Truque comigo > Permissões > Microfone." },
		{"What did you mom say?", "O que disse a sua mamã?" },
		//166
		{"Find a frame for these colored objects.", "Encontre um quadro para esses objetos coloridos." },
		{"I said find 'a frame' for these colored objects. :)", "Eu disse para encontrar 'uma moldura' para esses objetos coloridos. :)" },
		{"You are amazing!", "Você é demais!" },
		//167
		{"Do something to end the war.", "Faça algo para terminar com a guerra." },
		{"If you shoot at the right place, the war is over.", "Se você atirar no lugar certo, a guerra acaba." },
		{"#worldpeace", "#pazmundial" },
		//168
		{"Find the ball?", "Encontre a bola?" },
		{"To make 'x10' 'x1', delete '0' using your finger.", "Para criar 'x10' 'x1', exclua '0' usando o dedo." },
		{"A++++++", "Muito Bom" },
		//169
		{"After the game has started, you must turn the child left using your finger.", "Após o jogo começar, você deve virar a criança para a esquerda usando o dedo." },
		{"Nobody could pass this level except you.", "Ninguém conseguiria passar este nível, exceto você." },
		//170
		{"Hit the man's head and knock the man out. Then, shoot the ball.", "Bata na cabeça do homem e acabe com ele. De seguida, atire a bola." },
		{"Incredible goal!", "Que golo incrivel!" },
		//171
		{"Grasp the first car with two fingers and remove it draggingly. Then, park your car in its place.", "Segure o primeiro carro com os dois dedos e remova-o com força. Em seguida, estacione seu carro no lugar." },
		{"Nice job!", "Bom trabalho!!" },
		//172
		{"One of the L's in Lvl is big and the other small.", "Um dos L's no Lvl é grande e o outro pequeno." },
		{"You can think differently...", "Você consegue pensar de forma diferente..." },
		//173 DON'T FORGET TO CHANGE PREFAB
		{"Enter password", "Digite a senha" },
		{"Try zooming your screen a few times.", "Tente ampliar a tela algumas vezes." },
		{"You're very good!", "Você é muito bom!" },
		//174
		{"Behind one of the windows.", "Atrás de uma das janelas." },
		{"Don't lie, you're a gamer, too.", "Não minta, você também é jogador." },
		//175
		{"Grab the small key on watch video button and drag it to the door.", "Pegue a pequena chave no botão assistir vídeo e arraste-a para a porta." },
		{"Amazing!", "Espetacular!" },
		//176
		{"Hi, we’re still working on new levels. Stay tuned for the next update.", "Olá, ainda estamos a trabalhar em novos níveis. Fique atento à próxima atualização." },
		{"", "" }
    };
    public static Dictionary<string, string> CN = new Dictionary<string, string>()
    {
		{"EN", "CN" },
		//GENERAL UI ELEMENTS
		{"7.99USD", "61.11CNY" },
		{"Don't show again.", "不用再显示。" },
		{"You have to turn the phone's rotating feature on.", "你必须打开手机的旋转功能。" },
		{"RESTORE", "恢 复" },
		{"Restore Purchases", "恢复购买" },
		{"COMING SOON...", "马上推出。。。" },
		{"COME AGAIN TOMORROW!", "请明天再来！" },
		{"3 days free", "3天免费使用" },
		{"AND...", "还有。。。" },
		{"BECOME VIP!", "成为VIP！" },
		{"CONGRATULATIONS!!!", "恭喜！！！" },
		{"Daily Bonus", "每日奖励" },
		{"Double daily bonus", "双日常奖金" },
		//ANDROID EXPLANATION
		//Weekly Premium automatically renews. Payment will be charged to your Google account at the end of the trial period of purchase. The subscription automatically renews unless auto-renews unless auto-renew is turned off at least 24 hours before the end of the current period. You can manage and turn off auto-renewal of the subscription by going to your account settings on the Google Play after purchase.
		//IOS EXPLANATION
		//Weekly Premium automatically renews. Payment will be charged to your iTunes account at the end of the trial period of purchase The subscription automatically renews unless auto-renews unless auto-renew is turned off at least 24 hours before the end of the current period. You can manage and turn off auto-renewal of the subscription by going to your account settings on the iTunes after purchase.
		{"Feedback", "反馈" },
		{"Free", "免费" },
		{"Game Reset", "重启游戏" },
		{"Hint discounts", "提示折扣" },
		{"INSTANTLY", "马上" },
		{"All Levels", "所有级别" },
		{"Music", "音乐" },
		{"Next", "下一步" },
		{"Nice start...", "很好的开始。。。" },
		{"Privacy Policy", "私隐政策" },
		{"PRIVACY POLICY", "私 隐 政 策" },
		{"Rate", "评分" },
		{"remove ads", "移除广告" },
		{"Remove ads", "移 除广告" },
		{"Remove Ads", "移除 广告" },
		{"Share", "分享" },
		{"Skip discounts", "跳过折扣" },
		{"Skip", "跳过" },
		{"Skipping costs 2 keys. Would you like to skip?", "跳过需要2把钥匙。你想跳过吗？" },
		{"Sounds", "声音" },
		{"Store", "恢复" },
		{"TERMS OF USE", "使 用 条 款" },
		{"Terms of Use", "使用条款" },
		{"TRY FOR FREE!", "免费使用！" },
		{"Vibration", "振动" },
		{"Watch", "观看" },
		{"Weekly", "每周" },
		//PREFABS
		{"Exit", "退出" },
		{"OK", "好了" },
		{"Fire", "火" },
		{"FINISH", "完成" },
		{"RUN", "跑" },
		{"CLEAR", "清除" },
		{"START", "开 始" },
		{"JUMP", "跳" },
		{"Write your answer", "写上你的答案" },
		//LEVELS
		//1
		{"Which one is red?", "哪一个是红色的？" },
		{"Or you didn't click on the red text?", "你是否没有按红色的字？" },
		{"Good start.", "这是好的开始。" },
		{"Green", "绿色" },
		{"Yellow", "黄色" },
		{"Blue", "蓝色" },
		{"Red", "红色" },
		//2
		{"Shoot the basketball into the hoop", "把篮球投进篮筐" },
		{"You need to press the shoot button when it reaches green in order to shoot.", "你需要按下投篮按钮，当它变成绿色时，你就可以投篮了。" },
		{"Nice shot.", "投得漂亮" },
		{"Shoot", "投篮" },
		//3
		{"Throw everything away", "扔掉一切" },
		{"You should drag-and-drop pizza, cheese, ice-cream and cactus to the trash.", "您应该将比萨饼，奶酪，冰淇淋和仙人掌拖放到垃圾箱中。" },
		{"Cleaning is important, of course...", "清洁当然很重要……" },
		//4
		{"Find the different one", "找到不同的那个" },
		{"Could it be under the ice-cream? Look at it.", "它会不会在冰淇淋的下面？把它找出来。" },
		{"I guess someone likes a different kind of ice-cream :)", "我看到有人喜欢一种不同口味的冰淇淋 :)" },
		//5
		{"Which one is the biggest drop?", "哪一个的雪糕球最大？" },
		{"Put the drops on top of each other and create the largest one.", "把这些雪糕球放在一起，形成最大的雪糕球。" },
		{"Many a mickle makes a muckle...", "积少成多。" },
		//6
		{"Did you try covering the lamp with your hand?", "你试过用手盖住灯吗?" },
		{"You managed to help the baby sleep again. Zzz...", "你又设法帮助婴儿入睡了。打鼾声……" },
		//7
		{"How many points do you give to this game?", "这场比赛中你得了多少分？" },
		{"I think you liked it very much.", "我想你肯定非常喜欢它。" },
		{"Since you loved it so much, let’s continue!", "既然你这么喜欢它，那我们就继续吧！" },
		{"Waste of time", "浪费时间" },
		{"I couldn't figured it out", "我想不出来" },
		{"It's OK", "没关系" },
		{"It's nice", "这很好" },
		{"I liked it very much!", "我非常喜欢它！" },
		//8
		{"Make the baby sleep", "哄宝宝睡觉" },
		{"Firstly, you should give the bottle and then try to put the baby to sleep in his/her car.", "首先，你应该把奶瓶给宝宝，然后试着让宝宝睡在他/她的车里。" },
		{"Rub-a-dub-dub... Zzz...", "……打鼾声……" },
		//9
		{"Balance the scale", "平衡天平" },
		{"If you take everything off, the scale would be even.", "如果你把所有的东西都拿下来，天平就会是平的。" },
		{"I know you are a balanced person.", "我知道你是一个平衡的人。" },
		//10
		{"One of the girls looking at the West, the other is to the East. But both of them can see each other, how can you do that?", "一个女孩在看西边，另一个在看东边。但是他们两个都能看到对方，你是怎么能做到呢？" },
		{"You should move the girls’ head as to be turned as face-to-face.", "你应该转动女孩们的头，这样才能让她们面对面地看到对方。" },
		{"I see you’re getting used to it.", "我看你已经学会了" },
		//11
		{"Open the door", "打开门" },
		{"You need to use the key in the child's pocket in order to open the door.", "你需要用孩子口袋里的钥匙 才能打开门。" },
		{"Yeah, that’s it ;)", "是的，就是这样;)" },
		//12
		{"Stop the fight..!!", "停止战斗. . ! !" },
		{"You can stop the fight when you split the bone in two and give it to the dogs.", "当你把骨头劈成两半给狗吃时， 你就可以停止争斗了。" },
		{"Fifty-fifty ;)", "一半一半 😊" },
		//13
		{"Help the tree shed its leaves", "帮助树摇落叶子" },
		{"Paint the tree yellow with the paint bucket.", "用油漆把树漆成黄色。" },
		{"You’re doing great!", "你做的很好!" },
		//14
		{"Catch the fish!", "抓鱼!" },
		{"The fish is hidden between the waves. Move the waves.", "鱼藏在波涛之中。移动海浪。" },
		{"That move seems familiar...", "这个动作看起来很熟悉……" },
		//15
		{"Fill the bucket with water", "把水桶装满水" },
		{"Try to turn the phone. You will see that the direction of water will change.", "试着把电话转过去。 你会发现水的方向会改变。" },
		{"Nature will take its course.", "顺其自然。" },
		//16
		{"Help the man lose weight", "帮人减肥" },
		{"Hold the man with your finger, drag him to the left and right 4 times and make him lose weight.", "用你的手指按住他，将他左右拖四次，让他减肥。" },
		{"He’s skin and bones.", "他瘦得皮包骨了。" },
		//17
		{"Feed the hay to the cow", "把干草喂给牛吃" },
		{"Didn't you see the shovel behind the hay? You can open a way with it.", "你没看见干草后面的铲子吗? 你可以用它开启一条路。" },
		{"Now it’s time to eat.", "现在该吃饭了。" },
		//18
		{"Find the 10 differences", "找出10个不同点" },
		{"What’s important is making a difference :)", "重要的是与众不同:)" },
		//19
		{"Clean the page!", "清除页面!" },
		{"You can clean it by hovering over it with your finger.", "你可以用手指悬停在它上面来清洁它。" },
		{"Did you try to use a rubber? Hahaha", "你试过用橡皮吗?" },
		//20
		{"Which one is soda?", "哪一个是苏打水?" },
		{"Shake the phone, sparkle it and find the soda!", "摇一摇手机，点亮它，找到苏打水!" },
		{"You will fizz like blup blup blup xD", "你会发出咕嘟、咕嘟的声音 xD" },
		//21
		{"Find the gamer", "找到玩家" },
		{"A true gamer never sleeps.", "真正的玩家从不睡觉。" },
		{"Gamers don’t sleep. You can find the gamer by clicking on the only window in the apartment where the light is on.", "玩家不睡觉。你可以通过点击公寓里唯一一扇开着灯的窗户来找到游戏者。" },
		//22
		{"How many hairs does the child have?", "这个孩子有几根头发?" },
		{"If you lift the child’s wig, you will see how many of the real hair is.", "如果你拿起孩子的假发，你就会看到有多少真正的头发。" },
		{"If you could count all the hair, please contact us. :)", "如果你能数出所有的头发，请联系我们。:)" },
		//23
		{"Please charge the phone", "请给电话充电" },
		{"Have you ever tried touching the cables at the same time with your two fingers?", "你曾经尝试过用你的两个手指同时触摸电线吗？" },
		{"I'm taking a shine from you.", "我看上你了。" },
		//24
		{"If the hunter shots 2 of the birds, how many birds left at the branch?", "如果猎人射中了两只鸟，树枝上还剩下多少只鸟?" },
		{"'0' There would not be any birds left, all of them scared and flew away.", "0' 不会有任何鸟留下，他们都害怕，飞走了。" },
		{"Well done the hunter, he shot 2 birds at the same time.", "猎人干得好，他同时射了两只鸟。" },
		//25
		{"Pop the balloons!", "把气球吹起来！" },
		{"Scare the hedgehog and pop the balloons with its spines!", "吓一吓刺猬，用它的刺戳破气球!" },
		{"Boooooommmmm!", "Boooooommmmm !" },
		//26
		{"Reach the animal to the exit by using arrows", "用箭将动物射到出口" },
		{"You should wander around before entering the maze.", "在进入迷宫之前，你应该四处逛逛。" },
		{"All great minds think alike.", "英雄所见略同。" },
		//27
		{"How many letters left in alphabet if you take the letters of “a” and “b” out?", "如果你把“a”和“b”的字母拿出来，alphabet 里还剩下几个字母?" },
		{"There will be 6 letters left if you take a and b out from alphabet word.", "如果你把a和b从字母表里拿出来，就会剩下6个字母。" },
		{"Do you think that your friends can solve this question?", "你认为你的朋友能解决这个问题吗?" },
		//28
		{"How many flies are there?", "有多少只苍蝇?" },
		{"Enlarge the poop in the back and count the flies over it.", "放大后面的大便，数一数上面的苍蝇。" },
		{"Flies resides in the details.", "苍蝇驻留在细节上。" },
		//29 DON'T FORGET TO CHANGE PREFAB
		{"Try to drag the “sleep” word over the baby...", "试着把“睡觉”这个词拖到宝宝身上……" },
		{"It would be perfect if it was that easy to put babies in sleep in real life.", "如果在现实生活中让婴儿入睡是那么容易，那就太完美了。" },
		//30
		{"Try to close the cow's nose. Look at it, will it wake up?", "试着堵住牛的鼻子。看着它，它会醒来吗?" },
		{"Almost drowning.", "几乎淹死。" },
		//31
		{"Save the ship from crashing into the iceberg", "使船免于撞到冰山" },
		{"Try melting the iceberg by rubbing it with your finger.", "试着用手指摩擦来融化冰山。" },
		{"The Titanic would have sunk.", "泰坦尼克号即将沉没。" },
		//32
		{"Cross the truck across the bridge", "把卡车开过桥" },
		{"Try to lift the bridge from the top with your finger.", "试着用你的手指把桥从顶上提起来。" },
		{"Honk honk!", "Honk honk!" },
		//33
		{"Which one is edible?", "哪一个是可食用的?" },
		{"What you think of as diamond and poop is actually cone and ice cream. Drag the cone under the ice cream.", "你以为是钻石和便便的其实是蛋卷和冰淇淋。把蛋筒拖到冰淇淋下面。" },
		{"I wish they were here.", "我希望他们在这里。" },
		//34
		{"What would the result be if we multiply all the numbers with each other?", "如果我们把所有的数相乘， 结果会是什么?" },
		{"What would the result be if you multiply a number with zero?", "如果你把一个数乘以0会得到什么结果?" },
		{"You cannot ignore the zero...", "你不能忽略0…" },
		//35
		{"Do the right move to win the game!", "做正确的动作来赢得比赛!" },
		{"Touch the sides of 'O' in the middle, at the same time with 2 fingers!", "用两根手指同时触摸“O”的 中间部分。" },
		{"Good strategy.", "好策略。" },
		//36
		{"How would you empty the bathtub fastly?", "你怎样才能快速清空浴缸里的水?" },
		{"Didn't you try to remove the stopper from the tub? You should try it right now.", "你没有试着把浴缸的塞子拔下来吗? 你现在就应该试试。" },
		{"Your friends will have difficulty in solving this question!", "你的朋友们估计很难解决这个问题!" },
		//37
		{"Turn the child over by using two fingers and shake. The key will fall out of the child’s pocket.", "用两个手指把孩子翻过来摇一摇。钥匙会从孩子的口袋里掉出来。" },
		{"Successful!", "成功!" },
		//38
		{"Find the real shadow of the bird", "找到真正的鸟的影子" },
		{"If you drag the sun over the bird, the bird will have a shadow.", "如果你把太阳在鸟上面拖过去，鸟就会有影子" },
		{"You are great.", "你真棒。" },
		//39
		{"Some months take 30, some take 31; how many months have 28 days?", "有的月是30天，有的月是31天。多少个月有28天?" },
		{"Each month has 28 days.", "每个月有28天。" },
		{"It’s that simple.", "就是这么简单。" },
		//40
		{"Do not explode the bomb!", "不要引爆炸弹!" },
		{"The bomb will not explode already, just wait for 30 seconds.", "炸弹还不会爆炸，就等30秒吧。" },
		{"How impatient you are.", "你真没耐心。" },
		//41 DON'T FORGET TO CHANGE PREFAB
		{"You should hang the word of “Man” in the question.", "你应该在问题中加上“人”这个词。" },
		{"Rest in peace.", "安息。" },
		//42
		{"Wake up the cow", "唤醒母牛" },
		{"If you take the moon off the screen, the sun rises and the cow wakes up.", "如果你把月亮从屏幕上拿开，太阳就会升起，奶牛就会醒来。" },
		{"How can you sleep that much?", "你怎么能睡那么久?" },
		//43
		{"Press the orange circle 10 times, then press the blue circle once", "按橙色圆圈10次， 然后按蓝色圆圈1次" },
		{"Are you sure that you pressed 10 times? Because the number starts from 1.", "你确定你按了10次了吗? 因为数字是从1开始的。" },
		{"Or did you press 9 times? We said 10...", "还是你按了9次? 我们说10次…" },
		//44
		{"Find the couples and win the game", "找到那些情侣，赢得比赛" },
		{"Shrink your screen, you will see your other mate.", "缩小你的屏幕，你会看到你的另一半。" },
		{"You did a good job.", "你做得很好。" },
		//45
		{"How this equation becomes correct?", "这个方程如何变得正确?" },
		{"Use the number of 45 in the Lv.45 to create 4550 number.", "使用45级中的数字45来创建数字4550。" },
		{"You are a true genius.", "你真是个天才" },
		//46
		{"Confirm evenness by moving the single matchstick!", "均匀移动单根火柴棒!" },
		{"Move the number of 4's matchstick and get 2 pieces of 1! 311+89=400", "移动数字4的火柴棍，得到2根1! 311 + 89 = 400" },
		{"Did you know that the match was invented after the lighter?", "你知道火柴是在打火机之后发明的吗?" },
		//47
		{"Make all of it green!", "让一切都变成绿色!" },
		{"First of all, shake the phone, then put the chameleon on the grass, and then paint the question with the paint bucket. Don't forget to remove the clouds from the screen.", "首先，摇动手机，然后把变色龙放在草地上，然后用油漆桶把问题画出来。别忘了把云彩从屏幕上移开。" },
		{"How the greens will smile if the clouds do not cry?", "如果云彩不哭，绿色的植物将如何微笑?" },
		//48
		{"If 5 squirrels eat 5 walnuts in 5 minutes, in how many minutes does 15 squirrels eat 15 walnuts?", "如果5只松鼠在5分钟内吃了5个核桃，那么15只松鼠在几分钟内吃了15个核桃呢?" },
		{"In 5 minutes.", "在5分钟。" },
		{"Aren’t those squirrels so sweet?", "那些松鼠不是很可爱吗?" },
		//49 DON'T FORGET TO CHANGE PREFAB
		{"Drag the word 'Protect' on to the rocket.", "把单词“保护”拖到火箭上。" },
		{"Power shields are now activated.", "能量护盾现在被激活。" },
		//50
		{"You should win the game again", "你应该再赢一次比赛" },
		{"Use 0 in the 50 words. Hold and drag it to the middle of O and press the other side.", "用 50 words 中的0。按住它并拖动到O的中间，然后按另一边。" },
		{"You know it.", "你懂的。" },
		//51
		{"Pizza, ice-cream, cheese, cactus, 'Throw everything away' text and you should throw away the cap of the trash.", "披萨，冰淇淋，奶酪，仙人掌，还有 “扔掉一切” 的短信，你应该把垃圾桶的盖扔掉。" },
		//52
		{"How many rings are there on the screen?", "屏幕上有多少只戒指?" },
		{"We hid 4 of them under the Clean button. '22'", "我们把其中4个藏在了清除按钮下面。“22”" },
		{"Nothing can escape from you.", "没有什么可以逃过你的眼睛。" },
		//53
		{"Collect 5 mice like in the picture", "像图片那样收集5只老鼠" },
		{"Just click to the mouse in the left direction and do not forget the mouse in the example.", "只需点击左方的老鼠，不要忘了例子中的老鼠。" },
		{"You are a good hunter!", "你是个好猎手!" },
		//54
		{"How can the kangaroo jump higher than the building?", "袋鼠怎么能跳得比大楼还高呢?" },
		{"Make the trampoline bigger!", "让蹦床变大!" },
		{"Bounce bounce bounce...!", "反弹,反弹,反弹…!" },
		//55
		{"Bring the magnifier to the child's arm on the lower left. You will see the replica.", "将放大镜放在孩子左下方的手臂上。你会看到复制品。" },
		{"You’ve got him.", "你抓到他了。" },
		//56
		{"Which one is the prettiest?", "哪一个最漂亮?" },
		{"Drag the boy in front of the girl, whichever one he smiles at is the prettiest.", "把那个男孩拉到那个女孩前面，他对谁笑谁就最漂亮。" },
		{"Love at first sight.", "一见钟情。" },
		//57
		{"You should rub the baby’s belly and let the gas out.", "你应该摩擦婴儿的腹部，让气体流出来。" },
		{"Ops the baby has gas.", "噢，婴儿放屁了。" },
		//58 DON'T FORGET TO CHANGE PREFAB
		{"You should clean it by using the word 'Clean' in the question.", "你应该用问题中的“清除”这个单词来清除。" },
		{"I accept it was bad.", "我承认这很糟糕。" },
		//59
		{"Get the number of 100 twice by using a single line from the number of 188", "使用一条线将数字188 变成两个数字100" },
		{"Divide the number of 188 horizontally. You will have 2 of 1, 4 of 0.", "将188这个数字水平切割。1有2个，0有4个。" },
		{"Wooww, you are super.", "哇，你太棒了。" },
		//60
		{"To drop an apple from the tree, you must shake the tree very much. Shake the phone.", "要从树上掉下一个苹果，你必须把树摇得很厉害。摇电话。" },
		{"Did this cow discover gravity?", "这头牛发现重力了吗?" },
		//61
		{"Turn the light off", "把灯关掉" },
		{"Turn off the screen towards the table. The light will go off.", "把屏幕朝桌子的方向关掉。灯会灭的。" },
		{"Where were we?", "我们在哪里?" },
		//62
		{"Bring the pen into the empty space", "把钢笔拿进空白的地方" },
		{"One of the objects below can be rotated. Find the rotating pen and put it back correctly.", "下面的一个物体可以旋转。找到旋转的笔，把它放回正确的位置。" },
		{"The pen is mightier than the sword.", "笔比剑更有力。" },
		//63
		{"Feed the dog with the food under the box and wait for it to poop. Take the key that comes with the poop to the door.", "用盒子下面的食物喂狗，等它拉屎。拿着便便里的钥匙去开门。" },
		{"Sweet little doggie.", "可爱的小狗。" },
		//64
		{"Solve the problem!", "解决这个问题!" },
		{"Be careful about seeds of blackberry, 2 of them are missing. '18'", "当心黑莓的种子，有两粒不见了。“18”" },
		{"You understand the math...", "你懂数学…" },
		//65
		{"Try to get rain from the cloud.", "试着从云中获取雨水。" },
		{"It's raining, floods are flowing...", "下雨了，洪水泛滥……" },
		//66
		{"Do you guess the three letters upcoming in the order?", "您猜该订单中即将出现的三个字母吗？" },
		{"Look carefully at the first letters of words in the question? Use the first letters of last two words", "你能按顺序猜出接下来的三个字母吗?" },
		{"Did you guess?", "仔细看问题中单词的第一个字母。使用最后两个单词的首字母" },
		//67
		{"Find objects!", "找东西!" },
		{"You have a sharp sight!", "你的眼光真敏锐!" },
		//68
		{"How many numbers are there?", "有多少个数字?" },
		{"You are super!", "你是超级棒!" },
		//69
		{"Please write down the right answer?", "请写下正确答案。" },
		{"You should think simple. Add up the 8 and 5.", "你应该简单地思考。把8和5相加。" },
		{"Sometimes you need to think simple ;)", "有时候你需要简单地思考 ;)" },
		//70
		{"I go to bed at 8 o'clock at night and I set my cuckoo clock at 9 in the morning. How many hours will I sleep?", "我晚上8点睡觉，我把布谷鸟钟调到早上9点。我睡几个小时?" },
		{"The cuckoo clock won’t differentiate night and day, hence you will sleep for one hour.", "布谷鸟钟不会区分白天和黑夜，所以你会睡一个小时。" },
		{"Is the alarm a little bit early?", "闹钟响的有点早了吗?" },
		//71
		{"With two fingers, swipe to the left on the screen and plug the phone into a socket. Then touch the cables at the same time.", "用两根手指向左滑动屏幕，将手机插入插座。然后同时触摸电缆。" },
		{"Be careful, don’t be shocked!", "小心点，别被吓着了!" },
		//72
		{"The wheel of the car is in one of the clouds. Put the cloud with your finger and shake it. Mount the wheel on the truck. Tilt the screen to the right. The truck will move across the street.", "汽车的轮子在某个云朵里。手指按住云彩开始摇晃。把轮子装上卡车。把屏幕向右倾斜。卡车将过马路。" },
		{"Do not ask why the rubber tire is over there.", "不要问为什么橡胶轮胎在那边。" },
		//73
		{"You should try to turn off the light with your finger.", "你应该试着用你的手指把灯关掉。" },
		{"There would not be a more creative way.", "没有比这更有创意的方法了。" },
		//74
		{"Choose 3 balls, verify the evenness!", "均匀选择3个球!" },
		{"Turn the 9 upside down and make it 6! 11+13+6: 30! That much easy!", "把9倒过来变成6! 11 + 13 + 6=30 ! 多简单!" },
		{"We put the ball upside down, sorry.", "我们把球放倒了，对不起。" },
		//75
		{"Which one is the heaviest?", "哪一个最重?" },
		{"Lift both hammers and drop them at the same time to find out which one is the heaviest.", "举起两个锤子，同时放下，看看哪一个最重。" },
		{"I congratulate your physics teacher.", "我祝贺你们的物理老师。" },
		//76 DON'T FORGET TO CHANGE PREFAB
		{"Drag the “fish” text over to the edge of the fishing hook.", "将“鱼”文字拖到鱼钩边缘。" },
		{"Delicious.", "美味。" },
		//77
		{"Shake the drink and help the child drink it", "把饮料摇一摇，帮孩子喝" },
		{"Hold the bottle shut with your finger, shake your phone, and give the bottle to the child.", "用你的手指握住瓶子，摇动你的手机，然后把瓶子给孩子。" },
		{"Shake before drinking!", "在饮用之前摇匀!" },
		//78
		{"Help the child to open the safe", "帮助孩子打开保险柜" },
		{"Turn the phone over and shake it. The key will fall out of the child’s pocket.", "把手机翻过来摇一摇。钥匙会从孩子的口袋里掉出来。" },
		{"What do you think inside of it?", "你觉得里面是什么?" },
		//79
		{"Find the numbers on the balls", "找出球上的数字" },
		{"148", "148" },
		{"Are you a math professor or something?", "你是数学教授还是什么?" },
		//80
		{"Drag the screen towards the left and you will see the bird’s real shadow. (Use two fingers at the same time)", "将屏幕向左拖动，你会看到鸟的真实影子。(两根手指同时使用)" },
		{"I’m impressed… You’re fast.", "我印象深刻，你真快。" },
		//81
		{"Clean the car", "清洁汽车" },
		{"You need to clean over the car with your finger.", "你需要用你的手指把车擦干净。" },
		{"Sparkling clean.", "干净明亮闪闪发光。" },
		//82
		{"Find the strongest balloon!", "找到最结实的气球!" },
		{"Drag the balloons over to the skip forward sign, 4 of them will pop! The strongest balloon won’t pop.", "将气球拖到跳跃前进标志处，其中4个将会弹出!最结实的气球不会破。" },
		{"You’re doing great.", "你做的很好。" },
		//83
		{"How many orange cubes do you need to cover the blue cube?", "你需要多少个橙色的方块来覆盖蓝色的方块?" },
		{"22", "22" },
		{"That was a good one.", "做的不错。" },
		//84
		{"Flip the text with two fingers. Put it between the tap and the bucket.", "用两根手指翻动文本。把它放在水龙头和水桶之间。" },
		{"Bet you didn’t think of that one, did you?", "你肯定没想过这个，是吧?" },
		//85
		{"The baby will sleep if you put your phone down on the table face down.", "如果你把手机面朝下放在桌子上，婴儿就会睡着。" },
		{"You’re the best at putting babies to sleep.", "你很擅长哄孩子睡觉" },
		//86  DON'T FORGET TO CHANGE PREFAB
		{"What’s the size of the table?", "桌子有多大?" },
		{"You’re on a roll.", "你好运来了。" },
		//87
		{"Try dispersing the soil by shaking your phone", "试着通过摇动你的手机来分散土壤。" },
		{"We’re covered in dirt.", "我们浑身是土。" },
		//88
		{"Please help me find my dog in this mess", "请帮我在这乱糟糟的地方找到我的狗" },
		{"You need to make the screen smaller. The dog is somewhere outside of the screen.", "你需要把屏幕变小。狗在屏幕外面的某个地方。" },
		{"Thank you!", "谢谢你！" },
		//89
		{"Lift Thor’s hammer", "举起雷神锤" },
		{"The hammer is so heavy you will need to lift it with three fingers.", "这锤子太重了，你得用三个手指才能把它举起来。" },
		{"You’re even stronger than I thought!", "你比我想象的还要强大!" },
		//90
		{"Find the pairs and win the game", "找到配对，赢得比赛" },
		{"Divide the last one remaining in half by drawing a line through the middle of it.", "把最后一个剩下的分成两半，通过在中间画一条线。" },
		{"We make a good pair.", "我们这一对做的不错。" },
		//91
		{"Touch the cow’s head 10 times.", "摸牛头十次。" },
		{"The cow is a heavy sleeper.", "这头牛睡得很沉。" },
		//92
		{"Hey..!! What day of the month is it?", "嘿. . ! !今天是几号?" },
		{"Seriously, what day of the month is it? What number is the calendar on your phone showing?", "说真的，今天是几号?你手机上的日历 显示的是几号?" },
		{"Sometimes I forget the date, too.", "有时我也会忘记日期。" },
		//93
		{"You need to shake the tree a lot. The key will fall from it.", "你得使劲摇这棵树，钥匙会从树上掉下来的。" },
		{"Whose idea was it to hide the key in a tree?", "把钥匙藏在树上是谁的主意?" },
		//94  DON'T FORGET TO CHANGE PREFAB
		{"You can use the word “Balance” in the text to balance the scale.", "你可以使用文字中“平衡”这个词 来平衡天平。" },
		{"Are you balanced?", "你是平衡的吗?" },
		//95
		{"If the bridge is falling apart, you need to support the middle of the bridge with your hand.", "如果桥要塌了，你需要用手支撑桥的中间。" },
		{"You’re the king of the road.", "你是道路之王。" },
		//96
		{"It’s snowing! Catch the snow...", "下雪了!抓雪……" },
		{"Place your phone on a flat surface with the screen facing up and wait.", "把你的手机放在一个平面上，屏幕朝上，然后等待。" },
		{"Become one with the snow.", "与雪融为一体。" },
		//97
		{"Help him escape prison", "帮助他越狱" },
		{"You can escape by pressing the escape button after you unscrew the lightbulb.", "你可以在拧开灯泡后按下“逃跑”按钮来逃跑。" },
		{"Smells like freedom!", "自由的味道!" },
		//98
		{"Park the car", "把车停好" },
		{"There might be space further down the road.", "这条路前方可能有位置。" },
		{"Slowly… Slowly… Now park the car!", "慢点……慢点……现在停车!" },
		//99
		{"You will catch the cheater if you move the front row.", "如果你移动前排，你就会抓住作弊者。" },
		{"Caught red-handed.", "当场抓住。" },
		//100
		{"Help the child see!", "帮助孩子看东西!" },
		{"Drag the two zeros in '100' to make glasses for the kid.", "拖动“100”中的两个0为孩子做副眼镜。" },
		{"That’ll show you!", "看到了吧!" },
		//101
		{"Which one would you save?", "你会救哪一个?" },
		{"You need to press all three at the same time. Don’t try doing it one by one.", "你需要同时按这三个键。不要一个接一个地按。" },
		{"You are so single.", "你这么孤单。" },
		{"Family", "家庭" },
		{"Love", "爱" },
		{"Money", "金钱" },
		//102
		{"The animals are racing. The cow, the rabbit, and the turtle. Help the turtle win", "动物们在赛跑。奶牛，兔子和乌龟。帮助乌龟赢" },
		{"Drag the start button and hit the Turbo button underneath.", "拖动开始按钮，点击下面的涡轮按钮。" },
		{"Fast and furious.", "速度与激情。" },
		{"Start", "开始" },
		//103
		{"The baby will sleep if you turn the volume down on your phone.", "如果你把手机音量调小，宝宝就会睡着。" },
		{"Hush...", "嘘……" },
		//104
		{"What should be the next number in the sequence?", "序列中的下一个数字是什么?" },
		{"Read the numbers you see out loud! The numbers are how the previous numbers sound when you read them together… '13112221'", "大声读出你看到的数字! 数字就是你把之前的数字一起读出来时听到的那个……‘13112221’" },
		{"We’ll admit it was a hard question.", "我们得承认这是一个很难的问题。" },
		//105
		{"Help the truck pass through the tunnel", "帮助卡车通过隧道" },
		{"Shrink the truck with two fingers.", "用两个手指把卡车缩小" },
		{"Well done!", "做得好!" },
		//106
		{"If Mary gathers 2 bananas in 1 minute, how many bananas can she gather from this tree in 10 minutes?", "如果玛丽在1分钟内采了2根香蕉，那么她在10分钟内能从这棵树上采到多少香蕉呢?" },
		{"Does it look like bananas grow on this tree? The answer is '0'", "香蕉看起来像长在这棵树上吗? 答案是“0”" },
		{"You’re quite smart.", "你很聪明。" },
		//107 DON'T FORGET TO CHANGE PREFAB
		{"The match will be lit if you drag it and rub it over the word 'Light'.", "如果你把火柴拖过“点”这个词，它就会被点燃。" },
		{"Don’t play with fire.", "不要玩火。" },
		//108
		{"List the numbers you see on the screen in order", "按顺序列出你在屏幕上看到的数字" },
		{"At first, it started with 3, 2, 1, didn’t you see? 3, 2, 1, 32, 67, 21, 5, 14, 8", "一开始是3 2 1，你们没看到吗? 32 1 32 67 21 5 14 8" },
		{"I’m in awe of your visual memory!", "我对你的视觉记忆力感到敬畏!" },
		//109
		{"Who is pregnant?", "怀孕的是谁?" },
		{"Turn your phone upside down and shake it. Drag the pregnancy test over to the woman on the right.", "把你的手机倒过来摇一摇。把验孕棒拖到右边的女人那里。" },
		{"Congratulations!", "恭喜你!" },
		//110
		{"How many squares are there?", "有多少个正方形?" },
		{"Would it be 40?", "会是40吗?" },
		{"It is 40!", "是40 !" },
		//111
		{"Make the man happy!", "让这个人快乐!" },
		{"Drag the man up over the clouds.", "把那个人拉上云端。" },
		{"Being happy is that simple!", "幸福就是这么简单!" },
		//112
		{"Sally is 21 years older than her son. 2 years ago, Sally was 4 times her son’s age. How old is Sally?", "萨莉比她儿子大21岁。两年前，萨利的年龄是她儿子的四倍。萨莉多大了?" },
		{"She is 31.", "她是31。" },
		{"What did you study in school?", "你在学校学了什么?" },
		//113
		{"Park the car in the right spot", "把车停在正确的地方" },
		{"Drag the skirt off of the female symbol in the middle to make it appropriate for the driver.", "将有女性标志的裙子从中间拖开，使其适合驾驶。" },
		{"Thought you’d never figure it out.", "我以为你永远不会明白。" },
		//114
		{"That counts as a three-pointer.", "这也算一个三分球。" },
		//115
		{"Did you try taking the light that won’t turn off out of the screen?", "你有没有试过把屏幕外关不了的灯关掉?" },
		{"I love your sharp wit!", "我喜欢你的机智!" },
		//116
		{"Save the gorilla :(", "拯救大猩猩:(" },
		{"You can use the hint key to unlock the lock.", "您可以使用提示键来解锁。" },
		{"#FreedomForAnimals", "# FreedomForAnimals" },
		//117
		{"What’s the fastest route from A to I?", "从A到I最快的路线是什么" },
		{"You need to swap B and I’s places.", "你需要交换B和I的位置。" },
		{"You’re so fast!", "你这么快!" },
		//118
		{"Burn everything", "点燃一切" },
		{"Drag the magnifying glass between the sun and the wood to spark a fire. Then use the wood on the fire to burn everything. You can pass the level by burning everything including the 'Burn everything' text and the sun.", "把放大镜拖到太阳和木头之间，点燃一堆火。然后用火上的木头把所有的东西都点燃。你可以通过燃烧一切来通过这一关，包括“燃烧一切”这几个字和太阳。" },
		{"Time to call the fire station!", "该给消防局打电话了!" },
		//119
		{"2 of them are drowned, 4 of them are swimming, and 3 of them are dead. How many fish left in the aquarium?", "其中2个淹死了，4个在游泳，3个死亡。水族馆里还剩多少鱼?" },
		{"Fish don’t drown in water. But even if they did, none of them would go out of aquarium hence, 10 fish will be left.", "鱼不会在水里淹死。但即使他们这样做了，也没有鱼会走出水族馆，因此，会留下10条鱼。" },
		{"You are a real genius.", "你真是个天才。" },
		//120
		{"You should try charging your own phone while the game is on.", "你应该在游戏开始的时候给自己的手机充电。" },
		{"We gave you an excuse to charge your phone :)", "我们给了你一个给手机充电的借口:)" },
		//121
		{"Put the fire out", "把火扑灭" },
		{"Squeeze the cloud with two fingers and make water spill to put out the fire.", "用两个手指捏住云，让水溢出来扑灭火。" },
		{"It’s raining cats and dogs!", "倾盆大雨啊!" },
		//122
		{"Find the pirate", "找到海盗" },
		{"Pirates have wooden legs. Try lifting their pant legs to see.", "海盗有木腿。试着提起他们的裤腿看看。" },
		{"Nice, the next question awaits.", "很好，下一个问题等着你。" },
		//123
		{"Complete the equation", "完成方程" },
		{"Take the 1, 2, and 3 from “Lv. 123” and put them in the places of A, B, and C. That will complete the equation.", "从“Lv123”中取出1、2、3。然后把它们放在A、B、c的位置上，这样就完成了方程。" },
		{"You really surprised me.", "你真让我吃惊。" },
		//124
		{"Defeat your competitor in Rock-Paper-Scissors game!", "在石头-剪刀-布游戏中击败对手!" },
		{"You have to move to the winning side by relocating the players!", "你必须通过重新安置玩家来转为胜利的一方!" },
		{"Or did you cheat?", "还是你作弊了?" },
		//125
		{"It’s 3:35. What time would it be if the clock moved counter-clockwise 90 degrees?", "现在是3：35。如果时钟逆时针转90度，现在是什么时间?" },
		{"Could it be 12:20?", "12:20分可以吗?" },
		{"Did you ask your friends what level they’re on?", "你有没有问过你的朋友他们的级别?" },
		//126 DON'T FORGET TO CHANGE PREFAB
		{"Did you try to click on Europe text?", "你试着点击欧洲文本了吗?" },
		{"Bravo!", "真棒!" },
		//127
		{"Make the bulbs explode by clicking on the lights 5 times", "点击灯5次让灯泡爆炸" },
		{"The lights are off alright...", "灯都灭了，好吧……" },
		//128
		{"He broke the vase 10 minutes ago. Help him fix it", "他十分钟前把花瓶打碎了。帮他修一下" },
		{"The vase wasn’t broken 10 minutes ago. Try rewinding the clock.", "花瓶不是十分钟前打碎的。试着把时钟倒回去。" },
		{"You just traveled through time.", "你只是穿越了时间。" },
		//129
		{"Which tank would be filled first?", "哪个水槽会先被加满?" },
		{"Draw a line to A's drain. Thus, 'A' will be filled first.", "在A的排水管上画一条线。因此，将首先填充“A”。" },
		{"Hmm, smart...", "嗯,聪明……" },
		//130
		{"Shrink the building.", "将大楼变小。" },
		{"Kangaroo-lations!", "Kangaroo-lations !" },
		//131 DON'T FORGET TO CHANGE PREFAB
		{"You should try turning the 9 in the question into a 6. Then you will have the right number of bananas.", "你应该试着把问题中的9变成6。然后你就会得到正确数量的香蕉。" },
		{"Something’s not right about this.", "这件事有点不对劲。" },
		//132
		{"What should fill the blank?", "应该用什么来填空?" },
		{"Did you ever drive? This was car gear. Reverse gear 'R'...", "你曾经开车吗? 这是汽车的挡。倒挡 “R”……" },
		{"Ok understood, you don’t have an 'R'.", "好吧，明白了，你没有“R”。" },
		//133
		{"How many 3's are there?", "有多少个3 ?" },
		{"There are five 3's including the ones in 'Lv.133' and the question.", "有5个3，包括第133级的题目和问题。" },
		{"Good catch!", "解答的不错！" },
		//134
		{"Shake the clouds and catch the fish with the worm under the tree.", "摇摇云朵，用树下的虫子去钓鱼。" },
		{"Hook, line, and sinker!", "咬钩，上线，沉底儿!" },
		//135
		{"Help the truck pass through the tunnel!", "帮助卡车通过隧道!" },
		{"Deflate the truck’s wheels! You can use the 'Forward' symbol.", "给卡车轮子放气!您可以使用“前进”符号。" },
		{"Wish we could give you a reward.", "希望我们能给你点奖励。" },
		//136
		{"Make a square by moving 2 balls", "你会看到一张图片。带有箭头的图片应该足够了。" },
		{"Wow!", "哇!" },
		//137
		{"Turn off the lights", "关灯" },
		{"You should try putting your phone upside down on the table, with the screen facing down. Then the light will go off.", "你应该试着把手机倒放在桌子上，屏幕朝下。然后灯就会熄灭。" },
		{"That’s what we’re talking about.", "这就是我们要讨论的。" },
		//138
		{"Turn the cow in the other direction before it reaches the soil.", "在牛到达土壤之前，把它转向另一个方向。" },
		{"Where there’s a will, there’s a way.", "有志者，事竟成。" },
		//139
		{"Speed up the clock and reveal the pregnant woman.", "加速时钟，显示出孕妇的身份。" },
		{"Time flies...", "时间过得真快. ." },
		//140
		{"Take the key on the upper right corner of the screen and drag it onto the door to pass the level.", "拿起屏幕右上角的钥匙，拖到门上通过关卡。" },
		{"We couldn’t trick you...", "我们骗不了你……" },
		//141
		{"Leave me alone for a bit...", "让我一个人呆一会儿……" },
		{"Leave the game, wait a couple of seconds, and re-enter the game.", "离开游戏，等待几秒钟， 然后重新进入游戏。" },
		{"Thank you for understanding.", "谢谢你的理解。" },
		//142
		{"Hold the basketball with your finger and slam dunk!", "用你的手指拿住篮球，扣篮!" },
		{"A great slam dunk.", "一个漂亮的灌篮。" },
		//143
		{"Catch person who is cheating!", "抓住作弊的人!" },
		{"Try lifting the child’s hat who is at the right.", "试着把右边孩子的帽子举起来。" },
		{"You are not missing a thing.", "你没有错过任何东西。" },
		//144
		{"Help an old lady cross the road", "帮助一位老太太过马路" },
		{"One of the trucks has a green light in its truck bed. You need to put it in the right spot.", "其中一辆卡车的车厢里有一盏绿灯。你需要把它放在正确的位置。" },
		{"Thank you for your help!", "谢谢你的帮助!" },
		//145
		{"What is the result of the calculation?", "计算的结果是什么?" },
		{"The result of the calculation is '-62'.", "计算结果是'-62'。" },
		{"The social science people are now crying.", "社会科学的人们在哭泣。" },
		//146
		{"Gather the stones upstream and stop the water. Drag the net over the fish.", "把石头收集到上游，拦住水。拉网捞鱼。" },
		{"The fish jumps once jumps twice...", "鱼跳一次，跳两次……" },
		//147
		{"Shrink down the fire!", "把火关掉!" },
		{"Shake the phone, let the fire disperse and choose the smaller one!", "摇动手机，让火散开， 选择较小的那一个!" },
		{"Did you try to snuff it out?", "你想把它掐灭吗?" },
		//148
		{"Find the password!", "找到密码!" },
		{"'042' Think again... You can also ask a friend.", "‘042’再想想……你也可以问朋友。" },
		{"If you found this as well, you should be proud of yourself!", "如果你也发现了这个，你应该为自己感到骄傲!" },
		{"A number and it's place are correct", "一个数字和它的位置都是正确的" },
		{"A number is correct but it's place is wrong", "一个数字是正确的，但它的位置是错误的" },
		{"Two numbers are correct but the places are wrong", "两个数字是正确的，但位置是错误的" },
		{"Nothing is correct", "没什么是正确的" },
		{"ENTER", "输入" },
		//149
		{"Weigh the chicken", "给鸡称重" },
		{"Shake the chicken to make its eggs fall out and make it lighter.", "把鸡摇一摇，鸡蛋就会掉出来，这样鸡就会轻一些。" },
		{"I’m light as a feather.", "我轻如鸿毛。" },
		//150
		{"Is it too quiet here?", "这里太安静了吗?" },
		{"A little music wouldn't be bad.", "听点音乐也不错。" },
		{"Music is the essence of the soul ;)", "音乐是灵魂的本质。" },
		//151
		{"Take the ball outside!", "把球拿出去!" },
		{"Pour water from the dispenser size bottle to the glass and pour it into the pipe. Let the ball go up.", "从饮水机大小的瓶子里倒水到玻璃杯里，然后倒入水管里。让球飞起来。" },
		{"You discovered the buoyant force of the water.", "你发现了水的浮力。" },
		//152
		{"Score a goal.", "进一球。" },
		{"Try to press two arrows at the same time.", "试着同时按两个箭头。" },
		{"Gooaal!..!!", "Gooaal ! . . ! !" },
		//153
		{"Make the baby laugh.", "让宝宝笑。" },
		{"Take off the baby's socks and tickle the baby's feet with a feather.", "脱下宝宝的袜子，用羽毛挠宝宝的脚。" },
		{"The world is better when babies laugh.", "婴儿笑，世界更美好。" },
		//154
		{"Bring the child to the exit", "把孩子带到出口" },
		{"Turn your phone over and watch the child.", "把手机翻过来，看着孩子。" },
		{"Did you send the game to your friends? Now, send it from the share button below.", "你把游戏发给朋友了吗? 现在通过下面的共享按钮发送吧。" },
		//155
		{"The child is so lonely", "这孩子太孤独了" },
		{"Hold on the child with your finger for 5 seconds and then, copy the child.", "用手指按住孩子5秒钟，然后复制孩子。" },
		{"Now, they are twins.", "现在，他们是双胞胎。" },
		{"Copy", "复制" },
		{"Rate the game", "评价游戏" },
		//156
		{"Please click in the following order", "请按以下顺序点击" },
		{"Are you sure you did the right thing? Watch out for the last finger.", "你确定你做的是对的吗? 小心最后一根手指。" },
		{"That's it!", "就是这样!" },
		//157
		{"Silence the child", "让孩子安静" },
		{"The toy is hidden under the button. Give it to the child.", "玩具藏在按钮下面。把它给孩子。" },
		{"It's really awesome.", "真是太棒了。" },
		{"Watch video", "观看视频" },
		//158 DON'T FORGET TO CHANGE PREFAB
		{"Unlock the case.", "打开公文包。" },
		{"Take the word ‘password’ to the correct place.", "把“密码”这个词放到正确的位置。" },
		{"Is it difficult?", "困难吗?" },
		//159
		{"Grab the gift box on the daily bonus button and give it to the man. The man will be happy to receive a gift.", "拿起“每日奖金”按钮上的礼品盒，把它送给这个人。他会很高兴收到礼物。" },
		{"Who recently bought you a gift?", "最近谁给你买了礼物?" },
		//160
		{"What does the child see?", "孩子看到了什么?" },
		{"Try to look at from the perspective of the child.", "试着从孩子的角度看问题。" },
		{"It's all about perspective!", "这都是关于视角的!" },
		//161 DON'T FORGET TO CHANGE PREFAB
		{"One of the X's can be moved. Remove X and replace it with the dot in the question.", "其中一个X可以移动。 移开X并用问题中的点替换它。" },
		{"You are true genius!", "你真是个天才!" },
		//162
		{"Make the girl fall in love with the boy", "让女孩爱上男孩" },
		{"Shake the child quite a while. Maybe he is hiding a surprise gift.", "把孩子摇一摇。也许他藏着一份惊喜礼物。" },
		{"You're the last single person in the world.", "你是世界上最后一个单身的人。" },
		//163 DON'T FORGET TO CHANGE PREFAB
		{"Try to use the word 'Truck'.", "试着用“卡车”这个词。" },
		{"Poor truck.", "可怜的卡车。" },
		//164
		{"Find the water for kids to make a water fight.", "为孩子们找水来打水仗。" },
		{"Hold both clouds with your fingers at the same time shake your phone.", "用你的手指按住两朵云的同时，摇动你的手机。" },
		{"May the best man win!", "愿最优秀的人获胜!" },
		//165
		{"Shout and Say 'MOM'", "喊“妈妈”" },
		{"The level will be passed when you click the start button 4 times and fill the bar. You must allow microphone access, or enable Phone Settings > Apps > Trick Me > Permissions > Microphone option.", "当你点击4次开始按钮并将能量条充满时，即可通关。你必须允许访问麦克风，或启用手机设置>应用程序>Trick me>权限>麦克风选项。" },
		{"What did you mom say?", "你妈妈说什么?" },
		//166
		{"Find a frame for these colored objects.", "为这些彩色的物体找一个框架。" },
		{"I said find 'a frame' for these colored objects. :)", "我说为这些彩色的物体找“一个框架”。:)" },
		{"You are amazing!", "你是了不起的!" },
		//167
		{"Do something to end the war.", "做点什么来结束战争。" },
		{"If you shoot at the right place, the war is over.", "如果你射对了地方，战争就结束了。" },
		{"#worldpeace", "#世界和平" },
		//168
		{"Find the ball?", "找到球了吗?" },
		{"To make 'x10' 'x1', delete '0' using your finger.", "若要生成“x10”“x1”，请用手指删除“0”。" },
		{"A++++++", "A+ + + + + +" },
		//169
		{"After the game has started, you must turn the child left using your finger.", "游戏开始后，你必须用你的手指把孩子转到左边。" },
		{"Nobody could pass this level except you.", "除了你，没有人能通过这一关。" },
		//170
		{"Hit the man's head and knock the man out. Then, shoot the ball.", "打那个男人的头，把他打晕。然后，投篮。" },
		{"Incredible goal!", "难以置信的进球!" },
		//171
		{"Grasp the first car with two fingers and remove it draggingly. Then, park your car in its place.", "用两个手指按住第一辆车，拖着挪开。然后，把你的车停在上面。" },
		{"Nice job!", "完成的不错!" },
		//172
		{"One of the L's in Lvl is big and the other small.", "Lvl里有个L是大的，其他都是小的。" },
		{"You can think differently...", "你可以用不同的方式思考……" },
		//173 DON'T FORGET TO CHANGE PREFAB
		{"Enter password", "输入密码" },
		{"Try zooming your screen a few times.", "试着放大几次你的屏幕。" },
		{"You're very good!", "你很棒" },
		//174
		{"Behind one of the windows.", "在一扇窗户后面。" },
		{"Don't lie, you're a gamer, too.", "别撒谎，你也是个玩家。" },
		//175
		{"Grab the small key on watch video button and drag it to the door.", "拿取“观看视频”按钮上的小钥匙，把它拖到门口。" },
		{"Amazing!", "很奇妙吧!" },
		//176
		{"Hi, we’re still working on new levels. Stay tuned for the next update.", "嗨，我们还在开发新的关卡。请继续关注下一个更新。" },
		{"", "" }
    };
    public static Dictionary<string, string> FR = new Dictionary<string, string>()
    {
		{"EN", "FR" },
		//GENERAL UI ELEMENTS
		{"7.99USD", "7.99EUR" },
		{"Don't show again.", "Ne plus afficher." },
		{"You have to turn the phone's rotating feature on.", "Vous devez activer la fonction de rotation du téléphone." },
		{"RESTORE", "RESTAURER" },
		{"Restore Purchases", "Restaurer Achats" },
		{"COMING SOON...", "BIENTÔT..." },
		{"COME AGAIN TOMORROW!", "REVENEZ DEMAIN !" },
		{"3 days free", "3 jours gratuits" },
		{"AND...", "ET..." },
		{"BECOME VIP!", "DEVENEZ MEMBRE VIP !" },
		{"CONGRATULATIONS!!!", "FÉLICITATIONS !!!" },
		{"Daily Bonus", "Bonus Quotidien" },
		{"Double daily bonus", "Double bonus quotidien" },
		//ANDROID EXPLANATION
		//Weekly Premium automatically renews. Payment will be charged to your Google account at the end of the trial period of purchase. The subscription automatically renews unless auto-renews unless auto-renew is turned off at least 24 hours before the end of the current period. You can manage and turn off auto-renewal of the subscription by going to your account settings on the Google Play after purchase.
		//IOS EXPLANATION
		//Weekly Premium automatically renews. Payment will be charged to your iTunes account at the end of the trial period of purchase The subscription automatically renews unless auto-renews unless auto-renew is turned off at least 24 hours before the end of the current period. You can manage and turn off auto-renewal of the subscription by going to your account settings on the iTunes after purchase.
		{"Feedback", "Commentaires" },
		{"Free", "Gratuit" },
		{"Game Reset", "Réinitialisation du Jeu" },
		{"Hint discounts", "Remises sur les indices" },
		{"INSTANTLY", "IMMÉDIATEMENT" },
		{"All Levels", "Tous les niveaux" },
		{"Music", "Music" },
		{"Next", "Suivant" },
		{"Nice start...", "Bon début ..." },
		{"Privacy Policy", "Politique de Confidentialité" },
		{"PRIVACY POLICY", "POLITIQUE DE CONFIDENTIALITÉ" },
		{"Rate", "Tarif" },
		{"remove ads", "Supprimer les publicités" },
		{"Remove ads", "Supprimer les Publicités" },
		{"Remove Ads", "Supprimer les Pubs" },
		{"Share", "Partager" },
		{"Skip discounts", "Ignorer les remises" },
		{"Skip", "Ignorer" },
		{"Skipping costs 2 keys. Would you like to skip?", "Ignorer coûte 2 clés. Voulez-vous ignorer... ?" },
		{"Sounds", "Sonneries" },
		{"Store", "Boutique" },
		{"TERMS OF USE", "CONDITIONS D’UTILISATION" },
		{"Terms of Use", "Conditions d’utilisation" },
		{"TRY FOR FREE!", "ESSAYER GRATUITEMENT !" },
		{"Vibration", "Vibration" },
		{"Watch", "Chronomètre" },
		{"Weekly", "Par semaine" },
		//PREFABS
		{"Exit", "Quitter" },
		{"OK", "OK" },
		{"Fire", "Incendie" },
		{"FINISH", "TERMINER" },
		{"RUN", "EXÉCUTER" },
		{"CLEAR", "EFFACER" },
		{"START", "COMMENCER" },
		{"JUMP", "SAUT" },
		{"Write your answer", "Donnez votre réponse" },
		//LEVELS
		//1
		{"Which one is red?", "Lequel est rouge ?" },
		{"Or you didn't click on the red text?", "Ou vous n'avez pas cliqué sur le texte rouge ?" },
		{"Good start.", "Bon début." },
		{"Green", "Vert" },
		{"Yellow", "Jaune" },
		{"Blue", "Bleu" },
		{"Red", "Rouge" },
		//2
		{"Shoot the basketball into the hoop", "Tirez le ballon de basket dans le cerceau" },
		{"You need to press the shoot button when it reaches green in order to shoot.", "Vous devez appuyer sur le bouton de prise de vue lorsqu'il atteint le vert pour pouvoir tirer." },
		{"Nice shot.", "Joli tir." },
		{"Shoot", "Tir" },
		//3
		{"Throw everything away", "Jetez tout" },
		{"You should drag-and-drop pizza, cheese, ice-cream and cactus to the trash.", "Vous devriez glisser-déposer pizza, fromage, crème glacée et cactus à la poubelle." },
		{"Cleaning is important, of course...", "Le nettoyage est important, bien sûr ..." },
		//4
		{"Find the different one", "Trouvez le différent" },
		{"Could it be under the ice-cream? Look at it.", "Serait-ce sous la glace ? Regarde-le." },
		{"I guess someone likes a different kind of ice-cream :)", "Je suppose que quelqu'un aime un autre type de glace :)" },
		//5
		{"Which one is the biggest drop?", "Lequel est le meilleur ?" },
		{"Put the drops on top of each other and create the largest one.", "Mettez les gouttes les unes sur les autres et créez la plus grande." },
		{"Many a mickle makes a muckle...", "Les petits ruisseaux font les grandes rivières..." },
		//6
		{"Did you try covering the lamp with your hand?", "Avez-vous essayé de couvrir la lampe avec votre main ?" },
		{"You managed to help the baby sleep again. Zzz...", "Vous avez réussi à aider à nouveau le bébé à dormir. Zzz..." },
		//7
		{"How many points do you give to this game?", "Combien de points donnez-vous à ce jeu?" },
		{"I think you liked it very much.", "Je pense que ça vous a beaucoup plu." },
		{"Since you loved it so much, let’s continue!", "Puisque vous l'avez tant aimé, continuons!" },
		{"Waste of time", "Perte de temps" },
		{"I couldn't figured it out", "Je ne pouvais pas le comprendre" },
		{"It's OK", "C'est OK" },
		{"It's nice", "C'est bien" },
		{"I liked it very much!", "J'ai beaucoup aimé !" },
		//8
		{"Make the baby sleep", "Faire dormir le bébé" },
		{"Firstly, you should give the bottle and then try to put the baby to sleep in his/her car.", "Tout d'abord, vous devez donner le biberon, puis essayer de mettre le bébé en sommeil dans sa voiture." },
		{"Rub-a-dub-dub... Zzz...", "Rub-a-dub-dub... Zzz..." },
		//9
		{"Balance the scale", "Équilibrez l'échelle" },
		{"If you take everything off, the scale would be even.", "Si vous retirez tout, l'échelle serait uniforme." },
		{"I know you are a balanced person.", "Je sais que tu es une personne équilibrée." },
		//10
		{"One of the girls looking at the West, the other is to the East. But both of them can see each other, how can you do that?", "L'une des filles regarde vers l'ouest, l'autre vers l'est. Mais les deux peuvent se voir, comment pouvez-vous faire cela?" },
		{"You should move the girls’ head as to be turned as face-to-face.", "Vous devez déplacer la tête des filles pour qu'elles se tournent face à face." },
		{"I see you’re getting used to it.", "Je vois que tu t'y habitues." },
		//11
		{"Open the door", "Ouvrez la porte" },
		{"You need to use the key in the child's pocket in order to open the door.", "Vous devez utiliser la clé dans la poche de l'enfant pour ouvrir la porte." },
		{"Yeah, that’s it ;)", "Oui, c'est ça;)" },
		//12
		{"Stop the fight..!!", "Arrêtez le combat .. !!" },
		{"You can stop the fight when you split the bone in two and give it to the dogs.", "Vous pouvez arrêter le combat lorsque vous divisez l'os en deux et le donnez aux chiens." },
		{"Fifty-fifty ;)", "Fifty-Fifty" },
		//13
		{"Help the tree shed its leaves", "Aidez l'arbre à perdre ses feuilles" },
		{"Paint the tree yellow with the paint bucket.", "Peignez l'arbre jaune avec le pot de peinture." },
		{"You’re doing great!", "Vous vous en sortez bien!" },
		//14
		{"Catch the fish!", "Attrapez le poisson!" },
		{"The fish is hidden between the waves. Move the waves.", "Le poisson est caché entre les vagues. Déplacez les vagues." },
		{"That move seems familiar...", "Cette décision semble familière ..." },
		//15
		{"Fill the bucket with water", "Remplissez le seau d'eau" },
		{"Try to turn the phone. You will see that the direction of water will change.", "Essayez de tourner le téléphone. Vous verrez que la direction de l'eau va changer." },
		{"Nature will take its course.", "La nature suivra son cours." },
		//16
		{"Help the man lose weight", "Aidez l'homme à perdre du poids" },
		{"Hold the man with your finger, drag him to the left and right 4 times and make him lose weight.", "Tenez l'homme avec votre doigt, faites-le glisser vers la gauche et la droite 4 fois et faites-lui perdre du poids." },
		{"He’s skin and bones.", "C'est chair plus l'os." },
		//17
		{"Feed the hay to the cow", "Nourrissez le foin à la vache" },
		{"Didn't you see the shovel behind the hay? You can open a way with it.", "Vous n'avez pas vu la pelle derrière le foin? Vous pouvez ouvrir une voie avec elle." },
		{"Now it’s time to eat.", "C'est l'heure de manger." },
		//18
		{"Find the 10 differences", "Trouver les 10 différences" },
		{"What’s important is making a difference :)", "Ce qui est important, c'est de faire la différence :)" },
		//19
		{"Clean the page!", "Nettoyez la page !" },
		{"You can clean it by hovering over it with your finger.", "Vous pouvez le nettoyer en le survolant avec votre doigt." },
		{"Did you try to use a rubber? Hahaha", "Avez-vous essayé d'utiliser un caoutchouc?" },
		//20
		{"Which one is soda?", "Lequel est du soda?" },
		{"Shake the phone, sparkle it and find the soda!", "Secouez le téléphone, faites-le briller et trouvez le soda!" },
		{"You will fizz like blup blup blup xD", "Vous allez fizz comme blup blup blup xD" },
		//21
		{"Find the gamer", "Trouvez le joueur" },
		{"A true gamer never sleeps.", "Un vrai joueur ne dort jamais." },
		{"Gamers don’t sleep. You can find the gamer by clicking on the only window in the apartment where the light is on.", "Les joueurs ne dorment pas. Vous pouvez retrouver le joueur en cliquant sur la seule fenêtre de l'appartement où la lumière est allumée." },
		//22
		{"How many hairs does the child have?", "Combien de cheveux l'enfant a-t-il?" },
		{"If you lift the child’s wig, you will see how many of the real hair is.", "Si vous soulevez la perruque de l'enfant, vous verrez combien de vrais cheveux y sont." },
		{"If you could count all the hair, please contact us. :)", "Si vous pouviez compter tous les cheveux, veuillez nous contacter. :)" },
		//23
		{"Please charge the phone", "Veuillez recharger le téléphone" },
		{"Have you ever tried touching the cables at the same time with your two fingers?", "Avez-vous déjà essayé de toucher les câbles en même temps avec vos deux doigts ?" },
		{"I'm taking a shine from you.", "Je me réjouis de vous." },
		//24
		{"If the hunter shots 2 of the birds, how many birds left at the branch?", "Si le chasseur abat 2 oiseaux, combien reste-t-il d'oiseaux à la branche?" },
		{"'0' There would not be any birds left, all of them scared and flew away.", "'0' Il n'y aurait plus d'oiseaux, tous effrayés et s'envolèrent." },
		{"Well done the hunter, he shot 2 birds at the same time.", "Bravo le chasseur, il a abattu 2 oiseaux en même temps." },
		//25
		{"Pop the balloons!", "Faites éclater les ballons !" },
		{"Scare the hedgehog and pop the balloons with its spines!", "Effrayez le hérisson et éclatez les ballons avec ses épines!" },
		{"Boooooommmmm!", "Boooooommmmm!" },
		//26
		{"Reach the animal to the exit by using arrows", "Atteignez l'animal jusqu'à la sortie en utilisant des flèches" },
		{"You should wander around before entering the maze.", "Vous devriez vous promener avant d'entrer dans le labyrinthe." },
		{"All great minds think alike.", "Les grands esprits se rencontrent." },
		//27
		{"How many letters left in alphabet if you take the letters of “a” and “b” out?", "Combien de lettres reste-t-il dans l'alphabet si vous retirez les lettres «a» et «b»?" },
		{"There will be 6 letters left if you take a and b out from alphabet word.", "Il restera 7 lettres si vous retirez a et b du mot de l'alphabet." },
		{"Do you think that your friends can solve this question?", "Pensez-vous que vos amis peuvent résoudre cette question?" },
		//28
		{"How many flies are there?", "Combien de mouches y a-t-il?" },
		{"Enlarge the poop in the back and count the flies over it.", "Agrandir le caca dans le dos et compter les mouches dessus." },
		{"Flies resides in the details.", "Les mouches résident dans les détails." },
		//29 DON'T FORGET TO CHANGE PREFAB
		{"Try to drag the “sleep” word over the baby...", "Essayez de faire glisser le mot «coucher» sur le bébé ..." },
		{"It would be perfect if it was that easy to put babies in sleep in real life.", "Ce serait parfait si c'était aussi facile de mettre des bébés en sommeil dans la vraie vie." },
		//30
		{"Try to close the cow's nose. Look at it, will it wake up?", "Essayez de fermer le nez de la vache. Regardez-le, se réveillera-t-il?" },
		{"Almost drowning.", "Noyade presque." },
		//31
		{"Save the ship from crashing into the iceberg", "Empêchez le navire de s'écraser sur l'iceberg" },
		{"Try melting the iceberg by rubbing it with your finger.", "Essayez de faire fondre l'iceberg en le frottant avec votre doigt." },
		{"The Titanic would have sunk.", "Le Titanic aurait coulé." },
		//32
		{"Cross the truck across the bridge", "Traversez le camion sur le pont" },
		{"Try to lift the bridge from the top with your finger.", "Essayez de soulever le pont du haut avec votre doigt." },
		{"Honk honk!", "Honk honk!" },
		//33
		{"Which one is edible?", "Lequel est comestible?" },
		{"What you think of as diamond and poop is actually cone and ice cream. Drag the cone under the ice cream.", "Ce que vous pensez du diamant et du caca est en fait du cornet et de la crème glacée. Faites glisser le cône sous la glace." },
		{"I wish they were here.", "J'aimerais qu'ils soient ici." },
		//34
		{"What would the result be if we multiply all the numbers with each other?", "Quel serait le résultat si nous multiplions tous les nombres entre eux?" },
		{"What would the result be if you multiply a number with zero?", "Quel serait le résultat si vous multipliez un nombre par zéro?" },
		{"You cannot ignore the zero...", "Vous ne pouvez pas ignorer le zéro ..." },
		//35
		{"Do the right move to win the game!", "Faites le bon choix pour gagner le jeu !" },
		{"Touch the sides of 'O' in the middle, at the same time with 2 fingers!", "Touchez les côtés de «O» au milieu, en même temps avec 2 doigts !" },
		{"Good strategy.", "Bonne stratégie." },
		//36
		{"How would you empty the bathtub fastly?", "Comment videriez-vous la baignoire rapidement ?" },
		{"Didn't you try to remove the stopper from the tub? You should try it right now.", "N'avez-vous pas essayé de retirer le bouchon de la baignoire ? Vous devriez l'essayer dès maintenant." },
		{"Your friends will have difficulty in solving this question!", "Vos amis auront du mal à résoudre cette question!" },
		//37
		{"Turn the child over by using two fingers and shake. The key will fall out of the child’s pocket.", "Retournez l'enfant en utilisant deux doigts et secouez. La clé tombera de la poche de l'enfant." },
		{"Successful!", "Réussie !" },
		//38
		{"Find the real shadow of the bird", "Trouvez la vraie ombre de l'oiseau" },
		{"If you drag the sun over the bird, the bird will have a shadow.", "Si vous faites glisser le soleil sur l'oiseau, l'oiseau aura une ombre" },
		{"You are great.", "Vous êtes formidable." },
		//39
		{"Some months take 30, some take 31; how many months have 28 days?", "Certains mois en prennent 30, certains en prennent 31 ; combien de mois ont 28 jours ?" },
		{"Each month has 28 days.", "Chaque mois a 28 jours." },
		{"It’s that simple.", "C'est aussi simple que cela." },
		//40
		{"Do not explode the bomb!", "N'explose pas la bombe!" },
		{"The bomb will not explode already, just wait for 30 seconds.", "La bombe n'explosera pas déjà, attendez seulement 30 secondes." },
		{"How impatient you are.", "Comme tu es impatiente." },
		//41 DON'T FORGET TO CHANGE PREFAB
		{"You should hang the word of “Man” in the question.", "Vous devriez accrocher le mot «homme» dans la question." },
		{"Rest in peace.", "Repose en paix." },
		//42
		{"Wake up the cow", "Réveiller la vache" },
		{"If you take the moon off the screen, the sun rises and the cow wakes up.", "Si vous enlevez la lune de l'écran, le soleil se lève et la vache se réveille." },
		{"How can you sleep that much?", "Comment pouvez-vous dormir autant ?" },
		//43
		{"Press the orange circle 10 times, then press the blue circle once", "Appuyez 10 fois sur le cercle orange, puis appuyez une fois sur le cercle bleu" },
		{"Are you sure that you pressed 10 times? Because the number starts from 1.", "Êtes-vous sûr d'avoir appuyé 10 fois? Parce que le nombre commence à 1." },
		{"Or did you press 9 times? We said 10...", "Ou avez-vous appuyé 9 fois ? Nous avons dit 10 ..." },
		//44
		{"Find the couples and win the game", "Trouvez les couples et gagnez la partie" },
		{"Shrink your screen, you will see your other mate.", "Rétrécissez votre écran, vous verrez votre autre compagnon." },
		{"You did a good job.", "Vous avez fait du bon boulot." },
		//45
		{"How this equation becomes correct?", "Comment cette équation devient correcte?" },
		{"Use the number of 45 in the Lv.45 to create 4550 number.", "Utilisez le nombre de 45 dans le Lv.45 pour créer le numéro 4550." },
		{"You are a true genius.", "Tu es un vrai génie" },
		//46
		{"Confirm evenness by moving the single matchstick!", "Confirmez l'uniformité en déplaçant la seule allumette!" },
		{"Move the number of 4's matchstick and get 2 pieces of 1! 311+89=400", "Déplacez le nombre d'allumettes de 4 et obtenez 2 pièces de 1! 311 +89 = 400" },
		{"Did you know that the match was invented after the lighter?", "Saviez-vous que l'allumette a été inventé après le briquet?" },
		//47
		{"Make all of it green!", "Rendez tout cela vert!" },
		{"First of all, shake the phone, then put the chameleon on the grass, and then paint the question with the paint bucket. Don't forget to remove the clouds from the screen.", "Tout d'abord, secouez le téléphone, puis posez le caméléon sur l'herbe, puis peignez la question avec le pot de peinture. N'oubliez pas de supprimer les nuages de l'écran." },
		{"How the greens will smile if the clouds do not cry?", "Comment les verts vont sourire si les nuages ne pleurent pas ?" },
		//48
		{"If 5 squirrels eat 5 walnuts in 5 minutes, in how many minutes does 15 squirrels eat 15 walnuts?", "Si 5 écureuils mangent 5 noix en 5 minutes, en combien de minutes 15 écureuils mangent-ils 15 noix?" },
		{"In 5 minutes.", "Dans 5 minutes." },
		{"Aren’t those squirrels so sweet?", "Ces écureuils ne sont-ils pas si doux?" },
		//49 DON'T FORGET TO CHANGE PREFAB
		{"Drag the word 'Protect' on to the rocket.", "Faites glisser le mot «Protect» sur la fusée." },
		{"Power shields are now activated.", "Les boucliers de puissance sont désormais activés." },
		//50
		{"You should win the game again", "Vous devriez gagner à nouveau le jeu" },
		{"Use 0 in the 50 words. Hold and drag it to the middle of O and press the other side.", "Utilisez 0 dans les 50 mots. Maintenez-le et faites-le glisser au milieu de O et appuyez de l'autre côté." },
		{"You know it.", "Vous le sentez." },
		//51
		{"Pizza, ice-cream, cheese, cactus, 'Throw everything away' text and you should throw away the cap of the trash.", "Pizza, glaces, fromage, cactus, texte «Jetez tout» et vous devriez jeter le capuchon de la poubelle." },
		//52
		{"How many rings are there on the screen?", "Combien d'anneaux y a-t-il sur l'écran?" },
		{"We hid 4 of them under the Clean button. '22'", "Nous en avons caché 4 sous le bouton Nettoyer. 22" },
		{"Nothing can escape from you.", "Rien ne peut vous échapper." },
		//53
		{"Collect 5 mice like in the picture", "Collectez 5 souris comme sur la photo" },
		{"Just click to the mouse in the left direction and do not forget the mouse in the example.", "Cliquez simplement sur la souris dans la direction gauche et n'oubliez pas la souris dans l'exemple." },
		{"You are a good hunter!", "Tu es un bon chasseur!" },
		//54
		{"How can the kangaroo jump higher than the building?", "Comment le kangourou peut-il sauter plus haut que le bâtiment?" },
		{"Make the trampoline bigger!", "Agrandissez le trampoline!" },
		{"Bounce bounce bounce...!", "Bounce bounce bounce...!" },
		//55
		{"Bring the magnifier to the child's arm on the lower left. You will see the replica.", "Apportez la loupe au bras de l'enfant en bas à gauche. Vous verrez la réplique." },
		{"You’ve got him.", "Tu l'as eu." },
		//56
		{"Which one is the prettiest?", "Laquelle est la plus jolie?" },
		{"Drag the boy in front of the girl, whichever one he smiles at is the prettiest.", "Faites glisser le garçon devant la fille, celui qu'il sourit est le plus joli." },
		{"Love at first sight.", "Coup de coeur." },
		//57
		{"You should rub the baby’s belly and let the gas out.", "Vous devez frotter le ventre du bébé et laisser échapper le gaz." },
		{"Ops the baby has gas.", "Ops le bébé a du gaz." },
		//58 DON'T FORGET TO CHANGE PREFAB
		{"You should clean it by using the word 'Clean' in the question.", "Vous devez le nettoyer en utilisant le mot «Nettoyer» dans la question." },
		{"I accept it was bad.", "J'accepte que c'était mauvais." },
		//59
		{"Get the number of 100 twice by using a single line from the number of 188", "Obtenez le nombre 100 deux fois en utilisant une seule ligne du nombre de 188" },
		{"Divide the number of 188 horizontally. You will have 2 of 1, 4 of 0.", "Divisez le nombre de 188 horizontalement. Vous aurez 2 sur 1, 4 sur 0." },
		{"Wooww, you are super.", "Wooww, tu es super." },
		//60
		{"To drop an apple from the tree, you must shake the tree very much. Shake the phone.", "Pour faire tomber une pomme de l'arbre, vous devez bien secouer l'arbre. Secouez le téléphone." },
		{"Did this cow discover gravity?", "Cette vache a-t-elle découvert la gravité?" },
		//61
		{"Turn the light off", "Éteignez la lumière" },
		{"Turn off the screen towards the table. The light will go off.", "Éteignez l'écran vers la table. Ensuite, la lumière s'éteindra." },
		{"Where were we?", "Où en étions-nous ?" },
		//62
		{"Bring the pen into the empty space", "Apportez le stylo dans l'espace vide" },
		{"One of the objects below can be rotated. Find the rotating pen and put it back correctly.", "L'un des objets ci-dessous peut être tourné. Trouvez le stylo rotatif et replacez-le correctement." },
		{"The pen is mightier than the sword.", "La plume est plus forte que l'épée." },
		//63
		{"Feed the dog with the food under the box and wait for it to poop. Take the key that comes with the poop to the door.", "Nourrissez le chien avec la nourriture sous la boîte et attendez qu'il fasse caca. Apportez la clé fournie avec le caca à la porte." },
		{"Sweet little doggie.", "Doux petit chien." },
		//64
		{"Solve the problem!", "Résoudre le Problème!" },
		{"Be careful about seeds of blackberry, 2 of them are missing. '18'", "Attention aux graines de mûre, il en manque 2. '18'" },
		{"You understand the math...", "Vous comprenez les mathématiques ..." },
		//65
		{"Try to get rain from the cloud.", "Essayez d'obtenir la pluie du nuage." },
		{"It's raining, floods are flowing...", "Il pleut, les inondations coulent ..." },
		//66
		{"Do you guess the three letters upcoming in the order?", "Pensez-vous que les trois lettres sont dans l'ordre?" },
		{"Look carefully at the first letters of words in the question? Use the first letters of last two words", "Regardez attentivement les premières lettres des mots de la question ? Utilisez les premières lettres des deux derniers mots" },
		{"Did you guess?", "L'avez-vous deviné?" },
		//67
		{"Find objects!", "Trouvez des objets !" },
		{"You have a sharp sight!", "Vous avez une vue nette !" },
		//68
		{"How many numbers are there?", "Combien y a-t-il de numéros ?" },
		{"You are super!", "Tu es super!" },
		//69
		{"Please write down the right answer?", "Veuillez écrire la bonne réponse ?" },
		{"You should think simple. Add up the 8 and 5.", "Vous devriez penser simplement. Additionnez les 8 et 5." },
		{"Sometimes you need to think simple ;)", "Parfois, vous devez penser simplement;)" },
		//70
		{"I go to bed at 8 o'clock at night and I set my cuckoo clock at 9 in the morning. How many hours will I sleep?", "Je me couche à 8 heures du soir et je règle mon alarme cuckoo à 9 heures du matin. Combien d'heures vais-je dormir?" },
		{"The cuckoo clock won’t differentiate night and day, hence you will sleep for one hour.", "L'horloge à coucou ne différenciera pas la nuit et le jour, vous dormirez donc pendant une heure." },
		{"Is the alarm a little bit early?", "L'alarme est-elle un peu tôt ?" },
		//71
		{"With two fingers, swipe to the left on the screen and plug the phone into a socket. Then touch the cables at the same time.", "Avec deux doigts, balayez vers la gauche sur l'écran et branchez le téléphone dans une prise. Touchez ensuite les câbles en même temps." },
		{"Be careful, don’t be shocked!", "Soyez prudent, ne soyez pas choqué !" },
		//72
		{"The wheel of the car is in one of the clouds. Put the cloud with your finger and shake it. Mount the wheel on the truck. Tilt the screen to the right. The truck will move across the street.", "La roue de la voiture est dans l'un des nuages. Mettez le nuage avec votre doigt et secouez-le. Montez la roue sur le camion. Inclinez l'écran vers la droite. Le camion traversera la rue." },
		{"Do not ask why the rubber tire is over there.", "Ne demandez pas pourquoi le pneu en caoutchouc est là-bas." },
		//73
		{"You should try to turn off the light with your finger.", "Vous devriez essayer d'éteindre la lumière avec votre doigt." },
		{"There would not be a more creative way.", "Il n'y aurait pas de moyen plus créatif." },
		//74
		{"Choose 3 balls, verify the evenness!", "Choisissez 3 balles, vérifiez la régularité!" },
		{"Turn the 9 upside down and make it 6! 11+13+6: 30! That much easy!", "Retournez le 9 et faites-en 6! 11 +13 +6: 30! C'est très simple!" },
		{"We put the ball upside down, sorry.", "Nous avons mis la balle à l'envers, désolé." },
		//75
		{"Which one is the heaviest?", "Lequel est le plus lourd?" },
		{"Lift both hammers and drop them at the same time to find out which one is the heaviest.", "Soulevez les deux marteaux et laissez-les tomber en même temps pour savoir lequel est le plus lourd." },
		{"I congratulate your physics teacher.", "Je félicite votre professeur de physique." },
		//76 DON'T FORGET TO CHANGE PREFAB
		{"Drag the “fish” text over to the edge of the fishing hook.", "Faites glisser le texte «poisson» sur le bord de l'hameçon." },
		{"Delicious.", "Délicieux." },
		//77
		{"Shake the drink and help the child drink it", "Secouez la boisson et aidez l'enfant à la boire" },
		{"Hold the bottle shut with your finger, shake your phone, and give the bottle to the child.", "Tenez le biberon fermé avec votre doigt, secouez votre téléphone et donnez le biberon à l'enfant." },
		{"Shake before drinking!", "Secouez avant de boire !" },
		//78
		{"Help the child to open the safe", "Aidez l'enfant à ouvrir le coffre-fort" },
		{"Turn the phone over and shake it. The key will fall out of the child’s pocket.", "Retournez le téléphone et secouez-le. La clé tombera de la poche de l'enfant." },
		{"What do you think inside of it?", "Qu'en pensez-vous?" },
		//79
		{"Find the numbers on the balls", "Trouvez les chiffres sur les boules" },
		{"148", "148" },
		{"Are you a math professor or something?", "Êtes-vous professeur de mathématiques ou autre chose?" },
		//80
		{"Drag the screen towards the left and you will see the bird’s real shadow. (Use two fingers at the same time)", "Faites glisser l'écran vers la gauche et vous verrez la véritable ombre de l'oiseau. (Utilisez deux doigts en même temps)" },
		{"I’m impressed… You’re fast.", "Je suis impressionnée… Tu es rapide." },
		//81
		{"Clean the car", "Nettoyer la voiture" },
		{"You need to clean over the car with your finger.", "Vous devez nettoyer la voiture avec votre doigt." },
		{"Sparkling clean.", "Étincelant de propreté." },
		//82
		{"Find the strongest balloon!", "Trouvez le ballon le plus solide!" },
		{"Drag the balloons over to the skip forward sign, 4 of them will pop! The strongest balloon won’t pop.", "Faites glisser les ballons vers le signe de saut vers l'avant, 4 d'entre eux éclateront! Le ballon le plus fort ne sautera pas." },
		{"You’re doing great.", "Vous vous en sortez bien." },
		//83
		{"How many orange cubes do you need to cover the blue cube?", "De combien de cubes orange avez-vous besoin pour recouvrir le cube bleu ?" },
		{"22", "22" },
		{"That was a good one.", "C'est toute une expérience." },
		//84
		{"Flip the text with two fingers. Put it between the tap and the bucket.", "Retournez le texte avec deux doigts. Mettez-le entre le robinet et le seau." },
		{"Bet you didn’t think of that one, did you?", "Je parie que vous n'y avez pas pensé, n'est-ce pas?" },
		//85
		{"The baby will sleep if you put your phone down on the table face down.", "Le bébé dormira si vous posez votre téléphone sur la table, face vers le bas." },
		{"You’re the best at putting babies to sleep.", "Vous êtes le meilleur pour endormir les bébés." },
		//86  DON'T FORGET TO CHANGE PREFAB
		{"What’s the size of the table?", "Quelle est la taille de la table?" },
		{"You’re on a roll.", "Vous êtes sur une lancée." },
		//87
		{"Try dispersing the soil by shaking your phone", "Essayez de disperser le sol en secouant votre téléphone." },
		{"We’re covered in dirt.", "Nous sommes couverts de terre." },
		//88
		{"Please help me find my dog in this mess", "S'il vous plaît, aidez-moi à trouver mon chien dans ce gâchis" },
		{"You need to make the screen smaller. The dog is somewhere outside of the screen.", "Vous devez rendre l'écran plus petit. Le chien est quelque part en dehors de l'écran." },
		{"Thank you!", "Merci !" },
		//89
		{"Lift Thor’s hammer", "Soulevez le marteau de Thor" },
		{"The hammer is so heavy you will need to lift it with three fingers.", "Le marteau est si lourd que vous devrez le soulever avec trois doigts." },
		{"You’re even stronger than I thought!", "Tu es encore plus fort que je ne le pensais!" },
		//90
		{"Find the pairs and win the game", "Trouvez les paires et gagnez la partie" },
		{"Divide the last one remaining in half by drawing a line through the middle of it.", "Divisez le dernier restant en deux en traçant une ligne au milieu." },
		{"We make a good pair.", "Nous faisons une bonne paire." },
		//91
		{"Touch the cow’s head 10 times.", "Touchez la tête de la vache 10 fois." },
		{"The cow is a heavy sleeper.", "La vache est une grosse dormeuse." },
		//92
		{"Hey..!! What day of the month is it?", "Hey..!! Quel jour du mois est-ce ?" },
		{"Seriously, what day of the month is it? What number is the calendar on your phone showing?", "Sérieusement, quel jour du mois est-ce ? Quel numéro affiche le calendrier sur votre téléphone ?" },
		{"Sometimes I forget the date, too.", "Parfois, j'oublie aussi la date." },
		//93
		{"You need to shake the tree a lot. The key will fall from it.", "Vous devez beaucoup secouer l'arbre. La clé en tombera." },
		{"Whose idea was it to hide the key in a tree?", "À qui était l'idée de cacher la clé dans un arbre?" },
		//94  DON'T FORGET TO CHANGE PREFAB
		{"You can use the word “Balance” in the text to balance the scale.", "Vous pouvez utiliser le mot «Équilibrez» dans le texte pour équilibrer l'échelle." },
		{"Are you balanced?", "Êtes-vous équilibré?" },
		//95
		{"If the bridge is falling apart, you need to support the middle of the bridge with your hand.", "Si le pont s'effondre, vous devez soutenir le milieu du pont avec votre main." },
		{"You’re the king of the road.", "Tu es le roi de la route." },
		//96
		{"It’s snowing! Catch the snow...", "Il Neige! Attrapez la neige..." },
		{"Place your phone on a flat surface with the screen facing up and wait.", "Placez votre téléphone sur une surface plane avec l'écran vers le haut et attendez." },
		{"Become one with the snow.", "Devenez un avec la neige." },
		//97
		{"Help him escape prison", "Aidez-le à s'échapper de prison" },
		{"You can escape by pressing the escape button after you unscrew the lightbulb.", "Vous pouvez vous échapper en appuyant sur le bouton d'échappement après avoir dévissé l'ampoule." },
		{"Smells like freedom!", "Ça sent la liberté!" },
		//98
		{"Park the car", "Garer la voiture" },
		{"There might be space further down the road.", "Il pourrait y avoir de l'espace plus loin sur la route." },
		{"Slowly… Slowly… Now park the car!", "Lentement... Lentement... Maintenant, garez la voiture!" },
		//99
		{"You will catch the cheater if you move the front row.", "Vous attraperez le tricheur si vous déplacez la première rangée." },
		{"Caught red-handed.", "Pris la main dans le sac." },
		//100
		{"Help the child see!", "Aidez l'enfant à voir!" },
		{"Drag the two zeros in '100' to make glasses for the kid.", "Faites glisser les deux zéros dans '100' pour fabriquer des lunettes pour l'enfant." },
		{"That’ll show you!", "Ça va vous montrer !" },
		//101
		{"Which one would you save?", "Lequel voudriez-vous enregistrer ?" },
		{"You need to press all three at the same time. Don’t try doing it one by one.", "Vous devez appuyer sur les trois en même temps. N'essayez pas de le faire un par un." },
		{"You are so single.", "Tu es tellement célibataire." },
		{"Family", "Famille" },
		{"Love", "Amour" },
		{"Money", "Argent" },
		//102
		{"The animals are racing. The cow, the rabbit, and the turtle. Help the turtle win", "Les animaux courent. La vache, le lapin et la tortue. Aidez la tortue à gagner" },
		{"Drag the start button and hit the Turbo button underneath.", "Faites glisser le bouton de démarrage et appuyez sur le bouton Turbo en dessous." },
		{"Fast and furious.", "Fast and furious." },
		{"Start", "Début" },
		//103
		{"The baby will sleep if you turn the volume down on your phone.", "Le bébé dormira si vous baissez le volume de votre téléphone." },
		{"Hush...", "Chut..." },
		//104
		{"What should be the next number in the sequence?", "Quel devrait être le prochain numéro de la séquence?" },
		{"Read the numbers you see out loud! The numbers are how the previous numbers sound when you read them together… '13112221'", "Lisez les chiffres que vous voyez à haute voix! Les chiffres sont la façon dont les numéros précédents sonnent lorsque vous les lisez ensemble… '13112221'" },
		{"We’ll admit it was a hard question.", "Nous admettrons que c'était une question difficile." },
		//105
		{"Help the truck pass through the tunnel", "Aidez le camion à traverser le tunnel" },
		{"Shrink the truck with two fingers.", "Rétrécissez le camion avec deux doigts" },
		{"Well done!", "Bon travail !" },
		//106
		{"If Mary gathers 2 bananas in 1 minute, how many bananas can she gather from this tree in 10 minutes?", "Si Marie cueille 2 bananes en 1 minute, combien de bananes peut-elle récolter de cet arbre en 10 minutes?" },
		{"Does it look like bananas grow on this tree? The answer is '0'", "Est-ce que ça ressemble à des bananes qui poussent sur cet arbre? La réponse est '0'" },
		{"You’re quite smart.", "Tu es plutôt intelligent." },
		//107 DON'T FORGET TO CHANGE PREFAB
		{"The match will be lit if you drag it and rub it over the word 'Light'.", "L'allimette sera allumée si vous le faites glisser et le frottez sur le mot 'allumé'." },
		{"Don’t play with fire.", "Ne jouer pas avec le feu." },
		//108
		{"List the numbers you see on the screen in order", "Énumérez les nombres que vous voyez à l'écran dans l'ordre" },
		{"At first, it started with 3, 2, 1, didn’t you see? 3, 2, 1, 32, 67, 21, 5, 14, 8", "Au début, ça a commencé par 3, 2, 1, tu ne vois pas ? 3, 2, 1, 32, 67, 21, 5, 14, 8" },
		{"I’m in awe of your visual memory!", "Je suis en admiration devant votre mémoire visuelle!" },
		//109
		{"Who is pregnant?", "Qui est enceinte?" },
		{"Turn your phone upside down and shake it. Drag the pregnancy test over to the woman on the right.", "Retournez votre téléphone et secouez-le. Faites glisser le test de grossesse vers la femme de droite." },
		{"Congratulations!", "Félicitations !" },
		//110
		{"How many squares are there?", "Combien de carrés y a-t-il?" },
		{"Would it be 40?", "Seriont-ils 40 ?" },
		{"It is 40!", "C'est 40!" },
		//111
		{"Make the man happy!", "Rendez l'homme heureux!" },
		{"Drag the man up over the clouds.", "Faites glisser l'homme au-dessus des nuages." },
		{"Being happy is that simple!", "Être heureux est aussi simple que cela!" },
		//112
		{"Sally is 21 years older than her son. 2 years ago, Sally was 4 times her son’s age. How old is Sally?", "Sally a 21 ans de plus que son fils. Il y a 2 ans, Sally avait 4 fois l'âge de son fils. Quel âge a Sally?" },
		{"She is 31.", "Elle a 31 ans." },
		{"What did you study in school?", "Qu’est-ce que tu as fait comme études ?" },
		//113
		{"Park the car in the right spot", "Garez la voiture au bon endroit" },
		{"Drag the skirt off of the female symbol in the middle to make it appropriate for the driver.", "Faites glisser la jupe hors du symbole féminin au milieu pour l'adapter au conducteur." },
		{"Thought you’d never figure it out.", "Je pensais que tu ne le comprendrais jamais." },
		//114
		{"That counts as a three-pointer.", "Cela compte comme un pointeur à trois." },
		//115
		{"Did you try taking the light that won’t turn off out of the screen?", "Avez-vous essayé de prendre la lumière qui ne s'éteindra pas hors de l'écran?" },
		{"I love your sharp wit!", "J'adore ton esprit vif!" },
		//116
		{"Save the gorilla :(", "Sauvez le gorille :(" },
		{"You can use the hint key to unlock the lock.", "Vous pouvez utiliser la touche indice pour déverrouiller le verrou." },
		{"#FreedomForAnimals", "#FreedomForAnimals" },
		//117
		{"What’s the fastest route from A to I?", "Quel est l'itinéraire le plus rapide de A à I" },
		{"You need to swap B and I’s places.", "Vous devez échanger les places de B et I." },
		{"You’re so fast!", "Tu es si rapide!" },
		//118
		{"Burn everything", "Brûlez tout" },
		{"Drag the magnifying glass between the sun and the wood to spark a fire. Then use the wood on the fire to burn everything. You can pass the level by burning everything including the 'Burn everything' text and the sun.", "Faites glisser la loupe entre le soleil et le bois pour allumer un feu. Utilisez ensuite le bois sur le feu pour tout brûler. Vous pouvez passer le niveau en brûlant tout, y compris le texte «Tout brûler» et le soleil." },
		{"Time to call the fire station!", "Il est temps d'appeler les pompiers!" },
		//119
		{"2 of them are drowned, 4 of them are swimming, and 3 of them are dead. How many fish left in the aquarium?", "2 d'entre eux sont noyés, 4 nagent et 3 sont morts. Combien de poissons restent dans l'aquarium?" },
		{"Fish don’t drown in water. But even if they did, none of them would go out of aquarium hence, 10 fish will be left.", "Les poissons ne se noient pas dans l'eau. Mais même s'ils le faisaient, aucun d'entre eux ne sortirait de l'aquarium, il restera donc 10 poissons." },
		{"You are a real genius.", "Tu es un vrai génie." },
		//120
		{"You should try charging your own phone while the game is on.", "Vous devriez essayer de charger votre propre téléphone pendant que le jeu est en cours." },
		{"We gave you an excuse to charge your phone :)", "Nous vous avons donné une excuse pour recharger votre téléphone :)" },
		//121
		{"Put the fire out", "Éteindre le feu" },
		{"Squeeze the cloud with two fingers and make water spill to put out the fire.", "Pressez le nuage avec deux doigts et faites couler de l'eau pour éteindre le feu." },
		{"It’s raining cats and dogs!", "Il pleut des cordes!" },
		//122
		{"Find the pirate", "Trouvez le pirate" },
		{"Pirates have wooden legs. Try lifting their pant legs to see.", "Les pirates ont des pattes en bois. Essayez de soulever les jambes de leur pantalon pour voir." },
		{"Nice, the next question awaits.", "Bien, la prochaine question attend." },
		//123
		{"Complete the equation", "Complétez l'équation" },
		{"Take the 1, 2, and 3 from “Lv. 123” and put them in the places of A, B, and C. That will complete the equation.", "Prenez les 1, 2 et 3 de «Lv. 123 ”et les mettre aux endroits A, B et C. Cela complétera l'équation." },
		{"You really surprised me.", "Tu m'as vraiment surpris." },
		//124
		{"Defeat your competitor in Rock-Paper-Scissors game!", "Battez votre concurrent dans le jeu Rock-Paper-Scissors!" },
		{"You have to move to the winning side by relocating the players!", "Vous devez passer du côté gagnant en déplaçant les joueurs!" },
		{"Or did you cheat?", "Ou as-tu triché?" },
		//125
		{"It’s 3:35. What time would it be if the clock moved counter-clockwise 90 degrees?", "Il est 15h35. Quelle heure serait-il si l'horloge se déplaçait de 90 degrés dans le sens antihoraire?" },
		{"Could it be 12:20?", "Serait-ce 12:20?" },
		{"Did you ask your friends what level they’re on?", "Avez-vous demandé à vos amis à quel niveau ils se trouvent?" },
		//126 DON'T FORGET TO CHANGE PREFAB
		{"Did you try to click on Europe text?", "Avez-vous essayé de cliquer sur le texte Europe ?" },
		{"Bravo!", "Bravo !" },
		//127
		{"Make the bulbs explode by clicking on the lights 5 times", "Faites exploser les ampoules en cliquant 5 fois sur les lumières" },
		{"The lights are off alright...", "Les lumières sont bien éteintes ..." },
		//128
		{"He broke the vase 10 minutes ago. Help him fix it", "Il a cassé le vase il y a 10 minutes. Aidez-le à le réparer" },
		{"The vase wasn’t broken 10 minutes ago. Try rewinding the clock.", "Le vase n'a pas été cassé il y a 10 minutes. Essayez de rembobiner l'horloge." },
		{"You just traveled through time.", "Vous venez de voyager dans le temps." },
		//129
		{"Which tank would be filled first?", "Quel réservoir serait rempli en premier?" },
		{"Draw a line to A's drain. Thus, 'A' will be filled first.", "Tracez une ligne au drain de A. Ainsi, «A» sera rempli en premier." },
		{"Hmm, smart...", "Hmm, intelligent ..." },
		//130
		{"Shrink the building.", "Rétrécissez le bâtiment." },
		{"Kangaroo-lations!", "Des kangourous!" },
		//131 DON'T FORGET TO CHANGE PREFAB
		{"You should try turning the 9 in the question into a 6. Then you will have the right number of bananas.", "Vous devriez essayer de transformer le 9 de la question en 6. Ensuite, vous aurez le bon nombre de bananes." },
		{"Something’s not right about this.", "Quelque chose ne va pas." },
		//132
		{"What should fill the blank?", "Que devrait remplir le blanc?" },
		{"Did you ever drive? This was car gear. Reverse gear 'R'...", "Avez-vous déjà conduit ? C'était du matériel automobile. Marche arrière 'R' ..." },
		{"Ok understood, you don’t have an 'R'.", "D'accord, vous n'avez pas de «R»." },
		//133
		{"How many 3's are there?", "Combien y a-t-il de 3?" },
		{"There are five 3's including the ones in 'Lv.133' and the question.", "Il y a cinq 3, y compris ceux du 'Lv.133 'et la question." },
		{"Good catch!", "Belle prise !" },
		//134
		{"Shake the clouds and catch the fish with the worm under the tree.", "Secouez les nuages et attrapez le poisson avec le ver sous l'arbre." },
		{"Hook, line, and sinker!", "Crochet, ligne et plomb!" },
		//135
		{"Help the truck pass through the tunnel!", "Aidez le camion à traverser le tunnel!" },
		{"Deflate the truck’s wheels! You can use the 'Forward' symbol.", "Dégonflez les roues du camion! Vous pouvez utiliser le symbole «Avancer»." },
		{"Wish we could give you a reward.", "Je souhaite que nous puissions vous donner une récompense." },
		//136
		{"Make a square by moving 2 balls", "Vous verrez une photo. L'image avec la flèche devrait suffire." },
		{"Wow!", "Waouh !" },
		//137
		{"Turn off the lights", "Éteindre les lumières" },
		{"You should try putting your phone upside down on the table, with the screen facing down. Then the light will go off.", "Vous devriez essayer de mettre votre téléphone à l'envers sur la table, l'écran vers le bas. Ensuite, la lumière s'éteindra." },
		{"That’s what we’re talking about.", "C'est ce dont nous parlons." },
		//138
		{"Turn the cow in the other direction before it reaches the soil.", "Tournez la vache dans l'autre sens avant qu'elle n'atteigne le sol." },
		{"Where there’s a will, there’s a way.", "Où il y a une volonté, il y a une solution." },
		//139
		{"Speed up the clock and reveal the pregnant woman.", "Accélérez le temps et révélez la femme enceinte." },
		{"Time flies...", "Le temps passe..." },
		//140
		{"Take the key on the upper right corner of the screen and drag it onto the door to pass the level.", "Prenez la clé dans le coin supérieur droit de l'écran et faites-la glisser sur la porte pour passer le niveau." },
		{"We couldn’t trick you...", "Nous ne pouvions pas vous tromper ..." },
		//141
		{"Leave me alone for a bit...", "Laisse-moi seul un peu ..." },
		{"Leave the game, wait a couple of seconds, and re-enter the game.", "Quittez le jeu, attendez quelques secondes et entrez à nouveau dans le jeu." },
		{"Thank you for understanding.", "Merci de votre compréhension." },
		//142
		{"Hold the basketball with your finger and slam dunk!", "Tenez le ballon de basket avec votre doigt et slam dunk!" },
		{"A great slam dunk.", "Un super slam dunk." },
		//143
		{"Catch person who is cheating!", "Attrapez une personne qui triche!" },
		{"Try lifting the child’s hat who is at the right.", "Essayez de soulever le chapeau de l'enfant qui est à droite." },
		{"You are not missing a thing.", "Vous ne manquez rien." },
		//144
		{"Help an old lady cross the road", "Aidez une vieille dame à traverser la route" },
		{"One of the trucks has a green light in its truck bed. You need to put it in the right spot.", "L'un des camions a un feu vert dans son lit de camion. Vous devez le mettre au bon endroit." },
		{"Thank you for your help!", "Merci de votre aide !" },
		//145
		{"What is the result of the calculation?", "Quel est le résultat du calcul ?" },
		{"The result of the calculation is '-62'.", "Le résultat du calcul est '-62'." },
		{"The social science people are now crying.", "Les gens des sciences sociales pleurent maintenant." },
		//146
		{"Gather the stones upstream and stop the water. Drag the net over the fish.", "Rassemblez les pierres en amont et arrêtez l'eau. Faites glisser le filet sur le poisson." },
		{"The fish jumps once jumps twice...", "Le poisson saute une fois saute deux fois ..." },
		//147
		{"Shrink down the fire!", "Rétrécissez le feu !" },
		{"Shake the phone, let the fire disperse and choose the smaller one!", "Secouez le téléphone, laissez le feu se disperser et choisissez le plus petit!" },
		{"Did you try to snuff it out?", "Avez-vous essayé de l'étouffer ?" },
		//148
		{"Find the password!", "Trouvez le mot de passe!" },
		{"'042' Think again... You can also ask a friend.", "'042' Détrompez-vous ... Vous pouvez également demander à un ami." },
		{"If you found this as well, you should be proud of yourself!", "Si vous l'avez trouvé aussi, vous devriez être fier de vous!" },
		{"A number and it's place are correct", "Un nombre et son emplacement sont corrects" },
		{"A number is correct but it's place is wrong", "Un nombre est correct mais son emplacement est incorrect" },
		{"Two numbers are correct but the places are wrong", "Deux chiffres sont corrects mais les emplacements sont faux" },
		{"Nothing is correct", "Rien n'est correct" },
		{"ENTER", "ENTRER" },
		//149
		{"Weigh the chicken", "Peser le poulet" },
		{"Shake the chicken to make its eggs fall out and make it lighter.", "Secouez le poulet pour faire tomber ses œufs et le rendre plus léger." },
		{"I’m light as a feather.", "Je suis léger comme une plume." },
		//150
		{"Is it too quiet here?", "Est-ce trop calme ici?" },
		{"A little music wouldn't be bad.", "Un peu de musique ne serait pas mauvais." },
		{"Music is the essence of the soul ;)", "La musique est l'essence de l'âme;)" },
		//151
		{"Take the ball outside!", "Sortez la boule !" },
		{"Pour water from the dispenser size bottle to the glass and pour it into the pipe. Let the ball go up.", "Versez l'eau de la bouteille de la taille du distributeur dans le verre et versez-la dans le tuyau. Laissez la balle monter." },
		{"You discovered the buoyant force of the water.", "Vous avez découvert la force flottante de l'eau." },
		//152
		{"Score a goal.", "Marquer un but." },
		{"Try to press two arrows at the same time.", "Essayez d'appuyer sur deux flèches en même temps." },
		{"Gooaal!..!!", "Buuuut!.. !!" },
		//153
		{"Make the baby laugh.", "Faites rire le bébé." },
		{"Take off the baby's socks and tickle the baby's feet with a feather.", "Enlevez les chaussettes du bébé et chatouillez les pieds du bébé avec une plume." },
		{"The world is better when babies laugh.", "Le monde est meilleur quand les bébés rient." },
		//154
		{"Bring the child to the exit", "Amenez l'enfant à la sortie" },
		{"Turn your phone over and watch the child.", "Retournez votre téléphone et regardez l'enfant." },
		{"Did you send the game to your friends? Now, send it from the share button below.", "Avez-vous envoyé le jeu à vos amis? Maintenant, envoyez-le à partir du bouton de partage ci-dessous." },
		//155
		{"The child is so lonely", "L'enfant est si seul" },
		{"Hold on the child with your finger for 5 seconds and then, copy the child.", "Tenez l'enfant avec votre doigt pendant 5 secondes, puis copiez l'enfant." },
		{"Now, they are twins.", "Maintenant, ce sont des jumeaux." },
		{"Copy", "Copier" },
		{"Rate the game", "Évaluer le jeu" },
		//156
		{"Please click in the following order", "Veuillez cliquer dans l'ordre suivant" },
		{"Are you sure you did the right thing? Watch out for the last finger.", "Êtes-vous sûr d'avoir fait la bonne chose? Attention au dernier doigt." },
		{"That's it!", "Et voilà !" },
		//157
		{"Silence the child", "Faire taire l'enfant" },
		{"The toy is hidden under the button. Give it to the child.", "Le jouet est caché sous le bouton. Donnez-le à l'enfant." },
		{"It's really awesome.", "C'est vraiment effarant." },
		{"Watch video", "Voir la vidéo" },
		//158 DON'T FORGET TO CHANGE PREFAB
		{"Unlock the case.", "Déverrouillez le boîtier." },
		{"Take the word ‘password’ to the correct place.", "Apportez le mot mot de «passe» au bon endroit." },
		{"Is it difficult?", "Est-ce difficile ?" },
		//159
		{"Grab the gift box on the daily bonus button and give it to the man. The man will be happy to receive a gift.", "Prenez le coffret cadeau sur le bouton bonus quotidien et donnez-le à l'homme. L'homme sera heureux de recevoir un cadeau." },
		{"Who recently bought you a gift?", "Qui vous a récemment acheté un cadeau?" },
		//160
		{"What does the child see?", "Que voit l'enfant?" },
		{"Try to look at from the perspective of the child.", "Essayez de regarder du point de vue de l'enfant." },
		{"It's all about perspective!", "Tout est question de perspective!" },
		//161 DON'T FORGET TO CHANGE PREFAB
		{"One of the X's can be moved. Remove X and replace it with the dot in the question.", "L'un des X peut être déplacé. Supprimez X et remplacez-le par le point dans la question." },
		{"You are true genius!", "Tu es un vrai génie!" },
		//162
		{"Make the girl fall in love with the boy", "Faire tomber la fille amoureuse du garçon" },
		{"Shake the child quite a while. Maybe he is hiding a surprise gift.", "Secouez l'enfant un bon moment. Peut-être qu'il cache un cadeau surprise." },
		{"You're the last single person in the world.", "Vous êtes la dernière personne célibataire au monde." },
		//163 DON'T FORGET TO CHANGE PREFAB
		{"Try to use the word 'Truck'.", "Essayez d'utiliser le mot «camion»." },
		{"Poor truck.", "Pauvre camion." },
		//164
		{"Find the water for kids to make a water fight.", "Trouvez de l'eau pour que les enfants se battent contre l'eau." },
		{"Hold both clouds with your fingers at the same time shake your phone.", "Tenez les deux nuages avec vos doigts en même temps secouez votre téléphone." },
		{"May the best man win!", "Que le meilleur gagne !" },
		//165
		{"Shout and Say 'MOM'", "Criez et dites «MAMAN»" },
		{"The level will be passed when you click the start button 4 times and fill the bar. You must allow microphone access, or enable Phone Settings > Apps > Trick Me > Permissions > Microphone option.", "Le niveau sera passé lorsque vous cliquez sur le bouton de démarrage 4 fois et remplissez la barre. Vous devez autoriser l'accès au microphone ou activer Paramètres du téléphone> Applications> Trick Me> Autorisations> Option microphone." },
		{"What did you mom say?", "Qu’est-ce que maman a dit ?" },
		//166
		{"Find a frame for these colored objects.", "Trouvez un cadre pour ces objets colorés." },
		{"I said find 'a frame' for these colored objects. :)", "J'ai dit de trouver «un cadre» pour ces objets colorés. :)" },
		{"You are amazing!", "Vous êtes formidable !" },
		//167
		{"Do something to end the war.", "Faites quelque chose pour mettre fin à la guerre." },
		{"If you shoot at the right place, the war is over.", "Si vous tirez au bon endroit, la guerre est finie." },
		{"#worldpeace", "#paixmondiale" },
		//168
		{"Find the ball?", "Trouvez le ballon?" },
		{"To make 'x10' 'x1', delete '0' using your finger.", "Pour faire «x10» «x1», supprimez «0» à l'aide de votre doigt." },
		{"A++++++", "A++++++" },
		//169
		{"After the game has started, you must turn the child left using your finger.", "Après le début du jeu, vous devez tourner l'enfant vers la gauche avec votre doigt." },
		{"Nobody could pass this level except you.", "Personne ne pouvait passer ce niveau sauf vous." },
		//170
		{"Hit the man's head and knock the man out. Then, shoot the ball.", "Frappez la tête de l'homme et assommez-le. Ensuite, lancez le ballon." },
		{"Incredible goal!", "Incroyable but!" },
		//171
		{"Grasp the first car with two fingers and remove it draggingly. Then, park your car in its place.", "Saisissez la première voiture avec deux doigts et retirez-la en la faisant glisser. Ensuite, garez votre voiture à sa place." },
		{"Nice job!", "Bon travail!" },
		//172
		{"One of the L's in Lvl is big and the other small.", "L'un des L de Lvl est grand et l'autre petit." },
		{"You can think differently...", "Vous pouvez penser différemment..." },
		//173 DON'T FORGET TO CHANGE PREFAB
		{"Enter password", "Saisir le mot de passe" },
		{"Try zooming your screen a few times.", "Essayez de zoomer votre écran plusieurs fois." },
		{"You're very good!", "Vous êtes très bon!" },
		//174
		{"Behind one of the windows.", "Derrière une des fenêtres." },
		{"Don't lie, you're a gamer, too.", "Ne mentez pas, vous êtes aussi un joueur." },
		//175
		{"Grab the small key on watch video button and drag it to the door.", "Prenez la petite clé sur le bouton regarder la vidéo et faites-la glisser vers la porte." },
		{"Amazing!", "Incroyable !" },
		//176
		{"Hi, we’re still working on new levels. Stay tuned for the next update.", "Salut, nous travaillons toujours sur de nouveaux niveaux. Restez à l'écoute pour la prochaine mise à jour." },
		{"", "" }
    };
	public static string GetEquivalent(string value, SystemLanguage Lang)
    {
        if (SafeMode)
        {
            try
            {
                switch (Lang)
                {
                    case SystemLanguage.Turkish:
                        return TR[value];
                    case SystemLanguage.Spanish:
                        return ESP[value];
                    case SystemLanguage.German:
                        return DE[value];
                    case SystemLanguage.Russian:
                        return RU[value];
                    case SystemLanguage.Portuguese:
                        return POR[value];
                    case SystemLanguage.Chinese:
                        return CN[value];
                    case SystemLanguage.French:
                        return FR[value];
                    default:
                        return value;
                }
            }
            catch (System.Exception)
            {
                Debug.LogWarning(value);
                return value;
            }
        }
        else
        {
            switch (Lang)
            {
                case SystemLanguage.Turkish:
                    return TR[value];
                case SystemLanguage.Spanish:
                    return ESP[value];
                case SystemLanguage.German:
                    return DE[value];
                case SystemLanguage.Russian:
                    return RU[value];
                case SystemLanguage.Portuguese:
                    return POR[value];
                case SystemLanguage.Chinese:
                    return CN[value];
                case SystemLanguage.French:
                    return FR[value];
                default:
                    return value;
            }
        }
    }

    public static string GetReversedEquivalent(string value, SystemLanguage Lang)
    {
        if (SafeMode)
        {
            try
            {
                switch (Lang)
                {
                    case SystemLanguage.Turkish:
                        return TR.ToDictionary(x => x.Value, x => x.Key)[value];
                    case SystemLanguage.Spanish:
                        return ESP.ToDictionary(x => x.Value, x => x.Key)[value];
                    case SystemLanguage.German:
                        return DE.ToDictionary(x => x.Value, x => x.Key)[value];
                    case SystemLanguage.Russian:
                        return RU.ToDictionary(x => x.Value, x => x.Key)[value];
                    case SystemLanguage.Portuguese:
                        return POR.ToDictionary(x => x.Value, x => x.Key)[value];
                    case SystemLanguage.Chinese:
                        return CN.ToDictionary(x => x.Value, x => x.Key)[value];
                    case SystemLanguage.French:
                        return FR.ToDictionary(x => x.Value, x => x.Key)[value];
                    default:
                        return value;
                }
            }
            catch (System.Exception)
            {
                Debug.LogWarning(value);
                return value;
            }
        }
        else
        {
            switch (Lang)
            {
                case SystemLanguage.Turkish:
                    return TR.ToDictionary(x => x.Value, x => x.Key)[value];
                case SystemLanguage.Spanish:
                    return ESP.ToDictionary(x => x.Value, x => x.Key)[value];
                case SystemLanguage.German:
                    return DE.ToDictionary(x => x.Value, x => x.Key)[value];
                case SystemLanguage.Russian:
                    return RU.ToDictionary(x => x.Value, x => x.Key)[value];
                case SystemLanguage.Portuguese:
                    return POR.ToDictionary(x => x.Value, x => x.Key)[value];
                case SystemLanguage.Chinese:
                    return CN.ToDictionary(x => x.Value, x => x.Key)[value];
                case SystemLanguage.French:
                    return FR.ToDictionary(x => x.Value, x => x.Key)[value];
                default:
                    return value;
            }
        }
    }
}
