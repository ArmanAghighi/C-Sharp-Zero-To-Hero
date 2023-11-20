using Chapter2_task3;
public class Program
{
    public static void Main()
    {
        WindowsFactory windowsFactory1 = new WindowsFactory();
        WindowsFactory windowsFactory2 = new WindowsFactory();
        MacFactory macFactory1 = new MacFactory();
        MacFactory macFactory2 = new MacFactory();

        void StartProduction()
        {
            const int productionCount = 100;

            for (int i = 0; i < productionCount; i++)
            {
                windowsFactory1.PrepareBody();
                windowsFactory1.InstallCPU();
                windowsFactory1.InstallRam();
                windowsFactory1.InstallCooler();
                windowsFactory1.InstallMotherboard();

                macFactory1.PrepareBody();
                macFactory1.InstallCPU();
                macFactory1.InstallRam();
                macFactory1.InstallCooler();
                macFactory1.InstallMotherboard();

                windowsFactory2.PrepareBody();
                windowsFactory2.InstallCPU();
                windowsFactory2.InstallRam();
                windowsFactory2.InstallCooler();
                windowsFactory2.InstallMotherboard();

                macFactory2.PrepareBody();
                macFactory2.InstallCPU();
                macFactory2.InstallRam();
                macFactory2.InstallCooler();
                macFactory2.InstallMotherboard();
            }
        }

        StartProduction();
    }
}