// CinemaFacade.cs
using System.Collections.Generic;

public class CinemaFacade : ISubject
{
    private readonly List<IObserver> observers = new List<IObserver>();
    // أضيفي هنا الـ Repositories الخاصة بكِ كما في كودك الأصلي

    public void Attach(IObserver observer) => observers.Add(observer);
    public void Detach(IObserver observer) => observers.Remove(observer);

    public void NotifyObservers(Event notification)
    {
        foreach (var observer in observers.ToList())
        { // ToList لتجنب أخطاء التعديل أثناء القراءة
            observer.Update(notification);
        }
    }

    public void BookTicket(int userId, string movieTitle)
    {
        // منطق الحجز هنا (قاعدة البيانات)

        // إرسال الإشعار
        NotifyObservers(new Event(
            EventType.TicketBooked,
            $"Successfully booked a ticket for: {movieTitle}",
            userId
        ));
    }

    public void DownloadMovie(int userId, string movieTitle)
    {
        NotifyObservers(new Event(
            EventType.MovieDownloaded,
            $"The download for {movieTitle} has started safely.",
            userId
        ));
    }
}