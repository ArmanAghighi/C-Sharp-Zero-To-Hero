namespace Chapter2_task3
{
    public class WindowsFactory : ComputersAssembler
    {
        public override void PrepareBody()
        {
            base.PrepareBody();
            Console.WriteLine("Prepare Body for Windows");
        }

        public override void InstallCPU()
        {
            base.InstallCPU();
            Console.WriteLine("Install Windows CPU");
        }

        public override void InstallRam()
        {
            base.InstallRam();
            Console.WriteLine("Install Windows Ram");
        }

        public override void InstallGPU()
        {
            base.InstallGPU();
            Console.WriteLine("Install Windows GPU");
        }

        public override void InstallCooler()
        {
            base.InstallCooler();
            Console.WriteLine("Install Windows Cooler");
        }

        public override void InstallMotherboard()
        {
            base.InstallMotherboard();
            Console.WriteLine("Install Windows Motherboard");
        }
    }
}