using MPXJ.Net;

namespace Samples
{
    public class ExtractData
    {
        public void Execute()
        {
            var project = new UniversalProjectReader().Read("example.mpp");

            System.Console.WriteLine("Tasks");
            foreach (var task in project.Tasks)
            {
                System.Console.WriteLine($"{task.ID}\t{task.Name}");
            }
        }
    }
}
