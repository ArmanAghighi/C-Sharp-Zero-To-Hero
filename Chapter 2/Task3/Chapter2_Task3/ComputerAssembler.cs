namespace Chapter2_task3
{
    public class ComputersAssembler
    {
        public virtual void PrepareBody()
        {
            Console.WriteLine("Ready to Prepare Body");
        }

        public virtual void InstallCPU()
        {
            Console.WriteLine("Ready to Install CPU");
        }

        public virtual void InstallRam()
        {
            Console.WriteLine("Ready to Install Ram");
        }

        public virtual void InstallGPU()
        {
            Console.WriteLine("Ready to Install GPU");
        }

        public virtual void InstallCooler()
        {
            Console.WriteLine("Ready to Install Cooler");
        }

        public virtual void InstallMotherboard()
        {
            Console.WriteLine("Ready to Install Motherboard");
        }
    }
}