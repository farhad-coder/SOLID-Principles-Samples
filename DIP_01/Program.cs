/*
public class EmailNotification
{
    public void Send(string message)
    {
        // ToDO : Send Message
    }
}

public class DatabaseManageer
{
    private EmailNotification notification;
    public DatabaseManageer()
    {
        notification = new EmailNotification();
    }

    public void Add() {
        notification.Send("Add New Record");
    }
    public void Update() {
        notification.Send("Remove");
    }
    public void Remove() {
        notification.Send("Update");
    }
}
*/

//*********************************************************

DatabaseManager db = new DatabaseManager(new EmailNotification());
DatabaseManager db2 = new DatabaseManager(new SmsNotification());

public interface INotification
{
    void Send(string message);
}

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        // ToDO : Send Message
    }
}

public class SmsNotification : INotification
{
    public void Send(string message)
    {
        // ToDO : Send Message
    }
}

public class DatabaseManager
{
    private INotification notification;
    public DatabaseManager(INotification notification)
    {
        this.notification = notification;
    }

    public void Add()
    {
        notification.Send("Add New Record");
    }
    public void Update()
    {
        notification.Send("Remove");
    }
    public void Remove()
    {
        notification.Send("Update");
    }
}