namespace Timer
{
    public class Timer
    {
        public event Action OnTimeElapsed;

        public void Start(int seconds)
        {
            Console.WriteLine("start timer");
            Thread.Sleep(seconds * 1000);
            OnTimeElapsed?.Invoke();
        }
    }
}