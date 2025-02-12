// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 *   Bir işlemin tamamlanması için, birkaç adımdan oluşan bir yakalayıcı (handler) nesne grubunuz var. 
 *   
 *   Örnek:
 *   
 *   Http Request 
 *     - 1. Güvenlik
 *     - 2. Kimliklendirme ve Yetki
 *     - 3. Hata yönetimi
 *     - 4. Durum yönetimi (Session, Cookie falan  fistan)
 *     
 *     
 */

ReservationRequest request = new ReservationRequest() { Owner ="Numan Nebakıyon", CheckIn= new DateOnly(2025,02,16), CheckOut=new DateOnly(2025, 02, 25) };

CheckOwnerHandler checkOwner = new CheckOwnerHandler();
CheckInAndOutDate checkInAndOut = new CheckInAndOutDate ();
SaveReservationToDatabaseHandler saveHandler = new SaveReservationToDatabaseHandler();

checkOwner.Next = checkInAndOut;
checkInAndOut.Next = saveHandler;

checkOwner.Handler(request);

//SaveReservationToDatabaseHandler saveReservation = new SaveReservationToDatabaseHandler();



//CheckInAndOutDate checkInAndOutDate = new CheckInAndOutDate (saveReservation);
//CheckOwnerHandler checkOwnerHandler = new CheckOwnerHandler(checkInAndOutDate);

