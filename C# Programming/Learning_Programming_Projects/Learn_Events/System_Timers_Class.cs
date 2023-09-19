
System.Timers.Timer aTimer;

aTimer = new System.Timers.Timer();
aTimer.Interval = 2000;

// Hook up the Elapsed event for the timer. 
aTimer.Elapsed += OnTimedEvent;

// Have the timer fire repeated events (true is the default)
aTimer.AutoReset = true;

// Start the timer
aTimer.Enabled = true;

Console.WriteLine("Press the Enter key to exit the program at any time... ");
Console.ReadLine();


