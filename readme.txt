Proje genel iki kýsýmdan oluþmaktadýr:
Server,Client
Kullanýcýnýn From1 de týkladýðý butonlar ile program ya dinleme yapar ya da baðlantý gönderir

Baðlantý gönderme iþleminde server a iki tane veri gönderilir:

Bunun nedeni server ýn bir baðlantýyý dinlerken gelen baðlantýnýn kaç byte olduðunu önceden
bilmesi gerektiðidir ('SocketServer' sýnýfý 85.satýr)
Server sýnýfýndaki dinleyici nesnesi okuma iþlemini dinamik olarak yapamadýðý için 
server in gelen verinin boyutunu önceden bilmesi gerekir.

Bu sorunun üstesinden gelmek için ise FileProcess klasörünün altýnda bulunan sýnýflardan 
yararlandýk
Bu sýnýflarýn iþleyiþi genel olarak þu þekildedir:

Yapý oluþturulurken 'Factory Design Patent' kullanýlmýþtýr. 'FileProcessInterface' sýnýfý
interface sýnýfdýr;'FileProcessHeader' ve 'FileProcessInfo' sýnýflarý ise interface sýnýfýndan
türetilmiþtir;'FileProcessCreater' sýnýfý ise içine aldýðý parametreler göre hangi sýnýfýn 
oluþturulacaðýna karar veren iþlemi yapam metod içermektedir.

'FileProcessHeader': Server a bir belge gönderilirken ilk olarak bu sýnýftan türeyen bir byte
dizisi gönderilir. Bu byte dizisinin içinde belgenin ismi,uzantýsý ve boyutu tutulur; bu veriler
tutulurken her bir veri arasýna '*' ifadesi koyulur. Bunun nedeni ise server a giden string 
ifadesinin '*' siplit edilebilip iþlenmesidir.

'FileProcessInfo':Ýkinci olarak bu sýnýftan türeyen byte dizisi gönderilir ve bu byte dizisinin
içinde gönderilecek olan dosyanýn kendisi bulunur.

Gönderilen Veri 'Socket' klasörü altýnda bulunan 'Client' sýnýfý sayesinde gönderilir
Alýnan Veri ise 'Socket' klasörü altýnda bulunan 'SocketServer' sýnýfý sayesinde iþlenir

'SocketServer':Genel soket programlama metodlarýnýn toplu bir sýnýf haline getirilmiþ halidir.
Buna ek olarak içinde bulunan'StartStream' metodu ile gelen verinin hangi türden olduðuna karar
veren bir yapýsý vardýr.Gelen byte dizisi string e çevrildikten sonra '*' ifadesine göre split
edilir ve bir diziye atanýr; dizinin ilk elemaný 'Header' ise ('FileProcessHeader' sýnýfýndan
gelmiþ ise) gelen veri yazýlmaz sadece gerekli bilgiler gerekli deðiþkenlere atýlýr ve dinleme
iþlemine devam edilir.Eðer gelen verinin ilk elemaný'Header' deðil ise ('FileProcessInfo' sýnýfýna
ait ise) dosya önceden gönderilen verilere göre bilgisayarýn masaüstüne yazdýrýlýr.


Bu iþlemler form elemanlarý þöyle daðýlmýþtýr:
'connectBtn' butonuna týklandýðý zaman server ýn açýk olmasý gerekir ve server a 'FileProcessHeader'
sýnýfýndan alýnan bilgileri gönderilir
'uploadBtn' butonuna týklandýðýnda ise server a 'FileProcessInfo' sýnýfýndan alýnan bilgiler 
server a gönderilir.

Verinin ilk olarak 'FileProcessHeader' sýnýfýndan  deðil de 'FileProcessInfo' sýnýfýndan gönderilmesini
engellmek için ise þu yönteme baþvurulmuþtur:
'connectBtn' a týklandýktan sonra ; 'Clinet' sýnýfýndaki 'Write' metodu çalýþtýktan sonra 
'uploadBtn' a enable özelliði verilmiþtir. Sistem açýldýðýnda 'uploadBtn' butonunun enable 
özelliði yoktur.
