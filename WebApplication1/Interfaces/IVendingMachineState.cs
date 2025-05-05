using WebApplication1.Models;
namespace WebApplication1.Interfaces
{
    public interface IVendingMachineState
    {
        string Handle(VendingMachineContext context, decimal insertedMoney, decimal itemPrice);
    }
}
