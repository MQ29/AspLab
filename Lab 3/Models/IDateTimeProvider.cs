namespace Lab_3.Models
{
    public interface IDateTimeProvider
    {
        DateTime date();
    }

    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime date()
        {
            return DateTime.Now;
        }
    }
}
