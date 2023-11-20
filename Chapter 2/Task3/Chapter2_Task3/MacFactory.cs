namespace Chapter2_task3
{
    public class MacFactory : ComputersAssembler
    {
        public override void PrepareBody()
        {
            base.PrepareBody();
            Console.WriteLine("Prepare MacOS Body");
        }

        public override void InstallCPU()
        {
            base.InstallCPU();
            Console.WriteLine("Install MacOS CPU");
        }

        public override void InstallRam()
        {
            base.InstallRam();
            Console.WriteLine("Install MacOS Ram");
        }

        public override void InstallGPU()
        {
            base.InstallGPU();
            Console.WriteLine("Install MacOS GPU");
        }

        public override void InstallCooler()
        {
            base.InstallCooler();
            Console.WriteLine("Install MacOS Cooler");
        }

        public override void InstallMotherboard()
        {
            base.InstallMotherboard();
            Console.WriteLine("Install MacOS Motherboard");
        }
    }
}