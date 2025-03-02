namespace EventsDelegates
{
    class Program
    {
        public static void Main()
        {
            // creating instance of class
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            // Subscribing the event handler to the event
            bl.ProcessCompleted += bl_ProcessCompleted;
            // Initiating the process
            bl.StartProcess();
        }

        // method that gets executed when the event is raised
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }
    }
}
