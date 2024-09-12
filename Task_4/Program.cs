Timer.Timer timer = new Timer.Timer();

timer.OnTimeElapsed += Timer_OnTimeElapsed;
timer.Start(3);

Console.ReadLine();

void Timer_OnTimeElapsed()
{
    Console.WriteLine("time is up");
}