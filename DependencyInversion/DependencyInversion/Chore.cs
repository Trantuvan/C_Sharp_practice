namespace DependencyInversion
{
    public class Chore : IChore
    {
        private readonly ILogger _logger;
        private readonly IMessageSender _messageSender;

        // de viet duoc kieu duoi can dung properties get, set
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }

        // private set set that through PerformedWork method chi xai trong class
        public bool IsComplete { get; private set; }
        public string ChoreName { get; set; }

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            //breaking coupling with ctor !Factory vi muon factory new o Program thoi
            this._logger = logger;
            this._messageSender = messageSender;

        }
        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            _logger.Log($"Completed {ChoreName}");

            _messageSender.SendMessage(Owner, $"The chore {ChoreName} is completed.");
        }

    }
}
