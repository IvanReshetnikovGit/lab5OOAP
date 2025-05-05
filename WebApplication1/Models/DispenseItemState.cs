using WebApplication1.Interfaces;
namespace WebApplication1.Models
{
    public class DispenseItemState : IVendingMachineState
    {
        public string Handle(VendingMachineContext context, decimal insertedMoney, decimal itemPrice)
        {
            return "Товар видано. Здача не потрібна.";
        }
    }
}
