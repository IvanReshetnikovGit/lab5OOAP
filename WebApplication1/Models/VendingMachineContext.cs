using WebApplication1.Interfaces;
namespace WebApplication1.Models
{
    public class VendingMachineContext
    {
        public IVendingMachineState State { get; set; }

        public VendingMachineContext()
        {
            State = new WaitingForPaymentState();
        }

        public string Process(decimal insertedMoney, decimal itemPrice)
        {
            return State.Handle(this, insertedMoney, itemPrice);
        }
    }
}
