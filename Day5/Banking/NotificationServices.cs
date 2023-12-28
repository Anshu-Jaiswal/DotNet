namespace Notifications;

public static class NotificationServices
{
    public static void SendEmail(string to, string content){
    Console.WriteLine( "Email is Sent to "+ to + content);
    /*Thread currentThread=Thread.CurrentThread;
    int threadId=currentThread.ManagedThreadId;
    Console.WriteLine( "Primary Thread Id="+ threadId);
    Console.WriteLine("Primary Thread Prioity: "+ currentThread.Priority);
*/

}

public static void SendSMS(string to, string content){
    Console.WriteLine( "SMS is Sent to "+ to + content );
}



public static void SendWhatsAppMessage(string to, string content){
    Console.WriteLine( "Whatsapp is Sent to "+ to + content);
}

}