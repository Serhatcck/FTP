Proje genel iki k�s�mdan olu�maktad�r:
Server,Client
Kullan�c�n�n From1 de t�klad��� butonlar ile program ya dinleme yapar ya da ba�lant� g�nderir

Ba�lant� g�nderme i�leminde server a iki tane veri g�nderilir:

Bunun nedeni server �n bir ba�lant�y� dinlerken gelen ba�lant�n�n ka� byte oldu�unu �nceden
bilmesi gerekti�idir ('SocketServer' s�n�f� 85.sat�r)
Server s�n�f�ndaki dinleyici nesnesi okuma i�lemini dinamik olarak yapamad��� i�in 
server in gelen verinin boyutunu �nceden bilmesi gerekir.

Bu sorunun �stesinden gelmek i�in ise FileProcess klas�r�n�n alt�nda bulunan s�n�flardan 
yararland�k
Bu s�n�flar�n i�leyi�i genel olarak �u �ekildedir:

Yap� olu�turulurken 'Factory Design Patent' kullan�lm��t�r. 'FileProcessInterface' s�n�f�
interface s�n�fd�r;'FileProcessHeader' ve 'FileProcessInfo' s�n�flar� ise interface s�n�f�ndan
t�retilmi�tir;'FileProcessCreater' s�n�f� ise i�ine ald��� parametreler g�re hangi s�n�f�n 
olu�turulaca��na karar veren i�lemi yapam metod i�ermektedir.

'FileProcessHeader': Server a bir belge g�nderilirken ilk olarak bu s�n�ftan t�reyen bir byte
dizisi g�nderilir. Bu byte dizisinin i�inde belgenin ismi,uzant�s� ve boyutu tutulur; bu veriler
tutulurken her bir veri aras�na '*' ifadesi koyulur. Bunun nedeni ise server a giden string 
ifadesinin '*' siplit edilebilip i�lenmesidir.

'FileProcessInfo':�kinci olarak bu s�n�ftan t�reyen byte dizisi g�nderilir ve bu byte dizisinin
i�inde g�nderilecek olan dosyan�n kendisi bulunur.

G�nderilen Veri 'Socket' klas�r� alt�nda bulunan 'Client' s�n�f� sayesinde g�nderilir
Al�nan Veri ise 'Socket' klas�r� alt�nda bulunan 'SocketServer' s�n�f� sayesinde i�lenir

'SocketServer':Genel soket programlama metodlar�n�n toplu bir s�n�f haline getirilmi� halidir.
Buna ek olarak i�inde bulunan'StartStream' metodu ile gelen verinin hangi t�rden oldu�una karar
veren bir yap�s� vard�r.Gelen byte dizisi string e �evrildikten sonra '*' ifadesine g�re split
edilir ve bir diziye atan�r; dizinin ilk eleman� 'Header' ise ('FileProcessHeader' s�n�f�ndan
gelmi� ise) gelen veri yaz�lmaz sadece gerekli bilgiler gerekli de�i�kenlere at�l�r ve dinleme
i�lemine devam edilir.E�er gelen verinin ilk eleman�'Header' de�il ise ('FileProcessInfo' s�n�f�na
ait ise) dosya �nceden g�nderilen verilere g�re bilgisayar�n masa�st�ne yazd�r�l�r.


Bu i�lemler form elemanlar� ��yle da��lm��t�r:
'connectBtn' butonuna t�kland��� zaman server �n a��k olmas� gerekir ve server a 'FileProcessHeader'
s�n�f�ndan al�nan bilgileri g�nderilir
'uploadBtn' butonuna t�kland���nda ise server a 'FileProcessInfo' s�n�f�ndan al�nan bilgiler 
server a g�nderilir.

Verinin ilk olarak 'FileProcessHeader' s�n�f�ndan  de�il de 'FileProcessInfo' s�n�f�ndan g�nderilmesini
engellmek i�in ise �u y�nteme ba�vurulmu�tur:
'connectBtn' a t�kland�ktan sonra ; 'Clinet' s�n�f�ndaki 'Write' metodu �al��t�ktan sonra 
'uploadBtn' a enable �zelli�i verilmi�tir. Sistem a��ld���nda 'uploadBtn' butonunun enable 
�zelli�i yoktur.
