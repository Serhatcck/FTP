Proje genel iki kısımdan oluşmaktadır:
Server,Client
Kullanıcının From1 de tıkladığı butonlar ile program ya dinleme yapar ya da bağlantı gönderir

Bağlantı gönderme işleminde server a iki tane veri gönderilir:

Bunun nedeni server ın bir bağlantıyı dinlerken gelen bağlantının kaç byte olduğunu önceden
bilmesi gerektiğidir ('SocketServer' sınıfı 85.satır)
Server sınıfındaki dinleyici nesnesi okuma işlemini dinamik olarak yapamadığı için 
server in gelen verinin boyutunu önceden bilmesi gerekir.

Bu sorunun üstesinden gelmek için ise FileProcess klasörünün altında bulunan sınıflardan 
yararlandık
Bu sınıfların işleyişi genel olarak şu şekildedir:

Yapı oluşturulurken 'Factory Design Patent' kullanılmıştır. 'FileProcessInterface' sınıfı
interface sınıfdır;'FileProcessHeader' ve 'FileProcessInfo' sınıfları ise interface sınıfından
türetilmiştir;'FileProcessCreater' sınıfı ise içine aldığı parametreler göre hangi sınıfın 
oluşturulacağına karar veren işlemi yapam metod içermektedir.

'FileProcessHeader': Server a bir belge gönderilirken ilk olarak bu sınıftan türeyen bir byte
dizisi gönderilir. Bu byte dizisinin içinde belgenin ismi,uzantısı ve boyutu tutulur; bu veriler
tutulurken her bir veri arasına '*' ifadesi koyulur. Bunun nedeni ise server a giden string 
ifadesinin '*' siplit edilebilip işlenmesidir.

'FileProcessInfo':İkinci olarak bu sınıftan türeyen byte dizisi gönderilir ve bu byte dizisinin
içinde gönderilecek olan dosyanın kendisi bulunur.

Gönderilen Veri 'Socket' klasörü altında bulunan 'Client' sınıfı sayesinde gönderilir
Alınan Veri ise 'Socket' klasörü altında bulunan 'SocketServer' sınıfı sayesinde işlenir

'SocketServer':Genel soket programlama metodlarının toplu bir sınıf haline getirilmiş halidir.
Buna ek olarak içinde bulunan'StartStream' metodu ile gelen verinin hangi türden olduğuna karar
veren bir yapısı vardır.Gelen byte dizisi string e çevrildikten sonra '*' ifadesine göre split
edilir ve bir diziye atanır; dizinin ilk elemanı 'Header' ise ('FileProcessHeader' sınıfından
gelmiş ise) gelen veri yazılmaz sadece gerekli bilgiler gerekli değişkenlere atılır ve dinleme
işlemine devam edilir.Eğer gelen verinin ilk elemanı'Header' değil ise ('FileProcessInfo' sınıfına
ait ise) dosya önceden gönderilen verilere göre bilgisayarın masaüstüne yazdırılır.


Bu işlemler form elemanları şöyle dağılmıştır:
'connectBtn' butonuna tıklandığı zaman server ın açık olması gerekir ve server a 'FileProcessHeader'
sınıfından alınan bilgileri gönderilir
'uploadBtn' butonuna tıklandığında ise server a 'FileProcessInfo' sınıfından alınan bilgiler 
server a gönderilir.

Verinin ilk olarak 'FileProcessHeader' sınıfından  değil de 'FileProcessInfo' sınıfından gönderilmesini
engellmek için ise şu yönteme başvurulmuştur:
'connectBtn' a tıklandıktan sonra ; 'Clinet' sınıfındaki 'Write' metodu çalıştıktan sonra 
'uploadBtn' a enable özelliği verilmiştir. Sistem açıldığında 'uploadBtn' butonunun enable 
özelliği yoktur.
