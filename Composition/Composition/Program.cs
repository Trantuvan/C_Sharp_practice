namespace Composition
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // relationship 2 class allows one to contain other
            // Has a relationshop
            // Car has an Engine
            var dbMirgrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var intsaller = new Installer(logger);

            dbMirgrator.Migrate();
            intsaller.Install();
        }
    }
}
